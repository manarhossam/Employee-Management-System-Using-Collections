using Employee_Management_System_Using_Collections.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Using_Collections.Services
{
    class Company
    {
        List<Employee> ActiveEmployee = new List<Employee>();
        Dictionary<int, Department> Departments = new Dictionary<int, Department>();
        Queue<Employee> Onboarding = new Queue<Employee>();
        Stack<String> Actionhistory = new Stack<String>();
        HashSet<String> Uniqeskiils = new HashSet<String>();
        public void AddMember(Employee employee)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee),"not exist");
            }


            else if (employee.Salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            Onboarding.Enqueue(employee);
            foreach (string skill in employee.Skills)
            {
                Uniqeskiils.Add(skill);
            }
            Actionhistory.Push($"Employee {employee.Name} added to onboarding");
        }
        public void AddDepartment(Department department) {
            if (department is null) {
                throw new ArgumentNullException(nameof(department));

            }
            if (Departments.ContainsKey(department.ID))
              throw new InvalidOperationException($"Id already {department.ID} exist");
           Departments.Add(department.ID, department);
            
        }
        public Employee? seachemployee(int id)
        {
            foreach (Employee employee in ActiveEmployee)
            {
                if (employee is null) continue;
                
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
        public void ProcessOnboarding()
        {
            if (Onboarding.Count == 0)
            {
                Console.WriteLine("No employees in onboarding.");
                return;
            }

            Employee employee = Onboarding.Dequeue();

            ActiveEmployee.Add(employee);

            Actionhistory.Push(
                $"Employee onboarded: {employee.Name}"
            );

            Console.WriteLine(
                $"Employee {employee.Name} is now active."
            );
        }
        public double AverageSalary()
        {
            if (ActiveEmployee.Count == 0 )
            {
                return 0;
            }

            double total = 0;

            foreach (Employee employee in ActiveEmployee)
            {
                total += employee.Salary;
            }

            return total / ActiveEmployee.Count;
        }
        public void AddskillstoEmployees(int employeeid, string skill) {
            if (String.IsNullOrWhiteSpace(skill))
            {
                throw new ArgumentException("Skill cannot be empty");
            }
            Employee? employee = seachemployee(employeeid);
            if (employee == null) {
                throw new ArgumentException($"No employee found{employeeid}");
            }
            if (employee.Skills.Contains(skill)) { 
                employee.Skills.Add(skill);
            }
            Uniqeskiils.Add(skill);
            Actionhistory.Push($"skill{skill} added to {employee.Name}");
          }
          public void showemployeebydepartment(int departmentid)
        {
            if (!Departments.ContainsKey(departmentid)){
                throw new ArgumentException($"No depaetment withid{departmentid}");
            }
            Department department= Departments[departmentid];
            Console.WriteLine($"{department.Name}");
            bool found=false;
            foreach (Employee employee in ActiveEmployee)
            {
                if (employee.DepartmentId == departmentid) {
                    Console.WriteLine($"{employee.Name}{employee.Id}");
                    found = true;
                }
                if (!found) {
                    Console.WriteLine("No employees currently in this department.");

                }
            }
        }
    }
}
