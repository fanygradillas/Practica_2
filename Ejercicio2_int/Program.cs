﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 7;
            int perimetro = a + b + c;
            Console.WriteLine("El Perimetro del triangulo es:" + perimetro);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
