namespace EmployeeWageComputationProblemUsingOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            WageComputation monthlyWage = new WageComputation();
            monthlyWage.MonthlyWage();

        }
    }
}