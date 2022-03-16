            // UC-9 Ability to save the Total Wage for Each Company //
using System;

namespace UC_9
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeWage();
            Console.WriteLine(dMart.toString());
            reliance.computeWage();
            Console.Write(reliance.toString());
        }
    }
    public class EmpWageBuilderObject
    {
        public const int IS_PartTime = 1;
        public const int IS_FullTime = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHourssPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHourssPerMonth = maxHoursPerMonth;
        }
        public void computeWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHourssPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company :- " + company + "is:" + totalEmpWage);

        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + this.company + "is:" + this.totalEmpWage;
        }
    }
    
}
