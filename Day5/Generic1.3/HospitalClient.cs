using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1._3
{
    public class HospitalClient : IQueuItem
    {
        public HospitalClient(int number, decimal priceOfSupport)
        {
            Number = number;
            PriceOfSupport = priceOfSupport;
        }

        public int Number { get; set; }

        public decimal PriceOfSupport { get; set; }
    }
}
