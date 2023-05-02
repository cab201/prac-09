using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    /// <summary>
    /// The class should hold fields for number of kilometres driven, make, year and price which are passed as parameters
    /// </summary>
    internal class Automobile
    {
        private int kmDriven;
        private string make;
        private int year;

        public Automobile(int kmDriven, 
            string make, 
            int year)
        {
            this.kmDriven = kmDriven;
            this.make = make;
            this.year = year;
        }

        /// <summary>
        /// Increases the number of kms driven by
        /// a certain amount
        /// </summary>
        /// <param name="kms">The number of kms to increase by</param>
        public void Drive(int kms)
        {
            kmDriven += kms;
        }

        public override string ToString()
        {
            return $"{kmDriven} kms, make: {make}, year: {year}.";
        }
    }
}
