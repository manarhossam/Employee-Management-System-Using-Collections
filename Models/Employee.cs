using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Using_Collections.Models
{
     class Employee
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public DateTime HireDate {  get; set; }
        public double salary {  get; set; }
        public int DepartmentId {  get; set; }

        public List<string>skills=new List<string>();
    }
}
