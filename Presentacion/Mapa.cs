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
        List<GMapPolygon> poligonos = new List<GMapPolygon>();
        ServiciosDispositivo logicaDispositivo = new ServiciosDispositivo();
        int contadorDeEventos = 0;
        GMarkerGoogle marker;
        List<GMarkerGoogle> marcadores = new List<GMarkerGoogle>();
        GMapOverlay markerOverlay;
        PointLatLng latLng;
        double promedio = 0;
        double latitudCentral = 10.4402915855;//estas dos coordenadas son para centrar el mapa
        double longitudCentral = -73.2516118633;
        string mostrarMesaje;//Esto es para ver la media de tiempo en que se demora el proceso  para cada evento en el mapa
        DataTable listaMarcadores = new DataTable();
        int dispositivosTotalEnFinca = 0;
        public Mapa()
        {
            InitializeComponent();
            
        }


        private void Mapa_Load(object sender, EventArgs e)
        {
            gmFinca.IgnoreMarkerOnMouseWheel = true;
            poligonos.Clear();
            cargarMapa();
            cargarPerimetros();
            cargarListaMarcadores();
            conectarPuerto();
            
        }
        public void cargarMapa() {
           
            gmFinca.DragButton = MouseButtons.Left;
            gmFinca.CanDragMap = true;
            gmFinca.MapProvider = GoogleMapProvider.Instance;
            gmFinca.Position = new PointLatLng(latitudCentral, longitudCentral);
            gmFinca.MinZoom = 15;
            gmFinca.MaxZoom = 20;
            gmFinca.Zoom = 17;
            gmFinca.AutoScroll = true;
        }

        
        public void cargarListaMarcadores() {
            listaMarcadores = logicaDispositivo.listadoPosicionDispositivo();
            marcadores.Clear();
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
                
                gmFinca.Overlays.Add(markerOverlay);
                marcadores.Add(marker);
                dispositivosTotalEnFinca++;

            }
            //gMapControl1.Zoom = gMapControl1.Zoom + 1;
            //gMapControl1.Zoom = gMapControl1.Zoom - 1;
            btnDispositivosEnTotal.Text = "Dispositivos en Total\n" + dispositivosTotalEnFinca;            
        }
        public void cargarPerimetros()
        {
            DataTable listaPerimetros = new DataTable();
            listaPerimetros = logicaDispositivo.cargarPerimetros();
            poligonos.Clear();
            foreach (DataRow perimetro in listaPerimetros.Rows)
            {
                cargarPerimetrosCoordenadas(perimetro["idperimetro"].ToString());                
            }
        }
        public void cargarPerimetrosCoordenadas(string perimetro)
        {
            DataTable listaCoordenadasPerimetros = new DataTable();
            listaCoordenadasPerimetros = logicaDispositivo.listadoCoordenadasPerimetro(int.Parse(perimetro));
            markerOverlay = new GMapOverlay("" + perimetro);
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (DataRow coordenadas in listaCoordenadasPerimetros.Rows)
            {
                points.Add(new PointLatLng(double.Parse(coordenadas["latitud"].ToString()), double.Parse(coordenadas["longitud"].ToString())));
            }

            polygon = new GMapPolygon(points, "Poligono " + perimetro);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            markerOverlay.Polygons.Add(polygon);
            gmFinca.Overlays.Add(markerOverlay);
            poligonos.Add(polygon);
            
        }
        private void refrescarPoligonos()
        {
            markerOverlay.Polygons.Clear();
            poligonos.ForEach(x => gmFinca.Overlays.Remove(x.Overlay));
            poligonos.ForEach(x => markerOverlay.Polygons.Add(x));            
        }

        private void insertarMarcador(Posicion dispositivo) {
            List<GMapOverlay> lista = new List<GMapOverlay>();
            lista = gmFinca.Overlays.ToList();
            gmFinca.Overlays.Remove(lista.Find(gmapOverlay => gmapOverlay.Id == dispositivo.idDispositivo));
            
            markerOverlay = new GMapOverlay("" + dispositivo.idDispositivo);
            marker = new GMarkerGoogle(new PointLatLng(dispositivo.latitud, dispositivo.longitud), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); //Agregamos el mapa            
            //Agregamos un mensaje a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion:\n Dispositivo{0} \n latitud:{1} \n Longitud:{2} \n ", posicion.idDispositivo, posicion.latitud, posicion.longitud);
            //Agregar un marcador
            marker.ToolTipText = string.Format("{0}", dispositivo.idDispositivo);
            gmFinca.Overlays.Add(markerOverlay);            
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
            Posicion dispositivo;
            string cadena = datosIn.ToString();
            if (gmFinca.InvokeRequired)
            {
                gmFinca.Invoke(new MethodInvoker(delegate
                {
                    gmFinca.Zoom += 0.08;
                }));
            }
            if (!cadena.Trim().Equals(""))
            {
                cadena = cadena.TrimStart('{');
                cadena = cadena.TrimEnd();
                cadena = cadena.TrimEnd('}');
                string[] datos = cadena.Split(',');
                dispositivo = new Posicion(datos[0], datos[1] + "," + datos[2] + "," + datos[3] + "," + datos[4],
                    datos[5] + "," + datos[6] + "," + datos[7] + "," + datos[8], datos[9] + datos[10], datos[11] + datos[12], int.Parse(datos[13]));


                insertarMarcador(dispositivo);
                latLng = new PointLatLng(dispositivo.latitud, dispositivo.longitud);
                if (poligonos.Find(x => x.IsInside(latLng)) != null)
                {
                    dispositivo.estadoDispositivo = "Dentro";
                }
                else
                {
                    dispositivo.estadoDispositivo = "Fuera";
                }
                confirmacionBaseDeDatos = logicaDispositivo.registraPosicionActual(dispositivo);
                if (confirmacionBaseDeDatos == -1) {
                    MessageBox.Show("Error al conectar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                contadorDeEventos++;
                serialPort1.WriteLine("hola");
                //------------------------------------------------------
                stop = new TimeSpan(DateTime.Now.Ticks);
                mostrarMesaje += " " + stop.Subtract(start).TotalMilliseconds.ToString() + "\n";
                promedio += stop.Subtract(start).TotalMilliseconds;
                
            }
            if (gmFinca.InvokeRequired)
            {
                gmFinca.Invoke(new MethodInvoker(delegate
                {
                    gmFinca.Zoom-=0.08;
                    gmFinca.Refresh();
                    refrescarPoligonos();
                }));
            }
            
            //MessageBox.Show(mostrarMesaje);
        }
                    

        
        private void gmFinca_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (sender is GMapControl)
            {
                var tmp = sender as GMapControl;//Se crea una ariable temporal para un gmapcontrol                
                var poligono = poligonos.Find(x => x.IsInside(tmp.Position));//Se busca el poligono al que pertenece esa posicion

                if (poligono != null)
                {
                    int dispositivos = 0;
                    poligonos.ForEach(x => x.Fill = new SolidBrush(Color.FromArgb(50, Color.Red)));//Se cambia el color a los demas poligono
                    poligono.Fill = new SolidBrush(Color.FromArgb(50, Color.Green));//Se cambia el color al poligono seleccionado
                    dispositivos = marcadores.FindAll(x => poligono.IsInside(x.Position)).Count;
                    btnDispositivos.Text = "Dispositivos\n" + dispositivos;
                }
                else
                {
                   poligonos.ForEach(x => x.Fill = new SolidBrush(Color.FromArgb(50, Color.Red)));//Se cambia el color a los demas poligono
                    btnDispositivos.Text = "Dispositivos\n" + 0;
                }
            }            
           
        }

    }
}
