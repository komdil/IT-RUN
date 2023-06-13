using Generic1._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    public class BankClient : IQueuItem
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
