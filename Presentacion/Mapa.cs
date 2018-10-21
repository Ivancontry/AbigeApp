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
using GMap.NET.WindowsForms.Markers;
using Logica;
using Entidades;


namespace Presentacion
{
    public partial class Mapa : Form
    {
        GMapPolygon polygon;
        ServiciosDispositivo logicaDispositivo = new ServiciosDispositivo();
        int contadorDeEventos = 0;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        PointLatLng latLng;
        double promedio = 0;
        double latitudCentral = 10.4402915855;//estas dos coordenadas son para centrar el mapa
        double longitudCentral = -73.2516118633;
        string mostrarMesaje;//Esto es para ver la media de tiempo en que se demora el proceso  para cada evento en el mapa
        DataTable listaMarcadores = new DataTable();
        public Mapa()
        {
            InitializeComponent();
        }


        private void Mapa_Load(object sender, EventArgs e)
        {
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            cargarMapa();
            cargarPoligono();
            cargarListaMarcadores();
            conectarPuerto();
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
            
            gMapControl1.Refresh();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        public void cargarMapa() {
           
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            gMapControl1.Position = new PointLatLng(latitudCentral, longitudCentral);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 20;
            gMapControl1.AutoScroll = true;

        }

        
        public void cargarListaMarcadores() {
            listaMarcadores = logicaDispositivo.listadoPosicionDispositivo();
            foreach (DataRow dispositivo in listaMarcadores.Rows)
            {
                //Agregar un marcador
                markerOverlay = new GMapOverlay(""+dispositivo["Iddispositivo"].ToString());                
                marker = new GMarkerGoogle(new PointLatLng(double.Parse(dispositivo["latitud"].ToString()),double.Parse(dispositivo["longitud"].ToString())), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(marker); //Agregamos el mapa
           
                //Agregamos un mensaje a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                //marker.ToolTipText = string.Format("Ubicacion:\n Dispositivo{0} \n latitud:{1} \n Longitud:{2} \n ", dispositivo["Iddispositivo"].ToString(), double.Parse(dispositivo["latitud"].ToString()), double.Parse(dispositivo["longitud"].ToString()));
                marker.ToolTipText = string.Format("{0}", dispositivo["Iddispositivo"].ToString());
                
                gMapControl1.Overlays.Add(markerOverlay);
               


            }
            //gMapControl1.Zoom = gMapControl1.Zoom + 1;
            //gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }
        public void cargarPoligono() {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(10.441329, -73.251367));
            points.Add(new PointLatLng(10.441382, -73.252724));
            points.Add(new PointLatLng(10.438916, -73.252872));
            points.Add(new PointLatLng(10.440022, -73.251501));
            

            polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            gMapControl1.Overlays.Add(polyOverlay);
            polyOverlay.Polygons.Add(polygon);
            //*******************            
        }
        private void insertarMarcador(Dispositivos dispositivo) {
            List<GMapOverlay> lista = new List<GMapOverlay>();
            lista = gMapControl1.Overlays.ToList();
            gMapControl1.Overlays.RemoveAt(lista.FindIndex(gmapOverlay => gmapOverlay.Id == dispositivo.idDispositivo));
            
            //******************************************************
            /*foreach (var item in gMapControl1.Overlays.ToList())
            {
                if (item.Id == posicion.idDispositivo)
                {
                    //gMapControl1.Overlays.RemoveAt(gMapControl1.Overlays.IndexOf(item));
                    gMapControl1.Overlays.RemoveAt(gMapControl1.Overlays.IndexOf(item));
                }                                   
                
            }
            */
            markerOverlay = new GMapOverlay("" + dispositivo.idDispositivo);
            marker = new GMarkerGoogle(new PointLatLng(dispositivo.latitud, dispositivo.longitud), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); //Agregamos el mapa
            //Agregamos un mensaje a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion:\n Dispositivo{0} \n latitud:{1} \n Longitud:{2} \n ", posicion.idDispositivo, posicion.latitud, posicion.longitud);
            //Agregar un marcador
            marker.ToolTipText = string.Format("{0}", dispositivo.idDispositivo);
            gMapControl1.Overlays.Add(markerOverlay);
            
        }

        private void conectarPuerto() {
            serialPort1.Close();
            serialPort1.PortName = "COM3";
            serialPort1.Open();           
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            //------------------------------------------------------
            int confirmacionBaseDeDatos;//1 o -1
            object datosIn = new object();
            datosIn = serialPort1.ReadLine();
            Dispositivos dispositivo;
            string cadena = datosIn.ToString();

            if (!cadena.Trim().Equals(""))
            {
                cadena = cadena.TrimStart('{');
                cadena = cadena.TrimEnd();
                cadena = cadena.TrimEnd('}');                    
                string[] datos = cadena.Split(',');
                dispositivo = new Dispositivos(datos[0], datos[1] + "," + datos[2] + "," + datos[3] + "," + datos[4],
                    datos[5] + "," + datos[6] + "," + datos[7] + "," + datos[8], datos[9] + datos[10], datos[11] + datos[12], int.Parse(datos[13]));
                insertarMarcador(dispositivo);
                latLng = new PointLatLng(dispositivo.latitud, dispositivo.longitud);
                if(polygon.IsInside(latLng)){
                    dispositivo.estadoDispositivo = "Dentro";
                }
                else
                {
                    dispositivo.estadoDispositivo = "Fuera";
                }
                confirmacionBaseDeDatos = logicaDispositivo.registraPosicionActual(dispositivo);
                if (confirmacionBaseDeDatos == -1) {
                    MessageBox.Show("Error al conectar","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }               
                contadorDeEventos++;
                //------------------------------------------------------
                stop = new TimeSpan(DateTime.Now.Ticks);
                mostrarMesaje += " " + stop.Subtract(start).TotalMilliseconds.ToString() + "\n";
                promedio += stop.Subtract(start).TotalMilliseconds;
            }
        }
                    

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarMesaje);
            mostrarMesaje = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((promedio / contadorDeEventos).ToString() +"---"+ contadorDeEventos.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gMapControl1.Zoom = gMapControl1.Zoom + 1;

            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //gMapControl1.Zoom = 17.5;

        }
    }
}
