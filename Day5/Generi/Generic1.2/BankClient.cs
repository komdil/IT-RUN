using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    public class BankClient
    {
        public BankClient(int number, decimal priceOfSupport)
        {
            Number = number;
            PriceOfSupport = priceOfSupport;
        }

        public int Number { get; set; }

        public decimal PriceOfSupport { get; set; }
    }
}
