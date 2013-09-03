﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TM_2
{
    public partial class CalculateForm : Form
    {
        public CalculateInfo CalculateInfo { get; set; }
        private DateTime _selectedDate;
        private bool _isFormLoaded;

        public CalculateForm()
        {
            CalculateInfo = new CalculateInfo();
            InitializeComponent();
            TestDbConnect();
            InizializeDateComboBoxs();
            LoadObjectRegistrationNodes();
            _isFormLoaded = true;
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
            _selectedDate = GetSelectedDate();
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
            SaveAllCalcCoefficients(_selectedDate);
            Calculate();
            var reportForm = new ReportForm(CalculateInfo);
            reportForm.ShowDialog();
        }

        private void Calculate()
        {
            if (uiObjectRegistrationTreeView.SelectedNode == null)
            {
                uiObjectRegistrationTreeView.SelectedNode = uiObjectRegistrationTreeView.Nodes[0];
            }
            Cursor = Cursors.WaitCursor;
            uiMainDataGridView.Rows.Clear();
            var mindate = GetSelectedDate();
            var maxdate = mindate.AddMonths(1);
            CalculateAll(mindate, maxdate);
            ShowResult();
            Cursor = Cursors.Default;
        }

        private DateTime GetSelectedDate()
        {
            return Convert.ToDateTime("01." + Convert.ToString(uiMonthComboBox.SelectedIndex + 1) + "." +
                                             uiYearsComboBox.SelectedItem);
        }

        private void ShowResult()
        {
            uiEnergyTotalValueLabel.Text = Math.Round(CalculateInfo.EnergyTotal, 2).ToString();
            uiEnergyAverageCostValueLabel.Text = Math.Round(CalculateInfo.EnergyAverageCostSum, 2).ToString();
            uiEnergyOtherCostSumValueLabel.Text = Math.Round(CalculateInfo.EnergyOtherCostSum, 2).ToString();
            uiEnergyTransferCostSumValueLabel.Text = Math.Round(CalculateInfo.EnergyTransferCostSum, 2).ToString();
            uiEnergyTotalCostValueLabel.Text = Math.Round(CalculateInfo.EnergyTotalCost, 2).ToString();
            uiEnergySalesSurchargeCostSumValueLabel.Text =
                Math.Round(CalculateInfo.EnergySalesSurchargeCostSum, 2).ToString();

            uiPowerTotalValueLabel.Text = Math.Round(CalculateInfo.PowerTotal, 2).ToString();
            uiPowerTotalCostValueLabel.Text = Math.Round(CalculateInfo.PowerTotalCost, 2).ToString();
            uiPowerAverageCostSumValueLabel.Text = Math.Round(CalculateInfo.PowerAverageCostSum, 2).ToString();
            uiPowerSalesSurchargeCostSumValueLabel.Text =
                Math.Round(CalculateInfo.PowerSalesSurchargeCostSum, 2).ToString();
            uiTotalCostValueLabel.Text = Math.Round(CalculateInfo.TotalCost, 2).ToString();
        }

        private void CalculateAll(DateTime mindate, DateTime maxdate)
        {
            var energyTotalCostSum = CalculateEnergyTotalCostSum(mindate, maxdate);
            var powerTotalCostSum = CalculatePowerTotalCostSum(mindate, maxdate);
            var totalCost = energyTotalCostSum + powerTotalCostSum;
            CalculateInfo.TotalCost = totalCost;
        }

        private double CalculateEnergyTotalCostSum(DateTime mindate, DateTime maxdate)
        {
            double energyAverageCostSum = CalculateEnergyAverageCostSum(mindate, maxdate);
            double energyTransferCostSum = CalculateEnergyTransferCostSum();
            double energyOtherCostSum = CalculateEnergyOtherCostSum();
            double energySalesSurchargeCostSum = CalculateEnergySalesSurchargeCostSum();
            double energyTotalCostSum = energyAverageCostSum + energyTransferCostSum + energyOtherCostSum +
                                        energySalesSurchargeCostSum;
            CalculateInfo.EnergyTotalCost = energyTotalCostSum;
            return energyTotalCostSum;
        }

        private double CalculateEnergyAverageCostSum(DateTime mindate, DateTime maxdate)
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
                sqlProvider.SetParameter("@MinDate", mindate.AddMinutes(-30));
                sqlProvider.SetParameter("@MaxDate", maxdate.AddMinutes(-30));
                sqlProvider.ExecuteQuery(cmdText);
                for (int i = 0; i < sqlProvider.Rows.Count; i += 2)
                {
                    var energyValue = sqlProvider.Rows[i].Field<double>("Value") +
                                      sqlProvider.Rows[i + 1].Field<double>("Value");
                    var cost = sqlProvider.Rows[i + 1].Field<double?>("Cost") != null
                                   ? sqlProvider.Rows[i + 1].Field<double?>("Cost") ?? 0
                                   : sqlProvider.Rows[i].Field<double?>("Cost") ?? 0;
                    var filka = cost*energyValue/1000;
                    uiMainDataGridView.Rows.Add(sqlProvider.Rows[i + 1].Field<DateTime>("MeasureDate"), energyValue,
                                                cost, filka);
                    energyTotal += energyValue;
                    energyAverageCostSum += filka;
                }
                uiMainDataGridView.Rows.Add("all", energyTotal, energyAverageCostSum);
                CalculateInfo.EnergyTotal = energyTotal;
                CalculateInfo.EnergyAverageCostSum = energyAverageCostSum;
                return energyAverageCostSum;
            }
        }

        private double CalculateEnergyTransferCostSum()
        {
            double energyTotal = CalculateInfo.EnergyTotal;
            double transferCost = Convert.ToDouble(uiEnergyTransferCostTextBox.Text);
            double energyTransferCostSum = energyTotal*transferCost;
            CalculateInfo.EnergyTransferCostSum = energyTransferCostSum;
            return energyTransferCostSum;
        }

        private double CalculateEnergyOtherCostSum()
        {
            double energyTotal = CalculateInfo.EnergyTotal;
            double cost = Convert.ToDouble(uiEnergyOtherCostValueTextBox.Text);
            double energyOtherCostSum = energyTotal*cost;
            CalculateInfo.EnergyOtherCostSum = energyOtherCostSum;
            return energyOtherCostSum;
        }

        private double CalculateEnergySalesSurchargeCostSum()
        {
            double energyAverageCostSum = CalculateInfo.EnergyAverageCostSum;
            double coefficient = Convert.ToDouble(uiEnergySalesSurchargeCostValueTextBox.Text) * Convert.ToDouble(uiEnergySalesSurchargeCost2ValueTextBox.Text);
            double energySalesSurchargeCostSum = energyAverageCostSum*coefficient;
            CalculateInfo.EnergySalesSurchargeCostSum = energySalesSurchargeCostSum;
            return energySalesSurchargeCostSum;
        }

        private double CalculatePowerTotalCostSum(DateTime mindate, DateTime maxdate)
        {
            double averagePowerCostSum = CalculatePowerAverageCostSum(mindate, maxdate);
            double salesSurchargePowerSum = CalculatePowerSalesSurchargeCostSum();
            double powerTotalCost = averagePowerCostSum + salesSurchargePowerSum;
            CalculateInfo.PowerTotalCost = powerTotalCost;
            uiEnergyTotalCostValueLabel.Text = powerTotalCost.ToString();
            return powerTotalCost;
        }

        private double CalculatePowerAverageCostSum(DateTime mindate, DateTime maxdate)
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
                powerTotal = powerTotal/dateList.Count;
                var powerAverageCostSum = powerTotal*cost;
                CalculateInfo.PowerAverageCostSum = powerAverageCostSum;
                CalculateInfo.PowerTotal = powerTotal;
                return powerAverageCostSum;
            }
        }

        private double CalculatePowerSalesSurchargeCostSum()
        {
            double powerTotal = CalculateInfo.PowerTotal;
            double cost = CalculateInfo.CoefficientPowerAverage*CalculateInfo.CoefficientEnergySalesSurcharge*
                          CalculateInfo.CoefficientEnergySalesSurcharge2;
            double powerSalesSurchargeCostSum = powerTotal*cost;
            CalculateInfo.PowerSalesSurchargeCostSum = powerSalesSurchargeCostSum;
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

        private void SaveAllCalcCoefficients(DateTime date)
        {
            GetCoefficientsFromForm();
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.AddCommand(@"
                    DELETE FROM [CalcEnergy].[Coefficients] WHERE Date = @Date");
                sqlProvider.SetParameter("@Date", date);
                sqlProvider.AddCommand(@"
                    INSERT INTO [CalcEnergy].[Coefficients] 
                        (Date
                        ,EnergyOtherCost
                        ,EnergySalesSurchargeCost
                        ,EnergySalesSurchargeCost2
                        ,EnergyTransferCost
                        ,PowerSalesSurchargeCost
                        ,PowerAverageCost)
                    VALUES (@Date
                        ,@EnergyOtherCost
                        ,@EnergySalesSurchargeCost
                        ,@EnergySalesSurchargeCost2
                        ,@EnergyTransferCost
                        ,@PowerSalesSurchargeCost
                        ,@PowerAverageCost)");
                sqlProvider.SetParameter("@Date", date);
                sqlProvider.SetParameter("@EnergyOtherCost", CalculateInfo.CoefficientEnergyOther);
                sqlProvider.SetParameter("@EnergySalesSurchargeCost", CalculateInfo.CoefficientEnergySalesSurcharge);
                sqlProvider.SetParameter("@EnergySalesSurchargeCost2", CalculateInfo.CoefficientEnergySalesSurcharge2);
                sqlProvider.SetParameter("@EnergyTransferCost", CalculateInfo.CoefficientEnergyTransfer);
                sqlProvider.SetParameter("@PowerSalesSurchargeCost", CalculateInfo.CoefficientPowerSalesSurcharge);
                sqlProvider.SetParameter("@PowerAverageCost", CalculateInfo.CoefficientPowerAverage);
                sqlProvider.Commit();
            }
        }

        private void GetCoefficientsFromForm()
        {
            CalculateInfo.CoefficientEnergyOther = Convert.ToDouble(uiEnergyOtherCostValueTextBox.Text);
            CalculateInfo.CoefficientEnergySalesSurcharge = Convert.ToDouble(uiEnergySalesSurchargeCostValueTextBox.Text);
            CalculateInfo.CoefficientEnergySalesSurcharge2 = Convert.ToDouble(uiEnergySalesSurchargeCost2ValueTextBox.Text);
            CalculateInfo.CoefficientEnergyTransfer = Convert.ToDouble(uiEnergyTransferCostTextBox.Text);
            CalculateInfo.CoefficientPowerAverage = Convert.ToDouble(uiPowerAverageCostTextBox.Text);
        }

        private void LoadAllCalcCoefficients(DateTime date)
        {
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                sqlProvider.SetParameter("@Date", date);
                sqlProvider.ExecuteQuery(@"
                   SELECT EnergyOtherCost
                        ,EnergySalesSurchargeCost
                        ,EnergySalesSurchargeCost2
                        ,EnergyTransferCost
                        ,PowerAverageCost
                    FROM [CalcEnergy].[Coefficients]
                    WHERE Date = @Date");
                if (sqlProvider.HasRows)
                {
                    CalculateInfo.CoefficientEnergyOther
                        = sqlProvider.FirstRow.Field<double?>("EnergyOtherCost") ?? 0;
                    CalculateInfo.CoefficientEnergySalesSurcharge =
                        sqlProvider.FirstRow.Field<double?>("EnergySalesSurchargeCost") ?? 0;
                    CalculateInfo.CoefficientEnergySalesSurcharge2 =
                        sqlProvider.FirstRow.Field<double?>("EnergySalesSurchargeCost2") ?? 0;
                    CalculateInfo.CoefficientEnergyTransfer
                        = sqlProvider.FirstRow.Field<double?>("EnergyTransferCost") ?? 0;
                    CalculateInfo.CoefficientPowerAverage
                        = sqlProvider.FirstRow.Field<double?>("PowerAverageCost") ?? 0;
                }
                else
                {
                    CalculateInfo.ClearCoefficients();
                }
                ShowCoefficients();
            }
        }

        private void ShowCoefficients()
        {
            uiEnergyOtherCostValueTextBox.Text = CalculateInfo.CoefficientEnergyOther.ToString();
            uiEnergySalesSurchargeCostValueTextBox.Text = CalculateInfo.CoefficientEnergySalesSurcharge.ToString();
            uiEnergySalesSurchargeCost2ValueTextBox.Text = CalculateInfo.CoefficientEnergySalesSurcharge2.ToString();
            uiEnergyTransferCostTextBox.Text = CalculateInfo.CoefficientEnergyTransfer.ToString();
            uiPowerAverageCostTextBox.Text = CalculateInfo.CoefficientPowerAverage.ToString();
        }

        private void uiPowerAverageCostTextBox_Leave(object sender, EventArgs e)
        {
            double outputValue;
            var isNumber = double.TryParse(((TextBox)sender).Text, out outputValue);
            if(!isNumber)
            {
                ((TextBox) sender).Text = "0";
            }
        }

        private void uiDatesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isFormLoaded)
            {
                ChangeDate();
            }
        }

        private void ChangeDate()
        {
            SaveAllCalcCoefficients(_selectedDate);
            _selectedDate = GetSelectedDate();
            LoadAllCalcCoefficients(_selectedDate);
        }
    }
}
