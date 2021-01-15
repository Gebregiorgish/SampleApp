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
             new Employee() { Id=1, FirstName="Sam", LastName="Adams", Salary=75000},
             new Employee() { Id=2, FirstName="John", LastName="Doh", Salary=85000},
             new Employee() { Id=3, FirstName="Justin",LastName="Jason", Salary=100000},
             new Employee() { Id=4, FirstName="Selena", LastName="Trump", Salary=120000},
             new Employee() { Id=5, FirstName="Ruth", LastName="Nathen", Salary=150000},


        };
           foreach (var e in employees)
            {
                
               Console.WriteLine( e.PrintFristNameLastName(e));
                Console.WriteLine("----------------------------");
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public  string PrintFristNameLastName(Employee employee)
        {
            //Employee e = new Employee();

             return employee.FirstName + " " + employee.FirstName;
        }
    }
}
