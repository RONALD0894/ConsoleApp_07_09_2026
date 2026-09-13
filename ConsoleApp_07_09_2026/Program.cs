using System;
using System.Collections.Generic;
using ConsoleApp_07_09_2026;

class Program
{
    
    // 2.- Lista de usuarios registrados
    static List<Usuario> listaUsuarios = new List<Usuario>
    {
        new Usuario("ana", "1234", new List<string> { "admin", "usuario" }),
        new Usuario("luis", "admin123", new List<string> { "admin", "invitado" }),
        new Usuario("maria", "maria2024", new List<string> { "usuario" }),
        new Usuario("pedro", "pedropass", new List<string> { "usuario", "invitado" })
    };

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
                    MostrarPermisos(usuarioAutenticado.Nombre, rolIngresado);
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
        Usuario usuarioEncontrado = listaUsuarios.Find(u => u.Nombre == nombre && u.Password == password);

        if (usuarioEncontrado != null && usuarioEncontrado.RolesAsignados.Contains(rol))
        {
            return usuarioEncontrado;
        }

        return null;
    }

    // Muestra las acciones permitidas por usuario y rol
    static void MostrarPermisos(string usuario, string rol)
    {
        switch (usuario)
        {
            case "ana":
                if (rol == "admin")
                    Console.WriteLine("Permisos: Ana tiene acceso completo al sistema.");
                else if (rol == "usuario")
                    Console.WriteLine("Permisos: Ana tiene acceso limitado.");
                break;

            case "luis":
                if (rol == "admin")
                    Console.WriteLine("Permisos: Luis puede administrar el sistema.");
                else if (rol == "invitado")
                    Console.WriteLine("Permisos: Luis solo puede leer información.");
                break;

            case "maria":
                if (rol == "usuario")
                    Console.WriteLine("Permisos: María puede consultar y modificar datos.");
                break;

            case "pedro":
                if (rol == "usuario")
                    Console.WriteLine("Permisos: Pedro tiene acceso limitado.");
                else if (rol == "invitado")
                    Console.WriteLine("Permisos: Pedro solo puede leer.");
                break;

            default:
                Console.WriteLine("Permisos: Usuario no reconocido.");
                break;
        }
    }
}