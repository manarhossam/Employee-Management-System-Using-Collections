using Employee_Management_System_Using_Collections.Models;
using Employee_Management_System_Using_Collections.Services;

namespace Employee_Management_System_Using_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee System");
            Company company = new Company();
            Employee e = new Employee();
            
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            e.Name = name;
            Console.WriteLine("Enter your ID ");
            int id =Convert.ToInt32( Console.ReadLine());
            e.Id = id;
            Console.WriteLine("Entet your salary");
            double salary =Convert.ToDouble( Console.ReadLine());
            e.salary = salary;
            Console.WriteLine("Enter your skills");
            string skill = Console.ReadLine();
            e.skills.Add(skill);
            Console.WriteLine($"Employee {e.Name} added successfully.");
            company.AddMember(e);
            company.ProcessOnboarding();

            Console.WriteLine("Enter ID to search");
            int searchId = Convert.ToInt32(Console.ReadLine());

            Employee? result = company.seachemployee(searchId);

            if (result != null)
            {
                Console.WriteLine($"Employee Found: {result.Name}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

            Console.WriteLine("Enter name to search");
            string searchName = Console.ReadLine();

            Employee? resultName =
                company.seachemployeename(searchName);

            if (resultName != null)
            {
                Console.WriteLine($"Employee Found: {resultName.Name}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

            double average = company.AverageSalary();

            Console.WriteLine($"Average Salary = {average}");

            Console.WriteLine("===== Action History =====");

            company.ViewHistory();




        }
    }
}
