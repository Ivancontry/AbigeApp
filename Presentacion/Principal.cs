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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void btnGestionDispositivo_Click(object sender, EventArgs e)
        {
            if (panelDispositivo.Visible == false)
            {
                panelDispositivo.Visible = true;
                btnOpciones.Location = new Point(15,163);
            }
            else {
                panelDispositivo.Visible = false;
                posicionarMenuLocal();
            }
        }

        public void posicionarMenuLocal() {
          
            if (panelDispositivo.Visible)
            {
                //panelDispositivo.Visible = false;
                //panelOpciones.Visible = false;
                btnOpciones.Location = new Point(15, 163);
                panelBtnOpciones.Location = new Point(12, 163);
            }
            
        }
    }
}
