using System;
using System.IO;

class Program
{
    static void Main()
    {
        string rutaArchivo = "jugadores.csv";

        // Verifica si el archivo existe
        if (File.Exists(rutaArchivo))
        {
            Console.WriteLine("Lista de Jugadores:\n");

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                bool primeraLinea = true;

                while ((linea = sr.ReadLine()!) != null)
                {
                    if (primeraLinea)
                    {
                        primeraLinea = false;
                        continue;
                    }

                    // Separar los valores por coma
                    string[] datos = linea.Split(',');

                    Console.WriteLine($"Nombre: {datos[0]}");
                    Console.WriteLine($"Posición: {datos[1]}");
                    Console.WriteLine($"Juegos: {datos[2]}");
                    Console.WriteLine($"Hits: {datos[3]}");
                    Console.WriteLine($"Carreras: {datos[4]}");
                    Console.WriteLine($"HomeRuns: {datos[5]}");
                    Console.WriteLine($"Promedio de Bateo: {datos[6]}\n");
                }
            }
        }
        else
        {
            Console.WriteLine("No se encontró el archivo jugadores.csv");
        }
    }
}
