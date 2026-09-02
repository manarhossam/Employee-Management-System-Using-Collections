using Employee_Management_System_Using_Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Using_Collections.Services
{
    class Company
    {
        List<Employee> ActiveEmployee = new List<Employee>();
        Dictionary<int, Department> View = new Dictionary<int, Department>();
        Queue<Employee> Onboarding = new Queue<Employee>();
        Stack<String> Actionhistory = new Stack<String>();
        HashSet<String> Uniqeskiils = new HashSet<String>();
        public void AddMember(Employee employee)
        {
            if (employee is null)
            {
                Console.WriteLine("Employee donot exist");
                return;
            }
            else if (employee.salary < 0) {
                Console.WriteLine("Salary cannot be negative");
                return;
            }
            Onboarding.Enqueue(employee);
            foreach (string skill in employee.skills)
            {
                Uniqeskiils.Add(skill);
            }
            Actionhistory.Push(employee.Name);
        }
        public void AddDepartment(Department department) {
            if (department is null) {
                throw new ArgumentNullException(nameof(department));

            }
            if (View.ContainsKey(department.ID))
              throw new InvalidOperationException($"Id already {department.ID} exist");
           View.Add(department.ID, department);
            
        }
        public Employee? seachemployee(int id)
        {
            foreach (Employee employee in ActiveEmployee)
            {
                if (employee is null)
                {
                    throw new ArgumentNullException(nameof(employee));

                }
                if (employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public Employee? seachemployeename(string name)
        {
            foreach (Employee employee in ActiveEmployee)
            {
                if (employee is null)
                {
                    throw new ArgumentNullException(nameof(employee));

                }
                if (employee.Name == name)
                {
                    return employee;
                }
            }
            return null;
        }
       

    
      public void ViewHistory()
        {
            foreach (string action in Actionhistory)
            {
                Console.WriteLine(action);
            }
        }

    }
}
