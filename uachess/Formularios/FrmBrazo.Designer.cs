namespace UAChess
{
    partial class FrmBrazo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrazo));
            this.NSTheme = new NSTheme();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.NSGbpCalibrado = new NSGroupBox();
            this.LblAdvertencia = new System.Windows.Forms.Label();
            this.NSBtnCalibrar = new NSButton();
            this.NSCmbCalibrado = new NSComboBox();
            this.NSLblTitulo = new NSLabel();
            this.NSGpbTest = new NSGroupBox();
            this.LblR = new System.Windows.Forms.Label();
            this.LblA3 = new System.Windows.Forms.Label();
            this.LblA2 = new System.Windows.Forms.Label();
            this.LblA1 = new System.Windows.Forms.Label();
            this.NSGbpR = new NSGroupBox();
            this.NSBtnRDer = new NSButton();
            this.NSBtnRIzq = new NSButton();
            this.LblP = new System.Windows.Forms.Label();
            this.NSGbpA3 = new NSGroupBox();
            this.NSBtnA3Abajo = new NSButton();
            this.NSBtnA3Arriba = new NSButton();
            this.NSGbpA2 = new NSGroupBox();
            this.NSBtnA2Abajo = new NSButton();
            this.NSBtnA2Arriba = new NSButton();
            this.NSGbpA1 = new NSGroupBox();
            this.NSBtnA1Abajo = new NSButton();
            this.NSBtnA1Arriba = new NSButton();
            this.NSGbpP = new NSGroupBox();
            this.NSBtnRCerrar = new NSButton();
            this.NSBtnPAbrir = new NSButton();
            this.PbxBrazo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nsButton1 = new NSButton();
            this.nsButton2 = new NSButton();
            this.nsButton3 = new NSButton();
            this.nsButton4 = new NSButton();
            this.NSTheme.SuspendLayout();
            this.NSGbpCalibrado.SuspendLayout();
            this.NSGpbTest.SuspendLayout();
            this.NSGbpR.SuspendLayout();
            this.NSGbpA3.SuspendLayout();
            this.NSGbpA2.SuspendLayout();
            this.NSGbpA1.SuspendLayout();
            this.NSGbpP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBrazo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.NSGbpCalibrado);
            this.NSTheme.Controls.Add(this.NSLblTitulo);
            this.NSTheme.Controls.Add(this.NSGpbTest);
            this.NSTheme.Customization = "";
            this.NSTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.NSTheme.Image = null;
            this.NSTheme.Location = new System.Drawing.Point(0, 0);
            this.NSTheme.Movable = true;
            this.NSTheme.Name = "NSTheme";
            this.NSTheme.NoRounding = false;
            this.NSTheme.Sizable = false;
            this.NSTheme.Size = new System.Drawing.Size(450, 430);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "Brazo";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LblCerrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(423, 4);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LblCerrar.TabIndex = 0;
            this.LblCerrar.Text = "x";
            this.LblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // NSGbpCalibrado
            // 
            this.NSGbpCalibrado.Controls.Add(this.LblAdvertencia);
            this.NSGbpCalibrado.Controls.Add(this.NSBtnCalibrar);
            this.NSGbpCalibrado.Controls.Add(this.NSCmbCalibrado);
            this.NSGbpCalibrado.DrawSeperator = false;
            this.NSGbpCalibrado.Location = new System.Drawing.Point(8, 375);
            this.NSGbpCalibrado.Name = "NSGbpCalibrado";
            this.NSGbpCalibrado.Size = new System.Drawing.Size(432, 49);
            this.NSGbpCalibrado.SubTitle = "";
            this.NSGbpCalibrado.TabIndex = 0;
            this.NSGbpCalibrado.Text = "Calibrado:";
            this.NSGbpCalibrado.Title = "Calibrado:";
            // 
            // LblAdvertencia
            // 
            this.LblAdvertencia.AutoSize = true;
            this.LblAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.LblAdvertencia.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdvertencia.ForeColor = System.Drawing.Color.Salmon;
            this.LblAdvertencia.Location = new System.Drawing.Point(4, 29);
            this.LblAdvertencia.Name = "LblAdvertencia";
            this.LblAdvertencia.Size = new System.Drawing.Size(423, 12);
            this.LblAdvertencia.TabIndex = 0;
            this.LblAdvertencia.Text = "Colocar brazo en mitad exacta parte izq. tablero, vista desde jugador blanco.";
            this.LblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSBtnCalibrar
            // 
            this.NSBtnCalibrar.Location = new System.Drawing.Point(362, 3);
            this.NSBtnCalibrar.Name = "NSBtnCalibrar";
            this.NSBtnCalibrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnCalibrar.Size = new System.Drawing.Size(60, 23);
            this.NSBtnCalibrar.TabIndex = 12;
            this.NSBtnCalibrar.Text = "Calibrar";
            // 
            // NSCmbCalibrado
            // 
            this.NSCmbCalibrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbCalibrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbCalibrado.DropDownHeight = 100;
            this.NSCmbCalibrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbCalibrado.ForeColor = System.Drawing.Color.White;
            this.NSCmbCalibrado.FormattingEnabled = true;
            this.NSCmbCalibrado.IntegralHeight = false;
            this.NSCmbCalibrado.ItemHeight = 15;
            this.NSCmbCalibrado.Items.AddRange(new object[] {
            "Casilla  0,5 x 0,5 cm / Tablero 4 x 4 cm",
            "Casilla 1,0 x 1,0 cm / Tablero 8 x 8 cm",
            "Casilla 1,5 x 1,5 cm / Tablero 12 x 12 cm",
            "Casilla 2,0 x 2,0 cm / Tablero 16 x 16 cm"});
            this.NSCmbCalibrado.Location = new System.Drawing.Point(79, 3);
            this.NSCmbCalibrado.Name = "NSCmbCalibrado";
            this.NSCmbCalibrado.Size = new System.Drawing.Size(278, 21);
            this.NSCmbCalibrado.TabIndex = 11;
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Brazo";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "BRAZO";
            // 
            // NSGpbTest
            // 
            this.NSGpbTest.Controls.Add(this.panel1);
            this.NSGpbTest.Controls.Add(this.LblR);
            this.NSGpbTest.Controls.Add(this.LblA3);
            this.NSGpbTest.Controls.Add(this.LblA2);
            this.NSGpbTest.Controls.Add(this.LblA1);
            this.NSGpbTest.Controls.Add(this.NSGbpR);
            this.NSGpbTest.Controls.Add(this.LblP);
            this.NSGpbTest.Controls.Add(this.NSGbpA3);
            this.NSGpbTest.Controls.Add(this.NSGbpA2);
            this.NSGpbTest.Controls.Add(this.NSGbpA1);
            this.NSGpbTest.Controls.Add(this.NSGbpP);
            this.NSGpbTest.Controls.Add(this.PbxBrazo);
            this.NSGpbTest.DrawSeperator = false;
            this.NSGpbTest.Location = new System.Drawing.Point(8, 33);
            this.NSGpbTest.Name = "NSGpbTest";
            this.NSGpbTest.Size = new System.Drawing.Size(432, 336);
            this.NSGpbTest.SubTitle = "";
            this.NSGpbTest.TabIndex = 0;
            this.NSGpbTest.Text = "Test";
            this.NSGpbTest.Title = "Test";
            // 
            // LblR
            // 
            this.LblR.AutoSize = true;
            this.LblR.BackColor = System.Drawing.Color.Goldenrod;
            this.LblR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR.ForeColor = System.Drawing.Color.White;
            this.LblR.Location = new System.Drawing.Point(95, 299);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(17, 16);
            this.LblR.TabIndex = 0;
            this.LblR.Text = "R";
            this.LblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblA3
            // 
            this.LblA3.AutoSize = true;
            this.LblA3.BackColor = System.Drawing.Color.Goldenrod;
            this.LblA3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA3.ForeColor = System.Drawing.Color.White;
            this.LblA3.Location = new System.Drawing.Point(90, 234);
            this.LblA3.Name = "LblA3";
            this.LblA3.Size = new System.Drawing.Size(27, 16);
            this.LblA3.TabIndex = 0;
            this.LblA3.Text = "A3";
            this.LblA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblA2
            // 
            this.LblA2.AutoSize = true;
            this.LblA2.BackColor = System.Drawing.Color.Transparent;
            this.LblA2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA2.ForeColor = System.Drawing.Color.White;
            this.LblA2.Location = new System.Drawing.Point(46, 166);
            this.LblA2.Name = "LblA2";
            this.LblA2.Size = new System.Drawing.Size(27, 16);
            this.LblA2.TabIndex = 0;
            this.LblA2.Text = "A2";
            this.LblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblA1
            // 
            this.LblA1.AutoSize = true;
            this.LblA1.BackColor = System.Drawing.Color.Transparent;
            this.LblA1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA1.ForeColor = System.Drawing.Color.White;
            this.LblA1.Location = new System.Drawing.Point(58, 93);
            this.LblA1.Name = "LblA1";
            this.LblA1.Size = new System.Drawing.Size(27, 16);
            this.LblA1.TabIndex = 0;
            this.LblA1.Text = "A1";
            this.LblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSGbpR
            // 
            this.NSGbpR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSGbpR.Controls.Add(this.NSBtnRDer);
            this.NSGbpR.Controls.Add(this.NSBtnRIzq);
            this.NSGbpR.DrawSeperator = false;
            this.NSGbpR.Location = new System.Drawing.Point(242, 269);
            this.NSGbpR.Name = "NSGbpR";
            this.NSGbpR.Size = new System.Drawing.Size(180, 55);
            this.NSGbpR.SubTitle = "";
            this.NSGbpR.TabIndex = 0;
            this.NSGbpR.Text = "Motor Rotación (R)";
            this.NSGbpR.Title = "Motor Rotación (R)";
            // 
            // NSBtnRDer
            // 
            this.NSBtnRDer.Location = new System.Drawing.Point(92, 25);
            this.NSBtnRDer.Name = "NSBtnRDer";
            this.NSBtnRDer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnRDer.Size = new System.Drawing.Size(70, 23);
            this.NSBtnRDer.TabIndex = 10;
            this.NSBtnRDer.Text = "Der. (P)";
            this.NSBtnRDer.Click += new System.EventHandler(this.NSBtnRDer_Click);
            // 
            // NSBtnRIzq
            // 
            this.NSBtnRIzq.Location = new System.Drawing.Point(18, 25);
            this.NSBtnRIzq.Name = "NSBtnRIzq";
            this.NSBtnRIzq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnRIzq.Size = new System.Drawing.Size(70, 23);
            this.NSBtnRIzq.TabIndex = 9;
            this.NSBtnRIzq.Text = "Izq. (O)";
            this.NSBtnRIzq.Click += new System.EventHandler(this.NSBtnRIzq_Click);
            // 
            // LblP
            // 
            this.LblP.AutoSize = true;
            this.LblP.BackColor = System.Drawing.Color.Transparent;
            this.LblP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP.ForeColor = System.Drawing.Color.White;
            this.LblP.Location = new System.Drawing.Point(135, 46);
            this.LblP.Name = "LblP";
            this.LblP.Size = new System.Drawing.Size(17, 16);
            this.LblP.TabIndex = 0;
            this.LblP.Text = "P";
            this.LblP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSGbpA3
            // 
            this.NSGbpA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSGbpA3.Controls.Add(this.NSBtnA3Abajo);
            this.NSGbpA3.Controls.Add(this.NSBtnA3Arriba);
            this.NSGbpA3.DrawSeperator = false;
            this.NSGbpA3.Location = new System.Drawing.Point(242, 208);
            this.NSGbpA3.Name = "NSGbpA3";
            this.NSGbpA3.Size = new System.Drawing.Size(180, 55);
            this.NSGbpA3.SubTitle = "";
            this.NSGbpA3.TabIndex = 0;
            this.NSGbpA3.Text = "Motor Articulación 3 (A3)";
            this.NSGbpA3.Title = "Motor Articulación 3 (A3)";
            // 
            // NSBtnA3Abajo
            // 
            this.NSBtnA3Abajo.Location = new System.Drawing.Point(92, 25);
            this.NSBtnA3Abajo.Name = "NSBtnA3Abajo";
            this.NSBtnA3Abajo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA3Abajo.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA3Abajo.TabIndex = 8;
            this.NSBtnA3Abajo.Text = "Abajo (X)";
            this.NSBtnA3Abajo.Click += new System.EventHandler(this.NSBtnA3Abajo_Click);
            // 
            // NSBtnA3Arriba
            // 
            this.NSBtnA3Arriba.Location = new System.Drawing.Point(18, 25);
            this.NSBtnA3Arriba.Name = "NSBtnA3Arriba";
            this.NSBtnA3Arriba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA3Arriba.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA3Arriba.TabIndex = 7;
            this.NSBtnA3Arriba.Text = "Arriba (Z)";
            this.NSBtnA3Arriba.Click += new System.EventHandler(this.NSBtnA3Arriba_Click);
            // 
            // NSGbpA2
            // 
            this.NSGbpA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSGbpA2.Controls.Add(this.NSBtnA2Abajo);
            this.NSGbpA2.Controls.Add(this.NSBtnA2Arriba);
            this.NSGbpA2.DrawSeperator = false;
            this.NSGbpA2.Location = new System.Drawing.Point(242, 147);
            this.NSGbpA2.Name = "NSGbpA2";
            this.NSGbpA2.Size = new System.Drawing.Size(180, 55);
            this.NSGbpA2.SubTitle = "";
            this.NSGbpA2.TabIndex = 0;
            this.NSGbpA2.Text = "Motor Articulación 2 (A2)";
            this.NSGbpA2.Title = "Motor Articulación 2 (A2)";
            // 
            // NSBtnA2Abajo
            // 
            this.NSBtnA2Abajo.Location = new System.Drawing.Point(92, 25);
            this.NSBtnA2Abajo.Name = "NSBtnA2Abajo";
            this.NSBtnA2Abajo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA2Abajo.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA2Abajo.TabIndex = 6;
            this.NSBtnA2Abajo.Text = "Abajo (S)";
            this.NSBtnA2Abajo.Click += new System.EventHandler(this.NSBtnA2Abajo_Click);
            // 
            // NSBtnA2Arriba
            // 
            this.NSBtnA2Arriba.Location = new System.Drawing.Point(18, 25);
            this.NSBtnA2Arriba.Name = "NSBtnA2Arriba";
            this.NSBtnA2Arriba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA2Arriba.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA2Arriba.TabIndex = 5;
            this.NSBtnA2Arriba.Text = "Arriba (A)";
            this.NSBtnA2Arriba.Click += new System.EventHandler(this.NSBtnA2Arriba_Click);
            // 
            // NSGbpA1
            // 
            this.NSGbpA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSGbpA1.Controls.Add(this.NSBtnA1Abajo);
            this.NSGbpA1.Controls.Add(this.NSBtnA1Arriba);
            this.NSGbpA1.DrawSeperator = false;
            this.NSGbpA1.Location = new System.Drawing.Point(242, 86);
            this.NSGbpA1.Name = "NSGbpA1";
            this.NSGbpA1.Size = new System.Drawing.Size(180, 55);
            this.NSGbpA1.SubTitle = "";
            this.NSGbpA1.TabIndex = 0;
            this.NSGbpA1.Text = "Motor Articulación 1 (A1)";
            this.NSGbpA1.Title = "Motor Articulación 1 (A1)";
            // 
            // NSBtnA1Abajo
            // 
            this.NSBtnA1Abajo.Location = new System.Drawing.Point(92, 25);
            this.NSBtnA1Abajo.Name = "NSBtnA1Abajo";
            this.NSBtnA1Abajo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA1Abajo.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA1Abajo.TabIndex = 4;
            this.NSBtnA1Abajo.Text = "Abajo (W)";
            this.NSBtnA1Abajo.Click += new System.EventHandler(this.NSBtnA1Abajo_Click);
            // 
            // NSBtnA1Arriba
            // 
            this.NSBtnA1Arriba.Location = new System.Drawing.Point(18, 25);
            this.NSBtnA1Arriba.Name = "NSBtnA1Arriba";
            this.NSBtnA1Arriba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnA1Arriba.Size = new System.Drawing.Size(70, 23);
            this.NSBtnA1Arriba.TabIndex = 3;
            this.NSBtnA1Arriba.Text = "Arriba (Q)";
            this.NSBtnA1Arriba.Click += new System.EventHandler(this.NSBtnA1Arriba_Click);
            // 
            // NSGbpP
            // 
            this.NSGbpP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NSGbpP.Controls.Add(this.NSBtnRCerrar);
            this.NSGbpP.Controls.Add(this.NSBtnPAbrir);
            this.NSGbpP.DrawSeperator = false;
            this.NSGbpP.Location = new System.Drawing.Point(242, 25);
            this.NSGbpP.Name = "NSGbpP";
            this.NSGbpP.Size = new System.Drawing.Size(180, 55);
            this.NSGbpP.SubTitle = "";
            this.NSGbpP.TabIndex = 0;
            this.NSGbpP.Text = "Motor Pinzas (P)";
            this.NSGbpP.Title = "Motor Pinzas (P)";
            // 
            // NSBtnRCerrar
            // 
            this.NSBtnRCerrar.Location = new System.Drawing.Point(92, 25);
            this.NSBtnRCerrar.Name = "NSBtnRCerrar";
            this.NSBtnRCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnRCerrar.Size = new System.Drawing.Size(70, 23);
            this.NSBtnRCerrar.TabIndex = 2;
            this.NSBtnRCerrar.Text = "Cerrar (R)";
            this.NSBtnRCerrar.Click += new System.EventHandler(this.NSBtnRCerrar_Click);
            // 
            // NSBtnPAbrir
            // 
            this.NSBtnPAbrir.Location = new System.Drawing.Point(18, 25);
            this.NSBtnPAbrir.Name = "NSBtnPAbrir";
            this.NSBtnPAbrir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnPAbrir.Size = new System.Drawing.Size(70, 23);
            this.NSBtnPAbrir.TabIndex = 1;
            this.NSBtnPAbrir.Text = "Abrir (E)";
            this.NSBtnPAbrir.Click += new System.EventHandler(this.NSBtnPAbrir_Click);
            // 
            // PbxBrazo
            // 
            this.PbxBrazo.BackColor = System.Drawing.Color.Transparent;
            this.PbxBrazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxBrazo.Image = global::UAChess.Properties.Resources.AppBrazo;
            this.PbxBrazo.Location = new System.Drawing.Point(12, 25);
            this.PbxBrazo.Name = "PbxBrazo";
            this.PbxBrazo.Size = new System.Drawing.Size(215, 300);
            this.PbxBrazo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBrazo.TabIndex = 50;
            this.PbxBrazo.TabStop = false;
            this.PbxBrazo.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nsButton4);
            this.panel1.Controls.Add(this.nsButton3);
            this.panel1.Controls.Add(this.nsButton2);
            this.panel1.Controls.Add(this.nsButton1);
            this.panel1.Location = new System.Drawing.Point(27, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(10, 21);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(75, 23);
            this.nsButton1.TabIndex = 0;
            this.nsButton1.Text = "A y H";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // nsButton2
            // 
            this.nsButton2.Location = new System.Drawing.Point(101, 21);
            this.nsButton2.Name = "nsButton2";
            this.nsButton2.Size = new System.Drawing.Size(75, 23);
            this.nsButton2.TabIndex = 1;
            this.nsButton2.Text = "B y G";
            this.nsButton2.Click += new System.EventHandler(this.nsButton2_Click);
            // 
            // nsButton3
            // 
            this.nsButton3.Location = new System.Drawing.Point(10, 53);
            this.nsButton3.Name = "nsButton3";
            this.nsButton3.Size = new System.Drawing.Size(75, 23);
            this.nsButton3.TabIndex = 2;
            this.nsButton3.Text = "C y F";
            this.nsButton3.Click += new System.EventHandler(this.nsButton3_Click);
            // 
            // nsButton4
            // 
            this.nsButton4.Location = new System.Drawing.Point(101, 50);
            this.nsButton4.Name = "nsButton4";
            this.nsButton4.Size = new System.Drawing.Size(75, 23);
            this.nsButton4.TabIndex = 3;
            this.nsButton4.Text = "D y E";
            this.nsButton4.Click += new System.EventHandler(this.nsButton4_Click);
            // 
            // FrmBrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBrazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brazo";
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            this.NSGbpCalibrado.ResumeLayout(false);
            this.NSGbpCalibrado.PerformLayout();
            this.NSGpbTest.ResumeLayout(false);
            this.NSGpbTest.PerformLayout();
            this.NSGbpR.ResumeLayout(false);
            this.NSGbpA3.ResumeLayout(false);
            this.NSGbpA2.ResumeLayout(false);
            this.NSGbpA1.ResumeLayout(false);
            this.NSGbpP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBrazo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private NSGroupBox NSGpbTest;
        private System.Windows.Forms.PictureBox PbxBrazo;
        private NSGroupBox NSGbpP;
        private NSButton NSBtnRCerrar;
        private NSButton NSBtnPAbrir;
        private NSGroupBox NSGbpR;
        private NSButton NSBtnRDer;
        private NSButton NSBtnRIzq;
        private NSGroupBox NSGbpA3;
        private NSButton NSBtnA3Abajo;
        private NSButton NSBtnA3Arriba;
        private NSGroupBox NSGbpA2;
        private NSButton NSBtnA2Abajo;
        private NSButton NSBtnA2Arriba;
        private NSGroupBox NSGbpA1;
        private NSButton NSBtnA1Abajo;
        private NSButton NSBtnA1Arriba;
        private System.Windows.Forms.Label LblA2;
        private System.Windows.Forms.Label LblA1;
        private System.Windows.Forms.Label LblP;
        private System.Windows.Forms.Label LblR;
        private System.Windows.Forms.Label LblA3;
        private NSGroupBox NSGbpCalibrado;
        private NSComboBox NSCmbCalibrado;
        private NSButton NSBtnCalibrar;
        private System.Windows.Forms.Label LblAdvertencia;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Panel panel1;
        private NSButton nsButton4;
        private NSButton nsButton3;
        private NSButton nsButton2;
        private NSButton nsButton1;
    }
}