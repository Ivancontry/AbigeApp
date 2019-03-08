namespace Presentacion
{
    partial class RegistrarDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarDispositivo));
            this.mapaDispositivo = new GMap.NET.WindowsForms.GMapControl();
            this.txtCodigoDispositivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoAnimal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBateria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.bnfLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.epCodigoDispoitivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPerimetro = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoAnimal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBateria = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxPerimetro = new System.Windows.Forms.ComboBox();
            this.bnfBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoDispoitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPerimetro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBateria)).BeginInit();
            this.SuspendLayout();
            // 
            // mapaDispositivo
            // 
            this.mapaDispositivo.Bearing = 0F;
            this.mapaDispositivo.CanDragMap = true;
            this.mapaDispositivo.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaDispositivo.GrayScaleMode = false;
            this.mapaDispositivo.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaDispositivo.LevelsKeepInMemmory = 5;
            this.mapaDispositivo.Location = new System.Drawing.Point(435, 12);
            this.mapaDispositivo.MarkersEnabled = true;
            this.mapaDispositivo.MaxZoom = 2;
            this.mapaDispositivo.MinZoom = 2;
            this.mapaDispositivo.MouseWheelZoomEnabled = true;
            this.mapaDispositivo.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaDispositivo.Name = "mapaDispositivo";
            this.mapaDispositivo.NegativeMode = false;
            this.mapaDispositivo.PolygonsEnabled = true;
            this.mapaDispositivo.RetryLoadTile = 0;
            this.mapaDispositivo.RoutesEnabled = true;
            this.mapaDispositivo.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaDispositivo.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaDispositivo.ShowTileGridLines = false;
            this.mapaDispositivo.Size = new System.Drawing.Size(195, 138);
            this.mapaDispositivo.TabIndex = 0;
            this.mapaDispositivo.Zoom = 0D;
            // 
            // txtCodigoDispositivo
            // 
            this.txtCodigoDispositivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDispositivo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigoDispositivo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoDispositivo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDispositivo.HintText = "";
            this.txtCodigoDispositivo.isPassword = false;
            this.txtCodigoDispositivo.LineFocusedColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoDispositivo.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtCodigoDispositivo.LineThickness = 3;
            this.txtCodigoDispositivo.Location = new System.Drawing.Point(24, 25);
            this.txtCodigoDispositivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigoDispositivo.Name = "txtCodigoDispositivo";
            this.txtCodigoDispositivo.Size = new System.Drawing.Size(231, 33);
            this.txtCodigoDispositivo.TabIndex = 11;
            this.txtCodigoDispositivo.Text = "Codigo del Dispositivo";
            this.txtCodigoDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoDispositivo.Enter += new System.EventHandler(this.txtCodigoDispositivo_Enter);
            this.txtCodigoDispositivo.Leave += new System.EventHandler(this.txtCodigoDispositivo_Leave);
            // 
            // txtCodigoAnimal
            // 
            this.txtCodigoAnimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoAnimal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoAnimal.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoAnimal.HintText = "";
            this.txtCodigoAnimal.isPassword = false;
            this.txtCodigoAnimal.LineFocusedColor = System.Drawing.Color.Green;
            this.txtCodigoAnimal.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoAnimal.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtCodigoAnimal.LineThickness = 3;
            this.txtCodigoAnimal.Location = new System.Drawing.Point(238, 117);
            this.txtCodigoAnimal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigoAnimal.Name = "txtCodigoAnimal";
            this.txtCodigoAnimal.Size = new System.Drawing.Size(177, 33);
            this.txtCodigoAnimal.TabIndex = 14;
            this.txtCodigoAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBateria
            // 
            this.txtBateria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBateria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBateria.HintForeColor = System.Drawing.Color.Empty;
            this.txtBateria.HintText = "";
            this.txtBateria.isPassword = false;
            this.txtBateria.LineFocusedColor = System.Drawing.Color.Green;
            this.txtBateria.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtBateria.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtBateria.LineThickness = 3;
            this.txtBateria.Location = new System.Drawing.Point(238, 193);
            this.txtBateria.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBateria.Name = "txtBateria";
            this.txtBateria.Size = new System.Drawing.Size(177, 33);
            this.txtBateria.TabIndex = 16;
            this.txtBateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 92);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 21);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Perimetro";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(234, 92);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(153, 21);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Codigo del animal";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 168);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 21);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Estado";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(234, 168);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Bateria";
            // 
            // grbBotones
            // 
            this.grbBotones.Controls.Add(this.bnfLimpiar);
            this.grbBotones.Controls.Add(this.bnfActualizar);
            this.grbBotones.Controls.Add(this.bnfRegistrar);
            this.grbBotones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbBotones.Location = new System.Drawing.Point(12, 251);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(618, 81);
            this.grbBotones.TabIndex = 21;
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
            this.bnfLimpiar.Location = new System.Drawing.Point(383, 24);
            this.bnfLimpiar.Name = "bnfLimpiar";
            this.bnfLimpiar.Normalcolor = System.Drawing.Color.White;
            this.bnfLimpiar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfLimpiar.selected = false;
            this.bnfLimpiar.Size = new System.Drawing.Size(147, 32);
            this.bnfLimpiar.TabIndex = 21;
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
            this.bnfActualizar.Location = new System.Drawing.Point(231, 24);
            this.bnfActualizar.Name = "bnfActualizar";
            this.bnfActualizar.Normalcolor = System.Drawing.Color.White;
            this.bnfActualizar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfActualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfActualizar.selected = false;
            this.bnfActualizar.Size = new System.Drawing.Size(126, 32);
            this.bnfActualizar.TabIndex = 20;
            this.bnfActualizar.Text = "Actualizar";
            this.bnfActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfActualizar.Textcolor = System.Drawing.Color.Black;
            this.bnfActualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfActualizar.Click += new System.EventHandler(this.bnfActualizar_Click);
            // 
            // bnfRegistrar
            // 
            this.bnfRegistrar.Activecolor = System.Drawing.Color.SeaGreen;
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
            this.bnfRegistrar.Location = new System.Drawing.Point(88, 24);
            this.bnfRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnfRegistrar.Name = "bnfRegistrar";
            this.bnfRegistrar.Normalcolor = System.Drawing.Color.White;
            this.bnfRegistrar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfRegistrar.selected = false;
            this.bnfRegistrar.Size = new System.Drawing.Size(126, 32);
            this.bnfRegistrar.TabIndex = 19;
            this.bnfRegistrar.Text = "Registrar";
            this.bnfRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfRegistrar.Textcolor = System.Drawing.Color.Black;
            this.bnfRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfRegistrar.Click += new System.EventHandler(this.bnfRegistrar_Click);
            // 
            // epCodigoDispoitivo
            // 
            this.epCodigoDispoitivo.ContainerControl = this;
            // 
            // epPerimetro
            // 
            this.epPerimetro.ContainerControl = this;
            // 
            // epCodigoAnimal
            // 
            this.epCodigoAnimal.ContainerControl = this;
            // 
            // epEstado
            // 
            this.epEstado.ContainerControl = this;
            // 
            // epBateria
            // 
            this.epBateria.ContainerControl = this;
            // 
            // cbxPerimetro
            // 
            this.cbxPerimetro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbxPerimetro.FormattingEnabled = true;
            this.cbxPerimetro.Location = new System.Drawing.Point(24, 129);
            this.cbxPerimetro.Name = "cbxPerimetro";
            this.cbxPerimetro.Size = new System.Drawing.Size(177, 21);
            this.cbxPerimetro.TabIndex = 22;
            this.cbxPerimetro.SelectedIndexChanged += new System.EventHandler(this.cbxPerimetro_SelectedIndexChanged);
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
            this.bnfBuscar.Location = new System.Drawing.Point(284, 25);
            this.bnfBuscar.Name = "bnfBuscar";
            this.bnfBuscar.Normalcolor = System.Drawing.Color.White;
            this.bnfBuscar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bnfBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bnfBuscar.selected = false;
            this.bnfBuscar.Size = new System.Drawing.Size(122, 33);
            this.bnfBuscar.TabIndex = 23;
            this.bnfBuscar.Text = "Buscar";
            this.bnfBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfBuscar.Textcolor = System.Drawing.Color.Black;
            this.bnfBuscar.TextFont = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBuscar.Click += new System.EventHandler(this.bnfBuscar_Click_1);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(24, 205);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(177, 21);
            this.cbxEstado.TabIndex = 24;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(435, 206);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(182, 20);
            this.fecha.TabIndex = 27;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(431, 169);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Fecha";
            // 
            // RegistrarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 334);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.bnfBuscar);
            this.Controls.Add(this.cbxPerimetro);
            this.Controls.Add(this.grbBotones);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtBateria);
            this.Controls.Add(this.txtCodigoAnimal);
            this.Controls.Add(this.txtCodigoDispositivo);
            this.Controls.Add(this.mapaDispositivo);
            this.Name = "RegistrarDispositivo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RegistrarDispositivo";
            this.Load += new System.EventHandler(this.RegistrarDispositivo_Load);
            this.grbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoDispoitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPerimetro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapaDispositivo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoDispositivo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoAnimal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBateria;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.GroupBox grbBotones;
        private System.Windows.Forms.ErrorProvider epCodigoDispoitivo;
        private System.Windows.Forms.ErrorProvider epPerimetro;
        private System.Windows.Forms.ErrorProvider epCodigoAnimal;
        private System.Windows.Forms.ErrorProvider epEstado;
        private System.Windows.Forms.ErrorProvider epBateria;
        private System.Windows.Forms.ComboBox cbxPerimetro;
        private Bunifu.Framework.UI.BunifuFlatButton bnfLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfActualizar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfBuscar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker fecha;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton bnfRegistrar;
    }
}