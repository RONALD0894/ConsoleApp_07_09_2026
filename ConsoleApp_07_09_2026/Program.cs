using System;
using System.Collections.Generic;
using Sistema_de_Autenticacion;

class Program
{

    static void Main(string[] args)
    {
        // Variable para controlar la continuación del bucle principal
        bool continuarProbando = true;

        // Bucle principal del sistema
        while (continuarProbando)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Autenticación ===");
            Console.WriteLine("Usuarios disponibles para prueba: ana, luis, maria, pedro\n");

            //variable para validar el login exitoso
            bool loginExitoso = false;

            // Bucle de 3 intentos por cada sesión de prueba
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre del usuario: ");
                string nombreIngresado = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                string passwordIngresada = LeerPasswordOculta();

                Console.Write("Ingrese el rol al que desea acceder: ");
                string rolIngresado = Console.ReadLine();

                Usuario usuarioAutenticado = ValidarAcceso(nombreIngresado, passwordIngresada, rolIngresado);

                if (usuarioAutenticado != null)
                {
                    Console.WriteLine("\n----------------------------------------");
                    Console.WriteLine("¡ACCESO CONCEDIDO!");
                    MostrarPermisos(rolIngresado);
                    Console.WriteLine("----------------------------------------\n");
                    loginExitoso = true;
                    break; // Sale del bucle de intentos al lograr loguearse
                }
                else
                {
                    Console.WriteLine($"\n[X] Credenciales o rol inválidos. Intentos restantes: {2 - i}\n");
                }
            }

            if (!loginExitoso)
            {
                Console.WriteLine("Has agotado los 3 intentos para este inicio de sesión.\n");
            }

            // Menú para decidir si continuar o salir
            Console.WriteLine("¿Deseas probar con otro usuario?");
            Console.WriteLine("1. Sí, probar otro usuario");
            Console.WriteLine("2. No, salir del sistema");
            Console.Write("Seleccione una opción (1 o 2): ");

            string opcion = Console.ReadLine();

            if (opcion != "1")
            {
                continuarProbando = false; // Rompe el bucle principal
            }
        }

        Console.WriteLine("\nSaliendo del programa... ¡Hasta luego!");
        Console.WriteLine("Presiona Enter para cerrar la consola...");
        Console.ReadLine();
    }

    // Oculta la contraseña reemplazando caracteres con asteriscos
    static string LeerPasswordOculta()
    {
        string password = "";
        ConsoleKeyInfo tecla;

        do
        {
            tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
            else if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
            {
                password += tecla.KeyChar;
                Console.Write("*");
            }

        } while (tecla.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }

    // Valida credenciales y asignación de rol
    static Usuario ValidarAcceso(string nombre, string password, string rol)
    {
        Usuario usuarioEncontrado = RepositorioUsuario.listaUsuarios.Find(u => u.Nombre == nombre && u.PasswordHash == Seguridad.GenerarHash(password));

        if (usuarioEncontrado != null && usuarioEncontrado.RolesAsignados.Contains(rol))
        {
            return usuarioEncontrado;
        }

        return null;
    }

    // Muestra las acciones permitidas por usuario y rol
    static void MostrarPermisos(string rol)
    {
        switch (rol)
        {
            case "admin":
                Console.WriteLine("Permisos de administrador: acceso completo.");
                break;
            case "usuario":
                Console.WriteLine("Permisos de usuario: acceso limitado.");
                break;
            case "invitado":
                Console.WriteLine("Permisos de invitado: solo lectura.");
                break;
            default:
                Console.WriteLine("Permisos: rol no reconocido.");
                break;
        }
    }

}