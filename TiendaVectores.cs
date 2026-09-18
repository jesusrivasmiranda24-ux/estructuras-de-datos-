using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //una tienda registra las ventas de 10 dias en un array double[]
            //y necesitamos calcular : 
            //1.Calcular el total vendido
            //2.calcular el promedio diario
            //3.encontrar el dia con mayor venta
            //4.encontrar el dia con menor venta
            //5.contar cuantos dias superaron el promedio 

            double[] venta = { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211};
            double total = 0;
            double mayorventa = venta[0];
            double menorVenta = venta[0];
            int Diamayorventa = 0;
            int Diamenorventa = 0;


            for (int i = 0; i < venta.Length; i++)
            {
                total += venta[i];


                if (venta[i] > mayorventa)
                {
                    mayorventa = venta[i];
                    Diamayorventa = i;
                }
                if (venta[i] < menorVenta)
                {
                    menorVenta = venta[i];
                    Diamenorventa = i;
                }
            }

            double promedio = total / venta.Length;
            int diasSobrePromedio = 0;

            for(int i = 0;i < venta.Length; i++)
            {
                if (venta[i] > promedio)
                {
                    diasSobrePromedio++;
                }
            }

            Console.WriteLine("========= REPORTE DE VENTAS===========");
            Console.WriteLine();


            Console.WriteLine($"Total vendido: ${total:F3}");
            Console.WriteLine($"promedio diario: ${promedio:F3}");
            Console.WriteLine();


            Console.WriteLine($"Mayor venta ${mayorventa:F3} = el dia {Diamayorventa + 1}");
            Console.WriteLine($"Menor venta ${menorVenta:F3} = el dia {Diamenorventa + 1}");

            Console.WriteLine($"Dias que superaror el promedio de ventas: ${diasSobrePromedio}");
            Console.WriteLine();


            Console.WriteLine("ventas por dias");
            for (int i = 0; i <= venta.Length; i++)
            {
                Console.WriteLine($"dia {i + 1}: ${venta[i]:F3}");
            }
        }

    }

}
            

            
    
           
    

