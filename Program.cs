using Employee_Management_System_Using_Collections.Models;
using Employee_Management_System_Using_Collections.Services;

namespace Employee_Management_System_Using_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            bool exit = false;
            Console.WriteLine("Welcome Employee System");
            do
            {
                Console.WriteLine("1. Add New Employee (Onboarding)");
                Console.WriteLine("2. Add New Department");
                Console.WriteLine("3. Process Next Onboarding");
                Console.WriteLine("4. Add Skill to Employee");
                Console.WriteLine("5. Search Employee by Id");
                Console.WriteLine("6. Search Employee by Name");
                Console.WriteLine("7. Show Employees by Department");
                Console.WriteLine("8. Show Average Salary");
                Console.WriteLine("9. View Action History");
                Console.WriteLine("10. Show Unique Skills");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                int input = Convert.ToInt32(Console.ReadLine());


                switch (input)
                {
                    case 1:
                        Employee employee = new Employee();

                        Console.Write("Enter Id: ");
                        employee.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        employee.Name = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        employee.Salary = Convert.ToDouble(Console.ReadLine());

                        company.AddMember(employee);
                        break;
                }
            }
            while (!exit);


                       }
            }
            
            
            
    
}
