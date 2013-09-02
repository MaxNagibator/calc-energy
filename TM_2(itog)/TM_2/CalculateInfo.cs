namespace TM_2
{
    public class CalculateInfo
    {
        public double TotalCost { get; set; }

        public double EnergyTotalCost { get; set; }
        public double EnergyAverageCostSum { get; set; }
        public double EnergyTransferCostSum { get; set; }
        public double EnergyOtherCostSum { get; set; }
        public double EnergyAtsCostSum { get; set; }
        public double EnergyCfrCostSum { get; set; }
        public double EnergyEesCostSum { get; set; }
        public double EnergySalesSurchargeCostSum { get; set; }
        public double EnergyTotal { get; set; }

        public double PowerTotalCost { get; set; }
        public double PowerAverageCostSum { get; set; }
        public double PowerSalesSurchargeCostSum { get; set; }
        public double PowerTotal { get; set; }

        public const double TaxValue = 0.18;

        public double CoefficientEnergyOther { get; set; }
        public double CoefficientEnergySalesSurcharge { get; set; }
        public double CoefficientEnergyTransfer { get; set; }
        public double CoefficientPowerSalesSurcharge { get; set; }
        public double CoefficientPowerAverage { get; set; }

        public void ClearCoefficients()
        {
            CoefficientEnergyOther = 0;
            CoefficientEnergySalesSurcharge = 0;
            CoefficientEnergyTransfer = 0;
            CoefficientPowerSalesSurcharge = 0;
            CoefficientPowerAverage = 0;
        }
    }
}
