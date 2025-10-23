using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Control
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; } // 'F' o 'M'
        public string Telefono { get; set; }

        public Persona(string nombre, int edad, char genero, string telefono)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = char.ToUpper(genero);
            Telefono = telefono;
        }

        // Crea una nueva persona leyendo desde la consola
        public static Persona CrearDesdeConsola()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int edad;
            while (true)
            {
                Console.Write("Edad (años): ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                    break;
                Console.WriteLine("Edad inválida. Intente nuevamente.");
            }

            char genero;
            while (true)
            {
                Console.Write("Género (F/M): ");
                var entrada = Console.ReadLine();
                if (!string.IsNullOrEmpty(entrada))
                {
                    genero = char.ToUpper(entrada[0]);
                    if (genero == 'F' || genero == 'M')
                        break;
                }
                Console.WriteLine("Género inválido. Ingrese 'F' o 'M'.");
            }

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            return new Persona(nombre, edad, genero, telefono);
        }

        // Edita la información de la persona desde la consola
        public void EditarInformacion()
        {
            Console.WriteLine("--- Editar información ---");
            Console.Write($"Nombre ({Nombre}): ");
            var entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada)) Nombre = entrada;

            Console.Write($"Edad ({Edad}): ");
            entrada = Console.ReadLine();
            int nuevaEdad;
            if (int.TryParse(entrada, out nuevaEdad) && nuevaEdad >= 0) Edad = nuevaEdad;

            Console.Write($"Género ({Genero}): ");
            entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                var g = char.ToUpper(entrada[0]);
                if (g == 'F' || g == 'M') Genero = g;
            }

            Console.Write($"Teléfono ({Telefono}): ");
            entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada)) Telefono = entrada;

            Console.WriteLine("Información actualizada.");
        }

        public void ImprimirDetalles()
        {
            Console.WriteLine("--- Detalles de la persona ---");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }

        public int CalcularEdadEnDias()
        {
            return Edad * 365; // aproximado
        }

        // Método utilitario para agregar un nuevo usuario a una lista
        public static void AgregarNuevoUsuario(List<Persona> lista)
        {
            var p = CrearDesdeConsola();
            lista.Add(p);
            Console.WriteLine("Usuario agregado.");
        }

        public override string ToString()
        {
            return $"{Nombre} ({Edad} años)";
        }
    }
}
