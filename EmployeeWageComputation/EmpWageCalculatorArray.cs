using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmpWageCalculatorArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numOfCompany = 0;
        private CompEmpWage[] compEmpWageArray;
        public EmpWageCalculatorArray()
        {
            this.compEmpWageArray = new CompEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            compEmpWageArray[this.numOfCompany] = new CompEmpWage(company, empRatePerHour, numOfWorkingDays, maxHrsPerMonth);
            numOfCompany++;
        }
        public void compEmployeeWage()
        {
            for (int companyNumber = 0; companyNumber < numOfCompany; companyNumber++)
            {
                compEmpWageArray[companyNumber].setTotalEmpWage(compEmployeeWage(compEmpWageArray[companyNumber]));
                Console.WriteLine(this.compEmpWageArray[companyNumber].toString());
            }
        }
        private int compEmployeeWage(CompEmpWage compEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= compEmpWage.maxHrsPerMonth && totalWorkingDays < compEmpWage.numOfWorkingDays)
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
            return totalEmpHrs * compEmpWage.empRatePerHour;
        }
    }
}