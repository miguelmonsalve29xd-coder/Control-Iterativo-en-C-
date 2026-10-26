
using System;

class Program
{
    static void Main()
    {
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        // 1. Registro de calificaciones
        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

       for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudinate {i + 1}: {calificaciones[i]}");
        }

        // 2. Orden descendente
        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // 3. Suma total y promedio
        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        int sumaTotal = 0;

        foreach (int nota in calificaciones)
        {
            sumaTotal += nota;
        }

        double promedio = (double)sumaTotal / calificaciones.Length;

        Console.WriteLine($"Suma total: {sumaTotal}");
        Console.WriteLine($"Promedio: {promedio}");

        // 4. Posiciones pares (índices 0, 2, 4, 6, 8)
        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }



        // Sección 2 — While y Do-While:

        int intentos = 0;
        string clave = "sena2025";

        while (true)
        {
            Console.WriteLine($"Ingrese la clave (intento {intentos + 1}):");
            string palabra = Console.ReadLine();

            if (palabra == clave)
            {
                Console.WriteLine("Acceso concedido.");
                break;
            }

            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo..");
                intentos++;

                if (intentos >= 3)
                {
                    Console.WriteLine("Demasiados intentos fallidos. Acceso denegado.");
                    break;
                }
            }
        }

        int opcion;
        do
        {
            Console.WriteLine("===MENU PRINCIPAL===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                Console.WriteLine($"Promedio del grupo: {promedio}");
                break;

                case 2:
                Console.WriteLine($"Calificación más alta: {calificaciones.Max()}");
                break;

                case 3:
                Console.WriteLine("Hasta luego.");
                break;

                default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
            }
        } while (opcion != 3);

        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

        int aprobados = 0;

        foreach (int nota in calificaciones)
        {
            if (nota < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobado: {nota}");
            aprobados++;
        }

        Console.WriteLine($"Total aprobados: {aprobados}");

        Console.WriteLine("\n=== FILTRO COMBINADO ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] >= 95)
            {
                Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
                break;
            }

            if (calificaciones[i] < 70)
            {
                continue;
            }

            Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
        }
    }
}

