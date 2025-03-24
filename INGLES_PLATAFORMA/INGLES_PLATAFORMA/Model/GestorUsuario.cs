using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGLES_PLATAFORMA.Model
{
    internal class GestorUsuario
    {
        public static Conexion enlaceBD;
        public static SqlConnection BD;

        public static bool VerificarUsuario(Usuario usuario)
        {
            bool esValido = false;
            enlaceBD = new Conexion();
            BD = enlaceBD.AbrirConexion();
            string query = "SELECT COUNT(*) FROM Usuario WHERE email = @Email AND contraseña = @Contraseña";
            SqlCommand command = new SqlCommand(query, BD);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            BD.Open();
            try
            {
                int count = (int)command.ExecuteScalar();
                esValido = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }

            return esValido;
        }
    }
}
 

