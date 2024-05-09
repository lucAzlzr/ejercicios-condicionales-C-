﻿using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
            //y calcule y emita el importe con el descuento  aplicado..
            float importeTotal, litrosVendidos, importeFinal;

            Console.WriteLine("Ingrese el importe total:");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros vendidos:");
            litrosVendidos = float.Parse(Console.ReadLine());

            if(litrosVendidos > 500){
                importeFinal = importeTotal * 0.75F;
                Console.WriteLine("El importe final con el descuento aplicado es: " + importeFinal);
            }else if(litrosVendidos > 300){
                importeFinal = importeTotal * 0.85F;
                Console.WriteLine("El importe final con el descuento aplicado es: " + importeFinal);
            }else if(litrosVendidos > 100){
                importeFinal = importeTotal * 0.90F;
                Console.WriteLine("El importe final con el descuento aplicado es: " + importeFinal);
            }else
                Console.WriteLine("No aplica descuento, el importe final es: " + importeTotal);

            //if(litrosVendidos > 500){
                //importeTotal *= 0.75F;
            //else if(litrosVendidos > 300){
                //importeTotal *= 0.85F;
            //else if(litrosVendidos > 100){
                //importeTotal *= 0.90F;

            //Console.WriteLine("El importe final a pagar es: " + importeTotal);
        }
    }
}
