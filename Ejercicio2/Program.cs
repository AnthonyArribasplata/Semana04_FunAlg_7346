using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n1, n2;

            Console.Write("Ingrese numero1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero2: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1<n2)
            {
                Console.WriteLine(n1+" - "+n2);
            }

            if (n2<n1)
            {
                Console.Write(n2+" - "+n1);
            }
        }
    }
}
