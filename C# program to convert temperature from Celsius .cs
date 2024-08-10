using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Temperature
    {

        /// <summary>
        /// program to convert temperature from Celsius to Fahrenheit
        /// </summary>
        public static void CelsiusToFahrenheit()
        {

            try
            {

            Start1:
                Console.Write("Enter the Celsius value : ");

                if (!double.TryParse(Console.ReadLine(), out double Celsius))
                {
                    
                    Console.WriteLine("Celsius value is should be in number.");
                    goto Start1;
                }

                //Formula of CelsiusToFahrenheit=((celsius * 9) / 5) + 32;

                double CelsiusToFahrenheit = ((Celsius * 9) / 5) + 32;

                Console.WriteLine($"Fahrenheit= {CelsiusToFahrenheit}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }
    }
}
