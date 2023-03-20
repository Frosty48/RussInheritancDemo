using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InheritanceDemo.Employee;

namespace InheritanceDemo
{
   public class HourlyEmployee:Employee
   {
        
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() {
            HourlyRate = 30.00M;
        
        }
        
        
        public string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }


        public string PaySummary()
        {
            get { return $"This employee is payed {HourlyRate} per hour"; }


        }


   }
}
