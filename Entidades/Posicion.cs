using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posicion
    {
        public string idDispositivo { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public double altitud { get; set; }
        public string estadoDispositivo { get; set; } //primeramente manual ya que no sabemos como validar que este adentro :V. Ahora si se sabe XD
        public string estadoBateria { get; set; }
        public int novedadDispositivo { get; set; }
        public string idPerimetro { get; set; }
        public string idAnimal { get; set; }
        public Posicion() { }
        public Posicion(string idDispositivo,string latitud, string longitud,int novedadDispositivo, string estadoBateria)
        {
            this.idDispositivo = idDispositivo;
            this.latitud = Double.Parse(latitud.Replace(".", ","));
            this.longitud = Double.Parse(longitud.Replace(".", ","));
            this.estadoBateria = estadoBateria;
            this.novedadDispositivo = novedadDispositivo;
        }
        public double convertirCoordenada(string coordenada)
        {
            //primero se separa la coordenada en un vector y se convierte a double
            string[] coordenadaSeparada = coordenada.Split('.');
            Random random = new Random();
            double paraminuto = random.NextDouble()/1000 ;
            double parasegundo = random.NextDouble()/100000;
            double variable = ((Double.Parse(coordenadaSeparada[1]) /1000000) + parasegundo);
            double coordenadaCalculada = Double.Parse( coordenadaSeparada[0])
                + variable;
            
                return coordenadaCalculada;
                               
        }
    }
}
