using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "Infoestudiantes.csv";

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');

                Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}, Sexo: {campos[3]}, Asignatura: {campos[4]}");
            }
        }

        using (StreamWriter sw = new StreamWriter("Infestudiantes.csv", append: true))
        {
            sw.WriteLine("Pedro,23,88,Masculino,Matemáticas");
            sw.WriteLine("Juleka,20,95,Femenino,Español");
            sw.WriteLine("Rodrigo,21,85,Masculino,Informática");
        }
    }
}
