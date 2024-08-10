using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Rectangle
    {

        /// <summary>
        /// Calcualte Area and Perimeter of given length and width
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void CalculateAreaAndPerimeter()
        {

            try
            {

            LengthStart:
                Console.Write("Enter the length value : ");

                if (!Decimal.TryParse(Console.ReadLine(), out Decimal Length))
                {
                    
                    Console.WriteLine("Length value is should be in number.");
                    goto LengthStart;
                }
            WidthStart:
                Console.Write("Enter the width value : ");
                if (!Decimal.TryParse(Console.ReadLine(), out Decimal Width))
                {
                    Console.WriteLine("Width value is should be in number.");
                    goto WidthStart;
                    

                }
                //Formula of Area=Length*Width

                decimal Area = (Length * Width);

                //Formula of Perimeter=2*(Length + Width)

                decimal Perimeter = 2 * (Length + Width);

                Console.WriteLine($"Area of length:{Length} and width:{Width}= {Area}");
                Console.WriteLine($"Perimeter of length:{Length} and width:{Width}= {Perimeter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
