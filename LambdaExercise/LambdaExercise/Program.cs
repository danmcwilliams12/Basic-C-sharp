using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Tom";
            employee1.LastName = "Stapleton";

            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.FirstName = "Joe";
            employee2.LastName = "Swanson";

            Employee employee3 = new Employee();
            employee3.Id = 3;
            employee3.FirstName = "Sam";
            employee3.LastName = "Anders";

            Employee employee4 = new Employee();
            employee4.Id = 4;
            employee4.FirstName = "Sarah";
            employee4.LastName = "Warren";

            Employee employee5 = new Employee();
            employee5.Id = 5;
            employee5.FirstName = "Harald";
            employee5.LastName = "French";

            Employee employee6 = new Employee();
            employee6.Id = 6;
            employee6.FirstName = "Joe";
            employee6.LastName = "Lenard";

            Employee employee7 = new Employee();
            employee7.Id = 7;
            employee7.FirstName = "Karen";
            employee7.LastName = "Lanka";

            Employee employee8 = new Employee();
            employee8.Id = 8;
            employee8.FirstName = "Josh";
            employee8.LastName = "Lyeman";

            Employee employee9 = new Employee();
            employee9.Id = 9;
            employee9.FirstName = "Claudia";
            employee9.LastName = "Jean";

            Employee employee10 = new Employee();
            employee10.Id = 10;
            employee10.FirstName = "Chris";
            employee10.LastName = "Jameson";


            List<Employee> employees = new List<Employee>()
                {
                employee1, employee2, employee3,
                employee4, employee5, employee6,
                employee7, employee8, employee9, employee10
                };

            List<Employee> newList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                }
            }

            List<Employee> allJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in allJoes)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> greaterThanFive = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in greaterThanFive)
            {
                Console.WriteLine(employee.Id + employee.FirstName);                
            }

            Console.ReadLine();
        }
    }
}
