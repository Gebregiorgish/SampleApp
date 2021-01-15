using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public interface IEmployee
    {
        string PrintFristNameLastName(Employee employee);
        Double GetAnnualSalary( Double hourlyRate);
    }
    public enum EmployeeRole { M, E }
    public class Employee: IEmployee
    {
        const int monthsInAYear = 12;
        const int hoursInAWeek = 40;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Double HourlyRate { get; set; }
        public string Role { get; set; }
        public Manager Manager { get; set; }
        
        public string PrintFristNameLastName( Employee employee)
        {
            //Employee e = new Employee();

            return employee.FirstName + " " + employee.LastName;
        }
        public virtual Double GetAnnualSalary(Double hourlyRate)
        {
            Double totlalSalary;
            totlalSalary = hourlyRate * hoursInAWeek * monthsInAYear;
            return totlalSalary;
        }
    }
}
