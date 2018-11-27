using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Logica;

namespace Presentacion
{
    public partial class ConsultarDispositivoEnMantenimiento : Form
    {
        public ConsultarDispositivoEnMantenimiento()
        {
            InitializeComponent();
        }
        ServiciosMantenimientos logicaMantenimientos = new ServiciosMantenimientos();
        int cont = 0;
        public int validarIdDispositivo()
        {

            epIdDispositivo.Clear();
            if (txtCodigoDispositivo.Text.Equals("") || txtCodigoDispositivo.Text.Length > 20)
            {
                epIdDispositivo.SetError(txtCodigoDispositivo, "Digite un Dispositivo Valido");
                return -1;
            };
            return 1;
        }
        public void cargarTablaGrafica(string codigo)
        {
            DataTable tablaGrafica = new DataTable();
            tablaGrafica = logicaMantenimientos.buscarHistorialDispositvoMantenimiento(codigo);
            cargarGrafica(tablaGrafica);
        }
        public string convertirEstadoDispositivo( string estadoDispositivo) {
            switch (int.Parse(estadoDispositivo)) {
                case 0: return "En Espera";
                case 1: return "Funcionando"; 
                case 2: return "Dañado";
            }
            return "";
        }
        public void estadoCombobox()
        {

            if (cbxEstadoMantenimiento.SelectedIndex == 0 || cbxEstadoMantenimiento.SelectedIndex == 1)
            {
                cbxEstadoDispositivo.Enabled = false;

                if (cont > 0)
                {
                    cbxEstadoDispositivo.Items.Insert(0, "En espera");
                    cont = 0;
                }
                cbxEstadoDispositivo.SelectedIndex = 0;
            }
            else
            {
                cont++;
                cbxEstadoDispositivo.Items.RemoveAt(0);
                cbxEstadoDispositivo.SelectedIndex = 0;
            }


        }


        public void cargarGrafica(DataTable tabla)
        {
            int contDañados = 0, contAveriadosFincas = 0, contAveriadosTaller = 0, contFuncionando = 0, contGeneral=0;
            figura.Series.Clear();
            //figura.DataSource = tabla;            
            Series s1 = figura.Series.Add("PendienteFinca");
            Series s2 = figura.Series.Add("EnviadoTaller");
            Series s3 = figura.Series.Add("RevisadoFuncionando");
            Series s4 = figura.Series.Add("RevisadoDañado");
            s1.Color = System.Drawing.Color.Yellow;
            s2.Color = System.Drawing.Color.Orange;
            s3.Color = System.Drawing.Color.Green;
            s4.Color = System.Drawing.Color.Red;
            s1.ChartArea = "ChartArea1";
            foreach (DataRow fila in tabla.Rows)
            {
                if (fila["estadoActual"].ToString().Equals("A")) { contGeneral++; }
                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 0 && int.Parse(fila["estadoDispositivo"].ToString()) == 0)
                {
                    s1.Points.AddXY ("",fila["fecha"]);
                    contAveriadosFincas++;
                }
                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 1 && int.Parse(fila["estadoDispositivo"].ToString()) == 0)
                {
                    s2.Points.AddXY("", fila["fecha"]);
                    contAveriadosTaller++;
                }

                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 2 && int.Parse(fila["estadoDispositivo"].ToString()) == 1)
                {
                    s3.Points.AddXY("", fila["fecha"]);
                    contFuncionando++;
                }
                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 2 && int.Parse(fila["estadoDispositivo"].ToString()) == 2)
                {
                    s4.Points.AddXY("", fila["fecha"]);
                    contDañados++; 
                }
            }
            figura.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            figura.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            figura.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            figura.ChartAreas["ChartArea1"].AxisX.Title = "";
            figura.ChartAreas["ChartArea1"].AxisY.Title = "fecha del mantenimiento";
            labelAveridadoFinca.Text = contAveriadosFincas.ToString();
            labelAveriadoTaller.Text = contAveriadosTaller.ToString();
            labelFuncionando.Text = contFuncionando.ToString();
            labelDañado.Text = contDañados.ToString();
            labelGeneral.Text = contGeneral.ToString();

        }
        private void bnfBuscar_Click(object sender, EventArgs e)
        {

            DataTable mantenimientos = new DataTable();
          
            if(validarIdDispositivo() == 1)
            {
                mantenimientos = logicaMantenimientos.buscarDispositvoMantenientos(txtCodigoDispositivo.Text);
                if (mantenimientos.Rows.Count > 0)
                {
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
                            else
                            {
                                cbxEstadoDispositivo.SelectedIndex = int.Parse(mantenimientos.Rows[0]["estadoDispositivo"].ToString());
                            }

                        }

                        DateTime data;
                        data = DateTime.ParseExact(mantenimientos.Rows[0]["fecha"].ToString().Substring(0, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        fecha.Value = data;
                        cargarTablaGrafica(txtCodigoDispositivo.Text);
                        
                    
                }
                else
                {                   
                        epIdDispositivo.Clear();
                        MessageBox.Show("Dispositivo no ha sido llevado a mantenimiento");
                }
            }


        }
        
        private void cbxEstadoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoCombobox();
        }

        private void ConsultarDispositivoEnMantenimiento_Load(object sender, EventArgs e)
        {
            cbxEstadoMantenimiento.SelectedIndex = 0;
            cbxEstadoDispositivo.SelectedIndex = 0;
            txtDescripcion.Enabled = false;
            fecha.Enabled = false;
            cbxEstadoMantenimiento.Enabled = false;
            fecha.Enabled = false;
            cbxEstadoDispositivo.Enabled = false;
            estadoCombobox();

        }

        private void txtCodigoDispositivo_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDispositivo.Text == "")
            {
                txtCodigoDispositivo.Text = "Codigo del Dispositivo";
            }
        }

    }
}
