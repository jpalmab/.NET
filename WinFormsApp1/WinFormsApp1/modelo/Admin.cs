using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Admin
    {
        // ---------------------
        // Atributos
        // ---------------------

        private int idAdmin;

        private int cedula;

        private String usuario;

        private String clave;

        // ---------------------
        // Métodos (Get and Set de cada atributo)
        // ---------------------
        public int getCedula()
        {
            return cedula;
        }

        public int getIdAdmin()
        {
            return idAdmin;
        }

        public void setIdAdmin(int pIdAdmin)
        {
            idAdmin = pIdAdmin;
        }

        public void setCedula(int pCedula)
        {
            cedula = pCedula;
        }

        public String getUSuario()
        {
            return usuario;
        }

        public void setUsuario(String pUsuario)
        {
            usuario = pUsuario;
        }

        public String getClave()
        {
            return clave;
        }

        public void setClave(String pClave)
        {
            clave = pClave;
        }

    }
}
