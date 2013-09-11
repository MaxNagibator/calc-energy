using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
                                        _calculateInfo.TaxValue, (costTax).ToString("0.00"),
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
            }
        }

        private void WriteXlsData(string filename)
        {
            var excel = new Excel();
            excel.OpenDocument(filename);
            excel.SetValue("A1",
                           "Расчет за: " + _calculateInfo.Date.ToShortDateString() + "-" +
                           _calculateInfo.Date.AddMonths(1).AddDays(-1).ToShortDateString());
            for (int i = 1; i < uiMainDataGridView.Rows.Count; i++)
            {
                excel.SetValue("A" + (7 + i), GetValue(uiMainDataGridView[0, i]));
                excel.SetValue("B" + (7 + i), GetValue(uiMainDataGridView[1, i]));
                excel.SetValue("C" + (7 + i), GetValue(uiMainDataGridView[2, i]));
                excel.SetValue("D" + (7 + i), GetValue(uiMainDataGridView[3, i]));
                excel.SetValue("E" + (7 + i), GetValue(uiMainDataGridView[4, i]));
                excel.SetValue("F" + (7 + i), GetValue(uiMainDataGridView[5, i]));
                excel.SetValue("G" + (7 + i), GetValue(uiMainDataGridView[6, i]));
                excel.SetValue("H" + (7 + i), GetValue(uiMainDataGridView[7, i]));
                excel.SetValue("I" + (7 + i), GetValue(uiMainDataGridView[8, i]));
                excel.SetValue("J" + (7 + i), GetValue(uiMainDataGridView[9, i]));
            }
            excel.CloseDocument();
            Process.Start(filename);
        }

        private object GetValue(DataGridViewCell dataGridViewCell)
        {
            try
            {
                var a = dataGridViewCell.Value.ToString();
                var b = a.Split(',');
                return Convert.ToDouble(b[0]) + Convert.ToDouble(b[1])/(Math.Pow(10, b[1].Length));
            }
            catch
            {
                return dataGridViewCell.Value;
            }
        }
    }
}