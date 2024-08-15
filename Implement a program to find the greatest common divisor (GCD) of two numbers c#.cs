using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class GCD
    {

        /// <summary>
        /// Program of calcuate GCD of two numbers
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void CalculateGCD()
        {

            try
            {

            LengthStart:
                Console.Write("Enter the first number: ");

                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    
                    Console.WriteLine("first number is should be in number.");
                    goto LengthStart;
                }
            WidthStart:
                Console.Write("Enter the second number : ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("second number is should be in number.");
                    goto WidthStart;
                    

                }
                int remainder;
                while (num2 != 0)
                {
                    remainder = num1 % num2;
                    Console.WriteLine($"remainder = {remainder}");
                    num1 = num2;
                   num2 = remainder;


                }

                

                Console.WriteLine($"GCD = {num1}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
