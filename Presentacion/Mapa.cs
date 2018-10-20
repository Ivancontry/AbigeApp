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
        LogicaDispositivo logicaDispositivo = new LogicaDispositivo();
        int contadorDeEventos = 0;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        long promedio = 0;
        double latitud = 10.450335;
        double longitud = -73.260797;
        string mostrarMesaje;
        DataTable listaMarcadores = new DataTable();
        public Mapa()
        {
            InitializeComponent();
        }


        private void Mapa_Load(object sender, EventArgs e)
        {
            conectarPuerto();
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            cargarMapa();
            cargarPoligono();
            cargarListaMarcadores();
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;


        }
        public void cargarMapa() {
           
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latitud, longitud);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 19;
            gMapControl1.AutoScroll = true;

        }

        
        public void cargarListaMarcadores() {
            listaMarcadores = logicaDispositivo.listadoPosicionDispositivo();
            foreach (DataRow dispositivo in listaMarcadores.Rows)
            {
                //Agregar un marcador
                markerOverlay = new GMapOverlay(""+dispositivo["Iddispositivo"].ToString());
                MessageBox.Show("id prueba" + markerOverlay.Id);
                marker = new GMarkerGoogle(new PointLatLng(double.Parse(dispositivo["latitud"].ToString()),double.Parse(dispositivo["longitud"].ToString())), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(marker); //Agregamos el mapa
           
                //Agregamos un mensaje a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion:\n Dispositivo{0} \n latitud:{1} \n Longitud:{2} \n ", dispositivo["Iddispositivo"].ToString(), double.Parse(dispositivo["latitud"].ToString()), double.Parse(dispositivo["longitud"].ToString()));

                gMapControl1.Overlays.Add(markerOverlay);
               


            }
            //gMapControl1.Zoom = gMapControl1.Zoom + 1;
            //gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }
        public void cargarPoligono() {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(10.450661, -73.260675));
            points.Add(new PointLatLng(10.450503, -73.260493));
            points.Add(new PointLatLng(10.450287, -73.260700));
            points.Add(new PointLatLng(10.450110, -73.260845));
            points.Add(new PointLatLng(10.449854, -73.260848));
            points.Add(new PointLatLng(10.450337, -73.261280));
            points.Add(new PointLatLng(10.450350, -73.260894));
            points.Add(new PointLatLng(10.450657, -73.260671));

            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
                      
        }
        private void insertarMarcador(Posicion posicion) {
         
            foreach (var item in gMapControl1.Overlays.ToList())
            {
                if (item.Id == posicion.idDispositivo)
                {
                    gMapControl1.Overlays.RemoveAt(gMapControl1.Overlays.IndexOf(item));

                }               
                
            }

            markerOverlay = new GMapOverlay("" + posicion.idDispositivo);
            marker = new GMarkerGoogle(new PointLatLng(posicion.latitud, posicion.longitud), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); //Agregamos el mapa
            //Agregamos un mensaje a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion:\n Dispositivo{0} \n latitud:{1} \n Longitud:{2} \n ", posicion.idDispositivo, posicion.latitud, posicion.longitud);
            //Agregar un marcador
            gMapControl1.Overlays.Add(markerOverlay);
            
        }

        private void conectarPuerto() {
            serialPort1.Close();
            serialPort1.PortName = "COM3";
            serialPort1.Open();
            MessageBox.Show("Conectado con el puerto COM13");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            //------------------------------------------------------
            int respuesta;
            Posicion posicion;
            string cadena = serialPort1.ReadExisting();
            cadena = cadena.TrimStart('{');
            cadena = cadena.TrimEnd('}');
            string[] datos = cadena.Split(',');
            posicion = new Posicion(datos[0], datos[1] + "," + datos[2] + "," + datos[3] + "," + datos[4],
                datos[5] + "," + datos[6] + "," + datos[7] + "," + datos[8], datos[9] + datos[10], datos[11] + datos[12],int.Parse(datos[13]));
            insertarMarcador(posicion);
            respuesta = logicaDispositivo.registraPosicionActual(posicion);
            if (respuesta == -1) {
                MessageBox.Show("Error al conectar","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            contadorDeEventos++;
            //------------------------------------------------------
            stop = new TimeSpan(DateTime.Now.Ticks);
            mostrarMesaje += " "+ stop.Subtract(start).TotalMilliseconds.ToString() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarMesaje);
            mostrarMesaje = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((promedio / 10).ToString());
        }
    }
}
