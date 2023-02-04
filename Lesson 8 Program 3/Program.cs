using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, C, O, X, Y, Z, U, W;

            Console.WriteLine("Введите число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Введите число 'B':");
            B = Console.ReadLine();

            Console.WriteLine("Введите число 'C':");
            C = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int c = Convert.ToInt32(C);

            O = C + " " + B + " " + A;

            X = B + " " + C + " " + A;

            Y = C + " " + A + " " + B;

            Z = A + " " + C + " " + B;

            U = B + " " + A + " " + C;

            W = A + " " + B + " " + C;

            if (a > b && b > c)
            {
                Console.WriteLine(O);
            }

            else if (a > b && b < c)
            {
                Console.WriteLine(X);
            }

            else if (a < b && a > c)
            {
                Console.WriteLine(Y);
            }
            
            else if (a < c && b > c)
            {
                Console.WriteLine(Z);
            }

            else if (a > b && a < c)
            {
                Console.WriteLine(U);
            }

            else if (a < b && b < c)
            {
                Console.WriteLine(W);
            }

            Console.ReadLine();
        }
    }
}
