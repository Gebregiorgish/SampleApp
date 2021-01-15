using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    
   public class Manager : Employee
    {
        public Double Bonus { get; set; }

        public  Double GetAnnualBonus( Double hourly)
        {
            double bonusPerAnnum = GetAnnualSalary(hourly) * 0.5;
            return bonusPerAnnum;
        }

    }
}
