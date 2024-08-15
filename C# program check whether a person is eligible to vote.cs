using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Person
    {

        /// <summary>
        /// program check whether a person is eligible to vote


        /// </summary>
        public static void IsEligibleForVote()
        {

            try
            {

            Start1:
                Console.Write("Enter the age : ");

                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }
               string result= age>=18 ? "Eligible" : "Not Eligible";

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
