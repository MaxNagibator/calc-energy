using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TM_2
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
            TestDbConnect();
            InizializeDateComboBoxs();
            LoadObjectRegistrationNodes();
        }

        private void TestDbConnect()
        {
            var connectForm = new ConnectDbForm(); //forma tolyana :)
            if (connectForm.ShowDialog() != DialogResult.OK)
            {
                Dispose();
            }
        }

        private void InizializeDateComboBoxs()
        {
            int maxyear = DateTime.Now.Year;
            int minyear = maxyear - 10;
            int i = minyear;
            while (i <= maxyear)
            {
                uiYearsComboBox.Items.Add(i);
                i++;
            }
            uiYearsComboBox.SelectedIndex = maxyear - minyear;
            uiMonthComboBox.SelectedIndex = DateTime.Now.Month - 2;
        }

        private void LoadObjectRegistrationNodes()
        {
            uiObjectRegistrationTreeView.BeginUpdate();
            uiObjectRegistrationTreeView.Nodes.Clear();
            AddObjectRegistrationParent(uiObjectRegistrationTreeView);
            AddObjectRegistrationChilds(uiObjectRegistrationTreeView);
            uiObjectRegistrationTreeView.EndUpdate();
        }

        private void AddObjectRegistrationParent(TreeView node)
        {
            const string cmdText = @"SELECT ID_Point, NamePoint
                                    FROM tbl_Points
                                    WHERE (TypePoint=1) AND (ID_Parent=0) AND (ID_Point=2)";
            node.Nodes.AddRange(GetNodes(cmdText));
        }

        private void AddObjectRegistrationChilds(TreeView node)
        {
            const string cmdText = @"SELECT ID_Point, NamePoint
                                    FROM tbl_Points
                                    WHERE (TypePoint=3) AND (ID_Parent=2)";
            node.Nodes[0].Nodes.AddRange(GetNodes(cmdText));
        }

        private TreeNode[] GetNodes(string cmdText)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.ExecuteQuery(cmdText);
                return sqlProvider.Rows.Select(row => new TreeNode(row.Field<string>("NamePoint"))).ToArray();
            }
        }

        private void uiImportCostButton_Click(object sender, System.EventArgs e)
        {
            var importCostForm = new ImportCostForm();
            importCostForm.ShowDialog();
        }

        private void uiOldMainFormButton_Click(object sender, System.EventArgs e)
        {
            var a = new MainForm();
            a.ShowDialog();
        }

        private void uiCalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            var selectedObjectRegistrationNode = uiObjectRegistrationTreeView.SelectedNode.Text;

            Cursor = Cursors.WaitCursor;
            dataGridView.Rows.Clear();

            string mindate = "01." + Convert.ToString(uiMonthComboBox.SelectedIndex + 1) + "." +
                             uiYearsComboBox.SelectedItem;
            string maxdate = "01." + Convert.ToString(uiMonthComboBox.SelectedIndex + 2) + "." +
                             uiYearsComboBox.SelectedItem;

            var cmdText = @"SET dateformat dmy 
                        SELECT MeasureDate, Value, Cost
                        FROM Mains
                        LEFT JOIN [CalcEnergy].[HourPrice] AS HP ON HP.Date = Mains.MeasureDate
                        WHERE (MeasureDate >= @MinDate AND MeasureDate < @MaxDate)";

            if (selectedObjectRegistrationNode == "Фидер №725")
            {
                cmdText += " AND (ID_Channel = 34)";
            }
            else
            {
                if (selectedObjectRegistrationNode == "Фидер №728")
                {
                    cmdText += " AND (ID_Channel = 70)";
                }
            }
            Calculate2(cmdText, mindate, maxdate);
            Cursor = Cursors.Default;
        }

        private void Calculate2(string cmdText, string mindate, string maxdate)
        {

            dataGridView.Rows.Clear();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                double energyValueSum = 0;
                double filkaSum = 0;
                double cost = 0;
                sqlProvider.SetParameter("@MinDate", mindate);
                sqlProvider.SetParameter("@MaxDate", maxdate);
                sqlProvider.ExecuteQuery(cmdText);
                foreach (var row in sqlProvider.Rows)
                {
                    var energyValue = row.Field<double>("Value");
                    if (row.Field<double?>("Cost") != null)
                    {
                        cost = row.Field<double>("Cost");
                    }
                    var filka = cost*energyValue/1000;
                    dataGridView.Rows.Add(row.Field<DateTime>("MeasureDate"), energyValue, cost, filka);
                    energyValueSum += energyValue;
                    filkaSum += filka;
                }
                dataGridView.Rows.Add("all", energyValueSum, filkaSum);
            }
        }
    }
}
