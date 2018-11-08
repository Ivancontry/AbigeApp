namespace Presentacion
{
    partial class ConsultarMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMantenimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.bnfFuncionando = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfAveridadoTaller = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfAveriadoFinca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfDañados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.bnfGeneral = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelDañado = new System.Windows.Forms.Label();
            this.labelAveriadoTaller = new System.Windows.Forms.Label();
            this.labelAveridadoFinca = new System.Windows.Forms.Label();
            this.labelFuncionando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaGeneral = new System.Windows.Forms.DataGridView();
            this.codigoDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            this.bnfFuncionando.Location = new System.Drawing.Point(152, 42);
            this.bnfFuncionando.Name = "bnfFuncionando";
            this.bnfFuncionando.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfFuncionando.OnHovercolor = System.Drawing.Color.Lime;
            this.bnfFuncionando.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfFuncionando.selected = false;
            this.bnfFuncionando.Size = new System.Drawing.Size(146, 29);
            this.bnfFuncionando.TabIndex = 24;
            this.bnfFuncionando.Text = "Funcionando";
            this.bnfFuncionando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfFuncionando.Textcolor = System.Drawing.Color.Black;
            this.bnfFuncionando.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bnfAveridadoTaller
            // 
            this.bnfAveridadoTaller.Activecolor = System.Drawing.Color.Gold;
            this.bnfAveridadoTaller.BackColor = System.Drawing.Color.Gold;
            this.bnfAveridadoTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfAveridadoTaller.BorderRadius = 0;
            this.bnfAveridadoTaller.ButtonText = "Taller";
            this.bnfAveridadoTaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfAveridadoTaller.DisabledColor = System.Drawing.Color.Gray;
            this.bnfAveridadoTaller.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfAveridadoTaller.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfAveridadoTaller.Iconimage")));
            this.bnfAveridadoTaller.Iconimage_right = null;
            this.bnfAveridadoTaller.Iconimage_right_Selected = null;
            this.bnfAveridadoTaller.Iconimage_Selected = null;
            this.bnfAveridadoTaller.IconMarginLeft = 0;
            this.bnfAveridadoTaller.IconMarginRight = 0;
            this.bnfAveridadoTaller.IconRightVisible = true;
            this.bnfAveridadoTaller.IconRightZoom = 0D;
            this.bnfAveridadoTaller.IconVisible = true;
            this.bnfAveridadoTaller.IconZoom = 60D;
            this.bnfAveridadoTaller.IsTab = false;
            this.bnfAveridadoTaller.Location = new System.Drawing.Point(598, 40);
            this.bnfAveridadoTaller.Name = "bnfAveridadoTaller";
            this.bnfAveridadoTaller.Normalcolor = System.Drawing.Color.Gold;
            this.bnfAveridadoTaller.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnfAveridadoTaller.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfAveridadoTaller.selected = false;
            this.bnfAveridadoTaller.Size = new System.Drawing.Size(93, 29);
            this.bnfAveridadoTaller.TabIndex = 26;
            this.bnfAveridadoTaller.Text = "Taller";
            this.bnfAveridadoTaller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfAveridadoTaller.Textcolor = System.Drawing.Color.Black;
            this.bnfAveridadoTaller.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bnfAveriadoFinca
            // 
            this.bnfAveriadoFinca.Activecolor = System.Drawing.Color.Yellow;
            this.bnfAveriadoFinca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bnfAveriadoFinca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfAveriadoFinca.BorderRadius = 2;
            this.bnfAveriadoFinca.ButtonText = "Finca";
            this.bnfAveriadoFinca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfAveriadoFinca.DisabledColor = System.Drawing.Color.Gray;
            this.bnfAveriadoFinca.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfAveriadoFinca.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfAveriadoFinca.Iconimage")));
            this.bnfAveriadoFinca.Iconimage_right = null;
            this.bnfAveriadoFinca.Iconimage_right_Selected = null;
            this.bnfAveriadoFinca.Iconimage_Selected = null;
            this.bnfAveriadoFinca.IconMarginLeft = 0;
            this.bnfAveriadoFinca.IconMarginRight = 0;
            this.bnfAveriadoFinca.IconRightVisible = true;
            this.bnfAveriadoFinca.IconRightZoom = 0D;
            this.bnfAveriadoFinca.IconVisible = true;
            this.bnfAveriadoFinca.IconZoom = 60D;
            this.bnfAveriadoFinca.IsTab = false;
            this.bnfAveriadoFinca.Location = new System.Drawing.Point(483, 42);
            this.bnfAveriadoFinca.Name = "bnfAveriadoFinca";
            this.bnfAveriadoFinca.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bnfAveriadoFinca.OnHovercolor = System.Drawing.Color.Yellow;
            this.bnfAveriadoFinca.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfAveriadoFinca.selected = false;
            this.bnfAveriadoFinca.Size = new System.Drawing.Size(93, 29);
            this.bnfAveriadoFinca.TabIndex = 27;
            this.bnfAveriadoFinca.Text = "Finca";
            this.bnfAveriadoFinca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfAveriadoFinca.Textcolor = System.Drawing.Color.Black;
            this.bnfAveriadoFinca.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bnfDañados.Location = new System.Drawing.Point(341, 42);
            this.bnfDañados.Name = "bnfDañados";
            this.bnfDañados.Normalcolor = System.Drawing.Color.Red;
            this.bnfDañados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnfDañados.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfDañados.selected = false;
            this.bnfDañados.Size = new System.Drawing.Size(98, 29);
            this.bnfDañados.TabIndex = 28;
            this.bnfDañados.Text = "Dañados";
            this.bnfDañados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfDañados.Textcolor = System.Drawing.Color.Black;
            this.bnfDañados.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGeneral);
            this.groupBox1.Controls.Add(this.bnfGeneral);
            this.groupBox1.Controls.Add(this.labelDañado);
            this.groupBox1.Controls.Add(this.labelAveriadoTaller);
            this.groupBox1.Controls.Add(this.labelAveridadoFinca);
            this.groupBox1.Controls.Add(this.labelFuncionando);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bnfFuncionando);
            this.groupBox1.Controls.Add(this.bnfDañados);
            this.groupBox1.Controls.Add(this.bnfAveriadoFinca);
            this.groupBox1.Controls.Add(this.bnfAveridadoTaller);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 77);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // labelGeneral
            // 
            this.labelGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(110, 42);
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
            this.bnfGeneral.Location = new System.Drawing.Point(20, 42);
            this.bnfGeneral.Name = "bnfGeneral";
            this.bnfGeneral.Normalcolor = System.Drawing.Color.White;
            this.bnfGeneral.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bnfGeneral.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfGeneral.selected = false;
            this.bnfGeneral.Size = new System.Drawing.Size(98, 29);
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
            this.labelDañado.Location = new System.Drawing.Point(430, 42);
            this.labelDañado.Name = "labelDañado";
            this.labelDañado.Size = new System.Drawing.Size(26, 29);
            this.labelDañado.TabIndex = 33;
            this.labelDañado.Text = "0";
            this.labelDañado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAveriadoTaller
            // 
            this.labelAveriadoTaller.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAveriadoTaller.AutoSize = true;
            this.labelAveriadoTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAveriadoTaller.Location = new System.Drawing.Point(687, 40);
            this.labelAveriadoTaller.Name = "labelAveriadoTaller";
            this.labelAveriadoTaller.Size = new System.Drawing.Size(26, 29);
            this.labelAveriadoTaller.TabIndex = 32;
            this.labelAveriadoTaller.Text = "0";
            this.labelAveriadoTaller.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAveridadoFinca
            // 
            this.labelAveridadoFinca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAveridadoFinca.AutoSize = true;
            this.labelAveridadoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAveridadoFinca.Location = new System.Drawing.Point(555, 42);
            this.labelAveridadoFinca.Name = "labelAveridadoFinca";
            this.labelAveridadoFinca.Size = new System.Drawing.Size(26, 29);
            this.labelAveridadoFinca.TabIndex = 31;
            this.labelAveridadoFinca.Text = "0";
            this.labelAveridadoFinca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFuncionando
            // 
            this.labelFuncionando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFuncionando.AutoSize = true;
            this.labelFuncionando.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionando.Location = new System.Drawing.Point(287, 42);
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
            this.label1.Location = new System.Drawing.Point(547, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Averiados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablaGeneral
            // 
            this.tablaGeneral.AllowUserToAddRows = false;
            this.tablaGeneral.AllowUserToDeleteRows = false;
            this.tablaGeneral.BackgroundColor = System.Drawing.Color.White;
            this.tablaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDispositivo,
            this.descripcion,
            this.fecha,
            this.estadoMantenimiento,
            this.estadoDispositivo,
            this.estadoActual});
            this.tablaGeneral.GridColor = System.Drawing.Color.White;
            this.tablaGeneral.Location = new System.Drawing.Point(12, 267);
            this.tablaGeneral.Name = "tablaGeneral";
            this.tablaGeneral.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tablaGeneral.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaGeneral.Size = new System.Drawing.Size(726, 151);
            this.tablaGeneral.TabIndex = 30;
            // 
            // codigoDispositivo
            // 
            this.codigoDispositivo.HeaderText = "Cod_Dispositivo";
            this.codigoDispositivo.Name = "codigoDispositivo";
            this.codigoDispositivo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 180;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // estadoMantenimiento
            // 
            this.estadoMantenimiento.HeaderText = "Est_Mantenimiento";
            this.estadoMantenimiento.Name = "estadoMantenimiento";
            this.estadoMantenimiento.ReadOnly = true;
            // 
            // estadoDispositivo
            // 
            this.estadoDispositivo.HeaderText = "Est_Dispositivo";
            this.estadoDispositivo.Name = "estadoDispositivo";
            this.estadoDispositivo.ReadOnly = true;
            // 
            // estadoActual
            // 
            this.estadoActual.HeaderText = "EstadoActual";
            this.estadoActual.Name = "estadoActual";
            this.estadoActual.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 88);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(726, 173);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // ConsultarMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 473);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tablaGeneral);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarMantenimientos";
            this.Text = "ConsultarMantenimientos";
            this.Load += new System.EventHandler(this.ConsultarMantenimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bnfFuncionando;
        private Bunifu.Framework.UI.BunifuFlatButton bnfAveridadoTaller;
        private Bunifu.Framework.UI.BunifuFlatButton bnfAveriadoFinca;
        private Bunifu.Framework.UI.BunifuFlatButton bnfDañados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDañado;
        private System.Windows.Forms.Label labelAveriadoTaller;
        private System.Windows.Forms.Label labelAveridadoFinca;
        private System.Windows.Forms.Label labelFuncionando;
        private System.Windows.Forms.Label labelGeneral;
        private Bunifu.Framework.UI.BunifuFlatButton bnfGeneral;
        private System.Windows.Forms.DataGridView tablaGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoActual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}