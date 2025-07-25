namespace Accounting.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            return (NumberEmployees > 10) ? (AnualIncome * 0.14) : (AnualIncome * 0.16);      
        }
    }
}
