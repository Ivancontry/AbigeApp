using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmGestionUsuarios : Form
    {
        ServiciosUsuario serviciosUsuario = new ServiciosUsuario();
        Usuarios usuarioSesion;
        ContextMenuStrip blankContextMenu = new ContextMenuStrip();
        public frmGestionUsuarios()
        {
            InitializeComponent();            
          
        }
        public frmGestionUsuarios(Usuarios usuario)
        {
            InitializeComponent();
            this.usuarioSesion = usuario;            
  
        }
        private void validarSoloNumeros(KeyPressEventArgs e) {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void noPegar(KeyEventArgs e) {
            if (e.Control == true)
            {
                MessageBox.Show("No se puede Pegar");
            }
        }
        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {
            quitarMenuClickDerecho();
            buscarUsuaruio();

        }
        private void quitarMenuClickDerecho() {
            txtIdentificacion.ContextMenuStrip = blankContextMenu;
            txtTelefono.ContextMenuStrip = blankContextMenu;
        }

        public int validarCedula()
        {
            if (txtIdentificacion.Text.Length > 20 || txtIdentificacion.Text == "")
            {
                return -1;
            }
            return 1;
        }

        public int validarNombre()
        {
            if (txtNombre.Text.Length > 30 || txtNombre.Text == "")
            {
                return -1;
            }
            return 1;
        }
        public int validarPrimerApellido()
        {
            if (txtPrimerApellido.Text.Length > 20 || txtPrimerApellido.Text == "")
            {
                return -1;
            }
            return 1;
        }

        public int validarTelefono()
        {
            if (txtTelefono.Text.Length > 20 || txtTelefono.Text == "")
            {
                return -1;
            }
            return 1;
        }

        public int validarEmail()
        {
            if (txtEmail.Text.Length > 45 || txtEmail.Text == "")
            {
                return -1;
            }
            return 1;
        }

        public int validarSegundoApellido()
        {
            if (txtSegundoApellido.Text.Length > 20 || txtSegundoApellido.Text == "")
            {
                return -1;
            }
            return 1;
        }

        public int validarDireccion()
        {
            if (txtDireccion.Text.Length > 50 || txtDireccion.Text == "")
            {
                return -1;
            }
            return 1;
        }
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        private void selecionarcomboBox(ComboBox combo, String opcion)
        {
            combo.SelectedIndex = combo.FindString(opcion);
        }
        public void buscarUsuaruio() {
            Usuarios usuario1 = new Usuarios();
            usuario1 = Usuario.usuario;
            if (usuario1 == null)
            {
                MessageBox.Show("La identificacion no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtIdentificacion.Text = usuario1.Identificacion;
                txtContraseña.Text = usuario1.Clave;
                txtIdentificacion.Enabled = false;
                txtDireccion.Text = usuario1.Direccion;
                txtEmail.Text = usuario1.Email;
                txtNombre.Text = usuario1.Nombres;
                txtPrimerApellido.Text = usuario1.PrimerApellido;
                txtSegundoApellido.Text = usuario1.SegundoApellido;
                txtTelefono.Text = usuario1.Telefono;
                txtRepetirPassword.Text = usuario1.Clave;

                txtContraseña.isPassword = true;
                txtRepetirPassword.isPassword = true;

                if (usuario1.Estado == 'A')
                {
                    ckbEstado.Checked = true;
                }
                else
                    ckbEstado.Checked = false;

                txtIdentificacion.Enabled = false;
          
            }

        }
        private void btnBuscarIdentificacion_Click_1(object sender, EventArgs e)
        {
            
        }
        private void limpiarCampos(GroupBox groupBox)
        {
            errorContraseñas.Clear();
            errorProvider1.Clear();
            txtIdentificacion.Text = "";
            foreach (Control c in groupBox.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    c.Text = "";
                }
                else
                {
                    if (c is ComboBox)
                    {
                        var tmp = c as ComboBox;
                        selecionarcomboBox(tmp, "Selecione Rol");
                    }
                    else
                    {
                        if (c is Bunifu.Framework.UI.BunifuCheckbox)
                        {
                            var tmp = c as Bunifu.Framework.UI.BunifuCheckbox;
                            tmp.Checked = false;
                        }
                    }
                }
            }
        }

        private void btnRegistrar_Click_2(object sender, EventArgs e)
        {
            registrarOActualizarEmpleado();
        }

        private void txtIdentificacion_KeyDown_1(object sender, KeyEventArgs e)
        {
            noPegar(e);
        }

        private void txtIdentificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtTelefono_KeyDown_1(object sender, KeyEventArgs e)
        {
            noPegar(e);
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos(groupBox1);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                if (!IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Digite un email valido");
                }
            }
        }
        public void registrarOActualizarEmpleado()
        {
            Usuarios usuario = new Usuarios();
            usuario = Usuario.usuario;
            if (ckbEstado.Checked == true)
            {
                usuario.Estado = 'A';
            }
            else
            {
                usuario.Estado = 'I';
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Debe ingresar un correo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txtContraseña.Text != txtRepetirPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String mensaje="";
            if (validarCedula()==1 && validarDireccion()==1 && validarEmail()==1 && validarNombre()==1 &&
                validarPrimerApellido()==1 && validarSegundoApellido()==1 && validarTelefono()==1)
            {
                mensaje = serviciosUsuario.GuardarUsuarios(usuario);
            }
           

            if (mensaje == "exito")
            {
                MessageBox.Show("Proceso realizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
                limpiarCampos(groupBox1);
        
                txtIdentificacion.Enabled = true;
                txtIdentificacion.Text = "";
            }
            else if (mensaje == "Error")
            {
                MessageBox.Show("Disculpe las molestias ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(mensaje, "Error al digitar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            registrarOActualizarEmpleado();
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            errorContraseñas.Clear();
            if (txtContraseña.Text != txtRepetirPassword.Text)
            {
                errorContraseñas.SetError(txtRepetirPassword,"Las contraseñas no coinciden");
            }
        }

        private void txtDireccion_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ckbEstado_OnChange(object sender, EventArgs e)
        {

        }
    }
}
