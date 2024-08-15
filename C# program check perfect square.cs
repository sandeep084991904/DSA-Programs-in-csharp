using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Square
    {

        /// <summary>
        /// program check perfect square


        /// </summary>
        public static void perfectSquare()
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
                double sqrt=Math.Sqrt(num);
                
               if(sqrt== Convert.ToInt32(sqrt))
                {
                    Console.WriteLine($"Perfect square value is {Convert.ToInt32(sqrt)}");
                }
               else
                {
                    Console.WriteLine($"Perfect square is not possible");
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
