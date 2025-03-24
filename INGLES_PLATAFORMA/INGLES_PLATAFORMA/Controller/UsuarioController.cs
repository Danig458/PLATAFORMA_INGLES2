using INGLES_PLATAFORMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGLES_PLATAFORMA.Controller
{
    class UsuarioController
    {
        private Usuario gestionUsuario;

        public UsuarioController(string email, string contraseña)
        {
            this.gestionUsuario = new Usuario(email,contraseña);
        }

        public bool ValidarUsuario()
        {
            return GestorUsuario.VerificarUsuario(gestionUsuario) ? true : false;
        }
    }
}
