using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is absent");
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}