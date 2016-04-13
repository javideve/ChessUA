namespace UAChess
{
    partial class FrmMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensaje));
            this.NSTheme = new NSTheme();
            this.NSBtn4 = new NSButton();
            this.NSBtn3 = new NSButton();
            this.NSBtn2 = new NSButton();
            this.NSBtn1 = new NSButton();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.NSBtn4);
            this.NSTheme.Controls.Add(this.NSBtn3);
            this.NSTheme.Controls.Add(this.NSBtn2);
            this.NSTheme.Controls.Add(this.NSBtn1);
            this.NSTheme.Controls.Add(this.LblMensaje);
            this.NSTheme.Controls.Add(this.PbxImagen);
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
            this.NSTheme.Size = new System.Drawing.Size(450, 125);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "Mensaje";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // NSBtn4
            // 
            this.NSBtn4.Location = new System.Drawing.Point(196, 95);
            this.NSBtn4.Name = "NSBtn4";
            this.NSBtn4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtn4.Size = new System.Drawing.Size(56, 23);
            this.NSBtn4.TabIndex = 0;
            this.NSBtn4.Text = "4";
            this.NSBtn4.Click += new System.EventHandler(this.NSBtn_Click);
            // 
            // NSBtn3
            // 
            this.NSBtn3.Location = new System.Drawing.Point(258, 95);
            this.NSBtn3.Name = "NSBtn3";
            this.NSBtn3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtn3.Size = new System.Drawing.Size(56, 23);
            this.NSBtn3.TabIndex = 0;
            this.NSBtn3.Text = "3";
            this.NSBtn3.Click += new System.EventHandler(this.NSBtn_Click);
            // 
            // NSBtn2
            // 
            this.NSBtn2.Location = new System.Drawing.Point(320, 95);
            this.NSBtn2.Name = "NSBtn2";
            this.NSBtn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtn2.Size = new System.Drawing.Size(56, 23);
            this.NSBtn2.TabIndex = 0;
            this.NSBtn2.Text = "2";
            this.NSBtn2.Click += new System.EventHandler(this.NSBtn_Click);
            // 
            // NSBtn1
            // 
            this.NSBtn1.Location = new System.Drawing.Point(382, 95);
            this.NSBtn1.Name = "NSBtn1";
            this.NSBtn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtn1.Size = new System.Drawing.Size(56, 23);
            this.NSBtn1.TabIndex = 0;
            this.NSBtn1.Text = "1";
            this.NSBtn1.Click += new System.EventHandler(this.NSBtn_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.LblMensaje.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.White;
            this.LblMensaje.Location = new System.Drawing.Point(98, 33);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(340, 59);
            this.LblMensaje.TabIndex = 0;
            this.LblMensaje.Text = "Mensaje";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxImagen
            // 
            this.PbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxImagen.Location = new System.Drawing.Point(12, 33);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(85, 85);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 42;
            this.PbxImagen.TabStop = false;
            this.PbxImagen.Tag = "";
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Mensaje";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "MENSAJE";
            // 
            // FrmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 125);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensaje";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmMensaje_Shown);
            this.NSTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Label LblMensaje;
        private NSButton NSBtn1;
        private NSButton NSBtn2;
        private NSButton NSBtn4;
        private NSButton NSBtn3;
    }
}