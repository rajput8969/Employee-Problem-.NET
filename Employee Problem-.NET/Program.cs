       //Adding Part Time Employee And Wages//
using System;

namespace Employee_Problem_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Part_Time = 1;
            int IS_Full_Time = 2;
            int Emp_Rate_Per_hour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == IS_Part_Time)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_hour;
            Console.WriteLine("Employment Wage :-" + empWage);
        }
    }
}
