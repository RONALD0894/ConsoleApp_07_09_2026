//double CalcularIGV(double precio)
//{
//    return precio * 0.18;
//}

//double resultadoIGV = CalcularIGV(100) + 100;



//string ObtenerNombreUsuario()
//{
//    Console.WriteLine("Ingrese su nombre de usuario:");
//    string nombreUsuario = Console.ReadLine();
//    return nombreUsuario;
//}
//string resultadoConcatenacion = ObtenerNombreUsuario() + " - Usuario registrado";




//void MostrarUsuarioRegistrado(string nombreUsuario = "Guest")
//{
//    Console.WriteLine($"Usuario registrado: {nombreUsuario}");
//}

//do
//{
//    Console.WriteLine("Ingrese su nombre de usuario (o 'SALIR' para terminar):");
//    string nombreUsuario = Console.ReadLine();
//    if (nombreUsuario.ToUpper() == "SALIR")
//    {
//        break;
//    }
//    MostrarUsuarioRegistrado(nombreUsuario);
//} while (true);





//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("=== Validación de Accesos ===");

//        Console.Write("Ingrese el nombre del usuario Ana , Luis , Maria , Pedro , Otro :\n ");
//        string usuario = Console.ReadLine();

//        Console.Write("Ingrese el rol del usuario Admin, Usuario, Invitado, Otro :\n ");
//        string rol = Console.ReadLine();

//        /*valida el usuario y luego valida el rol*/
//        switch (usuario)
//        {
//            case "Ana":
//                if (rol == "Admin")
//                    Console.WriteLine("Ana tiene acceso completo al sistema.");
//                else if (rol == "Usuario")
//                    Console.WriteLine("Ana tiene acceso limitado.");
//                else
//                    Console.WriteLine("Rol no válido para Ana.");
//                break;

//            case "Luis":
//                if (rol == "Admin")
//                    Console.WriteLine("Luis puede administrar el sistema.");
//                else if (rol == "Invitado")
//                    Console.WriteLine("Luis solo puede leer información.");
//                else
//                    Console.WriteLine("Rol no válido para Luis.");
//                break;

//            case "Maria":
//                if (rol == "Usuario")
//                    Console.WriteLine("Maria puede consultar y modificar datos.");
//                else
//                    Console.WriteLine("Rol no válido para Maria.");
//                break;

//            case "Pedro":
//                if (rol == "Usuario")
//                    Console.WriteLine("Pedro tiene acceso limitado.");
//                else if (rol == "Invitado")
//                    Console.WriteLine("Pedro solo puede leer.");
//                else
//                    Console.WriteLine("Rol no válido para Pedro.");
//                break;

//            default:
//                Console.WriteLine("Usuario no reconocido. Acceso denegado.");
//                break;
//        }

//        Console.WriteLine("\nValidación finalizada.");
//    }
//}





//using System;

//// Programa que recibe nombre y edad como parámetros de entrada (o usa valores por defecto)
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Valores por defecto proporcionados por el usuario
//        string nombre = "ronald alarcon perales";
//        int edad = 32;

//        // Si se pasan argumentos por línea de comandos, los usamos
//        if (args.Length >= 1 && !string.IsNullOrWhiteSpace(args[0]))
//        {
//            nombre = args[0];
//        }
//        if (args.Length >= 2 && int.TryParse(args[1], out int parsedEdad))
//        {
//            edad = parsedEdad;
//        }

//        Console.WriteLine($"Hola {nombre}, edad: {edad}");

//        // Solicitar número al usuario
//        Console.Write("Escribe el numero: ");
//        string input = Console.ReadLine();

//        if (!int.TryParse(input, out int numero))
//        {
//            Console.WriteLine("Entrada no válida. Usando 0 por defecto.");
//            numero = 0;
//        }

//        numero += 5; // Incrementa el valor de numero en 5

//        int numero2 = numero + 10 * (6 - 15);

//        // Datos decimales
//        decimal resultado = numero2 / 3.0m;
//        float resultado2 = -numero2 / 3.0f; // cociente
//        double resultado3 = numero2 % 3.0; // residuo

//        // Determinar si un valor es par o impar
//        bool resultadoBool = numero % 2 == 0; // true si es par
//        bool resultadoBool2 = numero != 0;
//        bool numero2Bool = numero2 < 5;
//        bool numero3Bool = numero2 > 5;
//        bool numero4Bool = numero2 <= 5;
//        bool numero5Bool = numero2 >= 5;

//        // Tipos de variables adicionales
//        var resultado4 = numero2 / 3.0; // implicitly typed
//        dynamic resultado5 = numero2 / 3.0; // dynamic
//        resultado5 = "Este es un ejemplo de variable dinámica";

//        Console.WriteLine("El numero total: " + numero2);
//        Console.WriteLine("El resultado (decimal): " + resultado);
//        Console.WriteLine("El resultado2 (float): " + resultado2);
//        Console.WriteLine("El resultado3 (residuo double): " + resultado3);
//        Console.WriteLine("¿El número es par?: " + resultadoBool);
//        Console.WriteLine("¿El número es distinto de 0?: " + resultadoBool2);

//        Console.WriteLine("(Valores comparativos sobre numero2):");
//        //////Console.WriteLine("numero2 < 5: " + numero2Bool);
//        //////Console.WriteLine("numero2 > 5: " + numero3Bool);
//        //////Console.WriteLine("numero2 <= 5: " + numero4Bool);
//        //////Console.WriteLine("numero2 >= 5: " + numero5Bool);

//        Console.WriteLine("Variable var resultado4: " + resultado4);
//        Console.WriteLine("Variable dynamic resultado5: " + resultado5);

//        Console.WriteLine("Presiona Enter para salir...");
//        Console.ReadLine();
//    }
//}
