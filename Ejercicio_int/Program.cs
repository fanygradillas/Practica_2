﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_int
{
    class Program
    {
        //Ctrl + k + c
        //ctrl + k + u
        //Crear tres variables de tipo INT y asignarles valores estáticos.

        static void Main(string[] args)
        {
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de Suma es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();


        }
    }
}
