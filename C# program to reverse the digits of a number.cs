using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Digit
    {

        /// <summary>
        /// program to digit reverse

        /// </summary>
        public static void Reverse()
        {

            try
            {

            Start1:
                Console.Write("Enter  number: ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }
                int rem = 0;
                int revnum = 0;
                while(num!=0)
                {
                    rem = num % 10;
                    revnum = (revnum * 10) + rem;
                    num = num / 10;
                }
                Console.WriteLine($"Reverse Digit = {revnum}");

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
