using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class SumOfDigit
    {

        /// <summary>
        /// Implement a program to find the sum of digits of a given number
       
        /// </summary>
        public static void GetSumOfDigit()
        {

            try
            {

            Start1:
                Console.Write("Enter the Number : ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }
                int remainder = 0;
                int sumofdigit = 0;
                while (num!=0)
                {
                    remainder = num % 10;
                    sumofdigit += remainder;
                    num = num / 10;

                }

                Console.WriteLine($"sumofdigit = {sumofdigit}");
                Console.WriteLine($"Do you want to start again?.Y/N");
                char ch = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ch == 'Y') { goto Start1; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
