using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dispositivo
    {
        protected string idDispositivo;
        protected int idPerimetro;
        protected string estado;
        protected string idAnimal;
        protected string bateria;
        protected DateTime fecha;

        public Dispositivo() {}
        public Dispositivo(string iddispositivo, int idperimetro, string idanimal)
        {
            this.idDispositivo = iddispositivo;
            this.idPerimetro = idperimetro;
            this.idAnimal = idanimal;
        }


        public string IdDispositivo {
            get { return idDispositivo; }
            set
            {
                if (validarIdDispositivo(value)) {
                    idDispositivo = value;
                }
                else
                {
                    idDispositivo = "N/A";
                }
            }
        }
        public int IdPerimetro { get => idPerimetro; set => idPerimetro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string IdAnimal {
            get { return idAnimal; }
            set
            {
                if (validarIdAnimal(value))
                {
                    idAnimal = value;
                }
                else
                {
                    idAnimal = "N/A";
                }
            }
        }
        public string Bateria {
            get => estado; set => estado = value;
        }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public bool validarIdDispositivo(string codigo) {
            return (!codigo.Equals("") && codigo.Length >= 5 && codigo.Length <= 10);       
                           
        }

        public bool validarIdAnimal(string codigo)
        {
            return (!codigo.Equals("") && codigo.Length >= 4 && codigo.Length <= 10);

        }
     

    }
}
