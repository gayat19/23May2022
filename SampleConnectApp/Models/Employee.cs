using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConnectApp.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
