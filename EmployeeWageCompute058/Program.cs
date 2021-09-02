using System;

namespace EmployeeWageCompute058
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1;

            Random random = new Random();

            int IS_ABSENT = random.Next(0 , 2);

            //Selection statement
            if 
                (1 == IS_PRESENT)
                Console.WriteLine("EMPLOYEE IS PRESENT");
            else
                Console.WriteLine("EMPLOYEE IS ABSENT");
            Console.Read();


        }
    }
}
