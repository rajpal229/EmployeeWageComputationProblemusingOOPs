using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblemUsingOOPs
{
    internal class WageComputation
    {
        int fullTime = 1, partTime = 2, emp_Rate_Per_Hr = 20, empHrs = 0, empWage = 0, numWorkingDays=20, totalSalary=0, totalWorkingHours=0;
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
            Console.WriteLine("Using If-Else\n");
        }
        public int SwitchCase()
        {
            int Attendence = EmployeeAttendance();
            switch (Attendence)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is Present Full TIme");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is Present Part Time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage: " + empWage);
            return empWage;
        }
        public int empHrsReturn()
        {
            int Attendence = EmployeeAttendance();
            switch (Attendence)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }
            public void MonthlyWage()
        {
            for (int day = 1; (day <= numWorkingDays && totalWorkingHours <=100); day++)
            {
                SwitchCase();
                empHrsReturn();
                totalWorkingHours += empHrs;
                if (totalWorkingHours > 100)
                {
                    totalWorkingHours -= empHrs;
                    break;
                }
                totalSalary = totalSalary + empWage;
            }
            Console.WriteLine("Total Working Hours of Employee: " + totalWorkingHours);
            Console.WriteLine("Total Salary of a Month: " + totalSalary);
        }
    }
}
