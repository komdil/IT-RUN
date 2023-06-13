using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public partial class Product
    {
        private Product()
        {

        }

        private Product(int count, string name)
        {
            Count = count;
            Name = name;
        }

        public static Product CreateNewProduct(int count, string name)
        {
            if (count < 0)
            {
                count = 0;
            }
            return new Product(count, name);
        }

        string name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return "No name";
                }
                return name;
            }
            set
            {
                //seb SEB
                name = value.ToUpper();
            }
        }
        public int Count { get; private set; }

        public void Save()
        {

        }

        public void IncreaseCount(int count)
        {
            if (count > 0)
            {
                Count += count;
            }
        }

        public int MyProperty { get; set; }
    }
}
