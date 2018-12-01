using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void abrirformularioHija(Object frmhija)
        {
            if (this.panelcontenedor.Controls.Count >= 0)
            {
                if (this.panelcontenedor.Controls.Count > 0)
                {
                    this.panelcontenedor.Controls.RemoveAt(0);
                }
            }
                // 
                Form fro = frmhija as Form;
                fro.TopLevel = false; //se dice que es un formulario secundario
                //fro.Dock = DockStyle.Fill;
                //que se acople a mi panelcontenedor
                this.panelcontenedor.Controls.Add(fro);//lo agregamos al panel contenedor
                this.panelcontenedor.Tag = fro;//se establece la instancia como contenedor de datos para panel contenedor
                fro.Left = (this.panelcontenedor.Width - fro.Width) / 2;
                fro.Top = (this.panelcontenedor.Height - fro.Height) / 3;
                fro.Show();

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            panelGestionEmpleado();


            
            abrirformularioHija(new Mapa());
        }
        public void panelGestionEmpleado() {
            panelDispositivo.Visible = false;
            panelMantenimientos.Visible = false;
            panelOpciones.Visible = false;
            btnGestionDispositivo.Location = new Point(12, 157);
            panelBtnDispositivo.Location = new Point(3,157);
            btnMantenimientos.Location = new Point(12, 204);
            panelBtnMantenimientos.Location = new Point(3, 204);
            btnOpciones.Location = new Point(12, 251);
            panelBtnOpciones.Location = new Point(3, 251);
        }


        private void btnGestionDispositivo_Click(object sender, EventArgs e)
        {
            panelGestionDispositivo();
        }
        public void panelGestionDispositivo()
        {
            panelMantenimientos.Visible = false;
            panelOpciones.Visible = false;
            if (panelDispositivo.Visible == false)
            {
                panelDispositivo.Visible = true;
                panelDispositivo.Location = new Point(9, 203);
                btnMantenimientos.Location = new Point(12, 346);
                panelBtnMantenimientos.Location = new Point(3, 346);
                btnOpciones.Location = new Point(12, 393);
                panelBtnOpciones.Location = new Point(3, 393);
            }
            else
            {

                panelGestionEmpleado();

            }
        }

        public void panelGestionMantenimientos()
        {
            panelDispositivo.Visible = false;
            panelOpciones.Visible = false;
            btnMantenimientos.Location = new Point(12, 204);
            panelBtnMantenimientos.Location = new Point(3, 204);


            if (panelMantenimientos.Visible == false)
            {
                panelMantenimientos.Visible = true;
                panelMantenimientos.Location = new Point(9,249);
                btnOpciones.Location = new Point(12, 393);
                panelBtnOpciones.Location = new Point(3, 393);
                
            }
            else
            {
                panelGestionEmpleado();
            }
        }

        public void panelGestionOpciones()
        {
            panelDispositivo.Visible = false;
            panelMantenimientos.Visible = false;
            btnMantenimientos.Location = new Point(12, 204);
            panelBtnMantenimientos.Location = new Point(3, 204);
            btnOpciones.Location = new Point(12, 251);
            panelBtnOpciones.Location = new Point(3, 251);

            if (panelOpciones.Visible == false)
            {
                panelOpciones.Visible = true;
                panelOpciones.Location = new Point(9, 297);
            }
            else
            {
                panelGestionEmpleado();
            }
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
             panelGestionMantenimientos();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            panelGestionOpciones();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelGestionDispositivo();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelGestionMantenimientos();
        }

  
        private void btnOpciones_Click_1(object sender, EventArgs e)
        {
            panelGestionOpciones();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (panelLateral.Width == 347)
            {
                panelLateral.Width = 70;
                
            }
            else
            {
                panelLateral.Width = 347;
            }
                
            /*
            if (cont == 0)
            {
                panelLateral.Size = new Size(47, 764);
                panelSuperior.Size = new Size(1360,33);
                panelSuperior.Location = new Point(47, 0);
                imagenUsuario.Location = new Point(1159, 0);
                labelUsuario.Location = new Point(1200, 9);
                cont++;
            }
            else {
                panelLateral.Size = new Size(260, 764);
                panelSuperior.Size = new Size(1360, 33);
                panelSuperior.Location = new Point(260, 0);
                labelUsuario.Location = new Point(976, 9);
                imagenUsuario.Location = new Point(935, 0);
                cont = 0;
            }
            */
        }

        private void btnRegistrarDispositivos_Click(object sender, EventArgs e)
        {
            if (!CheckForm("RegistrarDispositivo"))
            {
                abrirformularioHija(new RegistrarDispositivo());
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (!CheckForm("RegistrarMantenimiento"))
            {
                abrirformularioHija(new RegistrarMantenimiento());
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (!CheckForm("ConsultarMantenimientos"))
            {
                abrirformularioHija(new ConsultarMantenimientos());
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (!CheckForm("ConsultarDispositivoEnMantenimiento"))
            {
                abrirformularioHija(new ConsultarDispositivoEnMantenimiento());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!CheckForm("Mapa"))
            {
                abrirformularioHija(new Mapa());
            }
        }
        private bool CheckForm(string formName)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    abrirformularioHija(f);
                    return true;
                }
            }
            return false;      
        }
    }
}
