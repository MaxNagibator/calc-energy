using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TM_2
{
    public partial class CalculateForm : Form
    {
        public CostSum totalCostSum { get; set; }
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

        private void uiImportCostButton_Click(object sender, EventArgs e)
        {
            var importCostForm = new ImportCostForm();
            importCostForm.ShowDialog();
        }

        private void uiPowerHourButton_Click(object sender, EventArgs e)
        {
            var importHourPowerForm = new ImportHourPowerForm();
            importHourPowerForm.ShowDialog();
        }

        private void uiOldMainFormButton_Click(object sender, EventArgs e)
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
            Cursor = Cursors.WaitCursor;
            uiMainDataGridView.Rows.Clear();

            string mindate = "01." + Convert.ToString(uiMonthComboBox.SelectedIndex + 1) + "." +
                             uiYearsComboBox.SelectedItem;
            string maxdate = "01." + Convert.ToString(uiMonthComboBox.SelectedIndex + 2) + "." +
                             uiYearsComboBox.SelectedItem;

            CalculateAll(mindate, maxdate);
            ShowResult();
            Cursor = Cursors.Default;
        }

        private void ShowResult()
        {
            uiEnergyAverageCostValueLabel.Text = totalCostSum.EnergyAverageCostSum.ToString();
            uiEnergyTotalValueLabel.Text = totalCostSum.EnergyTotal.ToString();
            uiEnergyEesCostSumValueLabel.Text = totalCostSum.EnergyEesCostSum.ToString();
            uiEnergyAtsCostSumValueLabel.Text = totalCostSum.EnergyAtsCostSum.ToString();
            uiEnergyCfrCostSumValueLabel.Text = totalCostSum.EnergyCfrCostSum.ToString();
            uiEnergyOtherCostSumValueLabel.Text = totalCostSum.EnergyOtherCostSum.ToString();
            uiEnergyTransferCostSumValueLabel.Text = totalCostSum.EnergyTransferCostSum.ToString();
            uiEnergyTotalCostValueLabel.Text = totalCostSum.EnergyTotalCost.ToString();
            uiEnergySalesSurchargeCostSumValueLabel.Text = totalCostSum.EnergySalesSurchargeCostSum.ToString();

            uiPowerTotalValueLabel.Text = totalCostSum.PowerTotal.ToString();
            uiPowerAverageCostSumValueLabel.Text = totalCostSum.PowerAverageCostSum.ToString();
            uiPowerSalesSurchargeCostSumValueLabel.Text = totalCostSum.PowerSalesSurchargeCostSum.ToString();
            uiTotalCostValueLabel.Text = totalCostSum.TotalCost.ToString();
        }

        private void CalculateAll(string mindate, string maxdate)
        {
           var energyTotalCostSum = CalculateEnergyTotalCostSum(mindate, maxdate);
           var powerTotalCostSum = CalculatePowerTotalCostSum(mindate, maxdate);
            var totalCost = energyTotalCostSum + powerTotalCostSum;
            totalCostSum.TotalCost = totalCost;
        }

        private double CalculateEnergyTotalCostSum(string mindate, string maxdate)
        {
            double energyAverageCostSum = CalculateEnergyAverageCostSum(mindate, maxdate);
            double energyTransferCostSum = CalculateEnergyTransferCostSum();
            double energyOtherCostSum = CalculateEnergyOtherCostSum();
            double energySalesSurchargeCostSum = CalculateEnergySalesSurchargeCostSum();
            double energyTotalCostSum = energyAverageCostSum + energyTransferCostSum + energyOtherCostSum + energySalesSurchargeCostSum;
            totalCostSum.EnergyTotalCost = energyTotalCostSum;
            return energyTotalCostSum;
        }

        private double CalculateEnergyAverageCostSum(string mindate, string maxdate)
        {
            var cmdText = @"SET dateformat dmy 
                        SELECT MeasureDate, Value, Cost
                        FROM Mains
                        LEFT JOIN [CalcEnergy].[HourPrice] AS HP ON HP.Date = Mains.MeasureDate
                        WHERE (MeasureDate >= @MinDate AND MeasureDate < @MaxDate)";

            cmdText += GetObjectChanelId();

            uiMainDataGridView.Rows.Clear();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                double energyTotal = 0;
                double energyAverageCostSum = 0;
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
                    uiMainDataGridView.Rows.Add(row.Field<DateTime>("MeasureDate"), energyValue, cost, filka);
                    energyTotal += energyValue;
                    energyAverageCostSum += filka;
                }
                uiMainDataGridView.Rows.Add("all", energyTotal, energyAverageCostSum);
                totalCostSum.EnergyTotal = energyTotal;
                totalCostSum.EnergyAverageCostSum = energyAverageCostSum;
                return energyAverageCostSum;
            }
        }

        private double CalculateEnergyTransferCostSum()
        {
            double energyTotal = totalCostSum.EnergyTotal;
            double transferCost = Convert.ToDouble(uiEnergyTransferCostTextBox.Text);
            double energyTransferCostSum = energyTotal*transferCost;
            totalCostSum.EnergyTransferCostSum = energyTransferCostSum;
            return energyTransferCostSum;
        }

        private double CalculateEnergyOtherCostSum()
        {
            double atsTotalEnergy = CalculateEnergyAtsCostSum();
            double cfrTotalEnergy = CalculateEnergyCfrCostSum();
            double eesTotalEnergy = CalculateEnergyEesCostSum();
            double energyOtherCostSum = atsTotalEnergy + cfrTotalEnergy + eesTotalEnergy;
            totalCostSum.EnergyOtherCostSum = energyOtherCostSum;
            return energyOtherCostSum;
        }

        private double CalculateEnergyAtsCostSum()
        {
            double energyTotal = totalCostSum.EnergyTotal;
            double cost = Convert.ToDouble(uiEnergyAtsCostValueTextBox.Text);
            double energyAtsCostSum = energyTotal * cost;
            totalCostSum.EnergyAtsCostSum = energyAtsCostSum;
            return energyAtsCostSum;
        }

        private double CalculateEnergyCfrCostSum()
        {
            double energyTotal = totalCostSum.EnergyTotal;
            double cost = Convert.ToDouble(uiEnergyCfrCostValueTextBox.Text);
            double energyCfrCostSum = energyTotal * cost;
            totalCostSum.EnergyCfrCostSum = energyCfrCostSum;
            return energyCfrCostSum;
        }

        private double CalculateEnergyEesCostSum()
        {
            double energyTotal = totalCostSum.EnergyTotal;
            double cost = Convert.ToDouble(uiEnergyEesCostValueTextBox.Text);
            double energyEesCostSum = energyTotal*cost;
            totalCostSum.EnergyEesCostSum = energyEesCostSum;
            return energyEesCostSum;
        }

        private double CalculateEnergySalesSurchargeCostSum()
        {
            double energyTotal = totalCostSum.EnergyTotal;
            double cost = Convert.ToDouble(uiEnergySalesSurchargeCostValueTextBox.Text);
            double energySalesSurchargeCostSum = energyTotal*cost;
            totalCostSum.EnergySalesSurchargeCostSum = energySalesSurchargeCostSum;
            return energySalesSurchargeCostSum;
        }

        private double CalculatePowerTotalCostSum(string mindate, string maxdate)
        {
            double averagePowerCostSum = CalculatePowerAverageCostSum(mindate, maxdate);
            double salesSurchargePowerSum =  CalculatePowerSalesSurchargeCostSum();
            double powerTotalCost = averagePowerCostSum + salesSurchargePowerSum;
            totalCostSum.PowerTotalCost = powerTotalCost;
            uiEnergyTotalCostValueLabel.Text = powerTotalCost.ToString();
            return powerTotalCost;
        }

        private double CalculatePowerAverageCostSum(string mindate, string maxdate)
        {
            double cost = Convert.ToDouble(uiPowerAverageCostTextBox.Text);
            double powerTotal = 0;
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@MinDate", mindate);
                sqlProvider.SetParameter("@MaxDate", maxdate);
                sqlProvider.ExecuteQuery(@"SELECT Date, Hour
                        FROM [CalcEnergy].[PowerHour]
                        WHERE (Date >= @MinDate AND Date < @MaxDate)");

                var dateList =
                    sqlProvider.Rows.Select(row =>
                                            row.Field<DateTime>("Date").AddHours(row.Field<int>("Hour"))).ToList();

                var cmdText = @"SELECT Value
                                FROM Mains
                                WHERE (MeasureDate = @Date OR MeasureDate = @Date2)";
                cmdText += GetObjectChanelId();

                foreach (var date in dateList)
                {
                    sqlProvider.SetParameter("@Date", date);
                    sqlProvider.SetParameter("@Date2", date.AddMinutes(-30));
                    sqlProvider.ExecuteQuery(cmdText);
                    if (sqlProvider.HasRows)
                    {
                        double value = sqlProvider.Rows.Sum(row => row.Field<double>("Value"));
                        powerTotal += value;
                        uiMainDataGridView.Rows.Add(date, value);
                    }
                }
                var powerAverageCostSum = (powerTotal*cost/dateList.Count);
                totalCostSum.PowerAverageCostSum = powerAverageCostSum;
                totalCostSum.PowerTotal = powerTotal;
                return powerAverageCostSum;
            }
        }

        private double CalculatePowerSalesSurchargeCostSum()
        {
            double powerTotal = totalCostSum.PowerTotal;
            double cost = Convert.ToDouble(uiPowerSalesSurchargeCostValueTextBox.Text);
            double powerSalesSurchargeCostSum = powerTotal * cost;
            totalCostSum.PowerSalesSurchargeCostSum = powerSalesSurchargeCostSum;
            return powerSalesSurchargeCostSum;
        }

        private string GetObjectChanelId()
        {
            var selectedObjectRegistrationNode = uiObjectRegistrationTreeView.SelectedNode.Text;
            if (selectedObjectRegistrationNode == "Фидер №725")
            {
                return " AND (ID_Channel = 34)";
            }
            if (selectedObjectRegistrationNode == "Фидер №728")
            {
                return " AND (ID_Channel = 70)";
            }
            if (selectedObjectRegistrationNode == "ПС Правобережная")
            {
                return " AND ((ID_Channel = 34) OR (ID_Channel = 70))";
            }
            return "";
        }
    }
}
