using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, h, a;
            Console.WriteLine("Ingresa base");
            // ENTRADA
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa altura");
            h = Convert.ToDouble(Console.ReadLine());
            // PROCESO
            a = x * h / 2;
            // SALIDA
            Console.WriteLine("El área del triangulo es");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
