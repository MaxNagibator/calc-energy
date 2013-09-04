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
            AddEnergyTotalCost(calculateInfo);
            AddEnergyAverageCostSum(calculateInfo);
            AddEnergyTransferCostSum(calculateInfo);
            AddEnergyOtherCostSum(calculateInfo);
            AddEnergySalesSurchargeCostSum(calculateInfo);
            AddClearRow();
            AddPowerTotalCost(calculateInfo);
            AddPowerAverageCostSum(calculateInfo);
            AddPowerSalesSurchargeCostSum(calculateInfo);
            AddTotalCost(calculateInfo);
        }

        private void AddFirstRow()
        {
            uiMainDataGridView.Rows.Add("1", "2а", "2б", "3", "4", "5", "6", "7", "8", "9");
        }

        private void AddEnergyTotalCost(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyTotalCost, calculateInfo.EnergyTotal,
                   (calculateInfo.EnergyTotalCost/calculateInfo.EnergyTotal),
                   "1. Ставка на электроэнергию по тарифу(цене) в т.ч.");
        }

        private void AddEnergyAverageCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyAverageCostSum, calculateInfo.EnergyTotal,
                   (calculateInfo.EnergyAverageCostSum/calculateInfo.EnergyTotal),
                   "1.1 Средневзвешанная стоимость покупки э/энергии");
        }

        private void AddEnergyTransferCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyTransferCostSum, calculateInfo.EnergyTotal,
                   calculateInfo.CoefficientEnergyTransfer, "1.2 Тариф на услуги по передаче э/энергии");
        }

        private void AddEnergyOtherCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergyOtherCostSum, calculateInfo.EnergyTotal, calculateInfo.CoefficientEnergyOther,
                   "1.3 Плата за иные услуги");
        }

        private void AddEnergySalesSurchargeCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.EnergySalesSurchargeCostSum, calculateInfo.EnergyTotal,
                   (calculateInfo.EnergySalesSurchargeCostSum/calculateInfo.EnergyTotal), "1.4 Сбытовая надбавка");
        }

        private void AddClearRow()
        {
            uiMainDataGridView.Rows.Add(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
        }

        private void AddPowerTotalCost(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.PowerTotalCost, calculateInfo.PowerTotal,
                   (calculateInfo.PowerTotalCost/calculateInfo.PowerTotal),
                   "2. Ставка за мощность, приобретаемую покупателем в т.ч.");
        }

        private void AddPowerAverageCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.PowerAverageCostSum, calculateInfo.PowerTotal,
                   (calculateInfo.PowerAverageCostSum/calculateInfo.PowerTotal),
                   "2.1 Средневзвешанная нергегулируемая цена");
        }

        private void AddPowerSalesSurchargeCostSum(CalculateInfo calculateInfo)
        {
            AddRow(calculateInfo.PowerSalesSurchargeCostSum, calculateInfo.PowerTotal,
                   (calculateInfo.PowerSalesSurchargeCostSum/calculateInfo.PowerTotal), "2.2 Сбытовая надбавка");
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

        private void AddTotalCost(CalculateInfo calculateInfo)
        {
            var costTax = CalculateInfo.TaxValue * calculateInfo.TotalCost;
            uiMainDataGridView.Rows.Add("Всего к оплате", "", "", "", "",
                                        calculateInfo.TotalCost.ToString("0.00"), "", "", "",
                                        (costTax + calculateInfo.TotalCost).ToString("0.00"));
        }
    }
}