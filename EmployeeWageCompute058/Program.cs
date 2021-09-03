using System;

namespace EmployeeWageCompute058
{
    class Program
    {
       public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20 ;
        public const int TOTAL_WORKING_DAY = 20;
        public const int MAX_HOURS_IN_MONTH = 100;
        static void Main(string[] args)
        {   //UC 6
            //local vairables
            int empHrs = 0;
            int totalEmpHr = 0;
            int TotalWorkingday = 0;
           
           while (totalEmpH <= MAX_HOURS_IN_MONTH && TotalWorkingday< TOTAL_WORKING_DAY ) 
            {
                TotalWorkingday++;
                Random random = new Random();
                int empchack = random.Next(0, 3);

                switch (b)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHr += empHrs
                    Console.WriteLine("day:" + TotalWorkingday + "Emp Hrs:" + empHrs);


                int totalEmpWage - totalEmpHr * EMP_RATE_PER_HR;
                Console.WriteLine("Total Emp Wage :" + totalEmpWage);


            }


        }
    }
}
