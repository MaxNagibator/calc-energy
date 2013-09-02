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
        }

        private void AddFirstRow()
        {
            uiMainDataGridView.Rows.Add("1", "2а", "2б", "3", "4", "5", "6", "7", "8", "9");
        }

        private void AddEnergyAverageCostSum(CalculateInfo calculateInfo)
        {
            uiMainDataGridView.Rows.Add("1. Ставка на электроэнергию по тарифу(цене) в т.ч.", "245", "кВт*ч",
                                        calculateInfo.EnergyTotal,
                                        calculateInfo.EnergyAverageCostSum/calculateInfo.EnergyTotal,
                                        calculateInfo.EnergyAverageCostSum, "без акциза",
                                        CalculateInfo.TaxValue, CalculateInfo.TaxValue * calculateInfo.EnergyAverageCostSum,
                                        (CalculateInfo.TaxValue + 1) * calculateInfo.EnergyAverageCostSum);
        }
    }
}
