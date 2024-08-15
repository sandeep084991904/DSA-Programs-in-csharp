using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Character
    {

        /// <summary>
        /// program  check whether a character is a vowel or  consotants

        /// </summary>
        public static void IsVowelOrConsotants()
        {


            try
            {
                 Start1:

                Console.Write("Enter the character: ");

                string inputstr = Console.ReadLine();
               

                int inputstrlength = inputstr.Length;
                string inputstruppercase = inputstr.ToUpper();
                for (int i = 0; i < inputstrlength; i++)
                {
                    if (inputstruppercase[i] == 'A' || inputstruppercase[i] == 'E' || inputstruppercase[i] == 'I' || inputstruppercase[i] == 'O' || inputstruppercase[i] == 'U')
                    {
                        Console.WriteLine($"{inputstruppercase[i]} is Vowel.");
                    }
                    else if(inputstruppercase[i]>='A' && inputstruppercase[i]<='Z')
                    {
                        Console.WriteLine($"{inputstruppercase[i]} is Consotants.");
                    }else
                    {
                        Console.WriteLine($"{inputstruppercase[i]} is others characters.");
                    }
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
