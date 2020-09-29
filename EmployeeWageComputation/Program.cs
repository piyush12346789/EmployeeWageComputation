using System;
namespace EmployeeWageComputation
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_WAGE_PER_HR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int empHrs = 0;
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;
        public static int GetWorkingHour(int ran)
        {
            int empHrs = 0;
            switch (ran)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
                }
            return empHrs;
        }
        public static void ComputeEmployeeWage()
        {
            int monthlySalary = 0;
            while(totalWorkingDays < MAX_HRS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int ran = (random.Next() % 3) + 1;
                empHrs = GetWorkingHour(ran);
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            monthlySalary = EMP_WAGE_PER_HR * totalEmpHrs;
            Console.WriteLine("Total salary of employee in a month is " + monthlySalary);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            ComputeEmployeeWage();
        }
    }
}