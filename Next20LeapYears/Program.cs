using System;

namespace Next20LeapYears
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int n, year = 2022, count = 0;

            while (count < 20)
            {
               year++;
                if((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    Console.WriteLine("The year " + year + " is a Leap year");
                        count++;
                }
            }
            
        }
    }
}