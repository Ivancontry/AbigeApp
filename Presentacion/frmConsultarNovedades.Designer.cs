namespace Presentacion
{
    partial class frmConsultarNovedades
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
            this.gmFincaNovedades = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gmFincaNovedades
            // 
            this.gmFincaNovedades.Bearing = 0F;
            this.gmFincaNovedades.CanDragMap = true;
            this.gmFincaNovedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmFincaNovedades.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmFincaNovedades.GrayScaleMode = false;
            this.gmFincaNovedades.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmFincaNovedades.LevelsKeepInMemmory = 5;
            this.gmFincaNovedades.Location = new System.Drawing.Point(0, 0);
            this.gmFincaNovedades.MarkersEnabled = true;
            this.gmFincaNovedades.MaxZoom = 2;
            this.gmFincaNovedades.MinZoom = 2;
            this.gmFincaNovedades.MouseWheelZoomEnabled = true;
            this.gmFincaNovedades.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmFincaNovedades.Name = "gmFincaNovedades";
            this.gmFincaNovedades.NegativeMode = false;
            this.gmFincaNovedades.PolygonsEnabled = true;
            this.gmFincaNovedades.RetryLoadTile = 0;
            this.gmFincaNovedades.RoutesEnabled = true;
            this.gmFincaNovedades.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmFincaNovedades.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmFincaNovedades.ShowTileGridLines = false;
            this.gmFincaNovedades.Size = new System.Drawing.Size(800, 450);
            this.gmFincaNovedades.TabIndex = 0;
            this.gmFincaNovedades.Zoom = 0D;
            // 
            // frmConsultarNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gmFincaNovedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarNovedades";
            this.Text = "frmConsultarNovedades";
            this.Load += new System.EventHandler(this.frmConsultarNovedades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmFincaNovedades;
    }
}