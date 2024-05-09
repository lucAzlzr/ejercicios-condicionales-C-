using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            int a, b, c, d;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            d = int.Parse(Console.ReadLine());

            if (a > 100)
                Console.WriteLine("El número " + a + " es mayor a 100");
            if (b > 100)
                Console.WriteLine("El número " + b + " es mayor a 100");
            if (c > 100)
                Console.WriteLine("El número " + c + " es mayor a 100");
            if (d > 100)
                Console.WriteLine("El número " + d + " es mayor a 100");
        }
    }
}
