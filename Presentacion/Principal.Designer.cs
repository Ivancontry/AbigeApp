namespace Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuHorizontal = new System.Windows.Forms.Panel();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.menuContenedor = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuHorizontal.SuspendLayout();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHorizontal
            // 
            this.menuHorizontal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuHorizontal.Controls.Add(this.btnCerrar);
            this.menuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.menuHorizontal.Name = "menuHorizontal";
            this.menuHorizontal.Size = new System.Drawing.Size(800, 38);
            this.menuHorizontal.TabIndex = 0;
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 38);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 412);
            this.menuVertical.TabIndex = 1;
            // 
            // menuContenedor
            // 
            this.menuContenedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuContenedor.Location = new System.Drawing.Point(220, 38);
            this.menuContenedor.Name = "menuContenedor";
            this.menuContenedor.Size = new System.Drawing.Size(580, 412);
            this.menuContenedor.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(763, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.menuHorizontal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuHorizontal.ResumeLayout(false);
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuHorizontal;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel menuContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}