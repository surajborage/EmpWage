using System;

namespace EmployeeWageCompute058
{
    class Program
    {
        static void Main(string[] args)
        {   //UC2
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

            // per defind random
            Random random = new Random();

            //next method () 0 is initial valu ,2 number of element from 0
            int empCheck = random.Next(0, 2);

            // selection staments
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
                empHrs = 0;
            }

            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is =" + empWage);
            Console.Read();


        }
    }
}
