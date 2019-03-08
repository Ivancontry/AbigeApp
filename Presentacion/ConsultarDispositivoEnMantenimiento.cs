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
        Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
        string valor = "", valor1 = "";
        public int validarIdDispositivo()
        {

            epIdDispositivo.Clear();
            if (txtCodigoDispositivo.Text.Equals("") || txtCodigoDispositivo.Text.Length > 20 || txtCodigoDispositivo.Text.Length<5)
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


        public void cargarGrafica(DataTable tabla)
        {
            int contDañados = 0, contFuncionando = 0, contGeneral=0;
            figura.Series.Clear();
            //figura.DataSource = tabla;            
         
            Series s3 = figura.Series.Add("RevisadoFuncionando");
            Series s4 = figura.Series.Add("RevisadoDañado");
          
            s3.Color = System.Drawing.Color.Green;
            s4.Color = System.Drawing.Color.Red;
            s3.ChartArea = "ChartArea1";
            foreach (DataRow fila in tabla.Rows)
            {
                       

                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 1)
                {
                    s3.Points.AddXY("", fila["fecha"]);
                    contFuncionando++;
                }
                if (int.Parse(fila["estadoMantenimiento"].ToString()) == 0)
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
            labelFuncionando.Text = contFuncionando.ToString();
            labelDañado.Text = contDañados.ToString();
            labelGeneral.Text = (contFuncionando+contDañados).ToString();

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
                        DateTime data;
                        data = DateTime.ParseExact(mantenimientos.Rows[0]["fecha"].ToString().Substring(0, 10),
                                                   "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
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
        

        private void ConsultarDispositivoEnMantenimiento_Load(object sender, EventArgs e)
        {
            cbxEstadoMantenimiento.SelectedIndex = 0;
            txtDescripcion.Enabled = false;
            fecha.Enabled = false;
            cbxEstadoMantenimiento.Enabled = false;
            fecha.Enabled = false;

        }

        private void txtCodigoDispositivo_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDispositivo.Text == "")
            {
                txtCodigoDispositivo.Text = "Codigo del Dispositivo";
            }
        }

        private void txtCodigoDispositivo_OnValueChanged(object sender, EventArgs e)
        {
            if (rg.IsMatch(txtCodigoDispositivo.Text))
            {
                valor = txtCodigoDispositivo.Text;
            }
            else
            {
                txtCodigoDispositivo.Text = valor;
                MessageBox.Show("Solo valores alfanumericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
