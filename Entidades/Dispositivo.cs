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


        public string IdDispositivo { get => idDispositivo; set => idDispositivo = value; }
        public int IdPerimetro { get => idPerimetro; set => idPerimetro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string IdAnimal { get => idAnimal; set => idAnimal = value; }
        public float Bateria { get => bateria; set => bateria = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
