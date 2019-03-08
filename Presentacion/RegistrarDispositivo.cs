using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Logica;
using Entidades;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class RegistrarDispositivo : Form
    {
        public RegistrarDispositivo()
        {
            InitializeComponent();
        }
        ServiciosDispositivo logicaDispositivo = new ServiciosDispositivo();
        Dispositivo dispositivo = new Dispositivo();
        GMapPolygon polygon;
        GMapOverlay polyOverlay;
        List<GMapPolygon> lista = new List<GMapPolygon>();
        Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
        string valor = "", valor1="";
        private void RegistrarDispositivo_Load(object sender, EventArgs e)
        {
            
            lista.Clear();
            cargarMapa();
            cargarPerimetros();
            mapaDispositivo.Zoom = mapaDispositivo.Zoom + 1;
            mapaDispositivo.Zoom = mapaDispositivo.Zoom - 1;
            mapaDispositivo.Refresh();
            cargarCampos();

            
        }
        public static bool IsAlfanumerico(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,"/^[A - Za - z0 - 9] +$/ g");
        }
        public void cargarCampos()
        {
            bnfActualizar.Enabled = false;
            bnfRegistrar.Enabled = false;
            cbxPerimetro.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            txtCodigoDispositivo.Text = "";
            txtCodigoAnimal.Text = "";
            txtBateria.Text = "";
            fecha.Value = DateTime.Now;
            txtCodigoDispositivo.Enabled = true;
            txtBateria.Enabled = false;

        }
        public void cargarMapa()
        {

            mapaDispositivo.DragButton = MouseButtons.Left;
            mapaDispositivo.CanDragMap = true;
            mapaDispositivo.MapProvider = GoogleMapProvider.Instance;
            mapaDispositivo.Position = new PointLatLng(10.4503389439809840, -73.2612871830206100);
            mapaDispositivo.MinZoom = 0;
            mapaDispositivo.MaxZoom = 24;
            mapaDispositivo.Zoom = 20;
            mapaDispositivo.AutoScroll = true;

        }
        public void cargarPerimetros() {
            DataTable listaPerimetros = new DataTable();
            listaPerimetros = logicaDispositivo.listadoPerimetros();

            foreach (DataRow perimetro in listaPerimetros.Rows)
            {
                cargarPerimetrosCoordenadas(perimetro["idperimetro"].ToString());
                cbxPerimetro.Items.Add(perimetro["idperimetro"].ToString());
            }
        }
        public void cargarPerimetrosCoordenadas(string perimetro) {
            DataTable listaCoordenadasPerimetros = new DataTable();
            listaCoordenadasPerimetros = logicaDispositivo.listadoCoordenadasPerimetro(int.Parse(perimetro));
            polyOverlay = new GMapOverlay("" + perimetro);
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (DataRow coordenadas in listaCoordenadasPerimetros.Rows)
            {                
                points.Add(new PointLatLng(double.Parse(coordenadas["latitud"].ToString()), double.Parse(coordenadas["longitud"].ToString())));
            }

            polygon = new GMapPolygon(points, "Poligono "+perimetro);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            mapaDispositivo.Overlays.Add(polyOverlay);
            polyOverlay.Polygons.Add(polygon);
            lista.Add(polygon);
        }

        public int validarIdDispositivo()
        {

            epCodigoDispoitivo.Clear();
            if (txtCodigoDispositivo.Text.Equals("") || txtCodigoDispositivo.Text.Length > 10 || txtCodigoDispositivo.Text.Length < 5)
            {
                epCodigoDispoitivo.SetError(txtCodigoDispositivo, "Digite un Dispositivo Valido");
                return -1;
            };
            return 1;
        }
        public int validarCodigoAnimal()
        {
            epCodigoAnimal.Clear();
            if (txtCodigoAnimal.Text.Equals("") || txtCodigoAnimal.Text.Length > 10 || txtCodigoAnimal.Text.Length < 4)
            {
                epCodigoAnimal.SetError(txtCodigoAnimal, "Verifique que este campo no este vacio, no exceda 10 caracteres, no tenga menos de 4 caracteres");
                return -1;
            };
            return 1;
        }


      

        private void txtCodigoDispositivo_Enter(object sender, EventArgs e)
        {
            epCodigoDispoitivo.Clear();
            if (txtCodigoDispositivo.Text == "Codigo del Dispositivo")
            {
                txtCodigoDispositivo.Text = "";
   
            }
        }

        private void cbxPerimetro_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                if (item.Name.Equals("Poligono " + cbxPerimetro.Text))
                {
                    item.Fill = new SolidBrush(Color.FromArgb(50, Color.Green));
                }
                else
                {
                    item.Fill = new SolidBrush(Color.FromArgb(50, Color.Gray));
                }
            }

           mapaDispositivo.Refresh();
           
        }
   
        private void bnfLimpiar_Click(object sender, EventArgs e)
        {
           
            cargarCampos();
        }

        private void bnfRegistrar_Click(object sender, EventArgs e)
        {
            if (validarCodigoAnimal()==1 && validarIdDispositivo()==1) {
                dispositivo.IdDispositivo = txtCodigoDispositivo.Text;
                dispositivo.IdAnimal = txtCodigoAnimal.Text;
                dispositivo.IdPerimetro = int.Parse(cbxPerimetro.Text);
                dispositivo.Estado = cbxEstado.Text;
                dispositivo.Fecha = fecha.Value;
                dispositivo.Bateria = txtBateria.Text;
                if (logicaDispositivo.registrarDispositivo(dispositivo) == 1)
                {
                    MessageBox.Show("Operacion Exitosa");
                    cargarCampos();
                }
                else {
                    MessageBox.Show("Error al realizar en registro");
                }

            }
        }

        private void bnfActualizar_Click(object sender, EventArgs e)
        {
            if (validarCodigoAnimal() == 1 )
            {
                dispositivo.IdDispositivo = txtCodigoDispositivo.Text;
                dispositivo.IdAnimal = txtCodigoAnimal.Text;
                dispositivo.IdPerimetro = int.Parse(cbxPerimetro.Text);
                dispositivo.Estado = cbxEstado.Text;
                dispositivo.Fecha = fecha.Value;
                dispositivo.Bateria = txtBateria.Text;

                if (logicaDispositivo.actulizarDispositivo(dispositivo)==1)
                {
                    MessageBox.Show("Operacion Exitosa");
                    cargarCampos();
                }
                else {
                    MessageBox.Show("Error al realizar en registro");
                }

            }
        }

        private void bnfBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable dispositivo = new DataTable();
            dispositivo = logicaDispositivo.buscarDispositvo(txtCodigoDispositivo.Text);
            if (validarIdDispositivo() == 1)
            {
                if (dispositivo.Rows.Count > 0)
                {
                    bnfRegistrar.Enabled = false;
                    bnfActualizar.Enabled = true;
                    txtCodigoAnimal.Text = dispositivo.Rows[0]["idanimal"].ToString();
                    cbxPerimetro.SelectedIndex = cbxPerimetro.FindString(dispositivo.Rows[0]["idperimetro"].ToString());
                    cbxEstado.SelectedIndex= int.Parse(dispositivo.Rows[0]["estado"].ToString());
                    txtBateria.Text = dispositivo.Rows[0]["bateria"].ToString();
                    DateTime data;
                    data = DateTime.ParseExact(dispositivo.Rows[0]["fecha"].ToString().Substring(0, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    fecha.Value = data;

                    MessageBox.Show("Dispositivo Encontrado");
                    txtCodigoDispositivo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Dispositivo no existe, Registrelo");
                    bnfRegistrar.Enabled = true;
                    bnfActualizar.Enabled = false;
                }
            }
        }

        private void txtCodigoDispositivo_Leave(object sender, EventArgs e)
        {
            if (IsAlfanumerico(txtCodigoDispositivo.Text)) {
                epCodigoDispoitivo.Clear();
                epCodigoDispoitivo.SetError(txtCodigoDispositivo,"Solo valores alfanumerico");
            }
        }

      
    
     
        private void txtCodigoDispositivo_OnValueChanged_1(object sender, EventArgs e)
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

        private void txtCodigoAnimal_OnValueChanged(object sender, EventArgs e)
        {
     
            if (rg.IsMatch(txtCodigoAnimal.Text))
            {
                valor1 = txtCodigoAnimal.Text;
            }
            else
            {
                txtCodigoAnimal.Text = valor1;
                MessageBox.Show("Solo valores alfanumericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
