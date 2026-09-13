using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_07_09_2026
{
    public class Usuario
    {
            public string Nombre { get; set; }
            public string Password { get; set; }
            public List<string> RolesAsignados { get; set; }

            public Usuario(string nombre, string password, List<string> roles)
            {
                Nombre = nombre;
                Password = password;
                RolesAsignados = roles;
            }
        
    }
}
