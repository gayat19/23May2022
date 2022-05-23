using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class ConsultantEmployee: Employee
    {
        public int WorkingHours { get; set; }
        public override void Sample()
        {
            Console.WriteLine("Sample from Cusultant Employee");
        }
    }
}
