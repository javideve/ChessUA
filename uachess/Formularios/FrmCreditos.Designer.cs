namespace UAChess
{
    partial class FrmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditos));
            this.NSTheme = new NSTheme();
            this.LblVersion = new System.Windows.Forms.Label();
            this.NSLblProyecto = new NSLabel();
            this.NSLblProgramador2 = new NSLabel();
            this.NSLblProgramador1 = new NSLabel();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.PbxCreditos = new System.Windows.Forms.PictureBox();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.LblVersion);
            this.NSTheme.Controls.Add(this.NSLblProyecto);
            this.NSTheme.Controls.Add(this.NSLblProgramador2);
            this.NSTheme.Controls.Add(this.NSLblProgramador1);
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.PbxCreditos);
            this.NSTheme.Controls.Add(this.NSLblTitulo);
            this.NSTheme.Customization = "";
            this.NSTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.NSTheme.Image = null;
            this.NSTheme.Location = new System.Drawing.Point(0, 0);
            this.NSTheme.Movable = true;
            this.NSTheme.Name = "NSTheme";
            this.NSTheme.NoRounding = false;
            this.NSTheme.Sizable = false;
            this.NSTheme.Size = new System.Drawing.Size(550, 450);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "Créditos";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LblVersion.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.ForeColor = System.Drawing.Color.Salmon;
            this.LblVersion.Location = new System.Drawing.Point(420, 152);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(33, 12);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "V. 1.2";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSLblProyecto
            // 
            this.NSLblProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NSLblProyecto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblProyecto.Location = new System.Drawing.Point(99, 225);
            this.NSLblProyecto.Name = "NSLblProyecto";
            this.NSLblProyecto.Size = new System.Drawing.Size(360, 23);
            this.NSLblProyecto.TabIndex = 0;
            this.NSLblProyecto.Text = "Créditos";
            this.NSLblProyecto.Value1 = "SISTEMAS INFORMÁTICOS";
            this.NSLblProyecto.Value2 = " . UNIVERSIDAD DE ALICANTE";
            // 
            // NSLblProgramador2
            // 
            this.NSLblProgramador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NSLblProgramador2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblProgramador2.Location = new System.Drawing.Point(111, 198);
            this.NSLblProgramador2.Name = "NSLblProgramador2";
            this.NSLblProgramador2.Size = new System.Drawing.Size(340, 23);
            this.NSLblProgramador2.TabIndex = 0;
            this.NSLblProgramador2.Text = "Créditos";
            this.NSLblProgramador2.Value1 = "JAVIER MARTÍNEZ MARTÍNEZ";
            this.NSLblProgramador2.Value2 = " . BRAZO / DOCUMENTACIÓN";
            // 
            // NSLblProgramador1
            // 
            this.NSLblProgramador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NSLblProgramador1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblProgramador1.Location = new System.Drawing.Point(105, 179);
            this.NSLblProgramador1.Name = "NSLblProgramador1";
            this.NSLblProgramador1.Size = new System.Drawing.Size(350, 23);
            this.NSLblProgramador1.TabIndex = 0;
            this.NSLblProgramador1.Text = "Créditos";
            this.NSLblProgramador1.Value1 = "MANUEL MARTÍNEZ GONZÁLEZ";
            this.NSLblProgramador1.Value2 = " . INTERFAZ / MOTOR / BBDD";
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LblCerrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(523, 4);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LblCerrar.TabIndex = 0;
            this.LblCerrar.Text = "x";
            this.LblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // PbxCreditos
            // 
            this.PbxCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCreditos.Image = global::UAChess.Properties.Resources.AppLogo;
            this.PbxCreditos.Location = new System.Drawing.Point(0, 26);
            this.PbxCreditos.Name = "PbxCreditos";
            this.PbxCreditos.Size = new System.Drawing.Size(550, 424);
            this.PbxCreditos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCreditos.TabIndex = 44;
            this.PbxCreditos.TabStop = false;
            this.PbxCreditos.Tag = "";
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Créditos";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "CRÉDITOS";
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private System.Windows.Forms.PictureBox PbxCreditos;
        private System.Windows.Forms.Label LblCerrar;
        private NSLabel NSLblProyecto;
        private NSLabel NSLblProgramador2;
        private NSLabel NSLblProgramador1;
        private System.Windows.Forms.Label LblVersion;
    }
}