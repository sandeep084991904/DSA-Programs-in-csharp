using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class LearYear
    {

        /// <summary>
        /// Implement a program to find the sum of digits of a given number
       
        /// </summary>
        public static void IsLeapYear()
        {

            try
            {

            Start1:
                Console.Write("Enter  year : ");

                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }
                if(((year%4==0)&& (year%100!=0)) || year%400==0)
                {
                    Console.WriteLine($"This {year} year is leap year.");
                }
                else
                {
                    Console.WriteLine($"This {year} year is not leap year.");
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
