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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDispositivosEnTotal = new System.Windows.Forms.Button();
            this.btnDispositivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmFinca
            // 
            this.gmFinca.Bearing = 0F;
            this.gmFinca.CanDragMap = true;
            this.gmFinca.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmFinca.GrayScaleMode = false;
            this.gmFinca.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmFinca.LevelsKeepInMemmory = 5;
            this.gmFinca.Location = new System.Drawing.Point(16, 15);
            this.gmFinca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gmFinca.Size = new System.Drawing.Size(1135, 571);
            this.gmFinca.TabIndex = 0;
            this.gmFinca.Zoom = 0D;
            this.gmFinca.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gmFinca_OnPolygonClick);
            this.gmFinca.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gmFinca_OnRouteClick);
            this.gmFinca.OnPolygonEnter += new GMap.NET.WindowsForms.PolygonEnter(this.gmFinca_OnPolygonEnter);
            this.gmFinca.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gmFinca.Click += new System.EventHandler(this.gmFinca_Click);
            this.gmFinca.Enter += new System.EventHandler(this.gmFinca_Enter);
            this.gmFinca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmFinca_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 4500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDispositivosEnTotal
            // 
            this.btnDispositivosEnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(124)))));
            this.btnDispositivosEnTotal.Enabled = false;
            this.btnDispositivosEnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivosEnTotal.ForeColor = System.Drawing.Color.White;
            this.btnDispositivosEnTotal.Location = new System.Drawing.Point(398, 605);
            this.btnDispositivosEnTotal.Name = "btnDispositivosEnTotal";
            this.btnDispositivosEnTotal.Size = new System.Drawing.Size(183, 93);
            this.btnDispositivosEnTotal.TabIndex = 2;
            this.btnDispositivosEnTotal.Text = "Dispositivos";
            this.btnDispositivosEnTotal.UseVisualStyleBackColor = false;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(124)))));
            this.btnDispositivos.Enabled = false;
            this.btnDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivos.ForeColor = System.Drawing.Color.White;
            this.btnDispositivos.Location = new System.Drawing.Point(628, 605);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(183, 93);
            this.btnDispositivos.TabIndex = 3;
            this.btnDispositivos.Text = "Dispositivos";
            this.btnDispositivos.UseVisualStyleBackColor = false;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 710);
            this.Controls.Add(this.btnDispositivos);
            this.Controls.Add(this.btnDispositivosEnTotal);
            this.Controls.Add(this.gmFinca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmFinca;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDispositivosEnTotal;
        private System.Windows.Forms.Button btnDispositivos;
    }
}