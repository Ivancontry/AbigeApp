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
            this.btnDispositivosFuera = new System.Windows.Forms.Button();
            this.btnNovedadBateria = new System.Windows.Forms.Button();
            this.contenedorBuscadorLog = new System.Windows.Forms.Panel();
            this.contenedorLog = new System.Windows.Forms.Panel();
            this.txtLogDispositivos = new System.Windows.Forms.RichTextBox();
            this.btnLimpiarLog = new Bunifu.Framework.UI.BunifuTileButton();
            this.contenedorBuscador = new System.Windows.Forms.Panel();
            this.btnBuscarDispositivo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contenedorMapa = new System.Windows.Forms.Panel();
            this.contenedorBotonesInferiores.SuspendLayout();
            this.contenedorBuscadorLog.SuspendLayout();
            this.contenedorLog.SuspendLayout();
            this.contenedorBuscador.SuspendLayout();
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
            this.gmFinca.Size = new System.Drawing.Size(880, 694);
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
            this.btnDispositivosEnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDispositivosEnTotal.BackColor = System.Drawing.Color.Navy;
            this.btnDispositivosEnTotal.Enabled = false;
            this.btnDispositivosEnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivosEnTotal.ForeColor = System.Drawing.Color.White;
            this.btnDispositivosEnTotal.Location = new System.Drawing.Point(625, 4);
            this.btnDispositivosEnTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispositivosEnTotal.Name = "btnDispositivosEnTotal";
            this.btnDispositivosEnTotal.Size = new System.Drawing.Size(137, 89);
            this.btnDispositivosEnTotal.TabIndex = 2;
            this.btnDispositivosEnTotal.Text = "Dispositivos en Total";
            this.btnDispositivosEnTotal.UseVisualStyleBackColor = false;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(124)))));
            this.btnDispositivos.Enabled = false;
            this.btnDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivos.ForeColor = System.Drawing.Color.White;
            this.btnDispositivos.Location = new System.Drawing.Point(287, 0);
            this.btnDispositivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(137, 89);
            this.btnDispositivos.TabIndex = 3;
            this.btnDispositivos.Text = "Dispositivos en el Perimetro";
            this.btnDispositivos.UseVisualStyleBackColor = false;
            // 
            // contenedorBotonesInferiores
            // 
            this.contenedorBotonesInferiores.AutoSize = true;
            this.contenedorBotonesInferiores.BackColor = System.Drawing.SystemColors.Control;
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivos);
            this.contenedorBotonesInferiores.Controls.Add(this.btnNovedadBateria);
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivosEnTotal);
            this.contenedorBotonesInferiores.Controls.Add(this.btnDispositivosFuera);
            this.contenedorBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorBotonesInferiores.Location = new System.Drawing.Point(0, 694);
            this.contenedorBotonesInferiores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorBotonesInferiores.Name = "contenedorBotonesInferiores";
            this.contenedorBotonesInferiores.Size = new System.Drawing.Size(880, 95);
            this.contenedorBotonesInferiores.TabIndex = 4;
            // 
            // btnDispositivosFuera
            // 
            this.btnDispositivosFuera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDispositivosFuera.BackColor = System.Drawing.Color.DarkRed;
            this.btnDispositivosFuera.Enabled = false;
            this.btnDispositivosFuera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivosFuera.ForeColor = System.Drawing.Color.White;
            this.btnDispositivosFuera.Location = new System.Drawing.Point(118, 0);
            this.btnDispositivosFuera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispositivosFuera.Name = "btnDispositivosFuera";
            this.btnDispositivosFuera.Size = new System.Drawing.Size(137, 89);
            this.btnDispositivosFuera.TabIndex = 5;
            this.btnDispositivosFuera.Text = "Dispositivos fuera del Perimetro";
            this.btnDispositivosFuera.UseVisualStyleBackColor = false;
            // 
            // btnNovedadBateria
            // 
            this.btnNovedadBateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNovedadBateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovedadBateria.Enabled = false;
            this.btnNovedadBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedadBateria.ForeColor = System.Drawing.Color.White;
            this.btnNovedadBateria.Location = new System.Drawing.Point(456, 2);
            this.btnNovedadBateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNovedadBateria.Name = "btnNovedadBateria";
            this.btnNovedadBateria.Size = new System.Drawing.Size(137, 89);
            this.btnNovedadBateria.TabIndex = 4;
            this.btnNovedadBateria.Text = "Novedad por Bateria";
            this.btnNovedadBateria.UseVisualStyleBackColor = false;
            // 
            // contenedorBuscadorLog
            // 
            this.contenedorBuscadorLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contenedorBuscadorLog.Controls.Add(this.contenedorLog);
            this.contenedorBuscadorLog.Controls.Add(this.contenedorBuscador);
            this.contenedorBuscadorLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBuscadorLog.Location = new System.Drawing.Point(880, 0);
            this.contenedorBuscadorLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorBuscadorLog.Name = "contenedorBuscadorLog";
            this.contenedorBuscadorLog.Size = new System.Drawing.Size(224, 789);
            this.contenedorBuscadorLog.TabIndex = 5;
            // 
            // contenedorLog
            // 
            this.contenedorLog.Controls.Add(this.txtLogDispositivos);
            this.contenedorLog.Controls.Add(this.btnLimpiarLog);
            this.contenedorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorLog.Location = new System.Drawing.Point(0, 276);
            this.contenedorLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorLog.Name = "contenedorLog";
            this.contenedorLog.Size = new System.Drawing.Size(224, 513);
            this.contenedorLog.TabIndex = 2;
            // 
            // txtLogDispositivos
            // 
            this.txtLogDispositivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogDispositivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogDispositivos.Location = new System.Drawing.Point(0, 0);
            this.txtLogDispositivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogDispositivos.Name = "txtLogDispositivos";
            this.txtLogDispositivos.ReadOnly = true;
            this.txtLogDispositivos.Size = new System.Drawing.Size(224, 473);
            this.txtLogDispositivos.TabIndex = 0;
            this.txtLogDispositivos.Text = "";
            this.txtLogDispositivos.TextChanged += new System.EventHandler(this.txtLogDispositivos_TextChanged);
            // 
            // btnLimpiarLog
            // 
            this.btnLimpiarLog.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLimpiarLog.color = System.Drawing.Color.SeaGreen;
            this.btnLimpiarLog.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLimpiarLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLimpiarLog.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnLimpiarLog.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarLog.Image = null;
            this.btnLimpiarLog.ImagePosition = 20;
            this.btnLimpiarLog.ImageZoom = 50;
            this.btnLimpiarLog.LabelPosition = 41;
            this.btnLimpiarLog.LabelText = "Limpiar Log";
            this.btnLimpiarLog.Location = new System.Drawing.Point(0, 473);
            this.btnLimpiarLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarLog.Name = "btnLimpiarLog";
            this.btnLimpiarLog.Size = new System.Drawing.Size(224, 40);
            this.btnLimpiarLog.TabIndex = 1;
            this.btnLimpiarLog.Click += new System.EventHandler(this.btnLimpiarLog_Click);
            // 
            // contenedorBuscador
            // 
            this.contenedorBuscador.Controls.Add(this.btnBuscarDispositivo);
            this.contenedorBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorBuscador.Location = new System.Drawing.Point(0, 0);
            this.contenedorBuscador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorBuscador.Name = "contenedorBuscador";
            this.contenedorBuscador.Size = new System.Drawing.Size(224, 276);
            this.contenedorBuscador.TabIndex = 1;
            // 
            // btnBuscarDispositivo
            // 
            this.btnBuscarDispositivo.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.btnBuscarDispositivo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarDispositivo.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.btnBuscarDispositivo.BorderThickness = 3;
            this.btnBuscarDispositivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBuscarDispositivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarDispositivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBuscarDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarDispositivo.isPassword = false;
            this.btnBuscarDispositivo.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarDispositivo.Name = "btnBuscarDispositivo";
            this.btnBuscarDispositivo.Size = new System.Drawing.Size(224, 36);
            this.btnBuscarDispositivo.TabIndex = 0;
            this.btnBuscarDispositivo.Text = "Codigo a buscar";
            this.btnBuscarDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contenedorMapa
            // 
            this.contenedorMapa.Controls.Add(this.gmFinca);
            this.contenedorMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorMapa.Location = new System.Drawing.Point(0, 0);
            this.contenedorMapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorMapa.Name = "contenedorMapa";
            this.contenedorMapa.Size = new System.Drawing.Size(880, 694);
            this.contenedorMapa.TabIndex = 6;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 789);
            this.Controls.Add(this.contenedorMapa);
            this.Controls.Add(this.contenedorBotonesInferiores);
            this.Controls.Add(this.contenedorBuscadorLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mapa";
            this.RightToLeftLayout = true;
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.contenedorBotonesInferiores.ResumeLayout(false);
            this.contenedorBuscadorLog.ResumeLayout(false);
            this.contenedorLog.ResumeLayout(false);
            this.contenedorBuscador.ResumeLayout(false);
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
        private System.Windows.Forms.Panel contenedorBuscadorLog;
        private System.Windows.Forms.Panel contenedorMapa;
        private System.Windows.Forms.Button btnDispositivosFuera;
        private System.Windows.Forms.Button btnNovedadBateria;
        private Bunifu.Framework.UI.BunifuMetroTextbox btnBuscarDispositivo;
        private System.Windows.Forms.Panel contenedorLog;
        private System.Windows.Forms.Panel contenedorBuscador;
        private System.Windows.Forms.RichTextBox txtLogDispositivos;
        private Bunifu.Framework.UI.BunifuTileButton btnLimpiarLog;
    }
}