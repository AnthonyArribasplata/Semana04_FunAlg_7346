using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Ingrese valor a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor b: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            } else
            {
                a++;
                b++;
            }

            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de b: " + b);
        }
    }
}
