using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulacion.Models
{
    public class TaxCalculator
    {
        private const double USTaxRate = 0.07;
        private const double EUTaxRate = 0.20;

        public double GetTaxRate(string country, string state)
        {
            if (state == "US")
            {
                return GetUSTax(state);
            }
            else if (country == "EU") 
            {
                return GetEUTax(country);
            }
            else
            {
                // Si el país no tiene un impuesto definido. Como china
                return 0.0;
            }
        }

        private double GetUSTax(string state)
        {
            return USTaxRate;
        }

        private double GetEUTax(string country)
        {
            return EUTaxRate;
        }
    }
}



