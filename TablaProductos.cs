using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "Tablaproductos.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,Teclado,80");
            sw.WriteLine("2,Audifonos,150");
            sw.WriteLine("3,Impresora,450");
            sw.WriteLine("4,Mouse,50");
        }

        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double precio = double.Parse(campos[2]);

            if (precio > 100)
                Console.WriteLine($"{campos[1]} - ${precio}");
        }
    }
}
