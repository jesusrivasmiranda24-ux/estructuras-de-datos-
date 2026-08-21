
using System;
using System.Text.RegularExpressions;

namespace program
{
    internal class Program
    {

        static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
            //ahora voy a realizar el calculo con la forma 
            double area = PI * Math.Pow(radio, 2);
            return area;

        }
        static void Main(string[] args)
        {
            Console.Write("ingresar el radio del circulo: ");
    double r = Convert.ToDouble(Console.ReadLine());


            double result = CalcularAreaCirculo(r);
            Console.WriteLine($"El area es: {result:f2}");


        }

    }
}