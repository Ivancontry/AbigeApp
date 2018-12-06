namespace Presentacion
{
    partial class RegistrarMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMantenimiento));
            this.txtCodigoDispositivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.epIdDispositivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.bnfLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTipDescripcion = new System.Windows.Forms.ToolTip(this.components);
            this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbxEstadoMantenimiento = new System.Windows.Forms.ComboBox();
            this.cbxEstadoDispositivo = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epIdDispositivo)).BeginInit();
            this.grbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoDispositivo
            // 
            this.txtCodigoDispositivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDispositivo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigoDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoDispositivo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDispositivo.HintText = "";
            this.txtCodigoDispositivo.isPassword = false;
            this.txtCodigoDispositivo.LineFocusedColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoDispositivo.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineThickness = 4;
            this.txtCodigoDispositivo.Location = new System.Drawing.Point(270, 39);
            this.txtCodigoDispositivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigoDispositivo.Name = "txtCodigoDispositivo";
            this.txtCodigoDispositivo.Size = new System.Drawing.Size(174, 33);
            this.txtCodigoDispositivo.TabIndex = 6;
            this.txtCodigoDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // epIdDispositivo
            // 
            this.epIdDispositivo.ContainerControl = this;
            // 
            // grbBotones
            // 
            this.grbBotones.Controls.Add(this.bnfLimpiar);
            this.grbBotones.Controls.Add(this.bnfActualizar);
            this.grbBotones.Controls.Add(this.bnfRegistrar);
            this.grbBotones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbBotones.Location = new System.Drawing.Point(57, 347);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(543, 81);
            this.grbBotones.TabIndex = 9;
            this.grbBotones.TabStop = false;
            // 
            // bnfLimpiar
            // 
            this.bnfLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfLimpiar.BackColor = System.Drawing.Color.White;
            this.bnfLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfLimpiar.BorderRadius = 0;
            this.bnfLimpiar.ButtonText = "Limpiar";
            this.bnfLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfLimpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfLimpiar.Iconimage")));
            this.bnfLimpiar.Iconimage_right = null;
            this.bnfLimpiar.Iconimage_right_Selected = null;
            this.bnfLimpiar.Iconimage_Selected = null;
            this.bnfLimpiar.IconMarginLeft = 0;
            this.bnfLimpiar.IconMarginRight = 0;
            this.bnfLimpiar.IconRightVisible = true;
            this.bnfLimpiar.IconRightZoom = 0D;
            this.bnfLimpiar.IconVisible = true;
            this.bnfLimpiar.IconZoom = 60D;
            this.bnfLimpiar.IsTab = false;
            this.bnfLimpiar.Location = new System.Drawing.Point(351, 37);
            this.bnfLimpiar.Name = "bnfLimpiar";
            this.bnfLimpiar.Normalcolor = System.Drawing.Color.White;
            this.bnfLimpiar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfLimpiar.selected = false;
            this.bnfLimpiar.Size = new System.Drawing.Size(147, 32);
            this.bnfLimpiar.TabIndex = 18;
            this.bnfLimpiar.Text = "Limpiar";
            this.bnfLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfLimpiar.Textcolor = System.Drawing.Color.Black;
            this.bnfLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfLimpiar.Click += new System.EventHandler(this.bnfLimpiar_Click);
            // 
            // bnfActualizar
            // 
            this.bnfActualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfActualizar.BackColor = System.Drawing.Color.White;
            this.bnfActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfActualizar.BorderRadius = 0;
            this.bnfActualizar.ButtonText = "Actualizar";
            this.bnfActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfActualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfActualizar.Iconimage")));
            this.bnfActualizar.Iconimage_right = null;
            this.bnfActualizar.Iconimage_right_Selected = null;
            this.bnfActualizar.Iconimage_Selected = null;
            this.bnfActualizar.IconMarginLeft = 0;
            this.bnfActualizar.IconMarginRight = 0;
            this.bnfActualizar.IconRightVisible = true;
            this.bnfActualizar.IconRightZoom = 0D;
            this.bnfActualizar.IconVisible = true;
            this.bnfActualizar.IconZoom = 60D;
            this.bnfActualizar.IsTab = false;
            this.bnfActualizar.Location = new System.Drawing.Point(199, 37);
            this.bnfActualizar.Name = "bnfActualizar";
            this.bnfActualizar.Normalcolor = System.Drawing.Color.White;
            this.bnfActualizar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfActualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfActualizar.selected = false;
            this.bnfActualizar.Size = new System.Drawing.Size(126, 32);
            this.bnfActualizar.TabIndex = 17;
            this.bnfActualizar.Text = "Actualizar";
            this.bnfActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfActualizar.Textcolor = System.Drawing.Color.Black;
            this.bnfActualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfActualizar.Click += new System.EventHandler(this.bnfActualizar_Click);
            // 
            // bnfRegistrar
            // 
            this.bnfRegistrar.Activecolor = System.Drawing.Color.White;
            this.bnfRegistrar.BackColor = System.Drawing.Color.White;
            this.bnfRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfRegistrar.BorderRadius = 0;
            this.bnfRegistrar.ButtonText = "Registrar";
            this.bnfRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfRegistrar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnfRegistrar.Iconimage")));
            this.bnfRegistrar.Iconimage_right = null;
            this.bnfRegistrar.Iconimage_right_Selected = null;
            this.bnfRegistrar.Iconimage_Selected = null;
            this.bnfRegistrar.IconMarginLeft = 0;
            this.bnfRegistrar.IconMarginRight = 0;
            this.bnfRegistrar.IconRightVisible = true;
            this.bnfRegistrar.IconRightZoom = 0D;
            this.bnfRegistrar.IconVisible = true;
            this.bnfRegistrar.IconZoom = 60D;
            this.bnfRegistrar.IsTab = false;
            this.bnfRegistrar.Location = new System.Drawing.Point(56, 37);
            this.bnfRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnfRegistrar.Name = "bnfRegistrar";
            this.bnfRegistrar.Normalcolor = System.Drawing.Color.White;
            this.bnfRegistrar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfRegistrar.selected = false;
            this.bnfRegistrar.Size = new System.Drawing.Size(126, 32);
            this.bnfRegistrar.TabIndex = 16;
            this.bnfRegistrar.Text = "Registrar";
            this.bnfRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfRegistrar.Textcolor = System.Drawing.Color.Black;
            this.bnfRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfRegistrar.Click += new System.EventHandler(this.bnfRegistrar_Click);
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
            this.bnfBuscar.Location = new System.Drawing.Point(478, 39);
            this.bnfBuscar.Name = "bnfBuscar";
            this.bnfBuscar.Normalcolor = System.Drawing.Color.White;
            this.bnfBuscar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfBuscar.selected = false;
            this.bnfBuscar.Size = new System.Drawing.Size(122, 33);
            this.bnfBuscar.TabIndex = 10;
            this.bnfBuscar.Text = "Buscar";
            this.bnfBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfBuscar.Textcolor = System.Drawing.Color.Black;
            this.bnfBuscar.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBuscar.Click += new System.EventHandler(this.bnfBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(270, 130);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescripcion.Size = new System.Drawing.Size(330, 189);
            this.txtDescripcion.TabIndex = 12;
           
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 106);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Fecha";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(266, 105);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 21);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Descripcion";
            // 
            // toolTipDescripcion
            // 
            this.toolTipDescripcion.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDescripcion.ToolTipTitle = "Error de Digitacion";
            // 
            // epDescripcion
            // 
            this.epDescripcion.ContainerControl = this;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(53, 187);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(179, 20);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Estado Mantenimiento";
            
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(53, 258);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Estado Dispositivo";
          
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
            this.cbxEstadoMantenimiento.Location = new System.Drawing.Point(57, 222);
            this.cbxEstadoMantenimiento.Name = "cbxEstadoMantenimiento";
            this.cbxEstadoMantenimiento.Size = new System.Drawing.Size(182, 21);
            this.cbxEstadoMantenimiento.TabIndex = 23;
            this.cbxEstadoMantenimiento.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoMantenimiento_SelectedIndexChanged);
            // 
            // cbxEstadoDispositivo
            // 
            this.cbxEstadoDispositivo.BackColor = System.Drawing.Color.White;
            this.cbxEstadoDispositivo.FormattingEnabled = true;
            this.cbxEstadoDispositivo.Items.AddRange(new object[] {
            "En Espera",
            "Funcionando",
            "Dañado"});
            this.cbxEstadoDispositivo.Location = new System.Drawing.Point(57, 291);
            this.cbxEstadoDispositivo.Name = "cbxEstadoDispositivo";
            this.cbxEstadoDispositivo.Size = new System.Drawing.Size(182, 21);
            this.cbxEstadoDispositivo.TabIndex = 24;
            
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(57, 147);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(182, 22);
            this.fecha.TabIndex = 25;

            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(53, 52);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(183, 20);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Codigo del Dispositivo";
            // 
            // RegistrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 440);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.cbxEstadoDispositivo);
            this.Controls.Add(this.cbxEstadoMantenimiento);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.bnfBuscar);
            this.Controls.Add(this.grbBotones);
            this.Controls.Add(this.txtCodigoDispositivo);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarMantenimiento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistrarMantenimiento";
            this.Load += new System.EventHandler(this.RegistrarMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epIdDispositivo)).EndInit();
            this.grbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoDispositivo;
        private System.Windows.Forms.ErrorProvider epIdDispositivo;
        private Bunifu.Framework.UI.BunifuFlatButton bnfBuscar;
        private System.Windows.Forms.GroupBox grbBotones;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Bunifu.Framework.UI.BunifuFlatButton bnfActualizar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfRegistrar;
        private System.Windows.Forms.ToolTip toolTipDescripcion;
        private System.Windows.Forms.ErrorProvider epDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cbxEstadoDispositivo;
        private System.Windows.Forms.ComboBox cbxEstadoMantenimiento;
        private System.Windows.Forms.DateTimePicker fecha;
        private Bunifu.Framework.UI.BunifuFlatButton bnfLimpiar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}