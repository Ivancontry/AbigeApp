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
        public string estadoDispositivo { get; set; } //primeramente manual ya que no sabemos como validar que este adentro :V
        public string estadoBateria { get; set; }
        public Posicion() { }
        public Posicion(string idDispositivo,string latitud, string longitud,string estadoBateria)
        {
            this.idDispositivo = idDispositivo;
            this.latitud = convertirCoordenada(latitud);
            this.longitud =-1*(convertirCoordenada(longitud));
            this.estadoDispositivo = "Dentro";
            this.estadoBateria = estadoBateria;
        }
        public double convertirCoordenada(string coordenada)
        {
            //primero se separa la coordenada en un vector y se convierte a double
            string[] coordenadaSeparada = coordenada.Split('.');
            double[] coordenadaSeparadaADouble = new Double[coordenadaSeparada.Length];
            for (int i = 0; i < coordenadaSeparada.Length; i++)
            {
                coordenadaSeparadaADouble[i] = Double.Parse(coordenadaSeparada[i]);
            }
            //luego se agrupa el vector para representarlo en coordenada
            //Convertido de grados minutos y segundos a decimal
            
            return coordenadaSeparadaADouble[0] + (coordenadaSeparadaADouble[1] / 60) + (coordenadaSeparadaADouble[2]) / 3600;
        }

       

  
    }
}
