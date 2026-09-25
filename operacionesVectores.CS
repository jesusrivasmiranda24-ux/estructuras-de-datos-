using System;
namespace proyect12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2. Busqueda y Modificacion de informacion de vectores
            //Operaciones: Busqueda Lineal, Verificacion de existencia y actualizacion de un elemento array

            int[] codigos = new int[20];

            
            for (int i = 0; i < codigos.Length; i++) {
                Console.Write($"Ingrese la  {i + 1}:");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"codigos actuales:{string.Join(",", codigos)}");
            Console.WriteLine($" ingrese el codigo que desea actualizar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda){
                    indiceEncontrado = i;
                    break;
                }

            }
            // VALIDANDO SI ENCONTRE EL VALOR QUE QUIERO MODIFICAR!!
            if (indiceEncontrado != -1)
            {
                Console.Write("ingrese el nuevo codigo:");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector Actualizado:{string.Join(",", codigos)}");
            }
            else
            {
                Console.WriteLine($"\n Valor del indice :{indiceEncontrado}");
                Console.WriteLine("\nError: El codigo ingresado no existe en la BDD");
            }

        }
    }
}
