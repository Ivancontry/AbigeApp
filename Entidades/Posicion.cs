using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posicion : Dispositivo
    {

        private double latitud;
        private double longitud;
        private string estadoDispositivo;
        private string estadoBateria;
        private int novedadDispositivo;

        public double Latitud { get=>latitud; set => latitud =value; }
        public double Longitud { get => longitud; set => longitud = value; }
        public string EstadoDispositivo { get => estadoDispositivo; set => estadoDispositivo= value; } //primeramente manual ya que no sabemos como validar que este adentro :V. Ahora si se sabe XD
        public string EstadoBateria { get => estadoBateria; set => estadoBateria = value; }
        public int NovedadDispositivo { get => novedadDispositivo; set => novedadDispositivo = value; }

        public Posicion() { }
        public Posicion(string idDispositivo,string latitud, string longitud, int novedadDispositivo, string estadoBateria)
        {
            this.idDispositivo = idDispositivo;
            this.latitud = Double.Parse(latitud.Replace(".", ","));
            this.longitud = Double.Parse(longitud.Replace(".", ","));
            this.estadoBateria = estadoBateria;
            
        }
        //public double convertirCoordenada(string coordenada)
        //{
        //    //primero se separa la coordenada en un vector y se convierte a double
        //    string[] coordenadaSeparada = coordenada.Split('.');
        //    Random random = new Random();
        //    double paraminuto = random.NextDouble()/1000 ;
        //    double parasegundo = random.NextDouble()/100000;
        //    double variable = ((Double.Parse(coordenadaSeparada[1]) /1000000) + parasegundo);
        //    double coordenadaCalculada = Double.Parse( coordenadaSeparada[0])
        //        + variable;
            
        //        return coordenadaCalculada;
                               
        //}
    }
}
