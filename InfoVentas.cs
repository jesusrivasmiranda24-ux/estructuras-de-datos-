using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "Infoventas.txt";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Producto:Cantidad");
            sw.WriteLine("Arroz:15");
            sw.WriteLine("Leche:8");
            sw.WriteLine("Pan:20");
            sw.WriteLine("Huevos:12");
            sw.WriteLine("Azucar:10");
            sw.WriteLine("Cafe:18");
        }

        string[] lineas = File.ReadAllLines(ruta);

        int total = 0;
        int mayor = 0;
        string productoMayor = "";

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(':');
            int cantidad = int.Parse(campos[1]);

            total += cantidad;

            if (cantidad > mayor)
            {
                mayor = cantidad;
                productoMayor = campos[0];
            }
        }

        Console.WriteLine($"Total vendido: {total}");
        Console.WriteLine($"Producto mas vendido: {productoMayor}");
        Console.WriteLine($"Cantidad vendida: {mayor}");
    }
}
