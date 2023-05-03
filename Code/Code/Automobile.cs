using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Automobile
    {
        private int kmsDriven;
        private string make;
        private int year;
        private double price;

        public Automobile(
            int kmsDriven, 
            string make, 
            int year, 
            double price)
        {
            this.kmsDriven = kmsDriven;
            this.make = make;
            this.year = year;
            this.price = price;
        }

        public void Drive(int kms)
        {
            kmsDriven += kms;
        }

        public override string ToString()
        {
            return $"Make: {make}; {kmsDriven} kms; " +
                $"year: {year}; price: {price:C2}";
        }
    }
}
