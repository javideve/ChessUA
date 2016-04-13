namespace UAChess
{
    partial class FrmCPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCPU));
            this.NSTheme = new NSTheme();
            this.NSBtnGuardar = new NSButton();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.NSOobBBDD = new NSOnOffBox();
            this.NSGpbBBDD = new NSGroupBox();
            this.NSTxbFechaFin = new NSTextBox();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.NSTxbFechaIni = new NSTextBox();
            this.LblFechaIni = new System.Windows.Forms.Label();
            this.NSCmbElo = new NSComboBox();
            this.LblElo = new System.Windows.Forms.Label();
            this.NSCmbJugador = new NSComboBox();
            this.LblJugador = new System.Windows.Forms.Label();
            this.NSCmbBBDD = new NSComboBox();
            this.LblBBDD = new System.Windows.Forms.Label();
            this.NSGpbMotor = new NSGroupBox();
            this.LblNumPlies = new System.Windows.Forms.Label();
            this.NSCmbMax = new NSComboBox();
            this.LblMin = new System.Windows.Forms.Label();
            this.NSCmbMin = new NSComboBox();
            this.NSTkbPlies = new NSTrackBar();
            this.LblMax = new System.Windows.Forms.Label();
            this.NSCmbAlgoritmo = new NSComboBox();
            this.LblPlies = new System.Windows.Forms.Label();
            this.LblAlgoritmo = new System.Windows.Forms.Label();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            this.NSGpbBBDD.SuspendLayout();
            this.NSGpbMotor.SuspendLayout();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.NSBtnGuardar);
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.NSOobBBDD);
            this.NSTheme.Controls.Add(this.NSGpbBBDD);
            this.NSTheme.Controls.Add(this.NSGpbMotor);
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
            this.NSTheme.Size = new System.Drawing.Size(450, 300);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "CPU";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // NSBtnGuardar
            // 
            this.NSBtnGuardar.Location = new System.Drawing.Point(381, 272);
            this.NSBtnGuardar.Name = "NSBtnGuardar";
            this.NSBtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnGuardar.Size = new System.Drawing.Size(60, 23);
            this.NSBtnGuardar.TabIndex = 11;
            this.NSBtnGuardar.Text = "Guardar";
            this.NSBtnGuardar.Click += new System.EventHandler(this.NSBtnGuardar_Click);
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
            // NSOobBBDD
            // 
            this.NSOobBBDD.Checked = false;
            this.NSOobBBDD.Location = new System.Drawing.Point(381, 118);
            this.NSOobBBDD.MaximumSize = new System.Drawing.Size(56, 24);
            this.NSOobBBDD.MinimumSize = new System.Drawing.Size(56, 24);
            this.NSOobBBDD.Name = "NSOobBBDD";
            this.NSOobBBDD.Size = new System.Drawing.Size(56, 24);
            this.NSOobBBDD.TabIndex = 5;
            this.NSOobBBDD.Text = "NSOobBBDD";
            this.NSOobBBDD.CheckedChanged += new NSOnOffBox.CheckedChangedEventHandler(this.NSOobBBDD_CheckedChanged);
            // 
            // NSGpbBBDD
            // 
            this.NSGpbBBDD.Controls.Add(this.NSTxbFechaFin);
            this.NSGpbBBDD.Controls.Add(this.LblFechaFin);
            this.NSGpbBBDD.Controls.Add(this.NSTxbFechaIni);
            this.NSGpbBBDD.Controls.Add(this.LblFechaIni);
            this.NSGpbBBDD.Controls.Add(this.NSCmbElo);
            this.NSGpbBBDD.Controls.Add(this.LblElo);
            this.NSGpbBBDD.Controls.Add(this.NSCmbJugador);
            this.NSGpbBBDD.Controls.Add(this.LblJugador);
            this.NSGpbBBDD.Controls.Add(this.NSCmbBBDD);
            this.NSGpbBBDD.Controls.Add(this.LblBBDD);
            this.NSGpbBBDD.DrawSeperator = false;
            this.NSGpbBBDD.Enabled = false;
            this.NSGpbBBDD.Location = new System.Drawing.Point(8, 129);
            this.NSGpbBBDD.Name = "NSGpbBBDD";
            this.NSGpbBBDD.Size = new System.Drawing.Size(433, 137);
            this.NSGpbBBDD.SubTitle = "";
            this.NSGpbBBDD.TabIndex = 0;
            this.NSGpbBBDD.Text = "BBDD";
            this.NSGpbBBDD.Title = "BBDD";
            // 
            // NSTxbFechaFin
            // 
            this.NSTxbFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTxbFechaFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbFechaFin.Location = new System.Drawing.Point(277, 110);
            this.NSTxbFechaFin.MaxLength = 10;
            this.NSTxbFechaFin.Multiline = false;
            this.NSTxbFechaFin.Name = "NSTxbFechaFin";
            this.NSTxbFechaFin.ReadOnly = false;
            this.NSTxbFechaFin.Size = new System.Drawing.Size(145, 24);
            this.NSTxbFechaFin.TabIndex = 10;
            this.NSTxbFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbFechaFin.UseSystemPasswordChar = false;
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaFin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFin.ForeColor = System.Drawing.Color.White;
            this.LblFechaFin.Location = new System.Drawing.Point(221, 116);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(47, 12);
            this.LblFechaFin.TabIndex = 0;
            this.LblFechaFin.Text = "Fecha F:";
            this.LblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTxbFechaIni
            // 
            this.NSTxbFechaIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTxbFechaIni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbFechaIni.Location = new System.Drawing.Point(70, 110);
            this.NSTxbFechaIni.MaxLength = 10;
            this.NSTxbFechaIni.Multiline = false;
            this.NSTxbFechaIni.Name = "NSTxbFechaIni";
            this.NSTxbFechaIni.ReadOnly = false;
            this.NSTxbFechaIni.Size = new System.Drawing.Size(145, 24);
            this.NSTxbFechaIni.TabIndex = 9;
            this.NSTxbFechaIni.Text = "1800/01/01";
            this.NSTxbFechaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbFechaIni.UseSystemPasswordChar = false;
            // 
            // LblFechaIni
            // 
            this.LblFechaIni.AutoSize = true;
            this.LblFechaIni.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaIni.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaIni.ForeColor = System.Drawing.Color.White;
            this.LblFechaIni.Location = new System.Drawing.Point(5, 116);
            this.LblFechaIni.Name = "LblFechaIni";
            this.LblFechaIni.Size = new System.Drawing.Size(46, 12);
            this.LblFechaIni.TabIndex = 0;
            this.LblFechaIni.Text = "Fecha I:";
            this.LblFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbElo
            // 
            this.NSCmbElo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbElo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbElo.DropDownHeight = 100;
            this.NSCmbElo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbElo.ForeColor = System.Drawing.Color.White;
            this.NSCmbElo.FormattingEnabled = true;
            this.NSCmbElo.IntegralHeight = false;
            this.NSCmbElo.ItemHeight = 15;
            this.NSCmbElo.Items.AddRange(new object[] {
            "Cualquiera",
            "1000-1399: Nivel Principiante",
            "1400-1599: Nivel Aficionado",
            "1600-1799: Jugador de Club Medio",
            "1800-1999: Jugador de Club Fuerte",
            "2000-2199: Experto Nacional",
            "2200-2299: Candidato a Maestro (CM)",
            "2300-2399: Maestro FIDE (MF)",
            "2400-2499: Maestro Internacional (MI)",
            "2500-2599: Gran Maestro (GM)",
            "2600-2699: Super Gran Maestro",
            "2700-2799: Candidato a Campeón Mundial",
            "2800+: Campeón del Mundo"});
            this.NSCmbElo.Location = new System.Drawing.Point(70, 83);
            this.NSCmbElo.Name = "NSCmbElo";
            this.NSCmbElo.Size = new System.Drawing.Size(352, 21);
            this.NSCmbElo.TabIndex = 8;
            // 
            // LblElo
            // 
            this.LblElo.AutoSize = true;
            this.LblElo.BackColor = System.Drawing.Color.Transparent;
            this.LblElo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElo.ForeColor = System.Drawing.Color.White;
            this.LblElo.Location = new System.Drawing.Point(5, 87);
            this.LblElo.Name = "LblElo";
            this.LblElo.Size = new System.Drawing.Size(29, 12);
            this.LblElo.TabIndex = 0;
            this.LblElo.Text = "ELO:";
            this.LblElo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbJugador
            // 
            this.NSCmbJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbJugador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbJugador.DropDownHeight = 100;
            this.NSCmbJugador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbJugador.ForeColor = System.Drawing.Color.White;
            this.NSCmbJugador.FormattingEnabled = true;
            this.NSCmbJugador.IntegralHeight = false;
            this.NSCmbJugador.ItemHeight = 15;
            this.NSCmbJugador.Items.AddRange(new object[] {
            "Todos"});
            this.NSCmbJugador.Location = new System.Drawing.Point(70, 56);
            this.NSCmbJugador.Name = "NSCmbJugador";
            this.NSCmbJugador.Size = new System.Drawing.Size(352, 21);
            this.NSCmbJugador.TabIndex = 7;
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.BackColor = System.Drawing.Color.Transparent;
            this.LblJugador.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugador.ForeColor = System.Drawing.Color.White;
            this.LblJugador.Location = new System.Drawing.Point(5, 60);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(48, 12);
            this.LblJugador.TabIndex = 0;
            this.LblJugador.Text = "Jugador:";
            this.LblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbBBDD
            // 
            this.NSCmbBBDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbBBDD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbBBDD.DropDownHeight = 100;
            this.NSCmbBBDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbBBDD.ForeColor = System.Drawing.Color.White;
            this.NSCmbBBDD.FormattingEnabled = true;
            this.NSCmbBBDD.IntegralHeight = false;
            this.NSCmbBBDD.ItemHeight = 15;
            this.NSCmbBBDD.Location = new System.Drawing.Point(70, 29);
            this.NSCmbBBDD.Name = "NSCmbBBDD";
            this.NSCmbBBDD.Size = new System.Drawing.Size(352, 21);
            this.NSCmbBBDD.TabIndex = 6;
            this.NSCmbBBDD.SelectedIndexChanged += new System.EventHandler(this.NSCmbBBDD_SelectedIndexChanged);
            // 
            // LblBBDD
            // 
            this.LblBBDD.AutoSize = true;
            this.LblBBDD.BackColor = System.Drawing.Color.Transparent;
            this.LblBBDD.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBBDD.ForeColor = System.Drawing.Color.White;
            this.LblBBDD.Location = new System.Drawing.Point(5, 33);
            this.LblBBDD.Name = "LblBBDD";
            this.LblBBDD.Size = new System.Drawing.Size(37, 12);
            this.LblBBDD.TabIndex = 0;
            this.LblBBDD.Text = "BBDD:";
            this.LblBBDD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSGpbMotor
            // 
            this.NSGpbMotor.Controls.Add(this.LblNumPlies);
            this.NSGpbMotor.Controls.Add(this.NSCmbMax);
            this.NSGpbMotor.Controls.Add(this.LblMin);
            this.NSGpbMotor.Controls.Add(this.NSCmbMin);
            this.NSGpbMotor.Controls.Add(this.NSTkbPlies);
            this.NSGpbMotor.Controls.Add(this.LblMax);
            this.NSGpbMotor.Controls.Add(this.NSCmbAlgoritmo);
            this.NSGpbMotor.Controls.Add(this.LblPlies);
            this.NSGpbMotor.Controls.Add(this.LblAlgoritmo);
            this.NSGpbMotor.DrawSeperator = false;
            this.NSGpbMotor.Location = new System.Drawing.Point(8, 33);
            this.NSGpbMotor.Name = "NSGpbMotor";
            this.NSGpbMotor.Size = new System.Drawing.Size(433, 90);
            this.NSGpbMotor.SubTitle = "";
            this.NSGpbMotor.TabIndex = 0;
            this.NSGpbMotor.Text = "Motor";
            this.NSGpbMotor.Title = "Motor";
            // 
            // LblNumPlies
            // 
            this.LblNumPlies.BackColor = System.Drawing.Color.Transparent;
            this.LblNumPlies.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumPlies.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNumPlies.Location = new System.Drawing.Point(386, 61);
            this.LblNumPlies.Name = "LblNumPlies";
            this.LblNumPlies.Size = new System.Drawing.Size(40, 12);
            this.LblNumPlies.TabIndex = 0;
            this.LblNumPlies.Text = ": 0";
            this.LblNumPlies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbMax
            // 
            this.NSCmbMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbMax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbMax.DropDownHeight = 100;
            this.NSCmbMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbMax.ForeColor = System.Drawing.Color.White;
            this.NSCmbMax.FormattingEnabled = true;
            this.NSCmbMax.IntegralHeight = false;
            this.NSCmbMax.ItemHeight = 15;
            this.NSCmbMax.Items.AddRange(new object[] {
            "-",
            "1",
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.NSCmbMax.Location = new System.Drawing.Point(366, 29);
            this.NSCmbMax.Name = "NSCmbMax";
            this.NSCmbMax.Size = new System.Drawing.Size(56, 21);
            this.NSCmbMax.TabIndex = 3;
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.BackColor = System.Drawing.Color.Transparent;
            this.LblMin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMin.ForeColor = System.Drawing.Color.White;
            this.LblMin.Location = new System.Drawing.Point(201, 33);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(44, 12);
            this.LblMin.TabIndex = 0;
            this.LblMin.Text = "Min (s):";
            this.LblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbMin
            // 
            this.NSCmbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbMin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbMin.DropDownHeight = 100;
            this.NSCmbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbMin.ForeColor = System.Drawing.Color.White;
            this.NSCmbMin.FormattingEnabled = true;
            this.NSCmbMin.IntegralHeight = false;
            this.NSCmbMin.ItemHeight = 15;
            this.NSCmbMin.Items.AddRange(new object[] {
            "-",
            "1",
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.NSCmbMin.Location = new System.Drawing.Point(251, 29);
            this.NSCmbMin.Name = "NSCmbMin";
            this.NSCmbMin.Size = new System.Drawing.Size(56, 21);
            this.NSCmbMin.TabIndex = 2;
            // 
            // NSTkbPlies
            // 
            this.NSTkbPlies.Location = new System.Drawing.Point(70, 56);
            this.NSTkbPlies.Maximum = 100;
            this.NSTkbPlies.Minimum = 0;
            this.NSTkbPlies.Name = "NSTkbPlies";
            this.NSTkbPlies.Size = new System.Drawing.Size(313, 23);
            this.NSTkbPlies.TabIndex = 4;
            this.NSTkbPlies.Text = "NSTkbPlies";
            this.NSTkbPlies.Value = 0;
            this.NSTkbPlies.Scroll += new NSTrackBar.ScrollEventHandler(this.NSTkbPlies_Scroll);
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.BackColor = System.Drawing.Color.Transparent;
            this.LblMax.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMax.ForeColor = System.Drawing.Color.White;
            this.LblMax.Location = new System.Drawing.Point(313, 33);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(47, 12);
            this.LblMax.TabIndex = 0;
            this.LblMax.Text = "Max (s):";
            this.LblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSCmbAlgoritmo
            // 
            this.NSCmbAlgoritmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbAlgoritmo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbAlgoritmo.DropDownHeight = 100;
            this.NSCmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbAlgoritmo.ForeColor = System.Drawing.Color.White;
            this.NSCmbAlgoritmo.FormattingEnabled = true;
            this.NSCmbAlgoritmo.IntegralHeight = false;
            this.NSCmbAlgoritmo.ItemHeight = 15;
            this.NSCmbAlgoritmo.Items.AddRange(new object[] {
            "TA: Minimax",
            "TA: Alfabeta",
            "TB: DAC"});
            this.NSCmbAlgoritmo.Location = new System.Drawing.Point(70, 29);
            this.NSCmbAlgoritmo.Name = "NSCmbAlgoritmo";
            this.NSCmbAlgoritmo.Size = new System.Drawing.Size(125, 21);
            this.NSCmbAlgoritmo.TabIndex = 1;
            // 
            // LblPlies
            // 
            this.LblPlies.AutoSize = true;
            this.LblPlies.BackColor = System.Drawing.Color.Transparent;
            this.LblPlies.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlies.ForeColor = System.Drawing.Color.White;
            this.LblPlies.Location = new System.Drawing.Point(5, 61);
            this.LblPlies.Name = "LblPlies";
            this.LblPlies.Size = new System.Drawing.Size(33, 12);
            this.LblPlies.TabIndex = 0;
            this.LblPlies.Text = "Plies:";
            this.LblPlies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAlgoritmo
            // 
            this.LblAlgoritmo.AutoSize = true;
            this.LblAlgoritmo.BackColor = System.Drawing.Color.Transparent;
            this.LblAlgoritmo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlgoritmo.ForeColor = System.Drawing.Color.White;
            this.LblAlgoritmo.Location = new System.Drawing.Point(5, 33);
            this.LblAlgoritmo.Name = "LblAlgoritmo";
            this.LblAlgoritmo.Size = new System.Drawing.Size(59, 12);
            this.LblAlgoritmo.TabIndex = 0;
            this.LblAlgoritmo.Text = "Algoritmo:";
            this.LblAlgoritmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "CPU";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "CPU";
            // 
            // FrmCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            this.VisibleChanged += new System.EventHandler(this.FrmCPU_VisibleChanged);
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            this.NSGpbBBDD.ResumeLayout(false);
            this.NSGpbBBDD.PerformLayout();
            this.NSGpbMotor.ResumeLayout(false);
            this.NSGpbMotor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private NSGroupBox NSGpbMotor;
        private NSComboBox NSCmbAlgoritmo;
        private System.Windows.Forms.Label LblPlies;
        private System.Windows.Forms.Label LblAlgoritmo;
        private NSGroupBox NSGpbBBDD;
        private NSOnOffBox NSOobBBDD;
        private NSTrackBar NSTkbPlies;
        private System.Windows.Forms.Label LblMax;
        private NSComboBox NSCmbMax;
        private System.Windows.Forms.Label LblMin;
        private NSComboBox NSCmbMin;
        private System.Windows.Forms.Label LblNumPlies;
        private System.Windows.Forms.Label LblCerrar;
        private NSButton NSBtnGuardar;
        private NSComboBox NSCmbBBDD;
        private System.Windows.Forms.Label LblBBDD;
        private NSComboBox NSCmbJugador;
        private System.Windows.Forms.Label LblJugador;
        private NSComboBox NSCmbElo;
        private System.Windows.Forms.Label LblElo;
        private NSTextBox NSTxbFechaFin;
        private System.Windows.Forms.Label LblFechaFin;
        private NSTextBox NSTxbFechaIni;
        private System.Windows.Forms.Label LblFechaIni;
    }
}