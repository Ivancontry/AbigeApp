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
    public partial class RegistrarMantenimiento : Form
    {
        public RegistrarMantenimiento()
        {
            InitializeComponent();
        }
        ServiciosMantenimientos logicaMantenimientos = new ServiciosMantenimientos();
        Mantenimientos mantenimientos = new Mantenimientos();
        int cont = 0;
        private void RegistrarMantenimiento_Load(object sender, EventArgs e)
        {
            bnfRegistrar.Enabled = false;
            bnfActualizar.Enabled = false;
            cbxEstadoMantenimiento.SelectedIndex = 0;
            cbxEstadoDispositivo.SelectedIndex = 0;
            estadoCombobox();

        }
        public void estadoCamposInicial() {
            txtCodigoDispositivo.Text = "";
            txtDescripcion.Text = "";
            fecha.Value = DateTime.Now;
            txtCodigoDispositivo.Enabled = true;
            txtDescripcion.Enabled = true;
            fecha.Enabled = true;
            cbxEstadoMantenimiento.SelectedIndex = 0;
            bnfActualizar.Enabled = false;
            bnfRegistrar.Enabled = false;
        }
        public int validarIdDispositivo() {
            
            epIdDispositivo.Clear();
            if (txtCodigoDispositivo.Text.Equals("") || txtCodigoDispositivo.Text.Length>20) {
                epIdDispositivo.SetError(txtCodigoDispositivo,"Digite un Dispositivo Valido");                
                return -1;
            };
            return 1;
        }
        public int validarDescripcion() {
            epDescripcion.Clear();
            if (txtDescripcion.Text.Equals("") || txtDescripcion.Text.Length > 200)
            {
                epDescripcion.SetError(txtDescripcion, "Por favor este campo no puede estar en blanco, ni exceder de los 250 caracteres");
                return -1;
            };
            return 1;
        }
        public void estadoCombobox() {
           
            if (cbxEstadoMantenimiento.SelectedIndex == 0 || cbxEstadoMantenimiento.SelectedIndex == 1)
            {
                cbxEstadoDispositivo.Enabled = false;              
                
                if (cont > 0) {
                    cbxEstadoDispositivo.Items.Insert(0, "En espera");
                    cont = 0;
                }
                cbxEstadoDispositivo.SelectedIndex = 0;
            }
            else
            {
                cont++;
                cbxEstadoDispositivo.Enabled = true;
                cbxEstadoDispositivo.Items.RemoveAt(0);
                cbxEstadoDispositivo.SelectedIndex = 0;
            }
            

        }

        private void bnfBuscar_Click(object sender, EventArgs e)
        {
            DataTable mantenimientos = new DataTable();
          
            if (validarIdDispositivo() == 1) {
                mantenimientos = logicaMantenimientos.buscarDispositvoMantenientos(txtCodigoDispositivo.Text);
                if (mantenimientos.Rows.Count > 0)
                {

                    bnfActualizar.Enabled = true;
                    bnfRegistrar.Enabled = false;
                    txtCodigoDispositivo.Enabled = false;
                    fecha.Enabled = false;
                    txtDescripcion.Text = mantenimientos.Rows[0]["descripcion"].ToString();
                    cbxEstadoMantenimiento.SelectedIndex = int.Parse(mantenimientos.Rows[0]["estadoMantenimiento"].ToString());
                   
                    if (cbxEstadoMantenimiento.SelectedIndex == 2 && int.Parse(mantenimientos.Rows[0]["estadoDispositivo"].ToString()) == 1)
                    {
                        cbxEstadoDispositivo.SelectedIndex = 0;
                    }
                    else
                    {
                        if (cbxEstadoMantenimiento.SelectedIndex == 2 && int.Parse(mantenimientos.Rows[0]["estadoDispositivo"].ToString()) == 2)
                        {
                            cbxEstadoDispositivo.SelectedIndex = 1;
                        }
                        else {
                            cbxEstadoDispositivo.SelectedIndex = int.Parse(mantenimientos.Rows[0]["estadoDispositivo"].ToString());
                        }
                        
                    }

                    DateTime data;
                        data= DateTime.ParseExact(mantenimientos.Rows[0]["fecha"].ToString().Substring(0,10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        fecha.Value = data;
                  
                      
                }
                else
                {
                    if (logicaMantenimientos.buscarDispositvo(txtCodigoDispositivo.Text).Rows.Count > 0)
                    {
                        bnfRegistrar.Enabled = true;
                        bnfActualizar.Enabled = false;

                    }
                    else {
                        epIdDispositivo.Clear();
                        MessageBox.Show("Dispositivo no existe");
                        epIdDispositivo.SetError(txtCodigoDispositivo, "Digite un Dispositivo que este registrado en el inventario");
                    }
                       
                }
            }
           
        }
        public char convertirEstadoDispositivo(char estMantenimiento, int estDispositivo) {
            if (estMantenimiento.Equals('2') && estDispositivo == 0)
            {
                return '1';
            }
            else
            {

                if (estMantenimiento.Equals('2') && estDispositivo == 1)
                {
                    return '2';
                }
                else
                {
                    return '0';
                }
            }

        }
        private void bnfRegistrar_Click(object sender, EventArgs e)
        {
            if (validarIdDispositivo() == 1 && validarDescripcion()==1  ) {
                mantenimientos.idDispositivo = txtCodigoDispositivo.Text;
                mantenimientos.descripcion = txtDescripcion.Text;
                mantenimientos.fecha = fecha.Value.Date;
                mantenimientos.estadoMantenimiento =char.Parse(cbxEstadoMantenimiento.SelectedIndex.ToString());
                mantenimientos.estadoDispositivo = convertirEstadoDispositivo(mantenimientos.estadoMantenimiento, cbxEstadoDispositivo.SelectedIndex);
               
                MessageBox.Show(mantenimientos.estadoDispositivo.ToString());
                if (logicaMantenimientos.registraMantenimiento(mantenimientos) == 1)
                {
                    MessageBox.Show("Operacion Existosa");
                    estadoCamposInicial();
                }
                else {
                    MessageBox.Show("Error en la Operacion");
                }
            }
        }

        private void cbxEstadoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoCombobox();
        }

        private void bnfActualizar_Click(object sender, EventArgs e)
        {
            if (validarDescripcion() == 1)
            {
                mantenimientos.idDispositivo = txtCodigoDispositivo.Text;
                mantenimientos.descripcion = txtDescripcion.Text;
                mantenimientos.fecha = DateTime.Now;
                mantenimientos.estadoMantenimiento = char.Parse(cbxEstadoMantenimiento.SelectedIndex.ToString());
                mantenimientos.estadoDispositivo = convertirEstadoDispositivo(mantenimientos.estadoMantenimiento, cbxEstadoDispositivo.SelectedIndex);
            
                if (logicaMantenimientos.actualizarMantenimiento(mantenimientos) == 1)
                {
                    MessageBox.Show("Operacion Existosa");
                    estadoCamposInicial();
                }
                else
                {
                    MessageBox.Show("Error en la Operacion");
                }
            }

        }

        private void bnfLimpiar_Click(object sender, EventArgs e)
        {
            estadoCamposInicial();
        }

        private void txtCodigoDispositivo_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDispositivo.Text == "")
            {
                //d
                txtCodigoDispositivo.Text = "Codigo del Dispositivo";
            }
        }

        private void txtCodigoDispositivo_Enter(object sender, EventArgs e)
        {

            if (txtCodigoDispositivo.Text == "Codigo del Dispositivo")
            {
                txtCodigoDispositivo.Text = "";
            }
        }

        private void cbxEstadoDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoDispositivo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
