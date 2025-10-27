using Estructura_De_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1........................................................

            //Console.WriteLine("Ingrese un numero: ");

            //int numero = int.Parse(Console.ReadLine()); // ReadLine = para leer la entrada de consola
            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("El numero es usted ingresó " + numero + " Es par");
            //}
            //else
            //{
            //    Console.WriteLine($"El numero que usted ingresó {numero} es impar");
            //}


            //2........................................................

            //{
            //    Console.WriteLine("Ingrese el primera nota: ");
            //    decimal nota1 = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese la segunda nota: ");
            //    decimal nota2 = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese la tercera nota: ");
            //    decimal nota3 = decimal.Parse(Console.ReadLine());

            //    if (nota1 < 1.0m || nota1 > 5.0m || nota2 < 1.0m || nota2 > 5.0m || nota3 < 1.0m || nota3 > 5.0m)
            //    {
            //        Console.WriteLine("Error: Las notas deben estar entre 1 y 5");
            //        return; // ERROR
            //    }
            //    else
            //    {

            //        nota1 = nota1 * 0.2m;
            //        nota2 = nota2 * 0.3m;
            //        nota3 = nota3 * 0.5m;

            //        decimal promedio = nota1 + nota2 + nota3;

            //        if (promedio >= 3.0m)
            //        {
            //            Console.WriteLine($"El estudiante aprobó con un promedio de: {promedio}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"El estudiante reprobó con un promedio de: {promedio}");
            //        }
            //    }
            //}

            //3........................................................

            //{
            //    Console.WriteLine("Ingrese el precio del producto:");

            //    int precio = int.Parse(Console.ReadLine());

            //    if (precio > 100000)
            //    {
            //        decimal descuento = precio * 0.20m;
            //        decimal precioFinal = precio - descuento;
            //        Console.WriteLine($"El precio final con descuento es: {precioFinal}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El precio final es: {precio}");
            //    }
            //}

            //4..............................................................

            //Console.WriteLine("Ingrese el monto del prestamo:");
            //decimal prestamo = decimal.Parse(Console.ReadLine());

            //decimal interes_anual = 0.05m;
            //decimal interes_mensual = interes_anual / 12;
            //decimal interes_trimestral = interes_mensual * 3;

            //decimal pago_interes_anual = prestamo * interes_anual;
            //decimal pago_interes_mensual = prestamo * interes_mensual;
            //decimal pago_interes_trimestral = prestamo * interes_trimestral;
            //decimal pago_total = prestamo + (prestamo * interes_anual);

            //Console.WriteLine($"El monto total a pagar por el prestamo es: {pago_total}");
            //Console.WriteLine($"El interes en el primer año es de: {pago_interes_anual}");
            //Console.WriteLine($"El interes en el primer mes es de: {pago_interes_mensual}");
            //Console.WriteLine($"El interes en el primer trimestre es de: {pago_interes_trimestral}");

            //5..............................................................

            //Console.WriteLine("ingrese su salario mensual: ");
            //decimal salario = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("ingrese cuanto desea ahorrar mensualmente: ");
            //decimal ahorro_mensual = decimal.Parse(Console.ReadLine());

            //decimal eps = salario * 0.125m;
            //decimal pension = salario * 0.16m;

            //decimal salario_neto = salario - eps - pension - ahorro_mensual;

            //Console.WriteLine($"su salario neto es: {salario_neto}");
            //Console.WriteLine($"Su descuento por eps es: {eps}");
            //Console.WriteLine($"Su descuento por pension es: {pension}");


            //6..............................................................

            // Menú para seleccionar ejercicios 
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1 - Biblioteca");
                Console.WriteLine("2 - Ejercicio 6: Matrícula Universidad");
                Console.WriteLine("3 - Ejercicio 7: Computronic Ventas");
                Console.WriteLine("4 - Ejercicio 8: Seguros Bogotá");
                Console.WriteLine("5 - Ejercicio 9: Bonos Empleados TikTok");
                Console.WriteLine("6 - Ejercicio 10: Distribución de Químicos");
                Console.WriteLine("7 - Salir");
                Console.Write("Seleccione una opción (1-7): ");

                string entrada = Console.ReadLine();
                Console.WriteLine();

                switch (entrada)
                {
                    case "1":
                        Console.WriteLine("Ejecutando: Biblioteca");
                        EjecutarBiblioteca();
                        break;
                    case "2":
                        Console.WriteLine("Ejecutando: Ejercicio 6 - Matrícula Universidad");
                        Ejercicios.Ejercicio6_MatriculaUniversidad();
                        break;
                    case "3":
                        Console.WriteLine("Ejecutando: Ejercicio 7 - Computronic Ventas");
                        Ejercicios.Ejercicio7_Computronic();
                        break;
                    case "4":
                        Console.WriteLine("Ejecutando: Ejercicio 8 - Seguros Bogotá");
                        Ejercicios.Ejercicio8_SegurosBogota();
                        break;
                    case "5":
                        Console.WriteLine("Ejecutando: Ejercicio 9 - Bonos Empleados TikTok");
                        Ejercicios.Ejercicio9_TikTokBonos();
                        break;
                    case "6":
                        Console.WriteLine("Ejecutando: Ejercicio 10 - Distribución de Químicos");
                        Ejercicios.Ejercicio10_DistribucionQuimicos();
                        break;
                    case "7":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Ejecuta el menú de la biblioteca
        private static void EjecutarBiblioteca()
        {
            Biblioteca biblioteca = new Biblioteca();
            int opcion = 0;

            do
            {
                Console.WriteLine("===== MENÚ BIBLIOTECA =====");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Listar libros");
                Console.WriteLine("3. Buscar libro por título");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Libro nuevoLibro = Libro.CrearDesdeConsola();
                        biblioteca.AgregarLibro(nuevoLibro);
                        break;
                    case 2:
                        biblioteca.ListarLibros();
                        break;
                    case 3:
                        Console.Write("Ingrese el título del libro a buscar: ");
                        string titulo = Console.ReadLine();
                        biblioteca.BuscarLibro(titulo);
                        break;
                    case 4:
                        // volver al menú principal
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.\n");
                        break;
                }

            } while (opcion != 4);
        }
    }
}

