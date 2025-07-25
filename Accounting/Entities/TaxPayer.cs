using System;
using System.Globalization;

namespace Accounting.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name 
                + ": $" + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
