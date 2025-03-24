using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGLES_PLATAFORMA.Model
{
    internal class Usuario
    {
        private string email;
        private string contraseña;

        public Usuario(string email, string contraseña)
        {
            this.Email = email;
            this.Contraseña = contraseña;
        }

        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
