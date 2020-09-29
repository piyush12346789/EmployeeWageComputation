using EmployeeWageComputation;
using System;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageCalculator rJio = new EmpWageCalculator("Reliance Jio", 10, 22, 120);
            EmpWageCalculator tata = new EmpWageCalculator("TATA", 25, 18, 80);
            rJio.compEmployeeWage();
            tata.compEmployeeWage();
            Console.WriteLine(rJio.toString());
            Console.WriteLine(tata.toString());
        }
    }
}