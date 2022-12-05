using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblemUsingOOPs
{
    internal class WageComputation
    {
        int fullTime = 1, partTime = 2, emp_Rate_Per_Hr = 20, empHrs = 0, empWage = 0;
        public int EmployeeAttendance()
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
            return checkPresent;
        }
        public void DailyWage()
        {
            int Attendence = EmployeeAttendance();
            if (Attendence == 1)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present Full Time");
            }
            else if (partTime == 2)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Present Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage: " + empWage);
            //Added Part Time
        }
    }
}
