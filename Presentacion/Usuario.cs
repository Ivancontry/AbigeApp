using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        public static Usuarios usuario = new Usuarios();
        ServiciosUsuario serviciosUsuario = new ServiciosUsuario();
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        public int validarEmail()
        {
            if (txtUsuario.Text.Length > 60 || txtUsuario.Text == "" || txtUsuario.Text.Length<15)
            {
                return -1;
            }
            return 1;
        }
        public int validarContraseña()
        {
            if (txtContraseña.Text.Length > 20 || txtContraseña.Text == "" || txtUsuario.Text.Length<6)
            {
                return -1;
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            usuario = serviciosUsuario.buscarPorCorreo(txtUsuario.Text);
            if (usuario == null)
            {
                epUsuario.SetError(txtUsuario, "usuario no existe");
            }
            else {
                if (IsValidEmail(txtUsuario.Text))
                {
                    if (validarContraseña() == 1 && validarEmail() == 1)
                    {
                        if (txtContraseña.Text.Equals(usuario.Clave))
                        {
                            this.Hide();
                            
                               Principal principal = new Principal();
                               principal.Show();
                            
                            
                        }
                        else
                        {
                            epContraseña.SetError(txtContraseña, "Contraseña invalida");

                        }

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
        }

       

    }
}
