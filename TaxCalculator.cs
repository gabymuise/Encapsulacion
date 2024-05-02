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
            if (country == "US")
            {
                return GetUSTax(country);
            }
            else if (state == "EU") 
            {
                return GetEUTax(state);
            }
            else
            {
                // Si el país no tiene un impuesto definido. Como china
                return 0.0;
            }
        }

        private double GetUSTax(string country)
        {
            return USTaxRate;
        }

        private double GetEUTax(string state)
        {
            return EUTaxRate;
        }
    }
}



