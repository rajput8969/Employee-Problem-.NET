        // UC-8 Ability to compute Employee Wage for multiple companies //

using System;
namespace UC_8
{
   class Program
    {
        public const int IS_PartTime = 1;
        public const int IS_FullTime = 2;

        public static int computeEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PartTime:
                        empHrs = 4;
                        break;
                    case IS_FullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:-" + totalWorkingDays + " Emp Hrs :-" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHours;
            Console.WriteLine("Total Emp Wage for company :- " + company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }

    }
}
