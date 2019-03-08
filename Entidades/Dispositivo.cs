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
        protected float bateria;
        protected DateTime fecha;

        public Dispositivo() {}
        public Dispositivo(string iddispositivo, int idperimetro, string idanimal)
        {
            this.idDispositivo = iddispositivo;
            this.idPerimetro = idperimetro;
            this.idAnimal = idanimal;
        }


        public string IdDispositivo {
            get { return IdDispositivo; }
            set
            {
                if (!idDispositivo.Equals("") && idDispositivo.Length >= 5 && idDispositivo.Length<=10)
                {
                    idDispositivo = value;
                }
            }
        }
        public int IdPerimetro { get => idPerimetro; set => idPerimetro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string IdAnimal {
            get { return IdAnimal; }
            set
            {
                if (!IdAnimal.Equals("") && IdAnimal.Length >= 4 && IdAnimal.Length <= 10)
                {
                    idDispositivo = value;
                }
            }
        }
        public float Bateria {
            get {return bateria; }
            set
            {
                if (bateria>=0.0 && bateria<= 5.0)
                {
                    bateria = value;
                }
            }

        }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
