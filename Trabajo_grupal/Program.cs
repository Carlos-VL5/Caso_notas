using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal
{
    

class Program
        {
            // Variable global
            static double saldo = 1000.00;

            static void Main()
            {
                MenuPrincipal();
            }

            // Método del menú principal
            static void MenuPrincipal()
            {
                int opcion;

                while (true)
                {
                    Console.WriteLine("\n===== CAJERO AUTOMÁTICO =====");
                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Depositar");
                    Console.WriteLine("3. Retirar");
                    Console.WriteLine("4. Mostrar números");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Ingrese una opción válida.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            ConsultarSaldo();
                            break;

                        case 2:
                            Depositar();
                            break;

                        case 3:
                            Retirar();
                            break;

                        case 4:
                            MostrarNumeros();
                            break;

                        case 5:
                            Console.WriteLine("Gracias por usar el cajero automático.");
                            return;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            // Método para consultar el saldo
            static void ConsultarSaldo()
            {
                Console.WriteLine($"Saldo actual: S/ {saldo:F2}");
            }

            // Método para depositar dinero
            static void Depositar()
            {
                double monto;

                Console.Write("Ingrese el monto a depositar: ");

                if (!double.TryParse(Console.ReadLine(), out monto))
                {
                    Console.WriteLine("Ingrese un monto válido.");
                    return;
                }

                if (monto > 0)
                {
                    saldo += monto;
                    Console.WriteLine($"Depósito realizado. Nuevo saldo: S/ {saldo:F2}");
                }
                else
                {
                    Console.WriteLine("El monto debe ser mayor a cero.");
                }
            }

            // Método para retirar dinero
            static void Retirar()
            {
                double monto;

                Console.Write("Ingrese el monto a retirar: ");

                if (!double.TryParse(Console.ReadLine(), out monto))
                {
                    Console.WriteLine("Ingrese un monto válido.");
                    return;
                }

                if (monto <= 0)
                {
                    Console.WriteLine("El monto debe ser mayor a cero.");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Fondos insuficientes.");
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro realizado. Nuevo saldo: S/ {saldo:F2}");
                }
            }

            // Método para mostrar números usando for
            static void MostrarNumeros()
            {
                int limite;

                Console.Write("Ingrese el límite del conteo: ");

                if (!int.TryParse(Console.ReadLine(), out limite))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    return;
                }

                if (limite <= 0)
                {
                    Console.WriteLine("El límite debe ser mayor a cero.");
                    return;
                }

                Console.WriteLine("Conteo:");

                for (int i = 1; i <= limite; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }


