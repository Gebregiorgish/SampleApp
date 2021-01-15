using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
             new Employee() { Id=1, FirstName="Sam", LastName="Adams", HourlyRate=50, Role=EmployeeRole.E.ToString()},
             new Employee() { Id=2, FirstName="John", LastName="Doh", HourlyRate=60, Role=EmployeeRole.E.ToString()},
             new Employee() { Id=3, FirstName="Justin",LastName="Jason", HourlyRate=80, Role=EmployeeRole.M.ToString()},
             new Employee() { Id=4, FirstName="Selena", LastName="Trump", HourlyRate=55, Role=EmployeeRole.E.ToString()},
             new Employee() { Id=5, FirstName="Ruth", LastName="Nathen", HourlyRate=75,Role=EmployeeRole.M.ToString()},


        };

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintFristNameLastName(e));
                Console.WriteLine("Hourly Salary = " + e.HourlyRate + "---------"
                    + "Annual Salary = " + e.GetAnnualSalary(e.HourlyRate));

                Manager manager = new Manager();
                if (e.Role == EmployeeRole.M.ToString())
                {
                    Console.WriteLine("Manager Annual Bonus Included = {0}", manager.GetAnnualBonus(e.HourlyRate));
                }
                else
                {
                    Console.WriteLine("Sorry you have {0} bonus at this time", manager.Bonus);
                }
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("END");
        }
    }
}
