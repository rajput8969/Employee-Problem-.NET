       //Check Employee is Present or Absent//
using System;

namespace Employee_Problem_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_Full_Time = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
