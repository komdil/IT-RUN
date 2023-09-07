using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMigrator
{
    public class ProductSale
    {
        public string Name { get; set; }

        public string Comment { get; set; }

        public int UserId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public Guid Id { get; internal set; }
    }
}
