using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class ConsultarMantenimientos : Form
    {
        ServiciosMantenimientos logicaMantenimientos = new ServiciosMantenimientos();
        DataTable tablaMantenimientos = new DataTable();
        int contDañados=0,contAveriadosFincas=0,contAveriadosTaller=0,contFuncionando=0;
        public ConsultarMantenimientos()
        {
            InitializeComponent();
        }

        private void ConsultarMantenimientos_Load(object sender, EventArgs e)
        {
            cargarTablaMantenimientos();
        }

        public void cargarTablaMantenimientos() {
            tablaMantenimientos.Clear();
            tablaMantenimientos = logicaMantenimientos.mostrarMantenimientos();
            cargarTablaGeneral();
        }
        public string convertirEstadoMantenimiento(string fila) {
            if (fila.Equals("0"))
            {
               return fila = "Pendiente";
            }
            else
            {
                if (fila.Equals("1"))
                {
                   return fila = "Enviado";
                }
                else
                {
                   return fila = "Revisado";
                }
            }
        }
        public string convertirEstadoDispositivo(string fila)
        {
            if (fila.Equals("0"))
            {
                return fila = "En espera";
            }
            else
            {
                if (fila.Equals("1"))
                {
                    return fila = "Funcionado";
                }
                else
                {
                    return fila = "Dañado";
                }
            }
        }
        public void cargarTablaGeneral() {
            foreach (DataRow fila in tablaMantenimientos.Rows)
            {
                if (fila["estadoDispositivo"].ToString().Equals("0") && fila["estadoMantenimiento"].ToString().Equals("0"))
                {
                    contAveriadosFincas++;
                }
                if (fila["estadoDispositivo"].ToString().Equals("0") && fila["estadoMantenimiento"].ToString().Equals("1"))
                {
                    contAveriadosTaller++;
                }

                if (fila["estadoDispositivo"].ToString().Equals("1")) {
                    contFuncionando++;
                }
                if (fila["estadoDispositivo"].ToString().Equals("2"))
                {
                    contDañados++;
                }
                    tablaGeneral.Rows.Add(
                            fila["iddispositivo"],
                            fila["descripcion"],
                            fila["fecha"],
                           convertirEstadoMantenimiento( fila["estadoMantenimiento"].ToString()),
                           convertirEstadoDispositivo( fila["estadoDispositivo"].ToString()),
                            fila["estadoActual"]
                            );
            }

            labelAveriadoTaller.Text = contAveriadosTaller.ToString();
            labelAveridadoFinca.Text = contAveriadosFincas.ToString();
            labelDañado.Text = contDañados.ToString();
            labelFuncionando.Text = contFuncionando.ToString();
            labelGeneral.Text = (contAveriadosFincas + contAveriadosTaller + contDañados + contFuncionando).ToString();
        }
     
    }
}
