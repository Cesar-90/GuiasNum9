using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Grado = new double[9];
            double nota;

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Ingrese la nota: {i}");
                nota = double.Parse(Console.ReadLine());
                if (nota == 8.5)
                {
                    Console.WriteLine($"Las notas iguales a 8.5 son las siguientes, nota {i}");
                }
            }
            Console.ReadKey();
        }
    }
}
