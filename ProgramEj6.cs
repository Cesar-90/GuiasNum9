using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[5];
            string personas;
            int edad;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona:  {i}");
                personas = Console.ReadLine();
                Console.WriteLine("Ingrese edad de la persona: ");
                edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    Console.WriteLine($"Las siguiente persona es mayor de edad: {personas}");
                }
                else
                {
                    Console.WriteLine($"No es mayor de edad");
                }
            }
            Console.ReadKey();
        }
    }
}
