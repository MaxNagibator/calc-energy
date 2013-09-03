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
            AddTo(calculateInfo);
            AddEnergyAverageCostSum(calculateInfo); 
            AddTransferCostSum(calculateInfo);
            AddOtherCostSum(calculateInfo);
            AddSalesSurchargeCostSum(calculateInfo);
        }

        private void AddFirstRow()
        {
            uiMainDataGridView.Rows.Add("1", "2а", "2б", "3", "4", "5", "6", "7", "8", "9");
        }

        private void AddTo(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyTotalCost, calculateInfo.EnergyTotal, (calculateInfo.EnergyTotalCost / calculateInfo.EnergyTotal), "1. Ставка на электроэнергию по тарифу(цене) в т.ч.");
        
        }

        private void AddEnergyAverageCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyAverageCostSum, calculateInfo.EnergyTotal, (calculateInfo.EnergyAverageCostSum / calculateInfo.EnergyTotal), "1.1 Средневзвешанная стоимость покупки э/энергии");
        }

        private void AddTransferCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyTransferCostSum, calculateInfo.EnergyTotal, calculateInfo.CoefficientEnergyTransfer, "1.2 Тариф на услуги по передаче э/энергии");
        }

        private void AddOtherCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyOtherCostSum, calculateInfo.EnergyTotal, calculateInfo.CoefficientEnergyOther, "1.3 Плата за иные услуги");
        }

        private void AddSalesSurchargeCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergySalesSurchargeCostSum, calculateInfo.EnergyTotal, (calculateInfo.EnergySalesSurchargeCostSum / calculateInfo.EnergyTotal), "1.4 Сбытовая надбавка");
        }

        private void AddRow(double energyCostSum, double energyTotal, double coefficientEnergyCost, string name)
        {
            var costTax = CalculateInfo.TaxValue * energyCostSum;
            uiMainDataGridView.Rows.Add(name, "245", "кВт*ч",
                                        energyTotal.ToString("0.00"),
                                        coefficientEnergyCost.ToString("0.00000"),
                                        energyCostSum.ToString("0.00"), "без акциза",
                                        CalculateInfo.TaxValue, (costTax).ToString("0.00"),
                                        (costTax + energyCostSum).ToString("0.00"));
        }
    }
}