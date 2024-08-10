using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Factorial
    {

       /// <summary>
       /// program that calculates the factorial of a number using a loop
        /// </summary>
        public static void CalculateFactorial()
        {

            try
            {

            Start1:
                Console.Write("Enter the Number : ");

                if (!Int64.TryParse(Console.ReadLine(), out Int64 Number))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }

                //Formula of Factorial=n*(n-1);
                long FactorialValue=1;
                //while (Number > 0)
                //{
                //    Console.WriteLine($"Factorial:{FactorialValue}*{Number}={FactorialValue*Number}");
                //    FactorialValue *= Number;
                //    Number -= 1;
                //}
                for (int i = 1; i <= Number; i++)
                {
                    Console.WriteLine($"Factorial:{FactorialValue}*{i}={FactorialValue * i}");
                    FactorialValue *= i;
                }


                Console.WriteLine($"Factorial= {FactorialValue}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
