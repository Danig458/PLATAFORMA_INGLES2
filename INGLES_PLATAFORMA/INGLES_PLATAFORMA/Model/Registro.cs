using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGLES_PLATAFORMA.Model
{
    class Registro
    {
        private string nombre;
        private string apellidos;
        private string email;
        private string contraseña;

        public Registro(string nombre, string apellidos, string email, string contraseña)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Contraseña = contraseña;
        }

        public string Nombre { get =>  nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
