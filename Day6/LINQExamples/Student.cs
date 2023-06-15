using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class Student : IComparable<Student>
    {
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (other.Age > Age)
            {
                return 1;
            }
            else if (other.Age < Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
