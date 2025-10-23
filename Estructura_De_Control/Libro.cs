using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Control
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }

        public Libro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AnioPublicacion = anioPublicacion;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({AnioPublicacion}) [{Editorial}]";
        }

        // Crea un libro leyendo sus datos desde la consola
        public static Libro CrearDesdeConsola()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Editorial: ");
            string editorial = Console.ReadLine();

            int anio;
            while (true)
            {
                Console.Write("Año de publicación: ");
                if (int.TryParse(Console.ReadLine(), out anio) && anio > 0)
                    break;
                Console.WriteLine("Año inválido. Ingrese un número entero positivo.");
            }

            return new Libro(titulo, autor, editorial, anio);
        }
    }
}
