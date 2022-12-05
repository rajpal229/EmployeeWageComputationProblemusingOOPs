namespace EmployeeWageComputationProblemUsingOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            WageComputation dailyWage = new WageComputation();
            dailyWage.DailyWage();
            //Added PartTime
        }
    }
}