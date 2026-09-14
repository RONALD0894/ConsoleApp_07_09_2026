using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Sistema_de_Autenticacion
{
    public class Usuario
    {
            public string Nombre { get; set; }
            public string PasswordHash { get; set; }
            public List<string> RolesAsignados { get; set; }

            public Usuario(string nombre, string password, List<string> roles)
            {
                Nombre = nombre;
                PasswordHash = Seguridad.GenerarHash(password);
                RolesAsignados = roles;
            }
        
    }
}
