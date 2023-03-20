using static InheritanceDemo.Employee;
using static System.Net.Mime.MediaTypeNames;

namespace InheritanceDemo
{
    internal class HRManager
    {

        static void Main(string[] args)
        {

            Employee emp = new Employee();

            emp.EmpNum = 1;

            emp.FirstName = "Steve";

            emp.LastName = "Jobs";


            HourlyEmployee hourEmp = new HourlyEmployee();

            hourEmp.EmpNum = 2;

            hourEmp.FirstName = "Bill";

            hourEmp.LastName = "Gates";

            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine("emp.GetPaySummary: " + emp.GetPaySummary());

            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.GetPaySummary());


            Employee emp2 = hourEmp;

            Console.WriteLine(emp.PaySummary());
            Console.WriteLine(hourEmp.PaySummary());
            Console.WriteLine(emp2.PaySummary());




        }
         
        //public class HourlyEmployee : Employee
        //{

        //    public decimal HourlyRate { get; set; }

        //    public HourlyEmployee() : base()
        //    {

        //        //HourlyRate = 15.0M;
        //        HourlyEmployee hourEmp = new HourlyEmployee();

        //        hourEmp.EmpNum = 2;

        //        hourEmp.FirstName = "Bill";

        //        hourEmp.LastName = "Gates";

        //        hourEmp.HourlyRate = 15.00M;

        //        Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.GetPaySummary());


        //    }




        //}


    }

}






