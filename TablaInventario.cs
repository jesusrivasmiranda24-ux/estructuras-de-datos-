using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "Tablainventario.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Producto,Cantidad");
            sw.WriteLine("1,Calculadora,5");
            sw.WriteLine("2,Block,12");
            sw.WriteLine("3,Cartulina,7");
            sw.WriteLine("4,Regla,4");
        }

        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            int cantidad = int.Parse(campos[2]);

            if (cantidad < 10)
                Console.WriteLine($"{campos[1]} - Cantidad: {cantidad}");
        }
    }
}
