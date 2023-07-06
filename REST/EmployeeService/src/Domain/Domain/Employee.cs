﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee : User
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }
}
