using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autenticacion
{
    public class RepositorioUsuario
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>
    {
        new Usuario("ana", "1234", new List<string> { "admin", "usuario" }),
        new Usuario("luis", "admin123", new List<string> { "admin", "invitado" }),
        new Usuario("maria", "maria2024", new List<string> { "usuario" }),
        new Usuario("pedro", "pedropass", new List<string> { "usuario", "invitado" })
    };

    }
}
