using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Student
    {

        /// <summary>
        ///  program to determine the grade of a student based on marks


        /// </summary>
        public static void GetGrade()
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
                if (num>=33 && num<=45) {
                    Console.WriteLine("Grade C");
                }
                else if(num >= 46 && num <= 59)
                {
                    Console.WriteLine("Grade B");
                }
                else if (num >= 60 && num <= 79)
                {
                    Console.WriteLine("Grade A");
                }
                else if (num >= 80)
                {
                    Console.WriteLine("Grade A+");
                }
                else
                {
                    Console.WriteLine("Result: Fail.");
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
