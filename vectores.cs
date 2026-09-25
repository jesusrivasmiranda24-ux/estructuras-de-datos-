    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {    double[] temperaturas = new double[5]; // declarado e inicializado

            //lectura/escritura de nuestro vector
            Console.WriteLine("======Ingreso de temperaturas======");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"ingrese la temperatura del dia {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double temp in temperaturas)
            
            {
                suma += temp;
                if (temp > maxT) maxT = temp;
                if (temp < minT) minT = temp;
                {
                    
                }
            }

            double promedio = suma / temperaturas.Length;
            //salida de informacion 
            Console.WriteLine("\n===reporte====");
            Console.WriteLine($"Temperatura registradas: {string.Join(", ", temperaturas)}");
            Console.WriteLine($"Temperatura promedio: {promedio:F2}°c");
            Console.WriteLine($"Temperatura maxima: {maxT:F2}°c");
            Console.WriteLine($"Temperatura minima: {minT:F2}°c");
        }
    }
}
