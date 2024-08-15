using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs_in_c_sharp
{
    public class Roots
    {

        /// <summary>
        ///program find the roots of a quadratic equation


        /// </summary>
        /// 
        static void Quadratic(double a, double b, double c)
        {
            
            double discriminant = b * b - 4.0 * a * c;

            if(discriminant==0)
            {
                double root1  = -b / (2.0 * a);
                double root2 = root1;
                Console.Write($"Root1 :{root1} ");
                Console.Write($"Root2 :{root2} ");
            }
            else
            {
                
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a); 
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.Write($"Root1 :{root1} ");
                Console.Write($"Root2 :{root2} ");
            }

           
        }
        public static void GetQuadraticEquation()
        {

            try
            {

            Start1:
                Console.Write("Enter the Number 1 : ");

                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    
                    Console.WriteLine("Value is should be in number.");
                    goto Start1;
                }

            Start2:
                Console.Write("Enter the Number 2 : ");

                if (!double.TryParse(Console.ReadLine(), out double num2))
                {

                    Console.WriteLine("Value is should be in number.");
                    goto Start2;
                }
            Start3:
                Console.Write("Enter the Number 2 : ");

                if (!double.TryParse(Console.ReadLine(), out double num3))
                {

                    Console.WriteLine("Value is should be in number.");
                    goto Start3;
                }
                Quadratic(num1, num2, num3);
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
