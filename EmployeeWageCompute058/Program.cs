using System;

namespace EmployeeWageCompute058
{
    class Program
    {
       public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20 ;
        static void Main(string[] args)
        {   //UC 4
            //local vairables
            int empHrs = 0;
            int empWage = 0;

            // perdefined random
            Random random = new Random();

            //next method () 0 is initial valu ,2 number of element from 0
            int empCheck = random.Next(0, 3);

           switch (empCheck)
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

            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Emp wage :" + empWage);

            Console.Read();


        }
    }
}
