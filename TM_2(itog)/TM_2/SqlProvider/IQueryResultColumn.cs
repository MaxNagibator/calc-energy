using System;

namespace SqlProviderNameSpace
{
    public interface IQueryResultColumn
    {
        string Name { get; }

        Type Type { get; }
    }
}