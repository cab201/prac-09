using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class FinancedAutomobile : Automobile
    {
        private int numberOfFinances;
        private int rate;

        public FinancedAutomobile(int kmsDriven,
            string make,
            int year,
            double price,
            int finances,
            int rate) : 
            base(kmsDriven, make, year, price)
        {
            numberOfFinances = finances;
            this.rate = rate;
        }

        public override string ToString()
        {
            return base.ToString()
                + $" and {numberOfFinances} finances, rate: {rate}";
        }
    }
}
