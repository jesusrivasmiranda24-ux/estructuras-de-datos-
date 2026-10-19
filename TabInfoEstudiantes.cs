using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "estudiantes.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("Juan,17,4.0");
            sw.WriteLine("Natalia,18,4.5");
            sw.WriteLine("Joimer,16,3.8");
        }

        string[] lineas = File.ReadAllLines(ruta);

        Console.WriteLine("Campos: Nombre, Edad, Nota");
        Console.WriteLine("Delimitador: coma (,)");

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            Console.WriteLine($"Nombre: {campos[0]} - Tipo: Texto");
            Console.WriteLine($"Edad: {campos[1]} - Tipo: Entero");
            Console.WriteLine($"Nota: {campos[2]} - Tipo: Decimal");
            Console.WriteLine();
        }
    }
}
