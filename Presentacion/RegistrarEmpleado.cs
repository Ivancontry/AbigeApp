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



namespace Presentacion
{
    public partial class RegistrarEmpleado : Form
    {
        LogicaCliente logicaCliente = new LogicaCliente();
        Clientes clientes = new Clientes();
        ContextMenuStrip blankContextMenu = new ContextMenuStrip();
        public RegistrarEmpleado()
        {
            InitializeComponent();
        }



        private void validarSoloNumeros(KeyPressEventArgs e) {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
           
        }
        private void quitarMenuClickDerecho() {
            txtIdentificacion.ContextMenuStrip = blankContextMenu;
            txtTelefono.ContextMenuStrip = blankContextMenu;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clientes.identificacion = txtIdentificacion.Text;
            clientes.nombres = txtNombre.Text;
            clientes.primerApellido = txtPrimerApellido.Text;
            clientes.segundoApellido = txtSegundoApellido.Text;
            clientes.direccion = txtDireccion.Text;
            clientes.email = txtEmail.Text;
            clientes.clave = txtContraseña.Text;
            clientes.estado = char.Parse(txtEstado.Text);
            clientes.telefono = txtTelefono.Text;
            
            
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            noPegar(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            noPegar(e);
        }
    }
}
