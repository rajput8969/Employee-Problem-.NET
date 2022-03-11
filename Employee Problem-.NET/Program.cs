       //Calculate Daily Employee Wage//
using System;

namespace Employee_Problem_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_Time = 1;
            int Emp_Rate_Per_hour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_Full_Time)
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
