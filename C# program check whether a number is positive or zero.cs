using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class CheckNumber
    {

        /// <summary>
        /// program check whether a number is positive or zero


        /// </summary>
        public static void IsPostiveOrNegativeOrZero()
        {

            try
            {

            Start1:
                Console.Write("Enter the Number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                
              if(num>0)
                {
                    Console.WriteLine("Number is positive.");
                }
              else if(num<0)
                {
                    Console.WriteLine("Nubmer is negative.");
                }
                else
                {
                    Console.WriteLine("Nubmer is zero.");
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
