﻿using System;
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
            
            double coordenadaCalculada = Double.Parse( coordenadaSeparada[0]) + (Double.Parse(coordenadaSeparada[1]) / 60)
                + (Double.Parse(coordenadaSeparada[2].Replace(".", ",")) /3600);
            if (coordenadaSeparada[3].Equals("N")|| coordenadaSeparada[3].Equals("E"))
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
