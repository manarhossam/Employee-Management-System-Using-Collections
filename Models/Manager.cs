using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Using_Collections.Models
{
     class Manager:Employee
    {
     public List<Employee> Teammembers { get; set; } =new List<Employee>();
    }
}
