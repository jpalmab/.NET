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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm 
    {
        // -------------------------------
        // Relaciones con las clases
        // -------------------------------

        Conexion conexion = new Conexion();
        Admin admin = new Admin();

       
        // --------------------
        // Métodos
        // --------------------

        public Form1() 
        {
            InitializeComponent();
        }



        private void bAgregar_Click(object sender, EventArgs e)
        {
            //Creo un objeto en donde guardo los datos de la conexión a la base de datos
            SqlConnection con = conexion.getConexion();
            con.Open();

            //Verifico que los campos ingresados no estén vacios
            if (tCedula.Text == "" || tUsuario.Text == "" || tClave.Text == "")
            {
                //Si los campos están vacios, me manda una alerta
                MessageBox.Show("Escriba en todos los campos");

            }
            //Si los campos no están vacios, procede a agregar el administrador
            else
            {

                //Guardo en variables lo escrito en los diversos textBox
                int cedulaIngresada = int.Parse(tCedula.Text);
                String usuarioIngresado = tUsuario.Text.Trim();
                String contraseniaIngresado = tClave.Text.Trim();

                //Hago uso de la programación orientada a objetos
                admin.setCedula(cedulaIngresada);
                admin.setUsuario(usuarioIngresado);
                admin.setClave(contraseniaIngresado);


                //Verifico que el usuario que se intenta registrar, no exísta en la base de datos
                String conUsuario = "SELECT usuario, contrasenia from admin where usuario = '" + usuarioIngresado + "' ";
                SqlCommand cmd = new SqlCommand(conUsuario, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    MessageBox.Show("Ya exíste ese usuario");

                }
                //Si el usuario no exíste, que me agregue al nuevo usuario
                else
                {
                    SqlConnection con2 = conexion.getConexion();
                    con2.Open();
                    //Inserto el dato en la base de datos
                    String sql = "insert into admin (cedula, usuario, contrasenia) values ('" + admin.getCedula() + "', '" + admin.getUSuario() + "', '" + admin.getClave() + "')";

                    //Ejecuto la sentencia sql
                    SqlCommand comando2 = new SqlCommand(sql, con2);
                    comando2.ExecuteNonQuery();

                    //Mensaje alusivo a la carga correcta de los datos
                    MessageBox.Show("Los datos se guardaron correctamente");

                    //Actualizo los datos
                    listarDatos();

                    con2.Close();
                }

            }
            //Finalizo la conexión con la base de datos
            con.Close();
        }


        /**
        * Permite modificar los datos de un administrador, esto al presionar el botón respectivo
        */
        private void bModificar_Click(object sender, EventArgs e)
        {
            //Creo un objeto en donde guardo los datos de la conexión a la base de datos
            SqlConnection con = conexion.getConexion();
            //Abro la conexión
            con.Open();

            //Verifico que los campos ingresados no estén vacios
            if (tCedula.Text == "" || tUsuario.Text == "" || tClave.Text == "")
            {
                //Si los campos están vacios, me manda una alerta
                MessageBox.Show("Escriba en todos los campos");
            }

            //Si los campos no están vacios, procede a agregar el administrador
            else
            {
                //Guardo en variables lo escrito en los diversos textBox
                int idAdminIngresado = int.Parse(tIdAdmin.Text);
                int cedulaIngresada = int.Parse(tCedula.Text);
                String usuarioIngresado = tUsuario.Text.Trim();
                String contraseniaIngresado = tClave.Text.Trim();

                //Hago uso de la programación orientada a objetos
                admin.setIdAdmin(idAdminIngresado);
                admin.setCedula(cedulaIngresada);
                admin.setUsuario(usuarioIngresado);
                admin.setClave(contraseniaIngresado);

                //Modifico el dato en la base de datos
                String sentencia = "UPDATE admin set cedula = '" + admin.getCedula() + "', usuario = '" + admin.getUSuario() + "', contrasenia = '" + admin.getClave() + "' where idAdmin = '" + admin.getIdAdmin() + "' ";

                //Ejecuto la sentencia sql
                SqlCommand comando = new SqlCommand(sentencia, con);
                comando.ExecuteNonQuery();

                //Mensaje de satisfacción
                MessageBox.Show("Los datos se modificaron correctamente");

                //Actualizo los datos
                listarDatos();

            }
            //Finalizo la conexión con la base de datos
            con.Close();
        }


        /**
         * Permite eliminar un administrador por su código, esto al presionar el botón respectivo
         */
        private void bEliminar_Click(object sender, EventArgs e)
        {
            //Creo una variable para almacenar la conexión con la base de datos
            SqlConnection con = conexion.getConexion();
            con.Open();

            //Verifico que en el campo haya texto
            if (tIdAdmin.Text == "")
            {
                MessageBox.Show("Escriba el código del administrador a eliminar");
            }
            //Si hay texto, procede
            else
            {
                //Almaceno lo escrito en el textBox y lo guardo en una variable
                int idAdminIngresado = int.Parse(tIdAdmin.Text);
                //Procedo a aplicar la programación orientada a objetos
                admin.setIdAdmin(idAdminIngresado);

                //Sentencia sql que permite eliminar un administrador por su idAdmin
                String sentencia = "delete from admin where idAdmin = '" + admin.getIdAdmin() + "' ";

                //Ejecuto la sentencia SQL
                SqlCommand comando = new SqlCommand(sentencia, con);
                comando.ExecuteNonQuery();

                //Mensaje de satisfacción
                MessageBox.Show("Se eliminó el registro correctamente");

                //Actualizo los datos
                listarDatos();

            }
            //Finalizo la conexión
            con.Close();
        }

        private void bRefrescar_Click_1(object sender, EventArgs e)
        {
            listarDatos();
        }

        /**
        * Llama al método listarDatos()
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            listarDatos();
        }


        /**
         * Permite listar los datos un administrador
         */
        public void listarDatos()
        {
            //Creo una variable para almacenar la conexión con la base de datos
            SqlConnection con = conexion.getConexion();
            con.Open();

            //Sentencia sql que permite consultar todos los administradores que hay
            String sentencia = "select * from admin";

            //Ejecuto la sentencia SQL y la muestro en el form1
            SqlCommand comando = new SqlCommand(sentencia, con);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Finalizo la conexión con la base de datos
            con.Close();
        }
    }
}
