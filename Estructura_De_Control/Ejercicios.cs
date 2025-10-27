using System;

namespace Estructura_De_Control
{
    internal static class Ejercicios
    {
        public static void Ejercicio6_MatriculaUniversidad()
        {
            string[] programas = { "Ingeniería de sistemas", "Psicología", "Economía", "Comunicación Social", "Administración de Empresas" };
            int[] creditos = { 20, 16, 18, 18, 20 };
            decimal[] descuentos = { 0.18m, 0.12m, 0.10m, 0.05m, 0.15m };
            decimal valorCredito = 200000m;

            Console.Write("Ingrese el número de estudiantes a matricular: ");
            int n = int.Parse(Console.ReadLine());

            int[] cantidadPorPrograma = new int[5];
            decimal totalCreditos = 0, totalSinDescuento = 0, totalDescuentos = 0, totalNeto = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Estudiante {i + 1} ---");
                for (int j = 0; j < programas.Length; j++)
                    Console.WriteLine($"{j + 1}. {programas[j]}");

                Console.Write("Seleccione el programa (1-5): ");
                int opcion = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Forma de pago (1: Efectivo, 2: En línea): ");
                int formaPago = int.Parse(Console.ReadLine());

                cantidadPorPrograma[opcion]++;
                int creditosPrograma = creditos[opcion];
                decimal valorPrograma = creditosPrograma * valorCredito;
                decimal descuentoAplicado = (formaPago == 1) ? valorPrograma * descuentos[opcion] : 0;
                decimal valorFinal = valorPrograma - descuentoAplicado;

                totalCreditos += creditosPrograma;
                totalSinDescuento += valorPrograma;
                totalDescuentos += descuentoAplicado;
                totalNeto += valorFinal;
            }

            Console.WriteLine("\n===== RESULTADOS =====");
            for (int i = 0; i < programas.Length; i++)
                Console.WriteLine($"{programas[i]}: {cantidadPorPrograma[i]} estudiantes");

            Console.WriteLine($"\nTotal créditos inscritos: {totalCreditos}");
            Console.WriteLine($"Valor total sin descuento: ${totalSinDescuento:N0}");
            Console.WriteLine($"Total descuentos aplicados: ${totalDescuentos:N0}");
            Console.WriteLine($"Valor neto total: ${totalNeto:N0}");
        }

