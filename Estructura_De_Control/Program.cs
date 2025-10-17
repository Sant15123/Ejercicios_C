using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Control
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

            Console.WriteLine("ingrese su salario mensual: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cuanto desea ahorrar mensualmente: ");
            decimal ahorro_mensual = decimal.Parse(Console.ReadLine());

            decimal eps = salario * 0.125m;
            decimal pension = salario * 0.16m;

            decimal salario_neto = salario - eps - pension - ahorro_mensual;

            Console.WriteLine($"su salario neto es: {salario_neto}");
            Console.WriteLine($"Su descuento por eps es: {eps}");
            Console.WriteLine($"Su descuento por pension es: {pension}");


            //6..............................................................

            //NOS DIJERON QUE NO HAGAMOS ESTE EJERCICIO DE CLASES

            //7..............................................................

            //NOS DIJERON QUE NO HAGAMOS ESTE EJERCICIO DE CLASES

            //8..............................................................

            //9..............................................................

            //10.............................................................

            //11.............................................................

            //12.............................................................




        }
    }
}

