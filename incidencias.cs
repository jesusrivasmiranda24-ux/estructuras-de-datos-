using System;
using System.Collections.Generic;
using System.IO;

// registro de incidencia de un soporte tecnico utulizando archivos(.txt)
//1 guardar una lista de incidencias atendidas en un archivo de texto(incidencia.txt)
//2 leer el archivo y mostrar su informacion
//3 generar un reporte que cuenta cuantas incidencias hay por prioridad (alta,media,baja)
// la estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.

//ejemplo: '01';'joimer';'daño de pc';'alta',
namespace Registro
{
    internal class Program
    {
        //C:\Users\Sala-1\Desktop\incidencias
        static string patharchivo = "C:\\Users\\Sala-1\\Desktop\\incidencias\\incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(patharchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(incidencia);
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine($"error al escribir el archivo: {ex.Message}");

            }
        }
       

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(patharchivo))
            {
                Console.WriteLine("El archivo no existe aun.");
                return incidencias;
            }
            try
            {string lineas;
                using (StreamReader sr = new StreamReader(patharchivo))
                {
                    while ((lineas = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(lineas))
                        {
                            string[] campos = lineas.Split(';');
                            incidencias.Add(campos);
                        }
                    }
                }

            }catch (Exception error)
            {
                Console.WriteLine($"Error al leer el archivo {error.Message}");
            }
            return incidencias;


        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("no hay incidencias para reportar");
                return;
            }
            Dictionary<string, int> conteoPorPreoridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //inc['01'; 'joimer'; 'daño de pc'; 'alta',]
                if (conteoPorPreoridad.ContainsKey(prioridad))
                {
                    conteoPorPreoridad[prioridad]++;
                }
                else
                {
                    conteoPorPreoridad [prioridad] = 1;
                }
            }
            Console.WriteLine("\n REPORTE DE INCIDENCIAS");
            Console.WriteLine($"TOTAL ATENDIDAS: {incidencias.Count}");
            Console.WriteLine("DETALLES POR PRIORIDAD");
            foreach (var inc in conteoPorPreoridad)
            {
                Console.WriteLine($"\nPrioridad {inc.Key}: {inc.Value}");
            }
        }
        static void Main(string[] args)
        {
            List<string[]> incidencias = new List<string[]>
            {
                new string[] { "1", "joimer", "no imprime", "alta" },
                new string[] { "2", "zuly", "problema de pc", "baja" },
                new string[] {"3","maria","olvido la contraseña","media"},
                new string[] { "4", "juan", "pantalla negra", "media" },
                new string[] {"5","pedro","pc quemada","alta"}

            };
            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");
            GuardarIncidencias(incidencias);

            Console.WriteLine("\n=== Leyendo incidencias del archivo ===");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEIDAS");
            Console.WriteLine($"{"ID",-4}{"USUARIO",-15}{"DESCRIPCION",-20}{"PRIORIDAD",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15}{inc[2],-20} {inc[3],-10}");
            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\nPresione cualquier tecla para salir!!!!!");
            Console.ReadKey();

        }





    }
}
