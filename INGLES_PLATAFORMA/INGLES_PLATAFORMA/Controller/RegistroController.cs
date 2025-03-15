using INGLES_PLATAFORMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGLES_PLATAFORMA.Controller
{
    class RegistroController
    {
        private Registro gestionRegistro;

        public RegistroController(string nombre, string apellidos, string email, string contraseña)
        {
            this.gestionRegistro = new Registro(nombre, apellidos, email, contraseña);
        }

        public Boolean GuardarUsuario()
        {
            return (GestorRegistro.RegistrarUsuario(gestionRegistro)) ? true : false;
        }
    }
}
