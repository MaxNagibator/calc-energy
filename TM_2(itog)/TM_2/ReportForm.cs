using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TM_2
{
    public partial class ReportForm : Form
    {
        public ReportForm(CalculateInfo calculateInfo)
        {
            InitializeComponent();
            AddFirstRow();
            AddEnergyAverageCostSum(calculateInfo); 
            AddTransferCostSum(calculateInfo);
            AddOtherCostSum(calculateInfo);
        }

        private void AddFirstRow()
        {
            uiMainDataGridView.Rows.Add("1", "2а", "2б", "3", "4", "5", "6", "7", "8", "9");
        }

        private void AddEnergyAverageCostSum(CalculateInfo calculateInfo)
        {
            var costTax = CalculateInfo.TaxValue * calculateInfo.EnergyAverageCostSum;
            uiMainDataGridView.Rows.Add("1.1 Средневзвешанная стоимость покупки э/энергии", "245", "кВт*ч",
                                        calculateInfo.EnergyTotal.ToString("0.00"),
                                        (calculateInfo.EnergyAverageCostSum/calculateInfo.EnergyTotal).ToString("0.00000"),
                                        calculateInfo.EnergyAverageCostSum.ToString("0.00"), "без акциза",
                                        CalculateInfo.TaxValue, (costTax).ToString("0.00"),
                                        (costTax + calculateInfo.EnergyAverageCostSum).ToString("0.00"));
        }

        private void AddTransferCostSum(CalculateInfo calculateInfo)
        {
            var costTax = CalculateInfo.TaxValue * calculateInfo.EnergyTransferCostSum;
            uiMainDataGridView.Rows.Add("1.2 Тариф на услуги по передаче э/энергии", "245", "кВт*ч",
                                        calculateInfo.EnergyTotal.ToString("0.00"),
                                        calculateInfo.CoefficientEnergyTransfer.ToString("0.00000"),
                                        calculateInfo.EnergyTransferCostSum.ToString("0.00"), "без акциза",
                                        CalculateInfo.TaxValue, (costTax).ToString("0.00"),
                                        (costTax + calculateInfo.EnergyTransferCostSum).ToString("0.00"));
        }

        private void AddOtherCostSum(CalculateInfo calculateInfo)
        {
            var costTax = CalculateInfo.TaxValue * calculateInfo.EnergyOtherCostSum;
            uiMainDataGridView.Rows.Add("1.3 Плата за иные услуги", "245", "кВт*ч",
                                        calculateInfo.EnergyTotal.ToString("0.00"),
                                        calculateInfo.CoefficientEnergyOther.ToString("0.00000"),
                                        calculateInfo.EnergyOtherCostSum.ToString("0.00"), "без акциза",
                                        CalculateInfo.TaxValue, (costTax).ToString("0.00"),
                                        (costTax + calculateInfo.EnergyOtherCostSum).ToString("0.00"));
        }
    }
}