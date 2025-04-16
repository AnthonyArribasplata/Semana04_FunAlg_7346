using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char estado_civil;
            Console.Write("Ingrese estado civil: ");
            estado_civil = char.Parse(Console.ReadLine().ToLower());
            bool st = false;

            if (estado_civil=='s')
            {
                Console.WriteLine("Soltero ☺");
                st = true;
            }
            if (estado_civil == 'c')
            {
                Console.WriteLine("Casado :(");
                st = true;
            }
            if (estado_civil == 'v')
            {
                Console.WriteLine("Viudo :)");
                st = true;
            }
            if (estado_civil == 'd')
            {
                Console.WriteLine("Divorciado :D");
                st = true;
            }
            ////&& => Y ||=> o
            //if (estado_civil!='c' && estado_civil!='s' && estado_civil!='v' && estado_civil!='d')
            //{
            //    Console.WriteLine("Sin especificar");
            //}
            if (st==false)
            {
                Console.WriteLine("Sin especificar");
            }
        }
    }
}
