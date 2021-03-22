using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n;
            int cantPiezas; 
            double longHierro;
            Console.WriteLine("Ingrese la cantidad del vector: ");
            cantPiezas = int.Parse(Console.ReadLine());

            n = new int[cantPiezas];
            for (int i = 0; i < cantPiezas; i++)
            {
                Console.WriteLine($"-- Piezas a procesar: {i}");
            }
            for (int i = 0; i < cantPiezas; i++)
            {
                Console.WriteLine($"Ingrese la longitud de la pieza de Hierro: {i}");
                longHierro = double.Parse(Console.ReadLine());

                if (longHierro == 1.20 || longHierro==1.40)
                {
                    Console.WriteLine($"Aptas: {i}");

                }
                else
                {
                    Console.WriteLine("Las piezas ingresadas no son aptas");
                }
            }
            Console.ReadKey();
        }
    }
}
