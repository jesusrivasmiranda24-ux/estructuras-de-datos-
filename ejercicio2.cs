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
            string[] estudiantes =
            { "ana", "nico", "anuar", "stevel" };

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(
                    $"Indice [{i}] {estudiantes[i]}");

            }

        }

    }

}
            

