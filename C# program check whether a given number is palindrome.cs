using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Palindrome
    {

        /// <summary>
        /// Program to check whether a given number is a palindrome
        /// </summary>
        public static void CheckPalindrome()
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

                //Condition of Palindrome=EnteredValue is equal to Revervalue
                bool IsPalindrome=false;
                long rem=0;
                long revNumber = 0;
                long temp = Number;
                while (Number > 0)
                {
                    rem = Number % 10;
                    revNumber = (revNumber * 10)+rem;
                    Number= Number / 10;
                }
                if(revNumber== temp)
                {
                    IsPalindrome = true;
                    Console.WriteLine($"IsPalindrome= {IsPalindrome}");
                }
                else
                {
                    Console.WriteLine($"{revNumber}");
                    Console.WriteLine($"IsPalindrome= {IsPalindrome}");
                }


               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
