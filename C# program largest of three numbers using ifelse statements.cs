using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class LargestOfThreeNumber
    {

        /// <summary>
        ///  Write a program to find the largest of three numbers using ifelse statements.

        /// </summary>
        public static void GetLargestNumber()
        {

            try
            {

            Start1:
                  Console.Write("Enter the First Number : ");

                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }

            Start2:
                Console.Write("Enter the Second Number : ");

                if (!int.TryParse(Console.ReadLine(), out int num2))
                {

                    Console.WriteLine("Value is should be in number.");
                    goto Start2;
                }

            Start3:
                Console.Write("Enter the Second Number : ");

                if (!int.TryParse(Console.ReadLine(), out int num3))
                {

                    Console.WriteLine("Value is should be in number.");
                    goto Start3;
                }
                
                if(num1>num2)
                {
                    if(num1>num3)
                    {
                        Console.WriteLine($"Latest Value is  = {num1}");
                    }
                    else if(num2>num3)
                    {
                        Console.WriteLine($"Latest Value is  = {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"Latest Value is  = {num3}");
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine($"Latest Value is  = {num2}");
                }
                else
                {
                    Console.WriteLine($"Latest Value is  = {num3}");
                }

               
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
