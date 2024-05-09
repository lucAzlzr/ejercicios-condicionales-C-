using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int a, b, resultado;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());

            if(a > b){
                resultado = a - b;
                Console.WriteLine("La resta de estos dos numeros es: " + resultado);
            }
            if(a == b){
                resultado = a + b;
                Console.WriteLine("La suma de estos dos numeros es: " + resultado);
            }
            if(a < b){
                resultado = a * b;
                Console.WriteLine("El producto de estos dos numeros es: " + resultado);
            }    
        }
    }
}
