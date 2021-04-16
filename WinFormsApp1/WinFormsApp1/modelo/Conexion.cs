using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    class Conexion
    {
        // -------------------
        // Métodos
        // -------------------

        //Retorna la conexión a la base de datos en SQL-SERVER
        public SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH5025R;Initial Catalog=admin;Integrated Security=True");

            return con;
        }
    }
}
