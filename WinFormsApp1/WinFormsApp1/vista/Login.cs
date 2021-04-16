using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        // -------------
        // Relación
        // -------------
        Conexion c = new Conexion();


        public Login()
        {
            InitializeComponent();
        }


        // ------------------
        // Métodos
        // ------------------


        private void bEntrar_Click(object sender, EventArgs e)
        {
            //Creo un objeto para almacenar la conexión con la base de datos y procedo a abrir la conexión
            SqlConnection con = c.getConexion();
            con.Open();

            //Guardo en variables lo escrito en los campos de cada textBox
            String usuario = tUsuarioLogin.Text.Trim();
            String clave = tClaveLogin.Text.Trim();

            //Verifico que se haya escrito en los campos
            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Complete los campos");
            }
            //Si hay texto, procedo a verificar si los datos ingresados corresponden a algún administrador para
            //acceder al sistema
            else
            {
                String sentencia = "SELECT usuario, contrasenia from admin where usuario = '" + usuario + "' AND contrasenia = '" + clave + "' ";

                SqlCommand cmd = new SqlCommand(sentencia, con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //Si los datos corresponden envía mensaje de alerta y oculta el formulario actual
                    Form1 f1 = new Form1();
                    this.Hide();
                    MessageBox.Show("Bienvenido Administrador");

                    f1.StartPosition = FormStartPosition.CenterParent;
                    f1.Show();

                }
                //Si los datos no corresponde envía mensaje de alerta
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }

            con.Close();
        }
    }
}
