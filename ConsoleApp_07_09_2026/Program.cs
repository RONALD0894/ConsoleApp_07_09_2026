using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== validación de accesos ===");

        Console.Write("ingrese el nombre del usuario ana , luis , maria , pedro , otro :\n ");
        string usuario = Console.ReadLine();

        Console.Write("ingrese el rol del usuario admin, usuario, invitado, otro :\n ");
        string rol = Console.ReadLine();

        /*valida el usuario y luego valida el rol*/
        switch (usuario)
        {
            case "ana":
                if (rol == "admin")
                    Console.WriteLine("ana tiene acceso completo al sistema.");
                else if (rol == "usuario")
                    Console.WriteLine("ana tiene acceso limitado.");
                else
                    Console.WriteLine("rol no válido para ana.");
                break;

            case "luis":
                if (rol == "admin")
                    Console.WriteLine("luis puede administrar el sistema.");
                else if (rol == "invitado")
                    Console.WriteLine("luis solo puede leer información.");
                else
                    Console.WriteLine("rol no válido para luis.");
                break;

            case "maria":
                if (rol == "usuario")
                    Console.WriteLine("maria puede consultar y modificar datos.");
                else
                    Console.WriteLine("rol no válido para maria.");
                break;

            case "pedro":
                if (rol == "usuario")
                    Console.WriteLine("pedro tiene acceso limitado.");
                else if (rol == "invitado")
                    Console.WriteLine("pedro solo puede leer.");
                else
                    Console.WriteLine("rol no válido para pedro.");
                break;

            default:
                Console.WriteLine("usuario no reconocido. acceso denegado.");
                break;
        }

        Console.WriteLine("\nvalidación finalizada.");

        // Espera para que el usuario vea el resultado
        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();
    }
}





