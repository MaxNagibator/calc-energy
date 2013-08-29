using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SqlProviderNameSpace
{
    public class SqlProvider : ISqlProvider
    {
        public class QueryRow : IQueryResultRow
        {
            private readonly Dictionary<string, object> _fields = new Dictionary<string, object>();

            internal void AddField(string fieldName, object value)
            {
                _fields.Add(fieldName.ToLower(), value);
            }

            public T FieldOrDefault<T>(string fieldName)
            {
                try
                {
                    return Field<T>(fieldName);
                }
                catch
                {
                    return default(T);
                }
            }

            public dynamic Field(string fieldName)
            {
                var value = Field<object>(fieldName);
                return DBNull.Value.Equals(value) ? null : value;
            }

            public T Field<T>(string fieldName)
            {
                var value = _fields[fieldName.ToLower()];
                if (IsNullableType(typeof(T)))
                {
                    return GetNullableValue<T>(value);
                }
                return GetNotNullableValue<T>(value);
            }

            private T GetNullableValue<T>(object value)
            {
                Type nullableType = Nullable.GetUnderlyingType(typeof(T));
                if (value is Guid?)
                {
                    return DBNull.Value.Equals(value) ?
                        default(T) : (T)Convert.ChangeType(value, typeof(Guid));
                }
                return DBNull.Value.Equals(value) ?
                        default(T) : (T)Convert.ChangeType(value, nullableType);
            }

            private T GetNotNullableValue<T>(object value)
            {
                if (value is Guid)
                {
                    return (T)Convert.ChangeType(value, typeof(Guid));
                }
                return (T)Convert.ChangeType(value, typeof(T));
            }

            private bool IsNullableType(Type type)
            {
                return Nullable.GetUnderlyingType(type) != null;
            }

            public bool IsNull(string fieldName)
            {
                return DBNull.Value.Equals(_fields[fieldName]);
            }
        }

        public class QueryColumn : IQueryResultColumn
        {
            internal QueryColumn(string name, Type type)
            {
                Name = name;
                Type = type;
            }

            public string Name { get; private set; }

            public Type Type { get; private set; }
        }

        public event EventHandler FailCommit;

        public event EventHandler SuccessCommit;

        private readonly SqlConnection _connection;
        private SqlCommand _currentCommand;
        private readonly ICollection<SqlCommand> _commands;
        private SqlDataReader _reader;
        private DataTable _dataTable;
        private readonly List<IQueryResultRow> _rows = new List<IQueryResultRow>();
        private readonly List<IQueryResultColumn> _columns = new List<IQueryResultColumn>();

        public ReadOnlyCollection<IQueryResultRow> Rows
        {
            get
            {
                return _rows.AsReadOnly();
            }
        }

        public ReadOnlyCollection<IQueryResultColumn> Columns
        {
            get
            {
                return _columns.AsReadOnly();
            }
        }

        public bool HasRows
        {
            get
            {
                return _rows.Any();
            }
        }

        [Obsolete("use SetParameter()!")]
        public SqlCommand Command
        {
            get
            {
                return _currentCommand;
            }
            set
            {
                _currentCommand = value;
            }
        }

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!")]
        public SqlDataReader Reader
        {
            get
            {
                return _reader;
            }
            set
            {
                _reader = value;
            }
        }

        public IQueryResultRow FirstRow
        {
            get
            {
                return _rows.FirstOrDefault();
            }
        }

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!")]
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            set
            {
                _dataTable = value;
            }
        }

        [Obsolete("use ExecuteQuery()!")]
        public void ExecuteReader(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                _reader = _currentCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlProvider(string connectionString)
        {
            try
            {
                _connection = new SqlConnection(connectionString);
                _connection.Open();
                _currentCommand = new SqlCommand("", _connection);
                _commands = new List<SqlCommand>();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                _commands.Add(_currentCommand);
                Commit();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public int ExecuteScalar(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                object commandResult = _currentCommand.ExecuteScalar();
                int intResult;
                if (!int.TryParse(commandResult.ToString(), out intResult))
                {
                    throw new ResultIsNotInt32Exception(commandResult);
                }
                return intResult;
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public int ExecuteInt32WithNullAsZero(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                object commandResult = _currentCommand.ExecuteScalar();
                if (commandResult is int?)
                {
                    return Convert.ToInt32(commandResult);
                }
                if (commandResult == DBNull.Value
                    || commandResult == null)
                {
                    return 0;
                }
                throw new ResultIsNotInt32Exception(commandResult);
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public bool ExecuteBooleanWithNullAsFalse(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                object commandResult = _currentCommand.ExecuteScalar();
                if (commandResult is bool?)
                {
                    return Convert.ToBoolean(commandResult);
                }
                if (commandResult == DBNull.Value
                    || commandResult == null)
                {
                    return false;
                }
                throw new ResultIsNotBooleanException(commandResult);
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void SetParameterImage(string parameterName, object value)
        {
            SetParameter(parameterName, value, SqlDbType.Image);
        }

        private void SetParameter(string parameterName, object value, SqlDbType sqlDbType)
        {
            object sqlValue = value ?? DBNull.Value;
            if (_currentCommand.Parameters.OfType<SqlParameter>().Any(p => p.ParameterName == parameterName))
            {
                _currentCommand.Parameters[parameterName].SqlDbType = sqlDbType;
            }
            else
            {
                _currentCommand.Parameters.AddWithValue(parameterName, sqlValue);
            }
            _currentCommand.Parameters[parameterName].SqlDbType = sqlDbType;
        }

        public void SetParameter(string parameterName, object value)
        {
            object sqlValue = value ?? DBNull.Value;
            if (_currentCommand.Parameters.OfType<SqlParameter>().Any(p => p.ParameterName == parameterName))
            {
                _currentCommand.Parameters[parameterName].Value = sqlValue;
            }
            else
            {
                _currentCommand.Parameters.AddWithValue(parameterName, sqlValue);
            }
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                GenerateColumnsAndRows();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void ExecuteProcedure(string procedureName)
        {
            try
            {
                _currentCommand.CommandType = CommandType.StoredProcedure;
                _currentCommand.CommandText = procedureName;
                GenerateColumnsAndRows();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        private void GenerateColumnsAndRows()
        {
            _reader = _currentCommand.ExecuteReader();
            GenerateColumsFromReader();
            GenerateRowsFromReader();
            _reader.Close();
        }

        private void GenerateColumsFromReader()
        {
            _columns.Clear();
            for (int i = 0; i < _reader.FieldCount; i++)
            {
                string columnName = _reader.GetName(i);
                var columnType = _reader.GetFieldType(i);
                var column = new QueryColumn(columnName, columnType);
                _columns.Add(column);
            }
        }

        private void GenerateRowsFromReader()
        {
            _rows.Clear();
            while (_reader.Read())
            {
                var row = new QueryRow();
                for (int i = 0; i < _reader.FieldCount; i++)
                {
                    row.AddField(_reader.GetName(i), _reader[i]);
                }
                _rows.Add(row);
            }
        }

        public string ExecuteString(string sql)
        {
            try
            {
                _currentCommand.CommandText = sql;
                _reader = _currentCommand.ExecuteReader();
                if (_reader.Read())
                {
                    return _reader[0].ToString();
                }
                _reader.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        [Obsolete("use ExecuteQuery()!")]
        public void ExecuteDataTable(string sql)
        {
            try
            {
                _dataTable = new DataTable();
                _currentCommand.CommandText = sql;
                using (var dataAdapter = new SqlDataAdapter(_currentCommand))
                {
                    dataAdapter.Fill(_dataTable);
                }
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void ExeuteInOneTransaction(StringCollection scripts)
        {
            SqlTransaction transaction = _currentCommand.Connection.BeginTransaction(IsolationLevel.ReadUncommitted);
            try
            {
                foreach (string script in scripts)
                {
                    ExecuteNonQueryTransacted(script, transaction);
                }
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                }
                finally
                {
                    throw new SqlProviderException(ex);
                }
            }
        }

        private void ExecuteNonQueryTransacted(string sql, SqlTransaction transaction)
        {
            _currentCommand.Transaction = transaction;
            _currentCommand.CommandText = sql;
            _currentCommand.ExecuteNonQuery();
        }

        public void ExecuteInOneTransaction(IEnumerable<SqlProviderCommand> commands)
        {
            using (SqlTransaction transaction = _connection.BeginTransaction())
            {
                foreach (SqlProviderCommand command in commands)
                {
                    using (SqlCommand sqlCommand = ConvertToSqlCommandInTransaction(command, transaction))
                    {
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            throw new SqlProviderException(ex);
                        }
                    }
                }
            }
        }

        private SqlCommand ConvertToSqlCommandInTransaction(SqlProviderCommand command, SqlTransaction transaction)
        {
            var sqlCommand = new SqlCommand(command.Instruction, _connection, transaction);
            foreach (SqlProviderCommand.Parameter parameter in command.Parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Name, parameter.Value);
            }
            return sqlCommand;
        }

        public void Dispose()
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }
            foreach (var command in _commands)
            {
                command.Dispose();
            }
            if (_dataTable != null)
            {
                _dataTable.Dispose();
            }
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }

        public void AddCommand(string commandText)
        {
            var command = new SqlCommand(commandText, _connection);
            _commands.Add(command);
            _currentCommand = command;
        }

        public void Commit()
        {
            using (SqlTransaction transaction = _connection.BeginTransaction())
            {
                var currentCommand = new SqlCommand();
                try
                {
                    foreach (var command in _commands)
                    {
                        currentCommand = command;
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    _commands.Clear();
                    FireSuccessCommit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    FireFailCommit();
                    throw new Exception(e.Message + " in command" + currentCommand.CommandText);
                }
            }
        }

        private void FireFailCommit()
        {
            if (FailCommit != null)
            {
                FailCommit(this, new EventArgs());
            }
        }

        private void FireSuccessCommit()
        {
            if (SuccessCommit != null)
            {
                SuccessCommit(this, new EventArgs());
            }
        }
    }
};