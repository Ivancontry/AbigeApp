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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bnfFuncionando = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfDañados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.bnfGeneral = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelDañado = new System.Windows.Forms.Label();
            this.labelFuncionando = new System.Windows.Forms.Label();
            this.tablaGeneral = new System.Windows.Forms.DataGridView();
            this.codigoDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCantidadTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnfBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.bnfFuncionando.Location = new System.Drawing.Point(335, 41);
            this.bnfFuncionando.Margin = new System.Windows.Forms.Padding(4);
            this.bnfFuncionando.Name = "bnfFuncionando";
            this.bnfFuncionando.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfFuncionando.OnHovercolor = System.Drawing.Color.Lime;
            this.bnfFuncionando.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfFuncionando.selected = false;
            this.bnfFuncionando.Size = new System.Drawing.Size(170, 29);
            this.bnfFuncionando.TabIndex = 24;
            this.bnfFuncionando.Text = "Funcionando";
            this.bnfFuncionando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfFuncionando.Textcolor = System.Drawing.Color.Black;
            this.bnfFuncionando.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfFuncionando.Click += new System.EventHandler(this.bnfFuncionando_Click);
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
            this.bnfDañados.Location = new System.Drawing.Point(556, 41);
            this.bnfDañados.Margin = new System.Windows.Forms.Padding(4);
            this.bnfDañados.Name = "bnfDañados";
            this.bnfDañados.Normalcolor = System.Drawing.Color.Red;
            this.bnfDañados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnfDañados.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfDañados.selected = false;
            this.bnfDañados.Size = new System.Drawing.Size(114, 29);
            this.bnfDañados.TabIndex = 28;
            this.bnfDañados.Text = "Dañados";
            this.bnfDañados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfDañados.Textcolor = System.Drawing.Color.Black;
            this.bnfDañados.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfDañados.Click += new System.EventHandler(this.bnfDañados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGeneral);
            this.groupBox1.Controls.Add(this.bnfGeneral);
            this.groupBox1.Controls.Add(this.labelDañado);
            this.groupBox1.Controls.Add(this.labelFuncionando);
            this.groupBox1.Controls.Add(this.bnfFuncionando);
            this.groupBox1.Controls.Add(this.bnfDañados);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 77);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // labelGeneral
            // 
            this.labelGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(286, 41);
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
            this.bnfGeneral.Location = new System.Drawing.Point(181, 41);
            this.bnfGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.bnfGeneral.Name = "bnfGeneral";
            this.bnfGeneral.Normalcolor = System.Drawing.Color.White;
            this.bnfGeneral.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bnfGeneral.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfGeneral.selected = false;
            this.bnfGeneral.Size = new System.Drawing.Size(114, 29);
            this.bnfGeneral.TabIndex = 34;
            this.bnfGeneral.Text = "General";
            this.bnfGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfGeneral.Textcolor = System.Drawing.Color.Black;
            this.bnfGeneral.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfGeneral.Click += new System.EventHandler(this.bnfGeneral_Click);
            // 
            // labelDañado
            // 
            this.labelDañado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDañado.AutoSize = true;
            this.labelDañado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDañado.Location = new System.Drawing.Point(660, 41);
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
            this.labelFuncionando.Location = new System.Drawing.Point(493, 41);
            this.labelFuncionando.Name = "labelFuncionando";
            this.labelFuncionando.Size = new System.Drawing.Size(26, 29);
            this.labelFuncionando.TabIndex = 30;
            this.labelFuncionando.Text = "0";
            this.labelFuncionando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.estadoActual});
            this.tablaGeneral.GridColor = System.Drawing.Color.White;
            this.tablaGeneral.Location = new System.Drawing.Point(123, 401);
            this.tablaGeneral.Name = "tablaGeneral";
            this.tablaGeneral.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tablaGeneral.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaGeneral.Size = new System.Drawing.Size(622, 221);
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
            this.chart1.Location = new System.Drawing.Point(15, 145);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(847, 235);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            title1.Name = "Top de los dispositivos con mas mantenimientos";
            this.chart1.Titles.Add(title1);
            // 
            // txtCantidadTop
            // 
            this.txtCantidadTop.Location = new System.Drawing.Point(134, 32);
            this.txtCantidadTop.Name = "txtCantidadTop";
            this.txtCantidadTop.Size = new System.Drawing.Size(133, 20);
            this.txtCantidadTop.TabIndex = 32;
            this.txtCantidadTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadTop_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Numero de Dispositivos";
            // 
            // fecha1
            // 
            this.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha1.Location = new System.Drawing.Point(297, 32);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(125, 20);
            this.fecha1.TabIndex = 36;
            // 
            // fecha2
            // 
            this.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha2.Location = new System.Drawing.Point(471, 32);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(125, 20);
            this.fecha2.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnfBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCantidadTop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fecha2);
            this.groupBox2.Controls.Add(this.fecha1);
            this.groupBox2.Location = new System.Drawing.Point(14, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 58);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.bnfBuscar.Location = new System.Drawing.Point(625, 19);
            this.bnfBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bnfBuscar.Name = "bnfBuscar";
            this.bnfBuscar.Normalcolor = System.Drawing.Color.White;
            this.bnfBuscar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfBuscar.selected = false;
            this.bnfBuscar.Size = new System.Drawing.Size(106, 33);
            this.bnfBuscar.TabIndex = 41;
            this.bnfBuscar.Text = "Buscar";
            this.bnfBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfBuscar.Textcolor = System.Drawing.Color.Black;
            this.bnfBuscar.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBuscar.Click += new System.EventHandler(this.bnfRegsitrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha 1";
            // 
            // ConsultarMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tablaGeneral);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarMantenimientos";
            this.Text = "ConsultarMantenimientos";
            this.Load += new System.EventHandler(this.ConsultarMantenimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bnfFuncionando;
        private Bunifu.Framework.UI.BunifuFlatButton bnfDañados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDañado;
        private System.Windows.Forms.Label labelFuncionando;
        private System.Windows.Forms.Label labelGeneral;
        private Bunifu.Framework.UI.BunifuFlatButton bnfGeneral;
        private System.Windows.Forms.DataGridView tablaGeneral;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtCantidadTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bnfBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoActual;
    }
}