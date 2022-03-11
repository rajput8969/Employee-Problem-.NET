//Calculating Wages For a Month assuming 20 Working Days in a Month//
using System;

namespace Employee_Problem_.NET
{
    class Program
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Emp_Rate_Per_hour = 20;
        public const int Num_Of_Working_Days = 2;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmWage = 0;
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
              Random random = new Random();
              int empCheck = random.Next(0, 3);
              switch (empCheck)
              {
                  case IS_Part_Time:
                      empHrs = 4;
                      break;
                  case IS_Full_Time:
                       empHrs = 8;
                        break;
                   default:
                         empHrs = 0;
                          break;
              }
              empWage = empHrs * Emp_Rate_Per_hour;
              totalEmWage += empWage;
              Console.WriteLine("Emp Wage :-" + empWage);
            }
            Console.WriteLine("Total Emp Wage :- " + totalEmWage);          
        }
    }
}
