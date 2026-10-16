using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "informacionEstudiantes.csv";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("nombre,edad,nota,ciudad,");
                sw.WriteLine("sebastian,18,4.5,cienaga");
                sw.WriteLine("maria,20,5,santaMarta");
                sw.WriteLine("jorje,15,3.4,barranquilla");
                sw.WriteLine("joimer,15,5,cienaga");
            }
            Console.WriteLine("Archivo creado exitosamente");
        }
    }
}
