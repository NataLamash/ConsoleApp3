using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  
    public class Converter
    {
        public decimal UsdRate {  get; set; } 
        public decimal EurRate { get; set; }

    
        public Converter(decimal usdRate, decimal eurRate)
        {
            this.UsdRate = usdRate;
            this.EurRate = eurRate;
        }

        public decimal ConvertToUSD(decimal uah)
        {
            return uah / UsdRate;
        }

       
        public decimal ConvertToEUR(decimal uah)
        {
            return uah / EurRate;
        }

        
        public decimal ConvertFromUSD(decimal usd)
        {
            return usd * UsdRate;
        }

        public decimal ConvertFromEUR(decimal eur)
        {
            return eur * EurRate;
        }
    }

}
