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
        public string estadoDispositivo { get; set; } //primeramente manual ya que no sabemos como validar que este adentro :V
        public string estadoBateria { get; set; }
        public int novedadDispositivo { get; set; }
        public Posicion() { }
        public Posicion(string idDispositivo,string latitud, string longitud,string altitud,string estadoBateria,int novedadDispositivo)
        {
            this.idDispositivo = idDispositivo;
            this.latitud = convertirCoordenada(latitud);
            this.longitud =convertirCoordenada(longitud);
            this.estadoDispositivo = "Dentro";
            this.estadoBateria = estadoBateria;
            this.novedadDispositivo = novedadDispositivo;
        }
        public double convertirCoordenada(string coordenada)
        {
            //primero se separa la coordenada en un vector y se convierte a double
            string[] coordenadaSeparada = coordenada.Split(',');
            double[] coordenadaSeparadaADouble = new Double[coordenadaSeparada.Length-1];
            double coordenadaCalculada = coordenadaSeparadaADouble[0] + (coordenadaSeparadaADouble[1] / 60) + (coordenadaSeparadaADouble[2]) / 3600;
            if (coordenadaSeparada[coordenada.Length-1].Equals("N")|| coordenadaSeparada[coordenada.Length - 1].Equals("E"))
            {
                return coordenadaCalculada;
            }
            else
            {
                return -1 * coordenadaCalculada;
            }                       
        }

       

  
    }
}
