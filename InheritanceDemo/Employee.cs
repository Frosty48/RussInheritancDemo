using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   

        public class Employee
        {

            public int EmpNum { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }



            public virtual string GetPaySummary() {  return "No pay for base class employee.";
            }

        }
        
 }
           



