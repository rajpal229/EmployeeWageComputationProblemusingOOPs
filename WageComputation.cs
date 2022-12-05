using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblemUsingOOPs
{
    internal class WageComputation
    {
        public void EmployeeAttendance()
        {
            int fullTime = 1;
            Random rannum = new Random();
            int checkPresent = rannum.Next(0, 2);
            Console.WriteLine("Random Number: " + checkPresent);
            if (checkPresent == fullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            } 
        }
    }
}
