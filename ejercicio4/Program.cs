﻿using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            int n1, n2, n3, n4, menor = 0;

            Console.WriteLine("Ingrese el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
            else
                menor = n2;
            if (n3 < menor)
                menor = n3;
            if (n4 < menor)
                menor = n4;
            Console.WriteLine("El número menor es: " + menor);
        }
    }
}
