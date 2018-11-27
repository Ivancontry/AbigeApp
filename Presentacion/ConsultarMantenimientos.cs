﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            cargarCamposConsulta();
        }
        public void cargarCamposConsulta() {           
            txtCantidadTop.Text = "";
            fecha1.Value = DateTime.Now;
            fecha2.Value = DateTime.Now;
        }

        public void cargarTablaMantenimientos() {
            tablaMantenimientos.Clear();
            tablaMantenimientos = logicaMantenimientos.mostrarMantenimientos();
            cargarTablaGeneral();
        }

        private void bnfGeneral_Click(object sender, EventArgs e)
        {
            cargarTablaMantenimientos();
            cargarCamposConsulta();
        }

        private void bnfFuncionando_Click(object sender, EventArgs e)
        {
            cargarTablaFiltrada("1", "0");
        }
        public void cargarTablaFiltrada(string estadoDispositivo, string estadoMantenimiento) {
            tablaGeneral.Rows.Clear();
            foreach (DataRow fila in tablaMantenimientos.Rows)
            {
                if (fila["estadoDispositivo"].ToString().Equals(estadoDispositivo) && fila["estadoMantenimiento"].ToString().Equals(estadoMantenimiento))
                {
                    //Dispositivos en la fincas
                    tablaGeneral.Rows.Add(
                       fila["iddispositivo"],
                       fila["descripcion"],
                       fila["fecha"],
                      convertirEstadoMantenimiento(fila["estadoMantenimiento"].ToString()),
                      convertirEstadoDispositivo(fila["estadoDispositivo"].ToString()),
                       fila["estadoActual"]
                       );
                }
                if (fila["estadoDispositivo"].ToString().Equals(estadoDispositivo) && fila["estadoMantenimiento"].ToString().Equals(estadoMantenimiento))
                {
                    //Dispositivos en el taller
                    tablaGeneral.Rows.Add(
                       fila["iddispositivo"],
                       fila["descripcion"],
                       fila["fecha"],
                      convertirEstadoMantenimiento(fila["estadoMantenimiento"].ToString()),
                      convertirEstadoDispositivo(fila["estadoDispositivo"].ToString()),
                       fila["estadoActual"]
                       );
                }

                if (fila["estadoDispositivo"].ToString().Equals(estadoDispositivo))
                {
                    //Dispositivos funcionandos despues de una revision
                    tablaGeneral.Rows.Add(
                       fila["iddispositivo"],
                       fila["descripcion"],
                       fila["fecha"],
                      convertirEstadoMantenimiento(fila["estadoMantenimiento"].ToString()),
                      convertirEstadoDispositivo(fila["estadoDispositivo"].ToString()),
                       fila["estadoActual"]
                       );
                }
                if (fila["estadoDispositivo"].ToString().Equals(estadoDispositivo))
                {
                    //Dispositivos dañados despues de una revision
                    tablaGeneral.Rows.Add(
                       fila["iddispositivo"],
                       fila["descripcion"],
                       fila["fecha"],
                      convertirEstadoMantenimiento(fila["estadoMantenimiento"].ToString()),
                      convertirEstadoDispositivo(fila["estadoDispositivo"].ToString()),
                       fila["estadoActual"]
                       );
                }
               
            }

        }

        private void bnfRegsitrar_Click(object sender, EventArgs e)
        {
            cargarTablaGrafica();
        }
        public void cargarTablaGrafica() {
            DataTable tablaGrafica = new DataTable();
            if (txtCantidadTop.Text.Trim().Equals("")) {
                txtCantidadTop.Text = "0";
            }
            tablaGrafica = logicaMantenimientos.topMantenimientos(int.Parse(txtCantidadTop.Text),fecha1.Value,fecha2.Value);
            cargarGrafica(tablaGrafica);
        }
        public void cargarGrafica(DataTable tabla) {
            chart1.Series.Clear();       
            Series s1 = chart1.Series.Add("Dispositivos");
            s1.ChartArea = "ChartArea1";
            s1.XValueMember = "iddispositivo";
            s1.YValueMembers = "cantidad";
            s1.IsValueShownAsLabel = true;
            chart1.DataSource = tabla;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Codigo de los dispositivos";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Cantidad de mantenimientos";
        }

        private void bnfAveriadoFinca_Click(object sender, EventArgs e)
        {
            cargarTablaFiltrada("0","0");
        }

        private void bnfAveridadoTaller_Click(object sender, EventArgs e)
        {
            cargarTablaFiltrada("0", "1");
        }

        private void bnfDañados_Click(object sender, EventArgs e)
        {
            cargarTablaFiltrada("2", "0");
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
            tablaGeneral.Rows.Clear();
            contAveriadosFincas = 0;
            contAveriadosTaller = 0;
            contDañados = 0;
            contFuncionando = 0;
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
