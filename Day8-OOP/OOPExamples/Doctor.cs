using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class Doctor
    {
        public string Name { get; set; }

        public Departmant Departmant { get; set; }
    }

    public class Departmant
    {
        public string Name { get; set; }

        public IEnumerable<Doctor> Doctors { get; set; }
    }

    public class Patient
    {
        public string Name { get; set; }

        public Doctor DoctorWhoIsTreating { get; set; }
    }
}
