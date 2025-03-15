using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace INGLES_PLATAFORMA.Model
{
    internal class GestorRegistro
    {
        public static Conexion enlaceBD;
        public static SqlConnection BD;

        public static bool RegistrarUsuario(Registro nuevoRegistro)
        {
            enlaceBD = new Conexion();
            BD = enlaceBD.AbrirConexion();
            string query = "INSERT INTO Usuario (email, nombre, apellido, contraseña) VALUES (@Email, @Nombre, @Apellido, @Contraseña)";
            SqlCommand command = new SqlCommand(query, BD);
            command.Parameters.AddWithValue("@Email",nuevoRegistro.Email);
            command.Parameters.AddWithValue("@Nombre", nuevoRegistro.Nombre);
            command.Parameters.AddWithValue("@Apellido", nuevoRegistro.Apellidos);
            command.Parameters.AddWithValue("@Contraseña", nuevoRegistro.Contraseña);
            BD.Open();
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
