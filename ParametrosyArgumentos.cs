using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //procedimiento sumar o imprmir

        public static void imprimirSuma(int a, int b)// a, b sn los parametros
        {
            int suma = a + b;
            Console.WriteLine(suma);

        }

        public static void MostrarPotenciaX(double num1,double Potencia) {

            double result = Math.Pow(num1, Potencia);
            Console.WriteLine($"La potencia de {num1} Elevado a {Potencia} es: {result}");

        

        }

        
        static void Main(string[] args)
        {
            int x = 12, y = 23;
           
            imprimirSuma(y, x); //y, x (argumentos Actuales)
            imprimirSuma(1000, -1); //1000, -1 (Argumentos literales)
            MostrarPotenciaX(x, y);

        }
    }

}
      
