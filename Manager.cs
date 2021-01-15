using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    
   public class Manager : Employee
    {
        private Double bonus = 0;
        public Double Bonus { 
            get { return bonus; } 
            set { bonus = value; } 
        }

        public  Double GetAnnualBonus( Double hourly) 
        {
            double bonusPerAnnum = GetAnnualSalary(hourly) * 0.5;
            return bonusPerAnnum;
        }

    }
}
