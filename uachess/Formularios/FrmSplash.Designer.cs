namespace UAChess
{
    partial class FrmSplash
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Diseñador

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCarga = new System.Windows.Forms.Label();
            this.NSTkbCarga = new NSTrackBar();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(170, 225);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(387, 24);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "Cargando aplicación...";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCarga
            // 
            this.LblCarga.AutoSize = true;
            this.LblCarga.BackColor = System.Drawing.Color.Transparent;
            this.LblCarga.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarga.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblCarga.Location = new System.Drawing.Point(523, 202);
            this.LblCarga.Name = "LblCarga";
            this.LblCarga.Size = new System.Drawing.Size(34, 16);
            this.LblCarga.TabIndex = 0;
            this.LblCarga.Text = "0%";
            this.LblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTkbCarga
            // 
            this.NSTkbCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NSTkbCarga.Location = new System.Drawing.Point(170, 200);
            this.NSTkbCarga.Maximum = 100;
            this.NSTkbCarga.Minimum = 0;
            this.NSTkbCarga.Name = "NSTkbCarga";
            this.NSTkbCarga.Size = new System.Drawing.Size(350, 23);
            this.NSTkbCarga.TabIndex = 0;
            this.NSTkbCarga.Text = "NSTkbCarga";
            this.NSTkbCarga.Value = 0;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::UAChess.Properties.Resources.AppLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 565);
            this.Controls.Add(this.LblCarga);
            this.Controls.Add(this.NSTkbCarga);
            this.Controls.Add(this.LblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAChess";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NSTrackBar NSTkbCarga;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblCarga;
        private System.Windows.Forms.Label LblDescripcion;
    }
}