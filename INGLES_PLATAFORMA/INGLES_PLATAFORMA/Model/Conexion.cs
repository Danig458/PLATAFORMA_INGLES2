using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INGLES_PLATAFORMA.Model
{
    internal class Conexion
    {
        private string connectionString = "Data Source=vivobookdaniela\\SQLEXPRESS;integrated security=true;database=EnglishFly_DB";
        public SqlConnection AbrirConexion()

        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {

                MessageBox.Show("Conectado: " + con.ConnectionString);
                return con;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexion" + ex.Message);
                return null;
            }

        }
    }
}
