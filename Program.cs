//Author: David Runowski
//Date: 01/30/2020
using System;

namespace Deliverable2_Runowski
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Grade as an Integer: ");

            try
            {
                string input = Console.ReadLine();

                decimal x = decimal.Parse(input);
                if(x > 100)
                    Console.WriteLine("Invalid Grade Entered");
                else if (x >= 98 )
                    Console.WriteLine("Your Grade is A+");
                else if (x >= 92)
                    Console.WriteLine("Your Grade is A");
                else if (x >= 90)
                    Console.WriteLine("Your Grade is A-");
                else if (x >= 88)
                    Console.WriteLine("Your Grade is B+");
                else if (x >= 82)
                    Console.WriteLine("Your Grade is B");
                else if (x >= 80)
                    Console.WriteLine("Your Grade is B-");
                else if (x >= 78)
                    Console.WriteLine("Your Grade is C+");
                else if (x >= 72)
                    Console.WriteLine("Your Grade is C");
                else if (x >= 70)
                    Console.WriteLine("Your Grade is C-");
                else if (x >= 68)
                    Console.WriteLine("Your Grade is D+");
                else if (x >= 62)
                    Console.WriteLine("Your Grade is D");
                else if (x >= 60)
                    Console.WriteLine("Your Grade is D-");
                else
                    Console.WriteLine("Your Grade is F");
            }

            catch
            {
                Console.WriteLine("Please Enter a Number....");
                Console.ReadKey(true);
            }


            

        }
    }
}
