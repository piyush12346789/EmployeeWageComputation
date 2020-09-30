using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    class CompEmpWage
    {
        //class variables
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxHrsPerMonth, totalEmpWage;
        //constructor
        public CompEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company " + this.company + " is " + this.totalEmpWage; ;
        }
    }
}