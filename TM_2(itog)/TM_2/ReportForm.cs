using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TM_2
{
    public partial class ReportForm : Form
    {
        private CalculateInfo _calculateInfo;

        public ReportForm(CalculateInfo calculateInfo)
        {
            InitializeComponent();
            _calculateInfo = calculateInfo;
            AddFirstRow();
            AddEnergyTotalCost();
            AddEnergyAverageCostSum();
            AddEnergyTransferCostSum();
            AddEnergyOtherCostSum();
            AddEnergySalesSurchargeCostSum();
            AddClearRow();
            AddPowerTotalCost();
            AddPowerAverageCostSum();
            AddPowerSalesSurchargeCostSum();
            AddTotalCost();
        }

        private void AddFirstRow()
        {
            uiMainDataGridView.Rows.Add("1", "2а", "2б", "3", "4", "5", "6", "7", "8", "9");
        }

        private void AddEnergyTotalCost()
        {
            AddRow(_calculateInfo.EnergyTotalCost, _calculateInfo.EnergyTotal,
                   (_calculateInfo.EnergyTotalCost/_calculateInfo.EnergyTotal),
                   "1. Ставка на электроэнергию по тарифу(цене) в т.ч.");
        }

        private void AddEnergyAverageCostSum()
        {
            AddRow(_calculateInfo.EnergyAverageCostSum, _calculateInfo.EnergyTotal,
                   (_calculateInfo.EnergyAverageCostSum/_calculateInfo.EnergyTotal),
                   "1.1 Средневзвешанная стоимость покупки э/энергии");
        }

        private void AddEnergyTransferCostSum()
        {
            AddRow(_calculateInfo.EnergyTransferCostSum, _calculateInfo.EnergyTotal,
                   _calculateInfo.CoefficientEnergyTransfer, "1.2 Тариф на услуги по передаче э/энергии");
        }

        private void AddEnergyOtherCostSum()
        {
            AddRow(_calculateInfo.EnergyOtherCostSum, _calculateInfo.EnergyTotal, _calculateInfo.CoefficientEnergyOther,
                   "1.3 Плата за иные услуги");
        }

        private void AddEnergySalesSurchargeCostSum()
        {
            AddRow(_calculateInfo.EnergySalesSurchargeCostSum, _calculateInfo.EnergyTotal,
                   (_calculateInfo.EnergySalesSurchargeCostSum/_calculateInfo.EnergyTotal), "1.4 Сбытовая надбавка");
        }

        private void AddClearRow()
        {
            uiMainDataGridView.Rows.Add(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
        }

        private void AddPowerTotalCost()
        {
            AddRow(_calculateInfo.PowerTotalCost, _calculateInfo.PowerTotal,
                   (_calculateInfo.PowerTotalCost/_calculateInfo.PowerTotal),
                   "2. Ставка за мощность, приобретаемую покупателем в т.ч.");
        }

        private void AddPowerAverageCostSum()
        {
            AddRow(_calculateInfo.PowerAverageCostSum, _calculateInfo.PowerTotal,
                   (_calculateInfo.PowerAverageCostSum/_calculateInfo.PowerTotal),
                   "2.1 Средневзвешанная нергегулируемая цена");
        }

        private void AddPowerSalesSurchargeCostSum()
        {
            AddRow(_calculateInfo.PowerSalesSurchargeCostSum, _calculateInfo.PowerTotal,
                   (_calculateInfo.PowerSalesSurchargeCostSum/_calculateInfo.PowerTotal), "2.2 Сбытовая надбавка");
        }

        private void AddRow(double energyCostSum, double energyTotal, double coefficientEnergyCost, string name)
        {
            var costTax = _calculateInfo.TaxValue*energyCostSum;
            uiMainDataGridView.Rows.Add(name, "245", "кВт*ч",
                                        energyTotal.ToString("0.00"),
                                        coefficientEnergyCost.ToString("0.00000"),
                                        energyCostSum.ToString("0.00"), "без акциза",
                                        _calculateInfo.TaxValue*100+'%', (costTax).ToString("0.00"),
                                        (costTax + energyCostSum).ToString("0.00"));
        }

        private void AddTotalCost()
        {
            var costTax = _calculateInfo.TaxValue*_calculateInfo.TotalCost;
            uiMainDataGridView.Rows.Add("Всего к оплате", "", "", "", "",
                                        _calculateInfo.TotalCost.ToString("0.00"), "", "", "",
                                        (costTax + _calculateInfo.TotalCost).ToString("0.00"));
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ExcelExport();
        }

        private void ExcelExport()
        {
            var saveFileDialog = new SaveFileDialog
                                     {
                                         Filter = "XLS files (*.xls)|*.xls*|All files (*.*)|*.*",
                                         FilterIndex = 1,
                                         RestoreDirectory = true,
                                         DefaultExt = "xls",
                                         AddExtension = true
                                     };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path1 = "ItogData.xls";
                string path2 = saveFileDialog.FileName;
                File.Copy(path1, path2, true);
                WriteXlsData(path2);
                //using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path2 + ";Extended Properties='Excel 8.0;HDR=Yes'"))
                //{
                //    conn.Open();
                //    string sql = "CREATE TABLE [Sheet1]([Тип устройства]string)";
                //    OleDbCommand cmd = new OleDbCommand(sql, conn);
                //    cmd.ExecuteNonQuery();

                //    cmd = new OleDbCommand("INSERT INTO [Sheet1$] VALUES ('test')", conn);
                //    cmd.ExecuteNonQuery();
                //    conn.Close();
                //}
            }
        }

        private void WriteXlsData(string filename)
        {
            var xlsConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename +
                                              ";Extended Properties=\"Excel 8.0\"");
            xlsConn.Open();
            var commandText = "[" + uiMainDataGridView.Columns[0].HeaderText + "]string"; 
            for (int c = 1; c < uiMainDataGridView.Columns.Count; c++)
            {
                commandText += ",[" + uiMainDataGridView.Columns[c].HeaderText + "]string";
            }

            string sql = "CREATE TABLE [Sheet1](" + commandText + ")";
            OleDbCommand cmd = new OleDbCommand(sql, xlsConn);
            cmd.ExecuteNonQuery();

            for(int r= 0;r<uiMainDataGridView.Rows.Count;r++)
            {
                commandText = "INSERT INTO [Sheet1$] VALUES (";
                commandText += "'" + uiMainDataGridView[0, r].Value + "'";
                for(int c= 1;c<uiMainDataGridView.Columns.Count;c++)
                {
                    commandText += ",'" + uiMainDataGridView[c, r].Value + "'";
                }
                commandText += ")";
                var xlsCmd = new OleDbCommand
                {
                    Connection = xlsConn,
                    CommandText = commandText
                };
                xlsCmd.ExecuteNonQuery();
            }
            for (int r = 0; r < uiMainDataGridView.Rows.Count; r++)
            {
                commandText = "INSERT INTO [Лист2$] ('a','b','c','d','e','f','g','h','i','k') VALUES (";
                commandText += "'" + uiMainDataGridView[0, r].Value + "'";
                for (int c = 1; c < uiMainDataGridView.Columns.Count; c++)
                {
                    commandText += ",'" + uiMainDataGridView[c, r].Value + "'";
                }
                commandText += ")";
                var xlsCmd = new OleDbCommand
                {
                    Connection = xlsConn,
                    CommandText = commandText
                };
                xlsCmd.ExecuteNonQuery();
            }
            xlsConn.Close();
            Process.Start(filename);
        }
    }
}