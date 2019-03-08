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
    public partial class RegistrarMantenimiento : Form
    {
        public RegistrarMantenimiento()
        {
            InitializeComponent();
        }
        ServiciosMantenimientos logicaMantenimientos = new ServiciosMantenimientos();
        Mantenimientos mantenimientos = new Mantenimientos();
        int cont = 0;
        Regex alfanumerica = new Regex(@"^[a-zA-Z0-9\s,]*$");
        Regex soloNombres = new Regex(@"^[a-zA-Z0-9\s,]*$\s*");
        string valor = "", valorNombre = "";
        private void RegistrarMantenimiento_Load(object sender, EventArgs e)
        {
            bnfRegistrar.Enabled = false;
            bnfActualizar.Enabled = false;
            fecha.Enabled = false;
            cbxEstadoMantenimiento.SelectedIndex = 0;

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
            if (txtCodigoDispositivo.Text.Equals("") || txtCodigoDispositivo.Text.Length>20 || txtCodigoDispositivo.Text.Length < 5) {
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
                mantenimientos.IdDispositivo = txtCodigoDispositivo.Text;
                mantenimientos.Descripcion = txtDescripcion.Text;
                mantenimientos.Fecha = fecha.Value.Date;
                mantenimientos.EstadoMantenimiento =char.Parse(cbxEstadoMantenimiento.SelectedIndex.ToString());
                if (soloNombres.IsMatch(txtDescripcion.Text))
                {
                    if (logicaMantenimientos.registraMantenimiento(mantenimientos) == 1)
                    {
                        MessageBox.Show("Operacion Existosa");
                        estadoCamposInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Operacion");
                    }

                }
                else
                {
                    MessageBox.Show("Solo valores frases de letras y numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epDescripcion.SetError(txtDescripcion,"Solo valores frases de letras y numeros");
                }
            }
        }

      
        private void bnfActualizar_Click(object sender, EventArgs e)
        {
            if (soloNombres.IsMatch(txtDescripcion.Text))
            {
                if (validarDescripcion() == 1)
                {
                    mantenimientos.IdDispositivo = txtCodigoDispositivo.Text;
                    mantenimientos.Descripcion = txtDescripcion.Text;
                    mantenimientos.Fecha = DateTime.Now;
                    mantenimientos.EstadoMantenimiento = char.Parse(cbxEstadoMantenimiento.SelectedIndex.ToString());

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
            else
                {
                    MessageBox.Show("Solo valores frases de letras y numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epDescripcion.SetError(txtDescripcion, "Solo valores frases de letras y numeros");
            }

        }

        private void bnfLimpiar_Click(object sender, EventArgs e)
        {
            estadoCamposInicial();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            //if (soloNombres.IsMatch(txtDescripcion.Text))
            //{
            //    valorNombre = txtDescripcion.Text;
            //}
            //else
            //{
                
            //    MessageBox.Show("Solo valores letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDescripcion.Text = valorNombre;
            //}
        }

        private void txtCodigoDispositivo_OnValueChanged(object sender, EventArgs e)
        {

            if (alfanumerica.IsMatch(txtCodigoDispositivo.Text))
            {
                valor = txtCodigoDispositivo.Text;
            }
            else
            {
                txtCodigoDispositivo.Text = valor;
                epIdDispositivo.SetError( txtCodigoDispositivo,"Solo valores alfanumericos");
                MessageBox.Show("Solo valores alfanumericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
