namespace UAChess
{
    partial class FrmGuardar
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
            NSListView.NSListViewColumnHeader nsListViewColumnHeader1 = new NSListView.NSListViewColumnHeader();
            NSListView.NSListViewColumnHeader nsListViewColumnHeader2 = new NSListView.NSListViewColumnHeader();
            NSListView.NSListViewColumnHeader nsListViewColumnHeader3 = new NSListView.NSListViewColumnHeader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuardar));
            this.NSTheme = new NSTheme();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.NSBtnGuardar = new NSButton();
            this.NSGpbFichero = new NSGroupBox();
            this.LblDirectorio = new System.Windows.Forms.Label();
            this.LblPGN = new System.Windows.Forms.Label();
            this.NSTxbFichero = new NSTextBox();
            this.LblFichero = new System.Windows.Forms.Label();
            this.NSLvItems = new NSListView();
            this.NSGpbEtiquetas = new NSGroupBox();
            this.NSTxbBlancas = new NSTextBox();
            this.NSTxbFecha = new NSTextBox();
            this.NSCmbRonda = new NSComboBox();
            this.NSCmbResultado = new NSComboBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblRonda = new System.Windows.Forms.Label();
            this.NSTxbNegras = new NSTextBox();
            this.LblNegras = new System.Windows.Forms.Label();
            this.LblBlancas = new System.Windows.Forms.Label();
            this.NSTxbLugar = new NSTextBox();
            this.LblLugar = new System.Windows.Forms.Label();
            this.NSTxbEvento = new NSTextBox();
            this.LblEvento = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            this.NSGpbFichero.SuspendLayout();
            this.NSGpbEtiquetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.NSBtnGuardar);
            this.NSTheme.Controls.Add(this.NSGpbFichero);
            this.NSTheme.Controls.Add(this.NSGpbEtiquetas);
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
            this.NSTheme.Size = new System.Drawing.Size(450, 410);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "Guardar";
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
            // NSBtnGuardar
            // 
            this.NSBtnGuardar.Location = new System.Drawing.Point(381, 382);
            this.NSBtnGuardar.Name = "NSBtnGuardar";
            this.NSBtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnGuardar.Size = new System.Drawing.Size(60, 23);
            this.NSBtnGuardar.TabIndex = 10;
            this.NSBtnGuardar.Text = "Guardar";
            this.NSBtnGuardar.Click += new System.EventHandler(this.NSBtnGuardar_Click);
            // 
            // NSGpbFichero
            // 
            this.NSGpbFichero.Controls.Add(this.LblDirectorio);
            this.NSGpbFichero.Controls.Add(this.LblPGN);
            this.NSGpbFichero.Controls.Add(this.NSTxbFichero);
            this.NSGpbFichero.Controls.Add(this.LblFichero);
            this.NSGpbFichero.Controls.Add(this.NSLvItems);
            this.NSGpbFichero.DrawSeperator = false;
            this.NSGpbFichero.Location = new System.Drawing.Point(8, 195);
            this.NSGpbFichero.Name = "NSGpbFichero";
            this.NSGpbFichero.Size = new System.Drawing.Size(433, 184);
            this.NSGpbFichero.SubTitle = "";
            this.NSGpbFichero.TabIndex = 0;
            this.NSGpbFichero.Text = "Fichero";
            this.NSGpbFichero.Title = "Fichero";
            // 
            // LblDirectorio
            // 
            this.LblDirectorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.LblDirectorio.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirectorio.ForeColor = System.Drawing.Color.White;
            this.LblDirectorio.Location = new System.Drawing.Point(80, 33);
            this.LblDirectorio.Name = "LblDirectorio";
            this.LblDirectorio.Size = new System.Drawing.Size(317, 21);
            this.LblDirectorio.TabIndex = 0;
            this.LblDirectorio.Text = "No seleccionado";
            this.LblDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPGN
            // 
            this.LblPGN.AutoSize = true;
            this.LblPGN.BackColor = System.Drawing.Color.Transparent;
            this.LblPGN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPGN.ForeColor = System.Drawing.Color.White;
            this.LblPGN.Location = new System.Drawing.Point(395, 160);
            this.LblPGN.Name = "LblPGN";
            this.LblPGN.Size = new System.Drawing.Size(29, 12);
            this.LblPGN.TabIndex = 0;
            this.LblPGN.Text = ".PGN";
            this.LblPGN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTxbFichero
            // 
            this.NSTxbFichero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbFichero.Location = new System.Drawing.Point(61, 154);
            this.NSTxbFichero.MaxLength = 20;
            this.NSTxbFichero.Multiline = false;
            this.NSTxbFichero.Name = "NSTxbFichero";
            this.NSTxbFichero.ReadOnly = false;
            this.NSTxbFichero.Size = new System.Drawing.Size(328, 24);
            this.NSTxbFichero.TabIndex = 9;
            this.NSTxbFichero.Text = "Partida";
            this.NSTxbFichero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbFichero.UseSystemPasswordChar = false;
            this.NSTxbFichero.TextChanged += new System.EventHandler(this.NSTxbFichero_TextChanged);
            // 
            // LblFichero
            // 
            this.LblFichero.AutoSize = true;
            this.LblFichero.BackColor = System.Drawing.Color.Transparent;
            this.LblFichero.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFichero.ForeColor = System.Drawing.Color.White;
            this.LblFichero.Location = new System.Drawing.Point(7, 160);
            this.LblFichero.Name = "LblFichero";
            this.LblFichero.Size = new System.Drawing.Size(45, 12);
            this.LblFichero.TabIndex = 0;
            this.LblFichero.Text = "Fichero:";
            this.LblFichero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSLvItems
            // 
            nsListViewColumnHeader1.Text = "Directorio:";
            nsListViewColumnHeader1.Width = 400;
            nsListViewColumnHeader2.Text = "Num";
            nsListViewColumnHeader2.Width = 0;
            nsListViewColumnHeader3.Text = "Ruta";
            nsListViewColumnHeader3.Width = 0;
            this.NSLvItems.Columns = new NSListView.NSListViewColumnHeader[] {
        nsListViewColumnHeader1,
        nsListViewColumnHeader2,
        nsListViewColumnHeader3};
            this.NSLvItems.Items = new NSListView.NSListViewItem[0];
            this.NSLvItems.Location = new System.Drawing.Point(5, 30);
            this.NSLvItems.MultiSelect = false;
            this.NSLvItems.Name = "NSLvItems";
            this.NSLvItems.Size = new System.Drawing.Size(421, 120);
            this.NSLvItems.TabIndex = 0;
            this.NSLvItems.Text = "NSLvItems";
            this.NSLvItems.DoubleClick += new System.EventHandler(this.NSLvItems_DoubleClick);
            // 
            // NSGpbEtiquetas
            // 
            this.NSGpbEtiquetas.Controls.Add(this.NSTxbBlancas);
            this.NSGpbEtiquetas.Controls.Add(this.NSTxbFecha);
            this.NSGpbEtiquetas.Controls.Add(this.NSCmbRonda);
            this.NSGpbEtiquetas.Controls.Add(this.NSCmbResultado);
            this.NSGpbEtiquetas.Controls.Add(this.LblResultado);
            this.NSGpbEtiquetas.Controls.Add(this.LblRonda);
            this.NSGpbEtiquetas.Controls.Add(this.NSTxbNegras);
            this.NSGpbEtiquetas.Controls.Add(this.LblNegras);
            this.NSGpbEtiquetas.Controls.Add(this.LblBlancas);
            this.NSGpbEtiquetas.Controls.Add(this.NSTxbLugar);
            this.NSGpbEtiquetas.Controls.Add(this.LblLugar);
            this.NSGpbEtiquetas.Controls.Add(this.NSTxbEvento);
            this.NSGpbEtiquetas.Controls.Add(this.LblEvento);
            this.NSGpbEtiquetas.Controls.Add(this.LblFecha);
            this.NSGpbEtiquetas.DrawSeperator = false;
            this.NSGpbEtiquetas.Location = new System.Drawing.Point(8, 33);
            this.NSGpbEtiquetas.Name = "NSGpbEtiquetas";
            this.NSGpbEtiquetas.Size = new System.Drawing.Size(433, 156);
            this.NSGpbEtiquetas.SubTitle = "";
            this.NSGpbEtiquetas.TabIndex = 0;
            this.NSGpbEtiquetas.Text = "Etiquetas";
            this.NSGpbEtiquetas.Title = "Etiquetas";
            // 
            // NSTxbBlancas
            // 
            this.NSTxbBlancas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbBlancas.Location = new System.Drawing.Point(60, 91);
            this.NSTxbBlancas.MaxLength = 50;
            this.NSTxbBlancas.Multiline = false;
            this.NSTxbBlancas.Name = "NSTxbBlancas";
            this.NSTxbBlancas.ReadOnly = false;
            this.NSTxbBlancas.Size = new System.Drawing.Size(366, 24);
            this.NSTxbBlancas.TabIndex = 6;
            this.NSTxbBlancas.Text = "Jugador Blancas";
            this.NSTxbBlancas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbBlancas.UseSystemPasswordChar = false;
            // 
            // NSTxbFecha
            // 
            this.NSTxbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTxbFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbFecha.Location = new System.Drawing.Point(61, 29);
            this.NSTxbFecha.MaxLength = 10;
            this.NSTxbFecha.Multiline = false;
            this.NSTxbFecha.Name = "NSTxbFecha";
            this.NSTxbFecha.ReadOnly = false;
            this.NSTxbFecha.Size = new System.Drawing.Size(100, 24);
            this.NSTxbFecha.TabIndex = 1;
            this.NSTxbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbFecha.UseSystemPasswordChar = false;
            // 
            // NSCmbRonda
            // 
            this.NSCmbRonda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbRonda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbRonda.DropDownHeight = 100;
            this.NSCmbRonda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbRonda.ForeColor = System.Drawing.Color.White;
            this.NSCmbRonda.FormattingEnabled = true;
            this.NSCmbRonda.IntegralHeight = false;
            this.NSCmbRonda.ItemHeight = 15;
            this.NSCmbRonda.Items.AddRange(new object[] {
            "?",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.NSCmbRonda.Location = new System.Drawing.Point(209, 31);
            this.NSCmbRonda.Name = "NSCmbRonda";
            this.NSCmbRonda.Size = new System.Drawing.Size(72, 21);
            this.NSCmbRonda.TabIndex = 2;
            // 
            // NSCmbResultado
            // 
            this.NSCmbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbResultado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbResultado.DropDownHeight = 100;
            this.NSCmbResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbResultado.ForeColor = System.Drawing.Color.White;
            this.NSCmbResultado.FormattingEnabled = true;
            this.NSCmbResultado.IntegralHeight = false;
            this.NSCmbResultado.ItemHeight = 15;
            this.NSCmbResultado.Items.AddRange(new object[] {
            "*",
            "1-0",
            "0-1",
            "1/2-1/2"});
            this.NSCmbResultado.Location = new System.Drawing.Point(354, 31);
            this.NSCmbResultado.Name = "NSCmbResultado";
            this.NSCmbResultado.Size = new System.Drawing.Size(72, 21);
            this.NSCmbResultado.TabIndex = 3;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.Color.Transparent;
            this.LblResultado.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.White;
            this.LblResultado.Location = new System.Drawing.Point(291, 35);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(59, 12);
            this.LblResultado.TabIndex = 0;
            this.LblResultado.Text = "Resultado:";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRonda
            // 
            this.LblRonda.AutoSize = true;
            this.LblRonda.BackColor = System.Drawing.Color.Transparent;
            this.LblRonda.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRonda.ForeColor = System.Drawing.Color.White;
            this.LblRonda.Location = new System.Drawing.Point(167, 35);
            this.LblRonda.Name = "LblRonda";
            this.LblRonda.Size = new System.Drawing.Size(40, 12);
            this.LblRonda.TabIndex = 0;
            this.LblRonda.Text = "Ronda:";
            this.LblRonda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTxbNegras
            // 
            this.NSTxbNegras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbNegras.Location = new System.Drawing.Point(60, 121);
            this.NSTxbNegras.MaxLength = 50;
            this.NSTxbNegras.Multiline = false;
            this.NSTxbNegras.Name = "NSTxbNegras";
            this.NSTxbNegras.ReadOnly = false;
            this.NSTxbNegras.Size = new System.Drawing.Size(366, 24);
            this.NSTxbNegras.TabIndex = 7;
            this.NSTxbNegras.Text = "Jugador Negras";
            this.NSTxbNegras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbNegras.UseSystemPasswordChar = false;
            // 
            // LblNegras
            // 
            this.LblNegras.AutoSize = true;
            this.LblNegras.BackColor = System.Drawing.Color.Transparent;
            this.LblNegras.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNegras.ForeColor = System.Drawing.Color.White;
            this.LblNegras.Location = new System.Drawing.Point(7, 127);
            this.LblNegras.Name = "LblNegras";
            this.LblNegras.Size = new System.Drawing.Size(43, 12);
            this.LblNegras.TabIndex = 0;
            this.LblNegras.Text = "Negras:";
            this.LblNegras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBlancas
            // 
            this.LblBlancas.AutoSize = true;
            this.LblBlancas.BackColor = System.Drawing.Color.Transparent;
            this.LblBlancas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBlancas.ForeColor = System.Drawing.Color.White;
            this.LblBlancas.Location = new System.Drawing.Point(7, 95);
            this.LblBlancas.Name = "LblBlancas";
            this.LblBlancas.Size = new System.Drawing.Size(47, 12);
            this.LblBlancas.TabIndex = 0;
            this.LblBlancas.Text = "Blancas:";
            this.LblBlancas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTxbLugar
            // 
            this.NSTxbLugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbLugar.Location = new System.Drawing.Point(271, 60);
            this.NSTxbLugar.MaxLength = 20;
            this.NSTxbLugar.Multiline = false;
            this.NSTxbLugar.Name = "NSTxbLugar";
            this.NSTxbLugar.ReadOnly = false;
            this.NSTxbLugar.Size = new System.Drawing.Size(155, 24);
            this.NSTxbLugar.TabIndex = 5;
            this.NSTxbLugar.Text = "UAChess";
            this.NSTxbLugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbLugar.UseSystemPasswordChar = false;
            // 
            // LblLugar
            // 
            this.LblLugar.AutoSize = true;
            this.LblLugar.BackColor = System.Drawing.Color.Transparent;
            this.LblLugar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLugar.ForeColor = System.Drawing.Color.White;
            this.LblLugar.Location = new System.Drawing.Point(222, 65);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(37, 12);
            this.LblLugar.TabIndex = 0;
            this.LblLugar.Text = "Lugar:";
            this.LblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSTxbEvento
            // 
            this.NSTxbEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbEvento.Location = new System.Drawing.Point(61, 60);
            this.NSTxbEvento.MaxLength = 20;
            this.NSTxbEvento.Multiline = false;
            this.NSTxbEvento.Name = "NSTxbEvento";
            this.NSTxbEvento.ReadOnly = false;
            this.NSTxbEvento.Size = new System.Drawing.Size(155, 24);
            this.NSTxbEvento.TabIndex = 4;
            this.NSTxbEvento.Text = "UAChess Event";
            this.NSTxbEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbEvento.UseSystemPasswordChar = false;
            // 
            // LblEvento
            // 
            this.LblEvento.AutoSize = true;
            this.LblEvento.BackColor = System.Drawing.Color.Transparent;
            this.LblEvento.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvento.ForeColor = System.Drawing.Color.White;
            this.LblEvento.Location = new System.Drawing.Point(7, 65);
            this.LblEvento.Name = "LblEvento";
            this.LblEvento.Size = new System.Drawing.Size(44, 12);
            this.LblEvento.TabIndex = 0;
            this.LblEvento.Text = "Evento:";
            this.LblEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(7, 35);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(38, 12);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Guardar";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "GUARDAR";
            // 
            // FrmGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(450, 410);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGuardar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar";
            this.VisibleChanged += new System.EventHandler(this.FrmGuardar_VisibleChanged);
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            this.NSGpbFichero.ResumeLayout(false);
            this.NSGpbFichero.PerformLayout();
            this.NSGpbEtiquetas.ResumeLayout(false);
            this.NSGpbEtiquetas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private NSListView NSLvItems;
        private NSGroupBox NSGpbEtiquetas;
        private System.Windows.Forms.Label LblFecha;
        private NSGroupBox NSGpbFichero;
        private System.Windows.Forms.Label LblFichero;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblRonda;
        private NSTextBox NSTxbNegras;
        private System.Windows.Forms.Label LblNegras;
        private System.Windows.Forms.Label LblBlancas;
        private NSTextBox NSTxbLugar;
        private System.Windows.Forms.Label LblLugar;
        private NSTextBox NSTxbEvento;
        private System.Windows.Forms.Label LblEvento;
        private NSButton NSBtnGuardar;
        private NSComboBox NSCmbResultado;
        private NSComboBox NSCmbRonda;
        private NSTextBox NSTxbFecha;
        private NSTextBox NSTxbFichero;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Label LblPGN;
        private NSTextBox NSTxbBlancas;
        private System.Windows.Forms.Label LblDirectorio;
    }
}