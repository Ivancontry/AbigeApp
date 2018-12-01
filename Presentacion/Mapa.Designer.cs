namespace Presentacion
{
    partial class Mapa
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
            this.gmFinca = new GMap.NET.WindowsForms.GMapControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnDispositivosEnTotal = new System.Windows.Forms.Button();
            this.btnDispositivos = new System.Windows.Forms.Button();
            this.contenedorBotonesInferiores = new System.Windows.Forms.Panel();
            this.contenedorBuscador = new System.Windows.Forms.Panel();
            this.contenedorMapa = new System.Windows.Forms.Panel();
            this.btnNovedadBateria = new System.Windows.Forms.Button();
            this.btnDispositivosFuera = new System.Windows.Forms.Button();
            this.contenedorBotonesInferiores.SuspendLayout();
            this.contenedorMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmFinca
            // 
            this.gmFinca.AutoSize = true;
            this.gmFinca.BackColor = System.Drawing.SystemColors.Control;
            this.gmFinca.Bearing = 0F;
            this.gmFinca.CanDragMap = true;
            this.gmFinca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmFinca.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmFinca.GrayScaleMode = false;
            this.gmFinca.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmFinca.LevelsKeepInMemmory = 5;
            this.gmFinca.Location = new System.Drawing.Point(0, 0);
            this.gmFinca.Margin = new System.Windows.Forms.Padding(4);
            this.gmFinca.MarkersEnabled = true;
            this.gmFinca.MaxZoom = 2;
            this.gmFinca.MinZoom = 2;
            this.gmFinca.MouseWheelZoomEnabled = true;
            this.gmFinca.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmFinca.Name = "gmFinca";
            this.gmFinca.NegativeMode = false;
            this.gmFinca.PolygonsEnabled = true;
            this.gmFinca.RetryLoadTile = 0;
            this.gmFinca.RoutesEnabled = true;
            this.gmFinca.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmFinca.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmFinca.ShowTileGridLines = false;
            this.gmFinca.Size = new System.Drawing.Size(1173, 847);
            this.gmFinca.TabIndex = 0;
            this.gmFinca.Zoom = 0D;
            this.gmFinca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmFinca_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnDispositivosEnTotal
            // 
            this.btnDispositivosEnTotal.BackColor = System.Drawing.Color.Navy;
            this.btnDispositivosEnTotal.Enabled = false;
            this.btnDispositivosEnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivosEnTotal.ForeColor = System.Drawing.Color.White;
            this.btnDispositivosEnTotal.Location = new System.Drawing.Point(211, 3);
            this.btnDispositivosEnTotal.Name = "btnDispositivosEnTotal";
            this.btnDispositivosEnTotal.Size = new System.Drawing.Size(183, 93);
            this.btnDispositivosEnTotal.TabIndex = 2;
            this.btnDispositivosEnTotal.Text = "Dispositivos en Total";
            this.btnDispositivosEnTotal.UseVisualStyleBackColor = false;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(124)))));
            this.btnDispositivos.Enabled = false;
            this.btnDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivos.ForeColor = System.Drawing.Color.White;
            this.btnDispositivos.Location = new System.Drawing.Point(400, 3);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(183, 93);
            this.btnDispositivos.TabIndex = 3;
            this.btnDispositivos.Text = "Dispositivos en el Perimetro";
            this.btnDispositivos.UseVisualStyleBackColor = false;
            // 
            // contenedorBotonesInferiores
            // 
            this.contenedorBotonesInferiores.AutoSize = true;
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivosFuera);
            this.contenedorBotonesInferiores.Controls.Add(this.btnNovedadBateria);
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivosEnTotal);
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivos);
            this.contenedorBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorBotonesInferiores.Location = new System.Drawing.Point(0, 847);
            this.contenedorBotonesInferiores.Name = "contenedorBotonesInferiores";
            this.contenedorBotonesInferiores.Size = new System.Drawing.Size(1173, 99);
            this.contenedorBotonesInferiores.TabIndex = 4;
            // 
            // contenedorBuscador
            // 
            this.contenedorBuscador.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contenedorBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBuscador.Location = new System.Drawing.Point(1173, 0);
            this.contenedorBuscador.Name = "contenedorBuscador";
            this.contenedorBuscador.Size = new System.Drawing.Size(299, 946);
            this.contenedorBuscador.TabIndex = 5;
            // 
            // contenedorMapa
            // 
            this.contenedorMapa.Controls.Add(this.gmFinca);
            this.contenedorMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorMapa.Location = new System.Drawing.Point(0, 0);
            this.contenedorMapa.Name = "contenedorMapa";
            this.contenedorMapa.Size = new System.Drawing.Size(1173, 847);
            this.contenedorMapa.TabIndex = 6;
            // 
            // btnNovedadBateria
            // 
            this.btnNovedadBateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovedadBateria.Enabled = false;
            this.btnNovedadBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedadBateria.ForeColor = System.Drawing.Color.White;
            this.btnNovedadBateria.Location = new System.Drawing.Point(589, 3);
            this.btnNovedadBateria.Name = "btnNovedadBateria";
            this.btnNovedadBateria.Size = new System.Drawing.Size(183, 93);
            this.btnNovedadBateria.TabIndex = 4;
            this.btnNovedadBateria.Text = "Novedad por Bateria";
            this.btnNovedadBateria.UseVisualStyleBackColor = false;
            // 
            // btnDispositivosFuera
            // 
            this.btnDispositivosFuera.BackColor = System.Drawing.Color.DarkRed;
            this.btnDispositivosFuera.Enabled = false;
            this.btnDispositivosFuera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivosFuera.ForeColor = System.Drawing.Color.White;
            this.btnDispositivosFuera.Location = new System.Drawing.Point(778, 3);
            this.btnDispositivosFuera.Name = "btnDispositivosFuera";
            this.btnDispositivosFuera.Size = new System.Drawing.Size(183, 93);
            this.btnDispositivosFuera.TabIndex = 5;
            this.btnDispositivosFuera.Text = "Dispositivos fuera del Perimetro";
            this.btnDispositivosFuera.UseVisualStyleBackColor = false;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 946);
            this.Controls.Add(this.contenedorMapa);
            this.Controls.Add(this.contenedorBotonesInferiores);
            this.Controls.Add(this.contenedorBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mapa";
            this.RightToLeftLayout = true;
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.contenedorBotonesInferiores.ResumeLayout(false);
            this.contenedorMapa.ResumeLayout(false);
            this.contenedorMapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmFinca;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnDispositivosEnTotal;
        private System.Windows.Forms.Button btnDispositivos;
        private System.Windows.Forms.Panel contenedorBotonesInferiores;
        private System.Windows.Forms.Panel contenedorBuscador;
        private System.Windows.Forms.Panel contenedorMapa;
        private System.Windows.Forms.Button btnDispositivosFuera;
        private System.Windows.Forms.Button btnNovedadBateria;
    }
}