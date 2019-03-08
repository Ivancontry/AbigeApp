namespace Presentacion
{
    partial class ConsultarDispositivoEnMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarDispositivoEnMantenimiento));
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cbxEstadoMantenimiento = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoDispositivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.figura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.epIdDispositivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.bnfBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.bnfGeneral = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelDañado = new System.Windows.Forms.Label();
            this.labelFuncionando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnfFuncionando = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfDañados = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.figura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIdDispositivo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(75, 113);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(182, 20);
            this.fecha.TabIndex = 33;
            // 
            // cbxEstadoMantenimiento
            // 
            this.cbxEstadoMantenimiento.BackColor = System.Drawing.Color.White;
            this.cbxEstadoMantenimiento.DropDownHeight = 134;
            this.cbxEstadoMantenimiento.FormattingEnabled = true;
            this.cbxEstadoMantenimiento.IntegralHeight = false;
            this.cbxEstadoMantenimiento.ItemHeight = 13;
            this.cbxEstadoMantenimiento.Items.AddRange(new object[] {
            "Pendiente",
            "Enviado",
            "Revisado"});
            this.cbxEstadoMantenimiento.Location = new System.Drawing.Point(75, 188);
            this.cbxEstadoMantenimiento.Name = "cbxEstadoMantenimiento";
            this.cbxEstadoMantenimiento.Size = new System.Drawing.Size(182, 21);
            this.cbxEstadoMantenimiento.TabIndex = 31;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(71, 153);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(179, 20);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Estado Mantenimiento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(288, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescripcion.Size = new System.Drawing.Size(330, 113);
            this.txtDescripcion.TabIndex = 28;
            // 
            // txtCodigoDispositivo
            // 
            this.txtCodigoDispositivo.BackColor = System.Drawing.Color.White;
            this.txtCodigoDispositivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDispositivo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDispositivo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoDispositivo.HintForeColor = System.Drawing.Color.Black;
            this.txtCodigoDispositivo.HintText = "";
            this.txtCodigoDispositivo.isPassword = false;
            this.txtCodigoDispositivo.LineFocusedColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoDispositivo.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineThickness = 4;
            this.txtCodigoDispositivo.Location = new System.Drawing.Point(288, 17);
            this.txtCodigoDispositivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigoDispositivo.Name = "txtCodigoDispositivo";
            this.txtCodigoDispositivo.Size = new System.Drawing.Size(208, 33);
            this.txtCodigoDispositivo.TabIndex = 1;
            this.txtCodigoDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoDispositivo.OnValueChanged += new System.EventHandler(this.txtCodigoDispositivo_OnValueChanged);
            // 
            // figura
            // 
            chartArea1.Name = "ChartArea1";
            this.figura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.figura.Legends.Add(legend1);
            this.figura.Location = new System.Drawing.Point(12, 319);
            this.figura.Name = "figura";
            this.figura.Size = new System.Drawing.Size(678, 332);
            this.figura.TabIndex = 34;
            this.figura.Text = "chart1";
            // 
            // epIdDispositivo
            // 
            this.epIdDispositivo.ContainerControl = this;
            // 
            // bnfBuscar
            // 
            this.bnfBuscar.Activecolor = System.Drawing.Color.White;
            this.bnfBuscar.BackColor = System.Drawing.Color.White;
            this.bnfBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfBuscar.BorderRadius = 0;
            this.bnfBuscar.ButtonText = "Buscar";
            this.bnfBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfBuscar.Iconimage")));
            this.bnfBuscar.Iconimage_right = null;
            this.bnfBuscar.Iconimage_right_Selected = null;
            this.bnfBuscar.Iconimage_Selected = null;
            this.bnfBuscar.IconMarginLeft = 0;
            this.bnfBuscar.IconMarginRight = 0;
            this.bnfBuscar.IconRightVisible = true;
            this.bnfBuscar.IconRightZoom = 0D;
            this.bnfBuscar.IconVisible = true;
            this.bnfBuscar.IconZoom = 60D;
            this.bnfBuscar.IsTab = false;
            this.bnfBuscar.Location = new System.Drawing.Point(518, 17);
            this.bnfBuscar.Name = "bnfBuscar";
            this.bnfBuscar.Normalcolor = System.Drawing.Color.White;
            this.bnfBuscar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfBuscar.selected = false;
            this.bnfBuscar.Size = new System.Drawing.Size(100, 33);
            this.bnfBuscar.TabIndex = 27;
            this.bnfBuscar.Text = "Buscar";
            this.bnfBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfBuscar.Textcolor = System.Drawing.Color.Black;
            this.bnfBuscar.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBuscar.Click += new System.EventHandler(this.bnfBuscar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(71, 74);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Fecha";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(71, 30);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(183, 20);
            this.bunifuCustomLabel2.TabIndex = 36;
            this.bunifuCustomLabel2.Text = "Codigo del Dispositivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGeneral);
            this.groupBox1.Controls.Add(this.bnfGeneral);
            this.groupBox1.Controls.Add(this.labelDañado);
            this.groupBox1.Controls.Add(this.labelFuncionando);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bnfFuncionando);
            this.groupBox1.Controls.Add(this.bnfDañados);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 60);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // labelGeneral
            // 
            this.labelGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(238, 19);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(26, 29);
            this.labelGeneral.TabIndex = 35;
            this.labelGeneral.Text = "0";
            this.labelGeneral.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bnfGeneral
            // 
            this.bnfGeneral.Activecolor = System.Drawing.Color.White;
            this.bnfGeneral.BackColor = System.Drawing.Color.White;
            this.bnfGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfGeneral.BorderRadius = 0;
            this.bnfGeneral.ButtonText = "General";
            this.bnfGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfGeneral.DisabledColor = System.Drawing.Color.Gray;
            this.bnfGeneral.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfGeneral.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfGeneral.Iconimage")));
            this.bnfGeneral.Iconimage_right = null;
            this.bnfGeneral.Iconimage_right_Selected = null;
            this.bnfGeneral.Iconimage_Selected = null;
            this.bnfGeneral.IconMarginLeft = 0;
            this.bnfGeneral.IconMarginRight = 0;
            this.bnfGeneral.IconRightVisible = true;
            this.bnfGeneral.IconRightZoom = 0D;
            this.bnfGeneral.IconVisible = true;
            this.bnfGeneral.IconZoom = 60D;
            this.bnfGeneral.IsTab = false;
            this.bnfGeneral.Location = new System.Drawing.Point(153, 19);
            this.bnfGeneral.Name = "bnfGeneral";
            this.bnfGeneral.Normalcolor = System.Drawing.Color.White;
            this.bnfGeneral.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bnfGeneral.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfGeneral.selected = false;
            this.bnfGeneral.Size = new System.Drawing.Size(85, 29);
            this.bnfGeneral.TabIndex = 34;
            this.bnfGeneral.Text = "General";
            this.bnfGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfGeneral.Textcolor = System.Drawing.Color.Black;
            this.bnfGeneral.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelDañado
            // 
            this.labelDañado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDañado.AutoSize = true;
            this.labelDañado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDañado.Location = new System.Drawing.Point(538, 19);
            this.labelDañado.Name = "labelDañado";
            this.labelDañado.Size = new System.Drawing.Size(26, 29);
            this.labelDañado.TabIndex = 33;
            this.labelDañado.Text = "0";
            this.labelDañado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFuncionando
            // 
            this.labelFuncionando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFuncionando.AutoSize = true;
            this.labelFuncionando.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionando.Location = new System.Drawing.Point(395, 19);
            this.labelFuncionando.Name = "labelFuncionando";
            this.labelFuncionando.Size = new System.Drawing.Size(26, 29);
            this.labelFuncionando.TabIndex = 30;
            this.labelFuncionando.Text = "0";
            this.labelFuncionando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(144, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Averiados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bnfFuncionando
            // 
            this.bnfFuncionando.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfFuncionando.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnfFuncionando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfFuncionando.BorderRadius = 0;
            this.bnfFuncionando.ButtonText = "Funcionando";
            this.bnfFuncionando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfFuncionando.DisabledColor = System.Drawing.Color.Gray;
            this.bnfFuncionando.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfFuncionando.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfFuncionando.Iconimage")));
            this.bnfFuncionando.Iconimage_right = null;
            this.bnfFuncionando.Iconimage_right_Selected = null;
            this.bnfFuncionando.Iconimage_Selected = null;
            this.bnfFuncionando.IconMarginLeft = 0;
            this.bnfFuncionando.IconMarginRight = 0;
            this.bnfFuncionando.IconRightVisible = true;
            this.bnfFuncionando.IconRightZoom = 0D;
            this.bnfFuncionando.IconVisible = true;
            this.bnfFuncionando.IconZoom = 60D;
            this.bnfFuncionando.IsTab = false;
            this.bnfFuncionando.Location = new System.Drawing.Point(276, 19);
            this.bnfFuncionando.Name = "bnfFuncionando";
            this.bnfFuncionando.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfFuncionando.OnHovercolor = System.Drawing.Color.Lime;
            this.bnfFuncionando.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfFuncionando.selected = false;
            this.bnfFuncionando.Size = new System.Drawing.Size(129, 29);
            this.bnfFuncionando.TabIndex = 24;
            this.bnfFuncionando.Text = "Funcionando";
            this.bnfFuncionando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfFuncionando.Textcolor = System.Drawing.Color.Black;
            this.bnfFuncionando.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bnfDañados
            // 
            this.bnfDañados.Activecolor = System.Drawing.Color.White;
            this.bnfDañados.BackColor = System.Drawing.Color.Red;
            this.bnfDañados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfDañados.BorderRadius = 0;
            this.bnfDañados.ButtonText = "Dañados";
            this.bnfDañados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfDañados.DisabledColor = System.Drawing.Color.Gray;
            this.bnfDañados.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfDañados.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfDañados.Iconimage")));
            this.bnfDañados.Iconimage_right = null;
            this.bnfDañados.Iconimage_right_Selected = null;
            this.bnfDañados.Iconimage_Selected = null;
            this.bnfDañados.IconMarginLeft = 0;
            this.bnfDañados.IconMarginRight = 0;
            this.bnfDañados.IconRightVisible = true;
            this.bnfDañados.IconRightZoom = 0D;
            this.bnfDañados.IconVisible = true;
            this.bnfDañados.IconZoom = 60D;
            this.bnfDañados.IsTab = false;
            this.bnfDañados.Location = new System.Drawing.Point(449, 19);
            this.bnfDañados.Name = "bnfDañados";
            this.bnfDañados.Normalcolor = System.Drawing.Color.Red;
            this.bnfDañados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnfDañados.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfDañados.selected = false;
            this.bnfDañados.Size = new System.Drawing.Size(101, 29);
            this.bnfDañados.TabIndex = 28;
            this.bnfDañados.Text = "Dañados";
            this.bnfDañados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfDañados.Textcolor = System.Drawing.Color.Black;
            this.bnfDañados.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ConsultarDispositivoEnMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.figura);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.cbxEstadoMantenimiento);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.bnfBuscar);
            this.Controls.Add(this.txtCodigoDispositivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarDispositivoEnMantenimiento";
            this.Text = "ConsultarDispositivoEnMantenimiento";
            this.Load += new System.EventHandler(this.ConsultarDispositivoEnMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.figura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIdDispositivo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox cbxEstadoMantenimiento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Bunifu.Framework.UI.BunifuFlatButton bnfBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoDispositivo;
        private System.Windows.Forms.DataVisualization.Charting.Chart figura;
        private System.Windows.Forms.ErrorProvider epIdDispositivo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGeneral;
        private Bunifu.Framework.UI.BunifuFlatButton bnfGeneral;
        private System.Windows.Forms.Label labelDañado;
        private System.Windows.Forms.Label labelFuncionando;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFuncionando;
        private Bunifu.Framework.UI.BunifuFlatButton bnfDañados;
    }
}