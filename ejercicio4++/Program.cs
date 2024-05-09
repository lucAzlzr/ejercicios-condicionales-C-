using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos 
            //primeros es mayor al producto del segundo con el tercero.
            int a, b, c, suma, producto;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());

            suma = a + b;
            producto = b * c;

            if(suma > producto)
                Console.WriteLine("La suma de los dos primeros números es mayor al producto del segundo con el tercero");
        }
    }
}
