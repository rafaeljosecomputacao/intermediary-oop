namespace Accounting.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (HealthExpenditures > 0.0)
            {
                tax = (AnualIncome < 20000.0) ? ((AnualIncome * 0.15) - (HealthExpenditures * 0.5)) : ((AnualIncome * 0.25) - (HealthExpenditures * 0.5));
            }
            else
            {
                tax = (AnualIncome < 20000.0) ? (AnualIncome * 0.15) : (AnualIncome * 0.25);
            }
            return tax;
        }
    }
}
