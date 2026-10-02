using System;
class Program
{
    static void Main()
    {
        // Reemplazar N por la cantidad de estudiantes dada en clase
        const int N = 21;

        // Arreglos estáticos paralelos
        string[] nombres = new string[N];
        double[] calificaciones = new double[N];

        // Registro de estudiantes
        for (int i = 0; i < N; i++)
        {
            // Validar nombre
            for (bool nombreValido = false; !nombreValido;)
            {
                Console.Write("Ingrese el nombre del estudiante " + (i + 1) + ": ");
                string nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombres[i] = nombre;
                    nombreValido = true;
                }
                else
                {
                    Console.WriteLine("Error: el nombre no puede estar vacío.");
                }
            }

            // Validar calificación
            for (bool notaValida = false; !notaValida;)
            {
                Console.Write("Ingrese la calificación de " + nombres[i] + " (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                double nota;

                if (double.TryParse(entrada, out nota) && nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: la nota debe ser un número entre 0.0 y 5.0.");
                }
            }

            Console.WriteLine();
        }

        // Variables para las estadísticas
        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        // Calcular estadísticas
        for (int i = 0; i < N; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > mayor)
            {
                mayor = calificaciones[i];
            }

            if (calificaciones[i] < menor)
            {
                menor = calificaciones[i];
            }

            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / N;

        // Reporte final
        Console.WriteLine("=================================");
        Console.WriteLine("       REPORTE DE CALIFICACIONES");
        Console.WriteLine("=================================");

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(
                nombres[i] + " - " +
                calificaciones[i].ToString("F2")
            );
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota mayor: " + mayor.ToString("F2"));
        Console.WriteLine("Nota menor: " + menor.ToString("F2"));
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
        Console.WriteLine("=================================");
    }
}
