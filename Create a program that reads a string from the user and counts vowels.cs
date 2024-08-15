using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Vowels
    {

        /// <summary>
        /// Create a program that reads a string from the user and counts the number of vowels.
        /// </summary>
        public static void GetVowelCount()
        {

            try
            {

           
                Console.Write("Enter the input string: ");

                string inputstr = Console.ReadLine();
                int vowelcount = 0;

                int inputstrlength = inputstr.Length;
                string inputstruppercase= inputstr.ToUpper();
                for (int i=0;i<inputstrlength;i++)
                {
                    if (inputstruppercase[i]=='A' || inputstruppercase[i] == 'E' || inputstruppercase[i] == 'I'|| inputstruppercase[i] == 'O'|| inputstruppercase[i] == 'U')
                    {
                        vowelcount++;
                    }
                }

               
                
                Console.WriteLine($"VowelCount= {vowelcount}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
