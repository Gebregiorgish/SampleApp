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
             new Employee() { Id=1, FirstName="Sam", LastName="Adams", HourlyRate=50},
             new Employee() { Id=2, FirstName="John", LastName="Doh", HourlyRate=60},
             new Employee() { Id=3, FirstName="Justin",LastName="Jason", HourlyRate=80},
             new Employee() { Id=4, FirstName="Selena", LastName="Trump", HourlyRate=55},
             new Employee() { Id=5, FirstName="Ruth", LastName="Nathen", HourlyRate=75},


        };
            foreach (var e in employees)
            {

                Console.WriteLine(e.PrintFristNameLastName(e));
                Console.WriteLine("Salary = "  + e.HourlyRate + "---------"
                    +"Annual Salary + " + e.GetAnnualSalary(e.HourlyRate));

                Console.WriteLine("----------------------------");
            }
            Console.Write("END");
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Double HourlyRate { get; set; }

        public string PrintFristNameLastName(Employee employee)
        {
            //Employee e = new Employee();

            return employee.FirstName + " " + employee.FirstName;
        }
        public Double GetAnnualSalary(Double hourlyRate)
        {
           const int monthsInAYear = 12;
            const int hoursInAWeek = 40;
            Double totlalSalary;
            totlalSalary = hourlyRate * hoursInAWeek * monthsInAYear;
            return totlalSalary;
        }



    }
}
