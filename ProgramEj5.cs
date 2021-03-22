using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] empleados;
            int numEmpleados;
            double sueldos;
            Console.WriteLine("Ingrese el total de empleados: ");
            numEmpleados = int.Parse(Console.ReadLine());
            empleados = new int[numEmpleados];

            for (int i = 0; i < numEmpleados; i++)
            {
                Console.WriteLine($"Ingrese el sueldo del {i}° empleado: ");
                sueldos = double.Parse(Console.ReadLine());

                if (sueldos <= 300 && sueldos >= 100)
                {
                    Console.WriteLine($"El empleado {i} gana entre $300 y $100");
                    Console.WriteLine("");
                }
                else if (sueldos >= 350)
                {
                    Console.WriteLine($"El empleado {i} gana más de $350");
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}
