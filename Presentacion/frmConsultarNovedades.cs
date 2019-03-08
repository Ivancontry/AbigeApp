using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmConsultarNovedades : Form
    {
        double latitudCentral = 10.4402915855;//estas dos coordenadas son para centrar el mapa
        double longitudCentral = -73.2516118633;
        public frmConsultarNovedades()
        {
            InitializeComponent();
        }

        private void frmConsultarNovedades_Load(object sender, EventArgs e)
        {
            cargarMapa();
        }
        public void cargarMapa()
        {

            gmFincaNovedades.DragButton = MouseButtons.Left;
            gmFincaNovedades.CanDragMap = true;
            gmFincaNovedades.MapProvider = GoogleMapProvider.Instance;
            gmFincaNovedades.Position = new PointLatLng(latitudCentral, longitudCentral);
            gmFincaNovedades.MinZoom = 15;
            gmFincaNovedades.MaxZoom = 20;
            gmFincaNovedades.Zoom = 17;
            gmFincaNovedades.AutoScroll = true;
        }
    }
}
