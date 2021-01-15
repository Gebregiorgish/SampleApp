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
        Double GetAnnualSalary(Double hourlyRate);
    }
    public class Employee: IEmployee
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
