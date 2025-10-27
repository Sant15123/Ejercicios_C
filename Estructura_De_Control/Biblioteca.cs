using System;
using System.Collections.Generic;

namespace Estructura_De_Control
{
    internal class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("\n? Libro agregado correctamente.\n");
        }

        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("? No hay libros registrados.\n");
                return;
            }

            Console.WriteLine("\n?? Lista de libros:\n");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
            Console.WriteLine();
        }

        public void BuscarLibro(string titulo)
        {
            var encontrado = libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                Console.WriteLine("\n?? Libro encontrado:\n");
                Console.WriteLine(encontrado + "\n");
            }
            else
            {
                Console.WriteLine("\n? No se encontró un libro con ese título.\n");
            }
        }
    }
}
