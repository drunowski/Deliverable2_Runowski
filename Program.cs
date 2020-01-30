//Author: David Runowski
//Date: 01/30/2020
using System;

namespace Deliverable2_Runowski
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask User to enter their grade
            Console.WriteLine("Please Enter Your Grade as an Integer: ");

            try
            {
                //set user input to variable string
                string input = Console.ReadLine();

                //use if else statements to check number in user input
                decimal x = decimal.Parse(input); //cast variable to decimal
                if (x > 100) // if number is greater than 100, print that its is invalid
                    Console.WriteLine("Invalid Grade Entered");
                else if (x >= 98) // print grade according to users input
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
                else if (x >= 0)
                    Console.WriteLine("Your Grade is F");
                else
                    Console.WriteLine("Negative number is not a valid number."); // if the number is negative, print the following message
            }

            catch
            {
                Console.WriteLine("Please Enter a Number...."); //error message
                Console.ReadKey(true);
            }


            

        }
    }
}
