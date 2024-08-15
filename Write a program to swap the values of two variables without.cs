using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Swaping
    {

       /// <summary>
       /// program that calculates the factorial of a number using a loop
        /// </summary>
        public static void SwapValue()
        {

            try
            {

            Start1:
                Console.Write("Enter the First Number : ");

                if (!Int64.TryParse(Console.ReadLine(), out Int64 Number1))
                {
                    
                    Console.WriteLine("First Number is should be in number.");
                    goto Start1;
                }
                Console.Write("Enter the Second Number : ");
                if (!Int64.TryParse(Console.ReadLine(), out Int64 Number2))
                {

                    Console.WriteLine("Second Number is should be in number.");
                    goto Start1;
                }
                Console.WriteLine($"Before Swapping");
                Console.WriteLine($"Number1= {Number1}");
                Console.WriteLine($"Number2= {Number2}");

                Number1 = Number1 + Number2;
                Number2 = Number1 - Number2;
                Number1=Number1-Number2;



                Console.WriteLine($"After Swapping");
                Console.WriteLine($"Number1= {Number1}");
                Console.WriteLine($"Number2= {Number2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
