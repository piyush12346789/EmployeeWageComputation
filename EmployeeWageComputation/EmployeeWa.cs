using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    public class EmpWageCalculator
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        //class variables
        private string company;
        private int empRatePerHour, numOfWorkingDays, maxHrsPerMonth, totalEmpWage;
        //constructor
        public EmpWageCalculator(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void compEmployeeWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                totalEmpHrs += empHrs;
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }
        public string toString()
        {
            return "Total Emp Wage for Company " + this.company + " is " + this.totalEmpWage;
        }
    }
}