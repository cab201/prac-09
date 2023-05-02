using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class FinancedAutomobile : Automobile
    {
        private int finances;
        private int rate;

        public FinancedAutomobile(int kmDriven,
            string make,
            int year,
            int finances,
            int rate) : base(kmDriven, make, year)
        {
            // Extensions
            this.finances = finances;
            this.rate = rate;
        }

        public override string ToString()
        {
            return $"{base.ToString()} This is a financed automobile with {finances} finances, and a rate of {rate}.";
        }
    }
}
