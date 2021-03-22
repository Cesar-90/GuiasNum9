using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("Ingrese el valor: ");
            valor = int.Parse(Console.ReadLine());

            int[] Valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int capacidad = 10;
            for (int i = 0; i < capacidad; i++)
            {
                if (valor == Valores[i])
                {
                    Console.WriteLine($"El {valor} fue encontrado en la posición {Valores[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
