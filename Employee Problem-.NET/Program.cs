//Calculating Wages till a condition of Total Working Hours of 100 or max days and 20 is reached for a month //
using System;

namespace Employee_Problem_.NET
{
    class Program
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Emp_Rate_Per_hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_In_Months = 10;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= Max_Hrs_In_Months && totalWorkingDays < Num_Of_Working_Days)
            {
              totalWorkingDays++;
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
              totalEmpHrs += empHrs;
              Console.WriteLine("Days#:-" + totalWorkingDays + " Emp Hrs :-" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_hour;
            Console.WriteLine("Total Emp Wage :- " + totalEmpWage);          
        }
    }
}