        public static void Ejercicio7_Computronic()
        {
            Console.Write("Ingrese el número de empleados: ");
            int empleados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= empleados; i++)
            {
                Console.WriteLine($"\n--- Empleado {i} ---");
                Console.Write("Ingrese la cantidad de ventas realizadas: ");
                int ventas = int.Parse(Console.ReadLine());

                int menores300 = 0, entre300y800 = 0, mayores800 = 0;
                decimal totalVentas = 0;

                for (int j = 1; j <= ventas; j++)
                {
                    Console.Write($"Venta #{j}: ");
                    decimal monto = decimal.Parse(Console.ReadLine());
                    totalVentas += monto;

                    if (monto <= 300000) menores300++;
                    else if (monto < 800000) entre300y800++;
                    else mayores800++;
                }

                decimal bonificacion = 0;
                if (totalVentas >= 800000) bonificacion = totalVentas * 0.10m;
                else if (totalVentas >= 400001 && totalVentas <= 800000) bonificacion = totalVentas * 0.05m;
                else if (totalVentas >= 400000) bonificacion = totalVentas * 0.03m;

                decimal pagoBasico = 500000;
                decimal pagoTotal = pagoBasico + bonificacion;

                Console.WriteLine("\nResultados del empleado:");
                Console.WriteLine($"Ventas ? $300.000: {menores300}");
                Console.WriteLine($"Ventas entre $300.001 y $800.000: {entre300y800}");
                Console.WriteLine($"Ventas ? $800.000: {mayores800}");
                Console.WriteLine($"Total vendido: ${totalVentas:N0}");
                Console.WriteLine($"Bonificación: ${bonificacion:N0}");
                Console.WriteLine($"Pago total: ${pagoTotal:N0}");
            }
        }

        public static void Ejercicio8_SegurosBogota()
        {
            Console.Write("Ingrese el número de conductores registrados: ");
            int n = int.Parse(Console.ReadLine());

            int menores30 = 0, masculinos = 0, femeninos = 0, mascEntre12y30 = 0, fueraBogota = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Conductor {i + 1} ---");
                Console.Write("Año de nacimiento: ");
                int nacimiento = int.Parse(Console.ReadLine());

                Console.Write("Sexo (1: Femenino, 2: Masculino): ");
                int sexo = int.Parse(Console.ReadLine());

                Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
                int registro = int.Parse(Console.ReadLine());

                int edad = DateTime.Now.Year - nacimiento;

                if (edad < 30) menores30++;
                if (sexo == 1) femeninos++; else masculinos++;
                if (sexo == 2 && edad >= 12 && edad <= 30) mascEntre12y30++;
                if (registro == 2) fueraBogota++;
            }

            Console.WriteLine("\n===== RESULTADOS =====");
            Console.WriteLine($"% Conductores menores de 30 años: {(menores30 * 100m / n):N2}%");
            Console.WriteLine($"% Masculinos: {(masculinos * 100m / n):N2}%");
            Console.WriteLine($"% Femeninos: {(femeninos * 100m / n):N2}%");
            Console.WriteLine($"% Masculinos entre 12 y 30 años: {(mascEntre12y30 * 100m / n):N2}%");
            Console.WriteLine($"% Conductores con registro fuera de Bogotá: {(fueraBogota * 100m / n):N2}%");
        }

        public static void Ejercicio9_TikTokBonos()
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            int n = int.Parse(Console.ReadLine());

            int[] cumplePorMes = new int[12];
            int totalEdad = 0, empleadosConBono = 0;
            const decimal bono = 150000m;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Empleado {i + 1} ---");
                Console.Write("Año de nacimiento: ");
                int anio = int.Parse(Console.ReadLine());
                Console.Write("Mes de nacimiento (1-12): ");
                int mes = int.Parse(Console.ReadLine());

                int edad = DateTime.Now.Year - anio;
                totalEdad += edad;

                if (edad > 18 && edad < 50)
                {
                    cumplePorMes[mes - 1]++;
                    empleadosConBono++;
                }
            }

            decimal totalBonos = empleadosConBono * bono;
            decimal promedioEdad = (decimal)totalEdad / n;

            Console.WriteLine("\n===== LISTA DESGLOSADA =====");
            for (int i = 0; i < 12; i++)
            {
                if (cumplePorMes[i] > 0)
                    Console.WriteLine($"{MesNombre(i + 1)}: {cumplePorMes[i]} empleados - Bonos: ${(cumplePorMes[i] * bono):N0}");
            }

            Console.WriteLine($"\nPromedio de edades: {promedioEdad:N1}");
            Console.WriteLine($"Total dinero en bonos: ${totalBonos:N0}");
        }

        public static void Ejercicio10_DistribucionQuimicos()
        {
            Console.WriteLine("=== Carga de camiones ===");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"\nCamión #{i} - Capacidad (litros): ");
                int capacidad = int.Parse(Console.ReadLine());

                int cargaActual = 0, tanque = 1;
                while (true)
                {
                    Console.Write($"Tanque #{tanque} (litros 3000–9000): ");
                    int litros = int.Parse(Console.ReadLine());

                    if (cargaActual + litros > capacidad)
                    {
                        Console.WriteLine("?? Excede la capacidad. Despachando camión...");
                        break;
                    }

                    cargaActual += litros;
                    Console.WriteLine($"Carga actual: {cargaActual}/{capacidad}");

                    tanque++;
                }
            }

            Console.WriteLine("\n? Se cargaron los 20 camiones del día.");
        }

        private static string MesNombre(int mes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[mes - 1];
        }
    }
}
