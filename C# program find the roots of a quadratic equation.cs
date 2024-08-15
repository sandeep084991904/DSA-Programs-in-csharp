using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Number
    {

        /// <summary>
        ///program find the roots of a quadratic equation


        /// </summary>
        public static void OddOrEven()
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
               string result= num % 2 == 0 ? "num is even" : "num is odd";

                Console.WriteLine($" {result}");
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
