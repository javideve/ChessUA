namespace UAChess
{
    partial class FrmChess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChess));
            this.NSTheme = new NSTheme();
            this.NSGpbHistorial = new NSGroupBox();
            this.NSRbtDescriptivo = new NSRadioButton();
            this.NSRbtAlgebraico = new NSRadioButton();
            this.PbxIcoDeshacer = new System.Windows.Forms.PictureBox();
            this.PbxIcoFinal = new System.Windows.Forms.PictureBox();
            this.PbxIcoAdelante = new System.Windows.Forms.PictureBox();
            this.PbxIcoReproducir = new System.Windows.Forms.PictureBox();
            this.PbxIcoAtras = new System.Windows.Forms.PictureBox();
            this.PbxIcoInicio = new System.Windows.Forms.PictureBox();
            this.NSLvHistorialA = new NSListView();
            this.NSLvHistorialD = new NSListView();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.PbxSelNegras = new System.Windows.Forms.PictureBox();
            this.PbxSelBlancas = new System.Windows.Forms.PictureBox();
            this.NSCmbNegras = new NSComboBox();
            this.NSCmbBlancas = new NSComboBox();
            this.PbxIcoNegras = new System.Windows.Forms.PictureBox();
            this.LblPuntosN = new System.Windows.Forms.Label();
            this.PbxIcoBlancas = new System.Windows.Forms.PictureBox();
            this.LblPuntosB = new System.Windows.Forms.Label();
            this.NSGpbDetalles = new NSGroupBox();
            this.LblModo = new System.Windows.Forms.Label();
            this.PnlVisor = new System.Windows.Forms.Panel();
            this.NSCmbPartidas = new NSComboBox();
            this.LblDEvento = new System.Windows.Forms.Label();
            this.LblDLugar = new System.Windows.Forms.Label();
            this.LblDFecha = new System.Windows.Forms.Label();
            this.LblDElo = new System.Windows.Forms.Label();
            this.LblDBlancas = new System.Windows.Forms.Label();
            this.LblDNegras = new System.Windows.Forms.Label();
            this.LblDResultado = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblNegras = new System.Windows.Forms.Label();
            this.LblBlancas = new System.Windows.Forms.Label();
            this.LblElo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblLugar = new System.Windows.Forms.Label();
            this.LblEvento = new System.Windows.Forms.Label();
            this.PnlJuego = new System.Windows.Forms.Panel();
            this.PnlNegras = new System.Windows.Forms.Panel();
            this.LblDAlgoritmoN = new System.Windows.Forms.Label();
            this.LblDMovsN = new System.Windows.Forms.Label();
            this.LblAlgoritmoN = new System.Windows.Forms.Label();
            this.LblMovsN = new System.Windows.Forms.Label();
            this.LblDAtaqueN = new System.Windows.Forms.Label();
            this.PbxNegras = new System.Windows.Forms.PictureBox();
            this.LblAtaqueN = new System.Windows.Forms.Label();
            this.PnlBlancas = new System.Windows.Forms.Panel();
            this.LblDAlgoritmoB = new System.Windows.Forms.Label();
            this.LblDMovsB = new System.Windows.Forms.Label();
            this.LblAlgoritmoB = new System.Windows.Forms.Label();
            this.LblMovsB = new System.Windows.Forms.Label();
            this.LblDAtaqueB = new System.Windows.Forms.Label();
            this.PbxBlancas = new System.Windows.Forms.PictureBox();
            this.LblAtaqueB = new System.Windows.Forms.Label();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.LblIcoBBDD = new System.Windows.Forms.Label();
            this.LblIcoCPU = new System.Windows.Forms.Label();
            this.LblIcoEstadisticas = new System.Windows.Forms.Label();
            this.LblIcoCreditos = new System.Windows.Forms.Label();
            this.PbxIcoBBDD = new System.Windows.Forms.PictureBox();
            this.LblIcoBrazo = new System.Windows.Forms.Label();
            this.PbxIcoCPU = new System.Windows.Forms.PictureBox();
            this.PbxIcoEstadisticas = new System.Windows.Forms.PictureBox();
            this.LblIcoAjustes = new System.Windows.Forms.Label();
            this.PbxIcoBrazo = new System.Windows.Forms.PictureBox();
            this.PbxIcoAjustes = new System.Windows.Forms.PictureBox();
            this.LblIcoCargar = new System.Windows.Forms.Label();
            this.PbxIcoCreditos = new System.Windows.Forms.PictureBox();
            this.PbxIcoCargar = new System.Windows.Forms.PictureBox();
            this.LblIcoGuardar = new System.Windows.Forms.Label();
            this.PbxIcoGuardar = new System.Windows.Forms.PictureBox();
            this.LblIcoJugar = new System.Windows.Forms.Label();
            this.LblIcoNuevo = new System.Windows.Forms.Label();
            this.PbxIcoJugar = new System.Windows.Forms.PictureBox();
            this.PbxIcoNuevo = new System.Windows.Forms.PictureBox();
            this.PnlTablero = new System.Windows.Forms.Panel();
            this.LblCasillasA = new System.Windows.Forms.Label();
            this.LblCasillasB = new System.Windows.Forms.Label();
            this.LblCasillasC = new System.Windows.Forms.Label();
            this.LblCasillasD = new System.Windows.Forms.Label();
            this.LblCasillasE = new System.Windows.Forms.Label();
            this.LblCasillasF = new System.Windows.Forms.Label();
            this.LblCasillasG = new System.Windows.Forms.Label();
            this.LblCasillasH = new System.Windows.Forms.Label();
            this.LblCasillas1 = new System.Windows.Forms.Label();
            this.LblCasillas2 = new System.Windows.Forms.Label();
            this.LblCasillas3 = new System.Windows.Forms.Label();
            this.LblCasillas4 = new System.Windows.Forms.Label();
            this.LblCasillas5 = new System.Windows.Forms.Label();
            this.LblCasillas6 = new System.Windows.Forms.Label();
            this.LblCasillas7 = new System.Windows.Forms.Label();
            this.LblCasillas8 = new System.Windows.Forms.Label();
            this.PbxCasilla00 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla01 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla02 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla03 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla04 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla05 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla06 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla07 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla10 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla11 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla12 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla13 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla14 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla15 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla16 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla17 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla20 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla21 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla22 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla23 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla24 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla25 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla26 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla27 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla30 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla31 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla32 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla33 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla34 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla35 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla36 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla37 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla40 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla41 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla42 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla43 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla44 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla45 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla46 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla47 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla50 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla51 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla52 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla53 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla54 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla55 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla56 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla57 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla60 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla61 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla62 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla63 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla64 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla65 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla66 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla67 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla70 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla71 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla72 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla73 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla74 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla75 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla76 = new System.Windows.Forms.PictureBox();
            this.PbxCasilla77 = new System.Windows.Forms.PictureBox();
            this.NSCBtnCerrar = new NSControlButton();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            this.NSGpbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoDeshacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoInicio)).BeginInit();
            this.PnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelNegras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelBlancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoNegras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBlancas)).BeginInit();
            this.NSGpbDetalles.SuspendLayout();
            this.PnlVisor.SuspendLayout();
            this.PnlJuego.SuspendLayout();
            this.PnlNegras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNegras)).BeginInit();
            this.PnlBlancas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlancas)).BeginInit();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBrazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoJugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoNuevo)).BeginInit();
            this.PnlTablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla77)).BeginInit();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.NSGpbHistorial);
            this.NSTheme.Controls.Add(this.PnlDatos);
            this.NSTheme.Controls.Add(this.PnlMenu);
            this.NSTheme.Controls.Add(this.PnlTablero);
            this.NSTheme.Controls.Add(this.NSCBtnCerrar);
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
            this.NSTheme.Size = new System.Drawing.Size(715, 565);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "UAChess";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // NSGpbHistorial
            // 
            this.NSGpbHistorial.Controls.Add(this.NSRbtDescriptivo);
            this.NSGpbHistorial.Controls.Add(this.NSRbtAlgebraico);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoDeshacer);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoFinal);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoAdelante);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoReproducir);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoAtras);
            this.NSGpbHistorial.Controls.Add(this.PbxIcoInicio);
            this.NSGpbHistorial.Controls.Add(this.NSLvHistorialA);
            this.NSGpbHistorial.Controls.Add(this.NSLvHistorialD);
            this.NSGpbHistorial.DrawSeperator = false;
            this.NSGpbHistorial.Location = new System.Drawing.Point(488, 282);
            this.NSGpbHistorial.Name = "NSGpbHistorial";
            this.NSGpbHistorial.Size = new System.Drawing.Size(214, 280);
            this.NSGpbHistorial.SubTitle = "Movimientos realizados en la partida";
            this.NSGpbHistorial.TabIndex = 0;
            this.NSGpbHistorial.Text = "Historial";
            this.NSGpbHistorial.Title = "Historial";
            // 
            // NSRbtDescriptivo
            // 
            this.NSRbtDescriptivo.Checked = false;
            this.NSRbtDescriptivo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtDescriptivo.Location = new System.Drawing.Point(98, 38);
            this.NSRbtDescriptivo.Name = "NSRbtDescriptivo";
            this.NSRbtDescriptivo.Size = new System.Drawing.Size(93, 23);
            this.NSRbtDescriptivo.TabIndex = 0;
            this.NSRbtDescriptivo.Text = "Descriptivo";
            this.NSRbtDescriptivo.Click += new System.EventHandler(this.NSRbtHistorial_Click);
            // 
            // NSRbtAlgebraico
            // 
            this.NSRbtAlgebraico.Checked = true;
            this.NSRbtAlgebraico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtAlgebraico.Location = new System.Drawing.Point(4, 38);
            this.NSRbtAlgebraico.Name = "NSRbtAlgebraico";
            this.NSRbtAlgebraico.Size = new System.Drawing.Size(94, 23);
            this.NSRbtAlgebraico.TabIndex = 0;
            this.NSRbtAlgebraico.Text = "Algebraico";
            this.NSRbtAlgebraico.Click += new System.EventHandler(this.NSRbtHistorial_Click);
            // 
            // PbxIcoDeshacer
            // 
            this.PbxIcoDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoDeshacer.Image = global::UAChess.Properties.Resources.IcoDeshacer;
            this.PbxIcoDeshacer.Location = new System.Drawing.Point(177, 249);
            this.PbxIcoDeshacer.Name = "PbxIcoDeshacer";
            this.PbxIcoDeshacer.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoDeshacer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoDeshacer.TabIndex = 55;
            this.PbxIcoDeshacer.TabStop = false;
            this.PbxIcoDeshacer.Tag = "";
            this.PbxIcoDeshacer.Click += new System.EventHandler(this.PbxIcoDeshacer_Click);
            this.PbxIcoDeshacer.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoDeshacer.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoFinal
            // 
            this.PbxIcoFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoFinal.Image = global::UAChess.Properties.Resources.IcoFinal;
            this.PbxIcoFinal.Location = new System.Drawing.Point(142, 249);
            this.PbxIcoFinal.Name = "PbxIcoFinal";
            this.PbxIcoFinal.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoFinal.TabIndex = 54;
            this.PbxIcoFinal.TabStop = false;
            this.PbxIcoFinal.Tag = "";
            this.PbxIcoFinal.Click += new System.EventHandler(this.PbxIcoFinal_Click);
            this.PbxIcoFinal.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoFinal.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoAdelante
            // 
            this.PbxIcoAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoAdelante.Image = global::UAChess.Properties.Resources.IcoAdelante;
            this.PbxIcoAdelante.Location = new System.Drawing.Point(107, 249);
            this.PbxIcoAdelante.Name = "PbxIcoAdelante";
            this.PbxIcoAdelante.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoAdelante.TabIndex = 53;
            this.PbxIcoAdelante.TabStop = false;
            this.PbxIcoAdelante.Tag = "";
            this.PbxIcoAdelante.Click += new System.EventHandler(this.PbxIcoAdelante_Click);
            this.PbxIcoAdelante.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoAdelante.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoReproducir
            // 
            this.PbxIcoReproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoReproducir.Image = global::UAChess.Properties.Resources.IcoReproducir;
            this.PbxIcoReproducir.Location = new System.Drawing.Point(72, 249);
            this.PbxIcoReproducir.Name = "PbxIcoReproducir";
            this.PbxIcoReproducir.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoReproducir.TabIndex = 52;
            this.PbxIcoReproducir.TabStop = false;
            this.PbxIcoReproducir.Tag = "Reproducir";
            this.PbxIcoReproducir.Click += new System.EventHandler(this.PbxIcoReproducir_Click);
            this.PbxIcoReproducir.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoReproducir.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoAtras
            // 
            this.PbxIcoAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoAtras.Image = global::UAChess.Properties.Resources.IcoAtras;
            this.PbxIcoAtras.Location = new System.Drawing.Point(37, 249);
            this.PbxIcoAtras.Name = "PbxIcoAtras";
            this.PbxIcoAtras.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoAtras.TabIndex = 51;
            this.PbxIcoAtras.TabStop = false;
            this.PbxIcoAtras.Tag = "";
            this.PbxIcoAtras.Click += new System.EventHandler(this.PbxIcoAtras_Click);
            this.PbxIcoAtras.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoAtras.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoInicio
            // 
            this.PbxIcoInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoInicio.Image = global::UAChess.Properties.Resources.IcoInicio;
            this.PbxIcoInicio.Location = new System.Drawing.Point(2, 249);
            this.PbxIcoInicio.Name = "PbxIcoInicio";
            this.PbxIcoInicio.Size = new System.Drawing.Size(35, 30);
            this.PbxIcoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoInicio.TabIndex = 50;
            this.PbxIcoInicio.TabStop = false;
            this.PbxIcoInicio.Tag = "";
            this.PbxIcoInicio.Click += new System.EventHandler(this.PbxIcoInicio_Click);
            this.PbxIcoInicio.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoInicio.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // NSLvHistorialA
            // 
            this.NSLvHistorialA.Columns = new NSListView.NSListViewColumnHeader[0];
            this.NSLvHistorialA.Items = new NSListView.NSListViewItem[0];
            this.NSLvHistorialA.Location = new System.Drawing.Point(3, 37);
            this.NSLvHistorialA.MultiSelect = false;
            this.NSLvHistorialA.Name = "NSLvHistorialA";
            this.NSLvHistorialA.Size = new System.Drawing.Size(208, 212);
            this.NSLvHistorialA.TabIndex = 0;
            this.NSLvHistorialA.Text = "NSLvHistorialA";
            this.NSLvHistorialA.Click += new System.EventHandler(this.NSLvHistorial_Click);
            // 
            // NSLvHistorialD
            // 
            this.NSLvHistorialD.Columns = new NSListView.NSListViewColumnHeader[0];
            this.NSLvHistorialD.Items = new NSListView.NSListViewItem[0];
            this.NSLvHistorialD.Location = new System.Drawing.Point(3, 37);
            this.NSLvHistorialD.MultiSelect = false;
            this.NSLvHistorialD.Name = "NSLvHistorialD";
            this.NSLvHistorialD.Size = new System.Drawing.Size(208, 212);
            this.NSLvHistorialD.TabIndex = 0;
            this.NSLvHistorialD.Text = "NSLvHistorialD";
            this.NSLvHistorialD.Visible = false;
            this.NSLvHistorialD.Click += new System.EventHandler(this.NSLvHistorial_Click);
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.PbxSelNegras);
            this.PnlDatos.Controls.Add(this.PbxSelBlancas);
            this.PnlDatos.Controls.Add(this.NSCmbNegras);
            this.PnlDatos.Controls.Add(this.NSCmbBlancas);
            this.PnlDatos.Controls.Add(this.PbxIcoNegras);
            this.PnlDatos.Controls.Add(this.LblPuntosN);
            this.PnlDatos.Controls.Add(this.PbxIcoBlancas);
            this.PnlDatos.Controls.Add(this.LblPuntosB);
            this.PnlDatos.Controls.Add(this.NSGpbDetalles);
            this.PnlDatos.Location = new System.Drawing.Point(488, 31);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(214, 245);
            this.PnlDatos.TabIndex = 0;
            // 
            // PbxSelNegras
            // 
            this.PbxSelNegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxSelNegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxSelNegras.Image = global::UAChess.Properties.Resources.AppFlecha;
            this.PbxSelNegras.Location = new System.Drawing.Point(119, -13);
            this.PbxSelNegras.Name = "PbxSelNegras";
            this.PbxSelNegras.Size = new System.Drawing.Size(15, 20);
            this.PbxSelNegras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSelNegras.TabIndex = 63;
            this.PbxSelNegras.TabStop = false;
            this.PbxSelNegras.Tag = "";
            this.PbxSelNegras.Visible = false;
            // 
            // PbxSelBlancas
            // 
            this.PbxSelBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxSelBlancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxSelBlancas.Image = global::UAChess.Properties.Resources.AppFlecha;
            this.PbxSelBlancas.Location = new System.Drawing.Point(15, -13);
            this.PbxSelBlancas.Name = "PbxSelBlancas";
            this.PbxSelBlancas.Size = new System.Drawing.Size(15, 20);
            this.PbxSelBlancas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSelBlancas.TabIndex = 62;
            this.PbxSelBlancas.TabStop = false;
            this.PbxSelBlancas.Tag = "";
            this.PbxSelBlancas.Visible = false;
            // 
            // NSCmbNegras
            // 
            this.NSCmbNegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbNegras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbNegras.DropDownHeight = 125;
            this.NSCmbNegras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbNegras.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSCmbNegras.ForeColor = System.Drawing.Color.White;
            this.NSCmbNegras.FormattingEnabled = true;
            this.NSCmbNegras.IntegralHeight = false;
            this.NSCmbNegras.ItemHeight = 12;
            this.NSCmbNegras.Items.AddRange(new object[] {
            "JUG.",
            "CPU"});
            this.NSCmbNegras.Location = new System.Drawing.Point(149, 34);
            this.NSCmbNegras.Name = "NSCmbNegras";
            this.NSCmbNegras.Size = new System.Drawing.Size(60, 18);
            this.NSCmbNegras.TabIndex = 0;
            this.NSCmbNegras.SelectedIndexChanged += new System.EventHandler(this.NSCmbJugador_SelectedIndexChanged);
            // 
            // NSCmbBlancas
            // 
            this.NSCmbBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbBlancas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbBlancas.DropDownHeight = 125;
            this.NSCmbBlancas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbBlancas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSCmbBlancas.ForeColor = System.Drawing.Color.White;
            this.NSCmbBlancas.FormattingEnabled = true;
            this.NSCmbBlancas.IntegralHeight = false;
            this.NSCmbBlancas.ItemHeight = 12;
            this.NSCmbBlancas.Items.AddRange(new object[] {
            "JUG.",
            "CPU"});
            this.NSCmbBlancas.Location = new System.Drawing.Point(45, 34);
            this.NSCmbBlancas.Name = "NSCmbBlancas";
            this.NSCmbBlancas.Size = new System.Drawing.Size(60, 18);
            this.NSCmbBlancas.TabIndex = 0;
            this.NSCmbBlancas.SelectedIndexChanged += new System.EventHandler(this.NSCmbJugador_SelectedIndexChanged);
            // 
            // PbxIcoNegras
            // 
            this.PbxIcoNegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoNegras.Image = global::UAChess.Properties.Resources.IcoTurnoS;
            this.PbxIcoNegras.Location = new System.Drawing.Point(104, 10);
            this.PbxIcoNegras.Name = "PbxIcoNegras";
            this.PbxIcoNegras.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoNegras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoNegras.TabIndex = 61;
            this.PbxIcoNegras.TabStop = false;
            this.PbxIcoNegras.Tag = "";
            this.PbxIcoNegras.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoNegras.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblPuntosN
            // 
            this.LblPuntosN.BackColor = System.Drawing.Color.Goldenrod;
            this.LblPuntosN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosN.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosN.Location = new System.Drawing.Point(149, 17);
            this.LblPuntosN.Name = "LblPuntosN";
            this.LblPuntosN.Size = new System.Drawing.Size(60, 15);
            this.LblPuntosN.TabIndex = 0;
            this.LblPuntosN.Text = "0 puntos";
            this.LblPuntosN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxIcoBlancas
            // 
            this.PbxIcoBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxIcoBlancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoBlancas.Image = global::UAChess.Properties.Resources.IcoTurno;
            this.PbxIcoBlancas.Location = new System.Drawing.Point(0, 10);
            this.PbxIcoBlancas.Name = "PbxIcoBlancas";
            this.PbxIcoBlancas.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoBlancas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoBlancas.TabIndex = 60;
            this.PbxIcoBlancas.TabStop = false;
            this.PbxIcoBlancas.Tag = "";
            this.PbxIcoBlancas.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoBlancas.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblPuntosB
            // 
            this.LblPuntosB.BackColor = System.Drawing.Color.White;
            this.LblPuntosB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosB.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosB.Location = new System.Drawing.Point(45, 17);
            this.LblPuntosB.Name = "LblPuntosB";
            this.LblPuntosB.Size = new System.Drawing.Size(60, 15);
            this.LblPuntosB.TabIndex = 0;
            this.LblPuntosB.Text = "0 puntos";
            this.LblPuntosB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSGpbDetalles
            // 
            this.NSGpbDetalles.Controls.Add(this.LblModo);
            this.NSGpbDetalles.Controls.Add(this.PnlVisor);
            this.NSGpbDetalles.Controls.Add(this.PnlJuego);
            this.NSGpbDetalles.DrawSeperator = false;
            this.NSGpbDetalles.Location = new System.Drawing.Point(0, 63);
            this.NSGpbDetalles.Name = "NSGpbDetalles";
            this.NSGpbDetalles.Size = new System.Drawing.Size(214, 182);
            this.NSGpbDetalles.SubTitle = "";
            this.NSGpbDetalles.TabIndex = 0;
            this.NSGpbDetalles.Text = "Detalles";
            this.NSGpbDetalles.Title = "Detalles";
            // 
            // LblModo
            // 
            this.LblModo.BackColor = System.Drawing.Color.White;
            this.LblModo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblModo.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModo.ForeColor = System.Drawing.Color.Black;
            this.LblModo.Location = new System.Drawing.Point(7, 23);
            this.LblModo.Name = "LblModo";
            this.LblModo.Size = new System.Drawing.Size(200, 13);
            this.LblModo.TabIndex = 0;
            this.LblModo.Text = "Aplicación en modo pausa";
            this.LblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlVisor
            // 
            this.PnlVisor.Controls.Add(this.NSCmbPartidas);
            this.PnlVisor.Controls.Add(this.LblDEvento);
            this.PnlVisor.Controls.Add(this.LblDLugar);
            this.PnlVisor.Controls.Add(this.LblDFecha);
            this.PnlVisor.Controls.Add(this.LblDElo);
            this.PnlVisor.Controls.Add(this.LblDBlancas);
            this.PnlVisor.Controls.Add(this.LblDNegras);
            this.PnlVisor.Controls.Add(this.LblDResultado);
            this.PnlVisor.Controls.Add(this.LblResultado);
            this.PnlVisor.Controls.Add(this.LblNegras);
            this.PnlVisor.Controls.Add(this.LblBlancas);
            this.PnlVisor.Controls.Add(this.LblElo);
            this.PnlVisor.Controls.Add(this.LblFecha);
            this.PnlVisor.Controls.Add(this.LblLugar);
            this.PnlVisor.Controls.Add(this.LblEvento);
            this.PnlVisor.Location = new System.Drawing.Point(7, 38);
            this.PnlVisor.Name = "PnlVisor";
            this.PnlVisor.Size = new System.Drawing.Size(200, 139);
            this.PnlVisor.TabIndex = 0;
            this.PnlVisor.Visible = false;
            // 
            // NSCmbPartidas
            // 
            this.NSCmbPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSCmbPartidas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NSCmbPartidas.DropDownHeight = 125;
            this.NSCmbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NSCmbPartidas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSCmbPartidas.ForeColor = System.Drawing.Color.White;
            this.NSCmbPartidas.FormattingEnabled = true;
            this.NSCmbPartidas.IntegralHeight = false;
            this.NSCmbPartidas.ItemHeight = 12;
            this.NSCmbPartidas.Location = new System.Drawing.Point(0, 0);
            this.NSCmbPartidas.Name = "NSCmbPartidas";
            this.NSCmbPartidas.Size = new System.Drawing.Size(199, 18);
            this.NSCmbPartidas.TabIndex = 0;
            this.NSCmbPartidas.SelectedIndexChanged += new System.EventHandler(this.NSCmbPartidas_SelectedIndexChanged);
            this.NSCmbPartidas.MouseLeave += new System.EventHandler(this.NSCmbPartidas_MouseLeave);
            // 
            // LblDEvento
            // 
            this.LblDEvento.BackColor = System.Drawing.Color.Transparent;
            this.LblDEvento.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDEvento.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDEvento.Location = new System.Drawing.Point(65, 23);
            this.LblDEvento.Name = "LblDEvento";
            this.LblDEvento.Size = new System.Drawing.Size(136, 12);
            this.LblDEvento.TabIndex = 0;
            this.LblDEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDLugar
            // 
            this.LblDLugar.BackColor = System.Drawing.Color.Transparent;
            this.LblDLugar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDLugar.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDLugar.Location = new System.Drawing.Point(65, 40);
            this.LblDLugar.Name = "LblDLugar";
            this.LblDLugar.Size = new System.Drawing.Size(136, 12);
            this.LblDLugar.TabIndex = 0;
            this.LblDLugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDFecha
            // 
            this.LblDFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblDFecha.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDFecha.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDFecha.Location = new System.Drawing.Point(65, 59);
            this.LblDFecha.Name = "LblDFecha";
            this.LblDFecha.Size = new System.Drawing.Size(136, 12);
            this.LblDFecha.TabIndex = 0;
            this.LblDFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDElo
            // 
            this.LblDElo.BackColor = System.Drawing.Color.Transparent;
            this.LblDElo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDElo.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDElo.Location = new System.Drawing.Point(65, 74);
            this.LblDElo.Name = "LblDElo";
            this.LblDElo.Size = new System.Drawing.Size(136, 12);
            this.LblDElo.TabIndex = 0;
            this.LblDElo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDBlancas
            // 
            this.LblDBlancas.BackColor = System.Drawing.Color.Transparent;
            this.LblDBlancas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDBlancas.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDBlancas.Location = new System.Drawing.Point(65, 91);
            this.LblDBlancas.Name = "LblDBlancas";
            this.LblDBlancas.Size = new System.Drawing.Size(136, 12);
            this.LblDBlancas.TabIndex = 0;
            this.LblDBlancas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDNegras
            // 
            this.LblDNegras.BackColor = System.Drawing.Color.Transparent;
            this.LblDNegras.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNegras.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDNegras.Location = new System.Drawing.Point(65, 108);
            this.LblDNegras.Name = "LblDNegras";
            this.LblDNegras.Size = new System.Drawing.Size(136, 12);
            this.LblDNegras.TabIndex = 0;
            this.LblDNegras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDResultado
            // 
            this.LblDResultado.BackColor = System.Drawing.Color.Transparent;
            this.LblDResultado.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDResultado.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDResultado.Location = new System.Drawing.Point(64, 125);
            this.LblDResultado.Name = "LblDResultado";
            this.LblDResultado.Size = new System.Drawing.Size(137, 12);
            this.LblDResultado.TabIndex = 0;
            this.LblDResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.Color.Transparent;
            this.LblResultado.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.White;
            this.LblResultado.Location = new System.Drawing.Point(-1, 125);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(60, 12);
            this.LblResultado.TabIndex = 0;
            this.LblResultado.Text = "Resultado:";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblNegras
            // 
            this.LblNegras.BackColor = System.Drawing.Color.Transparent;
            this.LblNegras.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNegras.ForeColor = System.Drawing.Color.White;
            this.LblNegras.Location = new System.Drawing.Point(-1, 108);
            this.LblNegras.Name = "LblNegras";
            this.LblNegras.Size = new System.Drawing.Size(60, 12);
            this.LblNegras.TabIndex = 0;
            this.LblNegras.Text = "Negras:";
            this.LblNegras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblBlancas
            // 
            this.LblBlancas.BackColor = System.Drawing.Color.Transparent;
            this.LblBlancas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBlancas.ForeColor = System.Drawing.Color.White;
            this.LblBlancas.Location = new System.Drawing.Point(-1, 91);
            this.LblBlancas.Name = "LblBlancas";
            this.LblBlancas.Size = new System.Drawing.Size(60, 12);
            this.LblBlancas.TabIndex = 0;
            this.LblBlancas.Text = "Blancas:";
            this.LblBlancas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblElo
            // 
            this.LblElo.BackColor = System.Drawing.Color.Transparent;
            this.LblElo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElo.ForeColor = System.Drawing.Color.White;
            this.LblElo.Location = new System.Drawing.Point(-1, 74);
            this.LblElo.Name = "LblElo";
            this.LblElo.Size = new System.Drawing.Size(60, 12);
            this.LblElo.TabIndex = 0;
            this.LblElo.Text = "EloB/EloN:";
            this.LblElo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(-1, 57);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(60, 12);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLugar
            // 
            this.LblLugar.BackColor = System.Drawing.Color.Transparent;
            this.LblLugar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLugar.ForeColor = System.Drawing.Color.White;
            this.LblLugar.Location = new System.Drawing.Point(-1, 40);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(60, 12);
            this.LblLugar.TabIndex = 0;
            this.LblLugar.Text = "Lugar:";
            this.LblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEvento
            // 
            this.LblEvento.BackColor = System.Drawing.Color.Transparent;
            this.LblEvento.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvento.ForeColor = System.Drawing.Color.White;
            this.LblEvento.Location = new System.Drawing.Point(-1, 23);
            this.LblEvento.Name = "LblEvento";
            this.LblEvento.Size = new System.Drawing.Size(60, 12);
            this.LblEvento.TabIndex = 0;
            this.LblEvento.Text = "Evento/R:";
            this.LblEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlJuego
            // 
            this.PnlJuego.Controls.Add(this.PnlNegras);
            this.PnlJuego.Controls.Add(this.PnlBlancas);
            this.PnlJuego.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlJuego.Location = new System.Drawing.Point(7, 38);
            this.PnlJuego.Name = "PnlJuego";
            this.PnlJuego.Size = new System.Drawing.Size(200, 139);
            this.PnlJuego.TabIndex = 0;
            // 
            // PnlNegras
            // 
            this.PnlNegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlNegras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNegras.Controls.Add(this.LblDAlgoritmoN);
            this.PnlNegras.Controls.Add(this.LblDMovsN);
            this.PnlNegras.Controls.Add(this.LblAlgoritmoN);
            this.PnlNegras.Controls.Add(this.LblMovsN);
            this.PnlNegras.Controls.Add(this.LblDAtaqueN);
            this.PnlNegras.Controls.Add(this.PbxNegras);
            this.PnlNegras.Controls.Add(this.LblAtaqueN);
            this.PnlNegras.Location = new System.Drawing.Point(0, 72);
            this.PnlNegras.Name = "PnlNegras";
            this.PnlNegras.Size = new System.Drawing.Size(200, 60);
            this.PnlNegras.TabIndex = 0;
            // 
            // LblDAlgoritmoN
            // 
            this.LblDAlgoritmoN.BackColor = System.Drawing.Color.Transparent;
            this.LblDAlgoritmoN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAlgoritmoN.ForeColor = System.Drawing.Color.Salmon;
            this.LblDAlgoritmoN.Location = new System.Drawing.Point(107, 40);
            this.LblDAlgoritmoN.Name = "LblDAlgoritmoN";
            this.LblDAlgoritmoN.Size = new System.Drawing.Size(85, 15);
            this.LblDAlgoritmoN.TabIndex = 0;
            this.LblDAlgoritmoN.Text = "Alfabeta / 10";
            this.LblDAlgoritmoN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDMovsN
            // 
            this.LblDMovsN.BackColor = System.Drawing.Color.Transparent;
            this.LblDMovsN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDMovsN.ForeColor = System.Drawing.Color.White;
            this.LblDMovsN.Location = new System.Drawing.Point(107, 21);
            this.LblDMovsN.Name = "LblDMovsN";
            this.LblDMovsN.Size = new System.Drawing.Size(85, 15);
            this.LblDMovsN.TabIndex = 0;
            this.LblDMovsN.Text = "20 movs";
            this.LblDMovsN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAlgoritmoN
            // 
            this.LblAlgoritmoN.BackColor = System.Drawing.Color.Transparent;
            this.LblAlgoritmoN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlgoritmoN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAlgoritmoN.Location = new System.Drawing.Point(29, 41);
            this.LblAlgoritmoN.Name = "LblAlgoritmoN";
            this.LblAlgoritmoN.Size = new System.Drawing.Size(78, 12);
            this.LblAlgoritmoN.TabIndex = 0;
            this.LblAlgoritmoN.Text = "Algor. / Plies:";
            this.LblAlgoritmoN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMovsN
            // 
            this.LblMovsN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblMovsN.Location = new System.Drawing.Point(29, 22);
            this.LblMovsN.Name = "LblMovsN";
            this.LblMovsN.Size = new System.Drawing.Size(78, 12);
            this.LblMovsN.TabIndex = 0;
            this.LblMovsN.Text = "Movs Posibles:";
            this.LblMovsN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDAtaqueN
            // 
            this.LblDAtaqueN.BackColor = System.Drawing.Color.Transparent;
            this.LblDAtaqueN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAtaqueN.ForeColor = System.Drawing.Color.White;
            this.LblDAtaqueN.Location = new System.Drawing.Point(107, 2);
            this.LblDAtaqueN.Name = "LblDAtaqueN";
            this.LblDAtaqueN.Size = new System.Drawing.Size(85, 15);
            this.LblDAtaqueN.TabIndex = 0;
            this.LblDAtaqueN.Text = "59% / 100%";
            this.LblDAtaqueN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbxNegras
            // 
            this.PbxNegras.BackColor = System.Drawing.Color.Goldenrod;
            this.PbxNegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxNegras.Location = new System.Drawing.Point(-1, -1);
            this.PbxNegras.Name = "PbxNegras";
            this.PbxNegras.Size = new System.Drawing.Size(25, 60);
            this.PbxNegras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxNegras.TabIndex = 61;
            this.PbxNegras.TabStop = false;
            this.PbxNegras.Tag = "";
            // 
            // LblAtaqueN
            // 
            this.LblAtaqueN.BackColor = System.Drawing.Color.Transparent;
            this.LblAtaqueN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtaqueN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAtaqueN.Location = new System.Drawing.Point(29, 3);
            this.LblAtaqueN.Name = "LblAtaqueN";
            this.LblAtaqueN.Size = new System.Drawing.Size(78, 12);
            this.LblAtaqueN.TabIndex = 0;
            this.LblAtaqueN.Text = "Ata. / Def.:";
            this.LblAtaqueN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlBlancas
            // 
            this.PnlBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlBlancas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBlancas.Controls.Add(this.LblDAlgoritmoB);
            this.PnlBlancas.Controls.Add(this.LblDMovsB);
            this.PnlBlancas.Controls.Add(this.LblAlgoritmoB);
            this.PnlBlancas.Controls.Add(this.LblMovsB);
            this.PnlBlancas.Controls.Add(this.LblDAtaqueB);
            this.PnlBlancas.Controls.Add(this.PbxBlancas);
            this.PnlBlancas.Controls.Add(this.LblAtaqueB);
            this.PnlBlancas.Location = new System.Drawing.Point(0, 6);
            this.PnlBlancas.Name = "PnlBlancas";
            this.PnlBlancas.Size = new System.Drawing.Size(200, 60);
            this.PnlBlancas.TabIndex = 0;
            // 
            // LblDAlgoritmoB
            // 
            this.LblDAlgoritmoB.BackColor = System.Drawing.Color.Transparent;
            this.LblDAlgoritmoB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAlgoritmoB.ForeColor = System.Drawing.Color.Salmon;
            this.LblDAlgoritmoB.Location = new System.Drawing.Point(107, 40);
            this.LblDAlgoritmoB.Name = "LblDAlgoritmoB";
            this.LblDAlgoritmoB.Size = new System.Drawing.Size(85, 15);
            this.LblDAlgoritmoB.TabIndex = 0;
            this.LblDAlgoritmoB.Text = "Jugador";
            this.LblDAlgoritmoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDMovsB
            // 
            this.LblDMovsB.BackColor = System.Drawing.Color.Transparent;
            this.LblDMovsB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDMovsB.ForeColor = System.Drawing.Color.White;
            this.LblDMovsB.Location = new System.Drawing.Point(107, 21);
            this.LblDMovsB.Name = "LblDMovsB";
            this.LblDMovsB.Size = new System.Drawing.Size(85, 15);
            this.LblDMovsB.TabIndex = 0;
            this.LblDMovsB.Text = "20 movs";
            this.LblDMovsB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAlgoritmoB
            // 
            this.LblAlgoritmoB.BackColor = System.Drawing.Color.Transparent;
            this.LblAlgoritmoB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlgoritmoB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAlgoritmoB.Location = new System.Drawing.Point(29, 41);
            this.LblAlgoritmoB.Name = "LblAlgoritmoB";
            this.LblAlgoritmoB.Size = new System.Drawing.Size(78, 12);
            this.LblAlgoritmoB.TabIndex = 0;
            this.LblAlgoritmoB.Text = "Algor. / Plies:";
            this.LblAlgoritmoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMovsB
            // 
            this.LblMovsB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblMovsB.Location = new System.Drawing.Point(29, 22);
            this.LblMovsB.Name = "LblMovsB";
            this.LblMovsB.Size = new System.Drawing.Size(78, 12);
            this.LblMovsB.TabIndex = 0;
            this.LblMovsB.Text = "Movs Posibles:";
            this.LblMovsB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDAtaqueB
            // 
            this.LblDAtaqueB.BackColor = System.Drawing.Color.Transparent;
            this.LblDAtaqueB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAtaqueB.ForeColor = System.Drawing.Color.White;
            this.LblDAtaqueB.Location = new System.Drawing.Point(107, 2);
            this.LblDAtaqueB.Name = "LblDAtaqueB";
            this.LblDAtaqueB.Size = new System.Drawing.Size(85, 15);
            this.LblDAtaqueB.TabIndex = 0;
            this.LblDAtaqueB.Text = "59% / 100%";
            this.LblDAtaqueB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbxBlancas
            // 
            this.PbxBlancas.BackColor = System.Drawing.Color.White;
            this.PbxBlancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxBlancas.Location = new System.Drawing.Point(-1, -1);
            this.PbxBlancas.Name = "PbxBlancas";
            this.PbxBlancas.Size = new System.Drawing.Size(25, 60);
            this.PbxBlancas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBlancas.TabIndex = 61;
            this.PbxBlancas.TabStop = false;
            this.PbxBlancas.Tag = "";
            // 
            // LblAtaqueB
            // 
            this.LblAtaqueB.BackColor = System.Drawing.Color.Transparent;
            this.LblAtaqueB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtaqueB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAtaqueB.Location = new System.Drawing.Point(29, 3);
            this.LblAtaqueB.Name = "LblAtaqueB";
            this.LblAtaqueB.Size = new System.Drawing.Size(78, 12);
            this.LblAtaqueB.TabIndex = 0;
            this.LblAtaqueB.Text = "Ata. / Def.:";
            this.LblAtaqueB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.LblIcoBBDD);
            this.PnlMenu.Controls.Add(this.LblIcoCPU);
            this.PnlMenu.Controls.Add(this.LblIcoEstadisticas);
            this.PnlMenu.Controls.Add(this.LblIcoCreditos);
            this.PnlMenu.Controls.Add(this.PbxIcoBBDD);
            this.PnlMenu.Controls.Add(this.LblIcoBrazo);
            this.PnlMenu.Controls.Add(this.PbxIcoCPU);
            this.PnlMenu.Controls.Add(this.PbxIcoEstadisticas);
            this.PnlMenu.Controls.Add(this.LblIcoAjustes);
            this.PnlMenu.Controls.Add(this.PbxIcoBrazo);
            this.PnlMenu.Controls.Add(this.PbxIcoAjustes);
            this.PnlMenu.Controls.Add(this.LblIcoCargar);
            this.PnlMenu.Controls.Add(this.PbxIcoCreditos);
            this.PnlMenu.Controls.Add(this.PbxIcoCargar);
            this.PnlMenu.Controls.Add(this.LblIcoGuardar);
            this.PnlMenu.Controls.Add(this.PbxIcoGuardar);
            this.PnlMenu.Controls.Add(this.LblIcoJugar);
            this.PnlMenu.Controls.Add(this.LblIcoNuevo);
            this.PnlMenu.Controls.Add(this.PbxIcoJugar);
            this.PnlMenu.Controls.Add(this.PbxIcoNuevo);
            this.PnlMenu.Location = new System.Drawing.Point(12, 31);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(470, 55);
            this.PnlMenu.TabIndex = 0;
            // 
            // LblIcoBBDD
            // 
            this.LblIcoBBDD.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoBBDD.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoBBDD.ForeColor = System.Drawing.Color.White;
            this.LblIcoBBDD.Location = new System.Drawing.Point(370, 2);
            this.LblIcoBBDD.Name = "LblIcoBBDD";
            this.LblIcoBBDD.Size = new System.Drawing.Size(45, 12);
            this.LblIcoBBDD.TabIndex = 0;
            this.LblIcoBBDD.Text = "BBDD";
            this.LblIcoBBDD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoBBDD.Visible = false;
            // 
            // LblIcoCPU
            // 
            this.LblIcoCPU.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoCPU.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoCPU.ForeColor = System.Drawing.Color.White;
            this.LblIcoCPU.Location = new System.Drawing.Point(235, 2);
            this.LblIcoCPU.Name = "LblIcoCPU";
            this.LblIcoCPU.Size = new System.Drawing.Size(45, 12);
            this.LblIcoCPU.TabIndex = 0;
            this.LblIcoCPU.Text = "CPU";
            this.LblIcoCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoCPU.Visible = false;
            // 
            // LblIcoEstadisticas
            // 
            this.LblIcoEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoEstadisticas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoEstadisticas.ForeColor = System.Drawing.Color.White;
            this.LblIcoEstadisticas.Location = new System.Drawing.Point(325, 2);
            this.LblIcoEstadisticas.Name = "LblIcoEstadisticas";
            this.LblIcoEstadisticas.Size = new System.Drawing.Size(45, 12);
            this.LblIcoEstadisticas.TabIndex = 0;
            this.LblIcoEstadisticas.Text = "Estadís.";
            this.LblIcoEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoEstadisticas.Visible = false;
            // 
            // LblIcoCreditos
            // 
            this.LblIcoCreditos.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoCreditos.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoCreditos.ForeColor = System.Drawing.Color.White;
            this.LblIcoCreditos.Location = new System.Drawing.Point(415, 2);
            this.LblIcoCreditos.Name = "LblIcoCreditos";
            this.LblIcoCreditos.Size = new System.Drawing.Size(45, 12);
            this.LblIcoCreditos.TabIndex = 0;
            this.LblIcoCreditos.Text = "Credit.";
            this.LblIcoCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoCreditos.Visible = false;
            // 
            // PbxIcoBBDD
            // 
            this.PbxIcoBBDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoBBDD.Image = global::UAChess.Properties.Resources.IcoBBDD;
            this.PbxIcoBBDD.Location = new System.Drawing.Point(370, 10);
            this.PbxIcoBBDD.Name = "PbxIcoBBDD";
            this.PbxIcoBBDD.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoBBDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoBBDD.TabIndex = 59;
            this.PbxIcoBBDD.TabStop = false;
            this.PbxIcoBBDD.Tag = "";
            this.PbxIcoBBDD.Click += new System.EventHandler(this.PbxIcoBBDD_Click);
            this.PbxIcoBBDD.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoBBDD.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblIcoBrazo
            // 
            this.LblIcoBrazo.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoBrazo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoBrazo.ForeColor = System.Drawing.Color.White;
            this.LblIcoBrazo.Location = new System.Drawing.Point(280, 2);
            this.LblIcoBrazo.Name = "LblIcoBrazo";
            this.LblIcoBrazo.Size = new System.Drawing.Size(45, 12);
            this.LblIcoBrazo.TabIndex = 0;
            this.LblIcoBrazo.Text = "Brazo";
            this.LblIcoBrazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoBrazo.Visible = false;
            // 
            // PbxIcoCPU
            // 
            this.PbxIcoCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoCPU.Image = global::UAChess.Properties.Resources.IcoCPU;
            this.PbxIcoCPU.Location = new System.Drawing.Point(235, 10);
            this.PbxIcoCPU.Name = "PbxIcoCPU";
            this.PbxIcoCPU.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoCPU.TabIndex = 53;
            this.PbxIcoCPU.TabStop = false;
            this.PbxIcoCPU.Tag = "";
            this.PbxIcoCPU.Click += new System.EventHandler(this.PbxIcoCPU_Click);
            this.PbxIcoCPU.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoCPU.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoEstadisticas
            // 
            this.PbxIcoEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoEstadisticas.Image = global::UAChess.Properties.Resources.IcoEstadisticas;
            this.PbxIcoEstadisticas.Location = new System.Drawing.Point(325, 10);
            this.PbxIcoEstadisticas.Name = "PbxIcoEstadisticas";
            this.PbxIcoEstadisticas.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoEstadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoEstadisticas.TabIndex = 57;
            this.PbxIcoEstadisticas.TabStop = false;
            this.PbxIcoEstadisticas.Tag = "";
            this.PbxIcoEstadisticas.Click += new System.EventHandler(this.PbxIcoEstadisticas_Click);
            this.PbxIcoEstadisticas.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoEstadisticas.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblIcoAjustes
            // 
            this.LblIcoAjustes.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoAjustes.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoAjustes.ForeColor = System.Drawing.Color.White;
            this.LblIcoAjustes.Location = new System.Drawing.Point(190, 2);
            this.LblIcoAjustes.Name = "LblIcoAjustes";
            this.LblIcoAjustes.Size = new System.Drawing.Size(45, 12);
            this.LblIcoAjustes.TabIndex = 0;
            this.LblIcoAjustes.Text = "Ajustes";
            this.LblIcoAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoAjustes.Visible = false;
            // 
            // PbxIcoBrazo
            // 
            this.PbxIcoBrazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoBrazo.Image = global::UAChess.Properties.Resources.IcoBrazo;
            this.PbxIcoBrazo.Location = new System.Drawing.Point(280, 10);
            this.PbxIcoBrazo.Name = "PbxIcoBrazo";
            this.PbxIcoBrazo.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoBrazo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoBrazo.TabIndex = 55;
            this.PbxIcoBrazo.TabStop = false;
            this.PbxIcoBrazo.Tag = "";
            this.PbxIcoBrazo.Click += new System.EventHandler(this.PbxIcoBrazo_Click);
            this.PbxIcoBrazo.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoBrazo.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoAjustes
            // 
            this.PbxIcoAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoAjustes.Image = global::UAChess.Properties.Resources.IcoAjustes;
            this.PbxIcoAjustes.Location = new System.Drawing.Point(190, 10);
            this.PbxIcoAjustes.Name = "PbxIcoAjustes";
            this.PbxIcoAjustes.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoAjustes.TabIndex = 49;
            this.PbxIcoAjustes.TabStop = false;
            this.PbxIcoAjustes.Tag = "";
            this.PbxIcoAjustes.Click += new System.EventHandler(this.PbxIcoAjustes_Click);
            this.PbxIcoAjustes.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoAjustes.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblIcoCargar
            // 
            this.LblIcoCargar.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoCargar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoCargar.ForeColor = System.Drawing.Color.White;
            this.LblIcoCargar.Location = new System.Drawing.Point(145, 2);
            this.LblIcoCargar.Name = "LblIcoCargar";
            this.LblIcoCargar.Size = new System.Drawing.Size(45, 12);
            this.LblIcoCargar.TabIndex = 0;
            this.LblIcoCargar.Text = "Cargar";
            this.LblIcoCargar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoCargar.Visible = false;
            // 
            // PbxIcoCreditos
            // 
            this.PbxIcoCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoCreditos.Image = global::UAChess.Properties.Resources.IcoCreditos;
            this.PbxIcoCreditos.Location = new System.Drawing.Point(415, 10);
            this.PbxIcoCreditos.Name = "PbxIcoCreditos";
            this.PbxIcoCreditos.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoCreditos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoCreditos.TabIndex = 51;
            this.PbxIcoCreditos.TabStop = false;
            this.PbxIcoCreditos.Tag = "";
            this.PbxIcoCreditos.Click += new System.EventHandler(this.PbxIcoCreditos_Click);
            this.PbxIcoCreditos.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoCreditos.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoCargar
            // 
            this.PbxIcoCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoCargar.Image = global::UAChess.Properties.Resources.IcoCargar;
            this.PbxIcoCargar.Location = new System.Drawing.Point(145, 10);
            this.PbxIcoCargar.Name = "PbxIcoCargar";
            this.PbxIcoCargar.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoCargar.TabIndex = 47;
            this.PbxIcoCargar.TabStop = false;
            this.PbxIcoCargar.Tag = "";
            this.PbxIcoCargar.Click += new System.EventHandler(this.PbxIcoCargar_Click);
            this.PbxIcoCargar.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoCargar.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblIcoGuardar
            // 
            this.LblIcoGuardar.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoGuardar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoGuardar.ForeColor = System.Drawing.Color.White;
            this.LblIcoGuardar.Location = new System.Drawing.Point(100, 2);
            this.LblIcoGuardar.Name = "LblIcoGuardar";
            this.LblIcoGuardar.Size = new System.Drawing.Size(45, 12);
            this.LblIcoGuardar.TabIndex = 0;
            this.LblIcoGuardar.Text = "Guardar";
            this.LblIcoGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoGuardar.Visible = false;
            // 
            // PbxIcoGuardar
            // 
            this.PbxIcoGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoGuardar.Image = global::UAChess.Properties.Resources.IcoGuardar;
            this.PbxIcoGuardar.Location = new System.Drawing.Point(100, 10);
            this.PbxIcoGuardar.Name = "PbxIcoGuardar";
            this.PbxIcoGuardar.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoGuardar.TabIndex = 45;
            this.PbxIcoGuardar.TabStop = false;
            this.PbxIcoGuardar.Tag = "";
            this.PbxIcoGuardar.Click += new System.EventHandler(this.PbxIcoGuardar_Click);
            this.PbxIcoGuardar.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoGuardar.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // LblIcoJugar
            // 
            this.LblIcoJugar.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoJugar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoJugar.ForeColor = System.Drawing.Color.White;
            this.LblIcoJugar.Location = new System.Drawing.Point(55, 2);
            this.LblIcoJugar.Name = "LblIcoJugar";
            this.LblIcoJugar.Size = new System.Drawing.Size(45, 12);
            this.LblIcoJugar.TabIndex = 0;
            this.LblIcoJugar.Text = "Jugar";
            this.LblIcoJugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoJugar.Visible = false;
            // 
            // LblIcoNuevo
            // 
            this.LblIcoNuevo.BackColor = System.Drawing.Color.Transparent;
            this.LblIcoNuevo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoNuevo.ForeColor = System.Drawing.Color.White;
            this.LblIcoNuevo.Location = new System.Drawing.Point(10, 2);
            this.LblIcoNuevo.Name = "LblIcoNuevo";
            this.LblIcoNuevo.Size = new System.Drawing.Size(45, 12);
            this.LblIcoNuevo.TabIndex = 0;
            this.LblIcoNuevo.Text = "Nuevo";
            this.LblIcoNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblIcoNuevo.Visible = false;
            // 
            // PbxIcoJugar
            // 
            this.PbxIcoJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoJugar.Image = global::UAChess.Properties.Resources.IcoReproducirS;
            this.PbxIcoJugar.Location = new System.Drawing.Point(55, 10);
            this.PbxIcoJugar.Name = "PbxIcoJugar";
            this.PbxIcoJugar.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoJugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoJugar.TabIndex = 43;
            this.PbxIcoJugar.TabStop = false;
            this.PbxIcoJugar.Tag = "Jugar";
            this.PbxIcoJugar.Click += new System.EventHandler(this.PbxIcoJugar_Click);
            this.PbxIcoJugar.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoJugar.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PbxIcoNuevo
            // 
            this.PbxIcoNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIcoNuevo.Image = global::UAChess.Properties.Resources.IcoNuevo;
            this.PbxIcoNuevo.Location = new System.Drawing.Point(10, 10);
            this.PbxIcoNuevo.Name = "PbxIcoNuevo";
            this.PbxIcoNuevo.Size = new System.Drawing.Size(45, 45);
            this.PbxIcoNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIcoNuevo.TabIndex = 41;
            this.PbxIcoNuevo.TabStop = false;
            this.PbxIcoNuevo.Tag = "";
            this.PbxIcoNuevo.Click += new System.EventHandler(this.PbxIcoNuevo_Click);
            this.PbxIcoNuevo.MouseEnter += new System.EventHandler(this.PbxIco_MouseEnter);
            this.PbxIcoNuevo.MouseLeave += new System.EventHandler(this.PbxIco_MouseLeave);
            // 
            // PnlTablero
            // 
            this.PnlTablero.Controls.Add(this.LblCasillasA);
            this.PnlTablero.Controls.Add(this.LblCasillasB);
            this.PnlTablero.Controls.Add(this.LblCasillasC);
            this.PnlTablero.Controls.Add(this.LblCasillasD);
            this.PnlTablero.Controls.Add(this.LblCasillasE);
            this.PnlTablero.Controls.Add(this.LblCasillasF);
            this.PnlTablero.Controls.Add(this.LblCasillasG);
            this.PnlTablero.Controls.Add(this.LblCasillasH);
            this.PnlTablero.Controls.Add(this.LblCasillas1);
            this.PnlTablero.Controls.Add(this.LblCasillas2);
            this.PnlTablero.Controls.Add(this.LblCasillas3);
            this.PnlTablero.Controls.Add(this.LblCasillas4);
            this.PnlTablero.Controls.Add(this.LblCasillas5);
            this.PnlTablero.Controls.Add(this.LblCasillas6);
            this.PnlTablero.Controls.Add(this.LblCasillas7);
            this.PnlTablero.Controls.Add(this.LblCasillas8);
            this.PnlTablero.Controls.Add(this.PbxCasilla00);
            this.PnlTablero.Controls.Add(this.PbxCasilla01);
            this.PnlTablero.Controls.Add(this.PbxCasilla02);
            this.PnlTablero.Controls.Add(this.PbxCasilla03);
            this.PnlTablero.Controls.Add(this.PbxCasilla04);
            this.PnlTablero.Controls.Add(this.PbxCasilla05);
            this.PnlTablero.Controls.Add(this.PbxCasilla06);
            this.PnlTablero.Controls.Add(this.PbxCasilla07);
            this.PnlTablero.Controls.Add(this.PbxCasilla10);
            this.PnlTablero.Controls.Add(this.PbxCasilla11);
            this.PnlTablero.Controls.Add(this.PbxCasilla12);
            this.PnlTablero.Controls.Add(this.PbxCasilla13);
            this.PnlTablero.Controls.Add(this.PbxCasilla14);
            this.PnlTablero.Controls.Add(this.PbxCasilla15);
            this.PnlTablero.Controls.Add(this.PbxCasilla16);
            this.PnlTablero.Controls.Add(this.PbxCasilla17);
            this.PnlTablero.Controls.Add(this.PbxCasilla20);
            this.PnlTablero.Controls.Add(this.PbxCasilla21);
            this.PnlTablero.Controls.Add(this.PbxCasilla22);
            this.PnlTablero.Controls.Add(this.PbxCasilla23);
            this.PnlTablero.Controls.Add(this.PbxCasilla24);
            this.PnlTablero.Controls.Add(this.PbxCasilla25);
            this.PnlTablero.Controls.Add(this.PbxCasilla26);
            this.PnlTablero.Controls.Add(this.PbxCasilla27);
            this.PnlTablero.Controls.Add(this.PbxCasilla30);
            this.PnlTablero.Controls.Add(this.PbxCasilla31);
            this.PnlTablero.Controls.Add(this.PbxCasilla32);
            this.PnlTablero.Controls.Add(this.PbxCasilla33);
            this.PnlTablero.Controls.Add(this.PbxCasilla34);
            this.PnlTablero.Controls.Add(this.PbxCasilla35);
            this.PnlTablero.Controls.Add(this.PbxCasilla36);
            this.PnlTablero.Controls.Add(this.PbxCasilla37);
            this.PnlTablero.Controls.Add(this.PbxCasilla40);
            this.PnlTablero.Controls.Add(this.PbxCasilla41);
            this.PnlTablero.Controls.Add(this.PbxCasilla42);
            this.PnlTablero.Controls.Add(this.PbxCasilla43);
            this.PnlTablero.Controls.Add(this.PbxCasilla44);
            this.PnlTablero.Controls.Add(this.PbxCasilla45);
            this.PnlTablero.Controls.Add(this.PbxCasilla46);
            this.PnlTablero.Controls.Add(this.PbxCasilla47);
            this.PnlTablero.Controls.Add(this.PbxCasilla50);
            this.PnlTablero.Controls.Add(this.PbxCasilla51);
            this.PnlTablero.Controls.Add(this.PbxCasilla52);
            this.PnlTablero.Controls.Add(this.PbxCasilla53);
            this.PnlTablero.Controls.Add(this.PbxCasilla54);
            this.PnlTablero.Controls.Add(this.PbxCasilla55);
            this.PnlTablero.Controls.Add(this.PbxCasilla56);
            this.PnlTablero.Controls.Add(this.PbxCasilla57);
            this.PnlTablero.Controls.Add(this.PbxCasilla60);
            this.PnlTablero.Controls.Add(this.PbxCasilla61);
            this.PnlTablero.Controls.Add(this.PbxCasilla62);
            this.PnlTablero.Controls.Add(this.PbxCasilla63);
            this.PnlTablero.Controls.Add(this.PbxCasilla64);
            this.PnlTablero.Controls.Add(this.PbxCasilla65);
            this.PnlTablero.Controls.Add(this.PbxCasilla66);
            this.PnlTablero.Controls.Add(this.PbxCasilla67);
            this.PnlTablero.Controls.Add(this.PbxCasilla70);
            this.PnlTablero.Controls.Add(this.PbxCasilla71);
            this.PnlTablero.Controls.Add(this.PbxCasilla72);
            this.PnlTablero.Controls.Add(this.PbxCasilla73);
            this.PnlTablero.Controls.Add(this.PbxCasilla74);
            this.PnlTablero.Controls.Add(this.PbxCasilla75);
            this.PnlTablero.Controls.Add(this.PbxCasilla76);
            this.PnlTablero.Controls.Add(this.PbxCasilla77);
            this.PnlTablero.Cursor = System.Windows.Forms.Cursors.No;
            this.PnlTablero.Location = new System.Drawing.Point(12, 86);
            this.PnlTablero.Name = "PnlTablero";
            this.PnlTablero.Size = new System.Drawing.Size(470, 470);
            this.PnlTablero.TabIndex = 0;
            // 
            // LblCasillasA
            // 
            this.LblCasillasA.AutoSize = true;
            this.LblCasillasA.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasA.ForeColor = System.Drawing.Color.White;
            this.LblCasillasA.Location = new System.Drawing.Point(35, 456);
            this.LblCasillasA.Name = "LblCasillasA";
            this.LblCasillasA.Size = new System.Drawing.Size(16, 13);
            this.LblCasillasA.TabIndex = 0;
            this.LblCasillasA.Text = "A";
            // 
            // LblCasillasB
            // 
            this.LblCasillasB.AutoSize = true;
            this.LblCasillasB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasB.ForeColor = System.Drawing.Color.White;
            this.LblCasillasB.Location = new System.Drawing.Point(91, 456);
            this.LblCasillasB.Name = "LblCasillasB";
            this.LblCasillasB.Size = new System.Drawing.Size(15, 13);
            this.LblCasillasB.TabIndex = 0;
            this.LblCasillasB.Text = "B";
            // 
            // LblCasillasC
            // 
            this.LblCasillasC.AutoSize = true;
            this.LblCasillasC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasC.ForeColor = System.Drawing.Color.White;
            this.LblCasillasC.Location = new System.Drawing.Point(147, 456);
            this.LblCasillasC.Name = "LblCasillasC";
            this.LblCasillasC.Size = new System.Drawing.Size(15, 13);
            this.LblCasillasC.TabIndex = 0;
            this.LblCasillasC.Text = "C";
            // 
            // LblCasillasD
            // 
            this.LblCasillasD.AutoSize = true;
            this.LblCasillasD.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasD.ForeColor = System.Drawing.Color.White;
            this.LblCasillasD.Location = new System.Drawing.Point(203, 456);
            this.LblCasillasD.Name = "LblCasillasD";
            this.LblCasillasD.Size = new System.Drawing.Size(16, 13);
            this.LblCasillasD.TabIndex = 0;
            this.LblCasillasD.Text = "D";
            // 
            // LblCasillasE
            // 
            this.LblCasillasE.AutoSize = true;
            this.LblCasillasE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasE.ForeColor = System.Drawing.Color.White;
            this.LblCasillasE.Location = new System.Drawing.Point(259, 456);
            this.LblCasillasE.Name = "LblCasillasE";
            this.LblCasillasE.Size = new System.Drawing.Size(15, 13);
            this.LblCasillasE.TabIndex = 0;
            this.LblCasillasE.Text = "E";
            // 
            // LblCasillasF
            // 
            this.LblCasillasF.AutoSize = true;
            this.LblCasillasF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasF.ForeColor = System.Drawing.Color.White;
            this.LblCasillasF.Location = new System.Drawing.Point(315, 456);
            this.LblCasillasF.Name = "LblCasillasF";
            this.LblCasillasF.Size = new System.Drawing.Size(15, 13);
            this.LblCasillasF.TabIndex = 0;
            this.LblCasillasF.Text = "F";
            // 
            // LblCasillasG
            // 
            this.LblCasillasG.AutoSize = true;
            this.LblCasillasG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasG.ForeColor = System.Drawing.Color.White;
            this.LblCasillasG.Location = new System.Drawing.Point(371, 456);
            this.LblCasillasG.Name = "LblCasillasG";
            this.LblCasillasG.Size = new System.Drawing.Size(16, 13);
            this.LblCasillasG.TabIndex = 0;
            this.LblCasillasG.Text = "G";
            // 
            // LblCasillasH
            // 
            this.LblCasillasH.AutoSize = true;
            this.LblCasillasH.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillasH.ForeColor = System.Drawing.Color.White;
            this.LblCasillasH.Location = new System.Drawing.Point(427, 456);
            this.LblCasillasH.Name = "LblCasillasH";
            this.LblCasillasH.Size = new System.Drawing.Size(16, 13);
            this.LblCasillasH.TabIndex = 0;
            this.LblCasillasH.Text = "H";
            // 
            // LblCasillas1
            // 
            this.LblCasillas1.AutoSize = true;
            this.LblCasillas1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas1.ForeColor = System.Drawing.Color.White;
            this.LblCasillas1.Location = new System.Drawing.Point(0, 422);
            this.LblCasillas1.Name = "LblCasillas1";
            this.LblCasillas1.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas1.TabIndex = 0;
            this.LblCasillas1.Text = "1";
            // 
            // LblCasillas2
            // 
            this.LblCasillas2.AutoSize = true;
            this.LblCasillas2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas2.ForeColor = System.Drawing.Color.White;
            this.LblCasillas2.Location = new System.Drawing.Point(0, 366);
            this.LblCasillas2.Name = "LblCasillas2";
            this.LblCasillas2.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas2.TabIndex = 0;
            this.LblCasillas2.Text = "2";
            // 
            // LblCasillas3
            // 
            this.LblCasillas3.AutoSize = true;
            this.LblCasillas3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas3.ForeColor = System.Drawing.Color.White;
            this.LblCasillas3.Location = new System.Drawing.Point(0, 310);
            this.LblCasillas3.Name = "LblCasillas3";
            this.LblCasillas3.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas3.TabIndex = 0;
            this.LblCasillas3.Text = "3";
            // 
            // LblCasillas4
            // 
            this.LblCasillas4.AutoSize = true;
            this.LblCasillas4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas4.ForeColor = System.Drawing.Color.White;
            this.LblCasillas4.Location = new System.Drawing.Point(0, 254);
            this.LblCasillas4.Name = "LblCasillas4";
            this.LblCasillas4.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas4.TabIndex = 0;
            this.LblCasillas4.Text = "4";
            // 
            // LblCasillas5
            // 
            this.LblCasillas5.AutoSize = true;
            this.LblCasillas5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas5.ForeColor = System.Drawing.Color.White;
            this.LblCasillas5.Location = new System.Drawing.Point(0, 198);
            this.LblCasillas5.Name = "LblCasillas5";
            this.LblCasillas5.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas5.TabIndex = 0;
            this.LblCasillas5.Text = "5";
            // 
            // LblCasillas6
            // 
            this.LblCasillas6.AutoSize = true;
            this.LblCasillas6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas6.ForeColor = System.Drawing.Color.White;
            this.LblCasillas6.Location = new System.Drawing.Point(0, 142);
            this.LblCasillas6.Name = "LblCasillas6";
            this.LblCasillas6.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas6.TabIndex = 0;
            this.LblCasillas6.Text = "6";
            // 
            // LblCasillas7
            // 
            this.LblCasillas7.AutoSize = true;
            this.LblCasillas7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas7.ForeColor = System.Drawing.Color.White;
            this.LblCasillas7.Location = new System.Drawing.Point(0, 86);
            this.LblCasillas7.Name = "LblCasillas7";
            this.LblCasillas7.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas7.TabIndex = 0;
            this.LblCasillas7.Text = "7";
            // 
            // LblCasillas8
            // 
            this.LblCasillas8.AutoSize = true;
            this.LblCasillas8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasillas8.ForeColor = System.Drawing.Color.White;
            this.LblCasillas8.Location = new System.Drawing.Point(0, 30);
            this.LblCasillas8.Name = "LblCasillas8";
            this.LblCasillas8.Size = new System.Drawing.Size(15, 13);
            this.LblCasillas8.TabIndex = 0;
            this.LblCasillas8.Text = "8";
            // 
            // PbxCasilla00
            // 
            this.PbxCasilla00.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla00.Image = global::UAChess.Properties.Resources.PzTorreB;
            this.PbxCasilla00.Location = new System.Drawing.Point(15, 400);
            this.PbxCasilla00.Name = "PbxCasilla00";
            this.PbxCasilla00.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla00.TabIndex = 0;
            this.PbxCasilla00.TabStop = false;
            this.PbxCasilla00.Tag = "NX";
            this.PbxCasilla00.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla00.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla00.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla00.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla01
            // 
            this.PbxCasilla01.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla01.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla01.Location = new System.Drawing.Point(15, 344);
            this.PbxCasilla01.Name = "PbxCasilla01";
            this.PbxCasilla01.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla01.TabIndex = 8;
            this.PbxCasilla01.TabStop = false;
            this.PbxCasilla01.Tag = "BX";
            this.PbxCasilla01.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla01.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla01.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla02
            // 
            this.PbxCasilla02.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla02.Location = new System.Drawing.Point(15, 288);
            this.PbxCasilla02.Name = "PbxCasilla02";
            this.PbxCasilla02.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla02.TabIndex = 15;
            this.PbxCasilla02.TabStop = false;
            this.PbxCasilla02.Tag = "NX";
            this.PbxCasilla02.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla02.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla02.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla03
            // 
            this.PbxCasilla03.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla03.Location = new System.Drawing.Point(15, 232);
            this.PbxCasilla03.Name = "PbxCasilla03";
            this.PbxCasilla03.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla03.TabIndex = 24;
            this.PbxCasilla03.TabStop = false;
            this.PbxCasilla03.Tag = "BX";
            this.PbxCasilla03.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla03.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla03.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla03.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla04
            // 
            this.PbxCasilla04.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla04.Location = new System.Drawing.Point(15, 176);
            this.PbxCasilla04.Name = "PbxCasilla04";
            this.PbxCasilla04.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla04.TabIndex = 31;
            this.PbxCasilla04.TabStop = false;
            this.PbxCasilla04.Tag = "NX";
            this.PbxCasilla04.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla04.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla04.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla04.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla05
            // 
            this.PbxCasilla05.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla05.Location = new System.Drawing.Point(15, 120);
            this.PbxCasilla05.Name = "PbxCasilla05";
            this.PbxCasilla05.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla05.TabIndex = 40;
            this.PbxCasilla05.TabStop = false;
            this.PbxCasilla05.Tag = "BX";
            this.PbxCasilla05.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla05.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla05.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla05.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla05.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla06
            // 
            this.PbxCasilla06.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla06.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla06.Location = new System.Drawing.Point(15, 64);
            this.PbxCasilla06.Name = "PbxCasilla06";
            this.PbxCasilla06.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla06.TabIndex = 47;
            this.PbxCasilla06.TabStop = false;
            this.PbxCasilla06.Tag = "NX";
            this.PbxCasilla06.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla06.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla06.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla06.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla07
            // 
            this.PbxCasilla07.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla07.Image = global::UAChess.Properties.Resources.PzTorreN;
            this.PbxCasilla07.Location = new System.Drawing.Point(15, 8);
            this.PbxCasilla07.Name = "PbxCasilla07";
            this.PbxCasilla07.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla07.TabIndex = 56;
            this.PbxCasilla07.TabStop = false;
            this.PbxCasilla07.Tag = "BX";
            this.PbxCasilla07.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla07.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla07.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla07.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla07.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla10
            // 
            this.PbxCasilla10.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla10.Image = global::UAChess.Properties.Resources.PzCaballoB;
            this.PbxCasilla10.Location = new System.Drawing.Point(71, 400);
            this.PbxCasilla10.Name = "PbxCasilla10";
            this.PbxCasilla10.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla10.TabIndex = 1;
            this.PbxCasilla10.TabStop = false;
            this.PbxCasilla10.Tag = "BX";
            this.PbxCasilla10.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla10.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla10.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla11
            // 
            this.PbxCasilla11.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla11.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla11.Location = new System.Drawing.Point(71, 344);
            this.PbxCasilla11.Name = "PbxCasilla11";
            this.PbxCasilla11.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla11.TabIndex = 9;
            this.PbxCasilla11.TabStop = false;
            this.PbxCasilla11.Tag = "NX";
            this.PbxCasilla11.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla11.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla11.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla12
            // 
            this.PbxCasilla12.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla12.Location = new System.Drawing.Point(71, 288);
            this.PbxCasilla12.Name = "PbxCasilla12";
            this.PbxCasilla12.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla12.TabIndex = 17;
            this.PbxCasilla12.TabStop = false;
            this.PbxCasilla12.Tag = "BX";
            this.PbxCasilla12.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla12.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla12.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla13
            // 
            this.PbxCasilla13.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla13.Location = new System.Drawing.Point(71, 232);
            this.PbxCasilla13.Name = "PbxCasilla13";
            this.PbxCasilla13.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla13.TabIndex = 25;
            this.PbxCasilla13.TabStop = false;
            this.PbxCasilla13.Tag = "NX";
            this.PbxCasilla13.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla13.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla13.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla14
            // 
            this.PbxCasilla14.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla14.Location = new System.Drawing.Point(71, 176);
            this.PbxCasilla14.Name = "PbxCasilla14";
            this.PbxCasilla14.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla14.TabIndex = 33;
            this.PbxCasilla14.TabStop = false;
            this.PbxCasilla14.Tag = "BX";
            this.PbxCasilla14.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla14.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla14.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla15
            // 
            this.PbxCasilla15.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla15.Location = new System.Drawing.Point(71, 120);
            this.PbxCasilla15.Name = "PbxCasilla15";
            this.PbxCasilla15.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla15.TabIndex = 41;
            this.PbxCasilla15.TabStop = false;
            this.PbxCasilla15.Tag = "NX";
            this.PbxCasilla15.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla15.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla15.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla16
            // 
            this.PbxCasilla16.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla16.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla16.Location = new System.Drawing.Point(71, 64);
            this.PbxCasilla16.Name = "PbxCasilla16";
            this.PbxCasilla16.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla16.TabIndex = 49;
            this.PbxCasilla16.TabStop = false;
            this.PbxCasilla16.Tag = "BX";
            this.PbxCasilla16.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla16.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla16.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla17
            // 
            this.PbxCasilla17.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla17.Image = global::UAChess.Properties.Resources.PzCaballoN;
            this.PbxCasilla17.Location = new System.Drawing.Point(71, 8);
            this.PbxCasilla17.Name = "PbxCasilla17";
            this.PbxCasilla17.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla17.TabIndex = 57;
            this.PbxCasilla17.TabStop = false;
            this.PbxCasilla17.Tag = "NX";
            this.PbxCasilla17.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla17.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla17.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla20
            // 
            this.PbxCasilla20.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla20.Image = global::UAChess.Properties.Resources.PzAlfilB;
            this.PbxCasilla20.Location = new System.Drawing.Point(127, 400);
            this.PbxCasilla20.Name = "PbxCasilla20";
            this.PbxCasilla20.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla20.TabIndex = 2;
            this.PbxCasilla20.TabStop = false;
            this.PbxCasilla20.Tag = "NX";
            this.PbxCasilla20.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla20.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla20.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla21
            // 
            this.PbxCasilla21.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla21.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla21.Location = new System.Drawing.Point(127, 344);
            this.PbxCasilla21.Name = "PbxCasilla21";
            this.PbxCasilla21.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla21.TabIndex = 10;
            this.PbxCasilla21.TabStop = false;
            this.PbxCasilla21.Tag = "BX";
            this.PbxCasilla21.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla21.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla21.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla22
            // 
            this.PbxCasilla22.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla22.Location = new System.Drawing.Point(127, 288);
            this.PbxCasilla22.Name = "PbxCasilla22";
            this.PbxCasilla22.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla22.TabIndex = 18;
            this.PbxCasilla22.TabStop = false;
            this.PbxCasilla22.Tag = "NX";
            this.PbxCasilla22.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla22.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla22.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla23
            // 
            this.PbxCasilla23.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla23.Location = new System.Drawing.Point(127, 232);
            this.PbxCasilla23.Name = "PbxCasilla23";
            this.PbxCasilla23.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla23.TabIndex = 26;
            this.PbxCasilla23.TabStop = false;
            this.PbxCasilla23.Tag = "BX";
            this.PbxCasilla23.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla23.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla23.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla24
            // 
            this.PbxCasilla24.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla24.Location = new System.Drawing.Point(127, 176);
            this.PbxCasilla24.Name = "PbxCasilla24";
            this.PbxCasilla24.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla24.TabIndex = 34;
            this.PbxCasilla24.TabStop = false;
            this.PbxCasilla24.Tag = "NX";
            this.PbxCasilla24.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla24.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla24.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla25
            // 
            this.PbxCasilla25.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla25.Location = new System.Drawing.Point(127, 120);
            this.PbxCasilla25.Name = "PbxCasilla25";
            this.PbxCasilla25.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla25.TabIndex = 42;
            this.PbxCasilla25.TabStop = false;
            this.PbxCasilla25.Tag = "BX";
            this.PbxCasilla25.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla25.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla25.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla25.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla26
            // 
            this.PbxCasilla26.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla26.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla26.Location = new System.Drawing.Point(127, 64);
            this.PbxCasilla26.Name = "PbxCasilla26";
            this.PbxCasilla26.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla26.TabIndex = 50;
            this.PbxCasilla26.TabStop = false;
            this.PbxCasilla26.Tag = "NX";
            this.PbxCasilla26.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla26.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla26.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla26.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla27
            // 
            this.PbxCasilla27.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla27.Image = global::UAChess.Properties.Resources.PzAlfilN;
            this.PbxCasilla27.Location = new System.Drawing.Point(127, 8);
            this.PbxCasilla27.Name = "PbxCasilla27";
            this.PbxCasilla27.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla27.TabIndex = 58;
            this.PbxCasilla27.TabStop = false;
            this.PbxCasilla27.Tag = "BX";
            this.PbxCasilla27.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla27.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla27.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla27.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla30
            // 
            this.PbxCasilla30.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla30.Image = global::UAChess.Properties.Resources.PzDamaB;
            this.PbxCasilla30.Location = new System.Drawing.Point(183, 400);
            this.PbxCasilla30.Name = "PbxCasilla30";
            this.PbxCasilla30.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla30.TabIndex = 3;
            this.PbxCasilla30.TabStop = false;
            this.PbxCasilla30.Tag = "BX";
            this.PbxCasilla30.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla30.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla30.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla30.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla31
            // 
            this.PbxCasilla31.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla31.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla31.Location = new System.Drawing.Point(183, 344);
            this.PbxCasilla31.Name = "PbxCasilla31";
            this.PbxCasilla31.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla31.TabIndex = 11;
            this.PbxCasilla31.TabStop = false;
            this.PbxCasilla31.Tag = "NX";
            this.PbxCasilla31.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla31.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla31.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla32
            // 
            this.PbxCasilla32.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla32.Location = new System.Drawing.Point(183, 288);
            this.PbxCasilla32.Name = "PbxCasilla32";
            this.PbxCasilla32.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla32.TabIndex = 19;
            this.PbxCasilla32.TabStop = false;
            this.PbxCasilla32.Tag = "BX";
            this.PbxCasilla32.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla32.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla32.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla33
            // 
            this.PbxCasilla33.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla33.Location = new System.Drawing.Point(183, 232);
            this.PbxCasilla33.Name = "PbxCasilla33";
            this.PbxCasilla33.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla33.TabIndex = 27;
            this.PbxCasilla33.TabStop = false;
            this.PbxCasilla33.Tag = "NX";
            this.PbxCasilla33.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla33.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla33.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla33.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla33.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla34
            // 
            this.PbxCasilla34.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla34.Location = new System.Drawing.Point(183, 176);
            this.PbxCasilla34.Name = "PbxCasilla34";
            this.PbxCasilla34.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla34.TabIndex = 35;
            this.PbxCasilla34.TabStop = false;
            this.PbxCasilla34.Tag = "BX";
            this.PbxCasilla34.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla34.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla34.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla34.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla34.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla35
            // 
            this.PbxCasilla35.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla35.Location = new System.Drawing.Point(183, 120);
            this.PbxCasilla35.Name = "PbxCasilla35";
            this.PbxCasilla35.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla35.TabIndex = 43;
            this.PbxCasilla35.TabStop = false;
            this.PbxCasilla35.Tag = "NX";
            this.PbxCasilla35.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla35.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla35.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla35.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla35.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla36
            // 
            this.PbxCasilla36.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla36.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla36.Location = new System.Drawing.Point(183, 64);
            this.PbxCasilla36.Name = "PbxCasilla36";
            this.PbxCasilla36.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla36.TabIndex = 51;
            this.PbxCasilla36.TabStop = false;
            this.PbxCasilla36.Tag = "BX";
            this.PbxCasilla36.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla36.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla36.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla36.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla36.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla37
            // 
            this.PbxCasilla37.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla37.Image = global::UAChess.Properties.Resources.PzDamaN;
            this.PbxCasilla37.Location = new System.Drawing.Point(183, 8);
            this.PbxCasilla37.Name = "PbxCasilla37";
            this.PbxCasilla37.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla37.TabIndex = 59;
            this.PbxCasilla37.TabStop = false;
            this.PbxCasilla37.Tag = "NX";
            this.PbxCasilla37.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla37.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla37.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla37.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla37.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla40
            // 
            this.PbxCasilla40.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla40.Image = global::UAChess.Properties.Resources.PzReyB;
            this.PbxCasilla40.Location = new System.Drawing.Point(239, 400);
            this.PbxCasilla40.Name = "PbxCasilla40";
            this.PbxCasilla40.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla40.TabIndex = 4;
            this.PbxCasilla40.TabStop = false;
            this.PbxCasilla40.Tag = "NX";
            this.PbxCasilla40.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla40.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla40.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla40.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla40.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla41
            // 
            this.PbxCasilla41.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla41.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla41.Location = new System.Drawing.Point(239, 344);
            this.PbxCasilla41.Name = "PbxCasilla41";
            this.PbxCasilla41.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla41.TabIndex = 12;
            this.PbxCasilla41.TabStop = false;
            this.PbxCasilla41.Tag = "BX";
            this.PbxCasilla41.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla41.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla41.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla41.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla41.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla42
            // 
            this.PbxCasilla42.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla42.Location = new System.Drawing.Point(239, 288);
            this.PbxCasilla42.Name = "PbxCasilla42";
            this.PbxCasilla42.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla42.TabIndex = 20;
            this.PbxCasilla42.TabStop = false;
            this.PbxCasilla42.Tag = "NX";
            this.PbxCasilla42.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla42.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla42.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla42.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla42.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla43
            // 
            this.PbxCasilla43.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla43.Location = new System.Drawing.Point(239, 232);
            this.PbxCasilla43.Name = "PbxCasilla43";
            this.PbxCasilla43.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla43.TabIndex = 28;
            this.PbxCasilla43.TabStop = false;
            this.PbxCasilla43.Tag = "BX";
            this.PbxCasilla43.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla43.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla43.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla43.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla43.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla44
            // 
            this.PbxCasilla44.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla44.Location = new System.Drawing.Point(239, 176);
            this.PbxCasilla44.Name = "PbxCasilla44";
            this.PbxCasilla44.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla44.TabIndex = 36;
            this.PbxCasilla44.TabStop = false;
            this.PbxCasilla44.Tag = "NX";
            this.PbxCasilla44.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla44.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla44.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla44.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla44.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla45
            // 
            this.PbxCasilla45.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla45.Location = new System.Drawing.Point(239, 120);
            this.PbxCasilla45.Name = "PbxCasilla45";
            this.PbxCasilla45.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla45.TabIndex = 44;
            this.PbxCasilla45.TabStop = false;
            this.PbxCasilla45.Tag = "BX";
            this.PbxCasilla45.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla45.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla45.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla45.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla46
            // 
            this.PbxCasilla46.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla46.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla46.Location = new System.Drawing.Point(239, 64);
            this.PbxCasilla46.Name = "PbxCasilla46";
            this.PbxCasilla46.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla46.TabIndex = 52;
            this.PbxCasilla46.TabStop = false;
            this.PbxCasilla46.Tag = "NX";
            this.PbxCasilla46.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla46.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla46.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla46.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla46.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla47
            // 
            this.PbxCasilla47.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla47.Image = global::UAChess.Properties.Resources.PzReyN;
            this.PbxCasilla47.Location = new System.Drawing.Point(239, 8);
            this.PbxCasilla47.Name = "PbxCasilla47";
            this.PbxCasilla47.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla47.TabIndex = 60;
            this.PbxCasilla47.TabStop = false;
            this.PbxCasilla47.Tag = "BX";
            this.PbxCasilla47.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla47.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla47.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla47.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla47.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla50
            // 
            this.PbxCasilla50.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla50.Image = global::UAChess.Properties.Resources.PzAlfilB;
            this.PbxCasilla50.Location = new System.Drawing.Point(295, 400);
            this.PbxCasilla50.Name = "PbxCasilla50";
            this.PbxCasilla50.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla50.TabIndex = 5;
            this.PbxCasilla50.TabStop = false;
            this.PbxCasilla50.Tag = "BX";
            this.PbxCasilla50.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla50.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla50.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla50.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla50.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla51
            // 
            this.PbxCasilla51.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla51.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla51.Location = new System.Drawing.Point(295, 344);
            this.PbxCasilla51.Name = "PbxCasilla51";
            this.PbxCasilla51.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla51.TabIndex = 13;
            this.PbxCasilla51.TabStop = false;
            this.PbxCasilla51.Tag = "NX";
            this.PbxCasilla51.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla51.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla51.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla51.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla51.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla52
            // 
            this.PbxCasilla52.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla52.Location = new System.Drawing.Point(295, 288);
            this.PbxCasilla52.Name = "PbxCasilla52";
            this.PbxCasilla52.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla52.TabIndex = 21;
            this.PbxCasilla52.TabStop = false;
            this.PbxCasilla52.Tag = "BX";
            this.PbxCasilla52.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla52.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla52.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla52.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla52.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla53
            // 
            this.PbxCasilla53.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla53.Location = new System.Drawing.Point(295, 232);
            this.PbxCasilla53.Name = "PbxCasilla53";
            this.PbxCasilla53.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla53.TabIndex = 29;
            this.PbxCasilla53.TabStop = false;
            this.PbxCasilla53.Tag = "NX";
            this.PbxCasilla53.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla53.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla53.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla53.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla53.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla54
            // 
            this.PbxCasilla54.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla54.Location = new System.Drawing.Point(295, 176);
            this.PbxCasilla54.Name = "PbxCasilla54";
            this.PbxCasilla54.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla54.TabIndex = 37;
            this.PbxCasilla54.TabStop = false;
            this.PbxCasilla54.Tag = "BX";
            this.PbxCasilla54.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla54.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla54.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla54.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla54.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla55
            // 
            this.PbxCasilla55.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla55.Location = new System.Drawing.Point(295, 120);
            this.PbxCasilla55.Name = "PbxCasilla55";
            this.PbxCasilla55.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla55.TabIndex = 45;
            this.PbxCasilla55.TabStop = false;
            this.PbxCasilla55.Tag = "NX";
            this.PbxCasilla55.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla55.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla55.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla55.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla55.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla56
            // 
            this.PbxCasilla56.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla56.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla56.Location = new System.Drawing.Point(295, 64);
            this.PbxCasilla56.Name = "PbxCasilla56";
            this.PbxCasilla56.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla56.TabIndex = 53;
            this.PbxCasilla56.TabStop = false;
            this.PbxCasilla56.Tag = "BX";
            this.PbxCasilla56.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla56.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla56.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla56.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla56.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla57
            // 
            this.PbxCasilla57.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla57.Image = global::UAChess.Properties.Resources.PzAlfilN;
            this.PbxCasilla57.Location = new System.Drawing.Point(295, 8);
            this.PbxCasilla57.Name = "PbxCasilla57";
            this.PbxCasilla57.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla57.TabIndex = 61;
            this.PbxCasilla57.TabStop = false;
            this.PbxCasilla57.Tag = "NX";
            this.PbxCasilla57.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla57.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla57.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla57.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla57.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla60
            // 
            this.PbxCasilla60.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla60.Image = global::UAChess.Properties.Resources.PzCaballoB;
            this.PbxCasilla60.Location = new System.Drawing.Point(351, 400);
            this.PbxCasilla60.Name = "PbxCasilla60";
            this.PbxCasilla60.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla60.TabIndex = 6;
            this.PbxCasilla60.TabStop = false;
            this.PbxCasilla60.Tag = "NX";
            this.PbxCasilla60.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla60.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla60.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla60.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla60.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla61
            // 
            this.PbxCasilla61.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla61.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla61.Location = new System.Drawing.Point(351, 344);
            this.PbxCasilla61.Name = "PbxCasilla61";
            this.PbxCasilla61.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla61.TabIndex = 14;
            this.PbxCasilla61.TabStop = false;
            this.PbxCasilla61.Tag = "BX";
            this.PbxCasilla61.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla61.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla61.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla61.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla61.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla62
            // 
            this.PbxCasilla62.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla62.Location = new System.Drawing.Point(351, 288);
            this.PbxCasilla62.Name = "PbxCasilla62";
            this.PbxCasilla62.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla62.TabIndex = 22;
            this.PbxCasilla62.TabStop = false;
            this.PbxCasilla62.Tag = "NX";
            this.PbxCasilla62.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla62.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla62.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla62.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla62.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla63
            // 
            this.PbxCasilla63.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla63.Location = new System.Drawing.Point(351, 232);
            this.PbxCasilla63.Name = "PbxCasilla63";
            this.PbxCasilla63.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla63.TabIndex = 30;
            this.PbxCasilla63.TabStop = false;
            this.PbxCasilla63.Tag = "BX";
            this.PbxCasilla63.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla63.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla63.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla63.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla63.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla64
            // 
            this.PbxCasilla64.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla64.Location = new System.Drawing.Point(351, 176);
            this.PbxCasilla64.Name = "PbxCasilla64";
            this.PbxCasilla64.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla64.TabIndex = 38;
            this.PbxCasilla64.TabStop = false;
            this.PbxCasilla64.Tag = "NX";
            this.PbxCasilla64.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla64.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla64.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla64.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla65
            // 
            this.PbxCasilla65.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla65.Location = new System.Drawing.Point(351, 120);
            this.PbxCasilla65.Name = "PbxCasilla65";
            this.PbxCasilla65.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla65.TabIndex = 46;
            this.PbxCasilla65.TabStop = false;
            this.PbxCasilla65.Tag = "BX";
            this.PbxCasilla65.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla65.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla65.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla65.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla65.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla66
            // 
            this.PbxCasilla66.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla66.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla66.Location = new System.Drawing.Point(351, 64);
            this.PbxCasilla66.Name = "PbxCasilla66";
            this.PbxCasilla66.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla66.TabIndex = 54;
            this.PbxCasilla66.TabStop = false;
            this.PbxCasilla66.Tag = "NX";
            this.PbxCasilla66.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla66.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla66.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla66.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla66.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla67
            // 
            this.PbxCasilla67.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla67.Image = global::UAChess.Properties.Resources.PzCaballoN;
            this.PbxCasilla67.Location = new System.Drawing.Point(351, 8);
            this.PbxCasilla67.Name = "PbxCasilla67";
            this.PbxCasilla67.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla67.TabIndex = 62;
            this.PbxCasilla67.TabStop = false;
            this.PbxCasilla67.Tag = "BX";
            this.PbxCasilla67.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla67.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla67.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla67.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla67.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla70
            // 
            this.PbxCasilla70.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla70.Image = global::UAChess.Properties.Resources.PzTorreB;
            this.PbxCasilla70.Location = new System.Drawing.Point(407, 400);
            this.PbxCasilla70.Name = "PbxCasilla70";
            this.PbxCasilla70.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla70.TabIndex = 7;
            this.PbxCasilla70.TabStop = false;
            this.PbxCasilla70.Tag = "BX";
            this.PbxCasilla70.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla70.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla70.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla70.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla70.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla71
            // 
            this.PbxCasilla71.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla71.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxCasilla71.Location = new System.Drawing.Point(407, 344);
            this.PbxCasilla71.Name = "PbxCasilla71";
            this.PbxCasilla71.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla71.TabIndex = 1;
            this.PbxCasilla71.TabStop = false;
            this.PbxCasilla71.Tag = "NX";
            this.PbxCasilla71.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla71.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla71.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla71.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla71.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla72
            // 
            this.PbxCasilla72.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla72.Location = new System.Drawing.Point(407, 288);
            this.PbxCasilla72.Name = "PbxCasilla72";
            this.PbxCasilla72.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla72.TabIndex = 23;
            this.PbxCasilla72.TabStop = false;
            this.PbxCasilla72.Tag = "BX";
            this.PbxCasilla72.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla72.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla72.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla72.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla72.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla73
            // 
            this.PbxCasilla73.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla73.Location = new System.Drawing.Point(407, 232);
            this.PbxCasilla73.Name = "PbxCasilla73";
            this.PbxCasilla73.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla73.TabIndex = 16;
            this.PbxCasilla73.TabStop = false;
            this.PbxCasilla73.Tag = "NX";
            this.PbxCasilla73.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla73.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla73.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla73.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla73.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla74
            // 
            this.PbxCasilla74.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla74.Location = new System.Drawing.Point(407, 176);
            this.PbxCasilla74.Name = "PbxCasilla74";
            this.PbxCasilla74.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla74.TabIndex = 39;
            this.PbxCasilla74.TabStop = false;
            this.PbxCasilla74.Tag = "BX";
            this.PbxCasilla74.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla74.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla74.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla74.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla74.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla75
            // 
            this.PbxCasilla75.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla75.Location = new System.Drawing.Point(407, 120);
            this.PbxCasilla75.Name = "PbxCasilla75";
            this.PbxCasilla75.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla75.TabIndex = 32;
            this.PbxCasilla75.TabStop = false;
            this.PbxCasilla75.Tag = "NX";
            this.PbxCasilla75.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla75.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla75.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla75.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla75.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla76
            // 
            this.PbxCasilla76.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaB;
            this.PbxCasilla76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla76.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxCasilla76.Location = new System.Drawing.Point(407, 64);
            this.PbxCasilla76.Name = "PbxCasilla76";
            this.PbxCasilla76.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla76.TabIndex = 55;
            this.PbxCasilla76.TabStop = false;
            this.PbxCasilla76.Tag = "BX";
            this.PbxCasilla76.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla76.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla76.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla76.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla76.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // PbxCasilla77
            // 
            this.PbxCasilla77.BackgroundImage = global::UAChess.Properties.Resources.TblCasillaN;
            this.PbxCasilla77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCasilla77.Image = global::UAChess.Properties.Resources.PzTorreN;
            this.PbxCasilla77.Location = new System.Drawing.Point(407, 8);
            this.PbxCasilla77.Name = "PbxCasilla77";
            this.PbxCasilla77.Size = new System.Drawing.Size(55, 55);
            this.PbxCasilla77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCasilla77.TabIndex = 48;
            this.PbxCasilla77.TabStop = false;
            this.PbxCasilla77.Tag = "NX";
            this.PbxCasilla77.Click += new System.EventHandler(this.PbxCasilla_Click);
            this.PbxCasilla77.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseDown);
            this.PbxCasilla77.MouseEnter += new System.EventHandler(this.PbxCasilla_MouseEnter);
            this.PbxCasilla77.MouseLeave += new System.EventHandler(this.PbxCasilla_MouseLeave);
            this.PbxCasilla77.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxCasilla_MouseUp);
            // 
            // NSCBtnCerrar
            // 
            this.NSCBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NSCBtnCerrar.ControlButton = NSControlButton.Button.Close;
            this.NSCBtnCerrar.Location = new System.Drawing.Point(688, 4);
            this.NSCBtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.NSCBtnCerrar.MaximumSize = new System.Drawing.Size(18, 20);
            this.NSCBtnCerrar.MinimumSize = new System.Drawing.Size(18, 20);
            this.NSCBtnCerrar.Name = "NSCBtnCerrar";
            this.NSCBtnCerrar.Size = new System.Drawing.Size(18, 20);
            this.NSCBtnCerrar.TabIndex = 0;
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "UACHESS";
            this.NSLblTitulo.Value1 = "UA";
            this.NSLblTitulo.Value2 = "CHESS";
            // 
            // FrmChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 565);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAChess";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChess_FormClosed);
            this.Shown += new System.EventHandler(this.FrmChess_Shown);
            this.NSTheme.ResumeLayout(false);
            this.NSGpbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoDeshacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoInicio)).EndInit();
            this.PnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelNegras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelBlancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoNegras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBlancas)).EndInit();
            this.NSGpbDetalles.ResumeLayout(false);
            this.PnlVisor.ResumeLayout(false);
            this.PnlJuego.ResumeLayout(false);
            this.PnlNegras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxNegras)).EndInit();
            this.PnlBlancas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlancas)).EndInit();
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoBrazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoJugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcoNuevo)).EndInit();
            this.PnlTablero.ResumeLayout(false);
            this.PnlTablero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCasilla77)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private NSControlButton NSCBtnCerrar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Label LblIcoNuevo;
        private System.Windows.Forms.PictureBox PbxIcoNuevo;
        private System.Windows.Forms.Label LblIcoJugar;
        private System.Windows.Forms.PictureBox PbxIcoJugar;
        private System.Windows.Forms.Label LblIcoGuardar;
        private System.Windows.Forms.PictureBox PbxIcoGuardar;
        private System.Windows.Forms.Label LblIcoCargar;
        private System.Windows.Forms.PictureBox PbxIcoCargar;
        private System.Windows.Forms.Label LblIcoAjustes;
        private System.Windows.Forms.PictureBox PbxIcoAjustes;
        private System.Windows.Forms.Label LblIcoCreditos;
        private System.Windows.Forms.PictureBox PbxIcoCreditos;
        private System.Windows.Forms.Label LblIcoCPU;
        private System.Windows.Forms.PictureBox PbxIcoCPU;
        private System.Windows.Forms.Label LblIcoBrazo;
        private System.Windows.Forms.PictureBox PbxIcoBrazo;
        private System.Windows.Forms.Label LblIcoEstadisticas;
        private System.Windows.Forms.PictureBox PbxIcoEstadisticas;
        private System.Windows.Forms.Label LblIcoBBDD;
        private System.Windows.Forms.PictureBox PbxIcoBBDD;
        private System.Windows.Forms.PictureBox PbxIcoReproducir;
        private System.Windows.Forms.PictureBox PbxIcoAtras;
        private System.Windows.Forms.PictureBox PbxIcoAdelante;
        private System.Windows.Forms.PictureBox PbxIcoInicio;
        private System.Windows.Forms.PictureBox PbxIcoFinal;
        private System.Windows.Forms.PictureBox PbxIcoDeshacer;
        private System.Windows.Forms.Panel PnlDatos;
        private System.Windows.Forms.PictureBox PbxIcoNegras;
        private System.Windows.Forms.Label LblPuntosN;
        private System.Windows.Forms.PictureBox PbxIcoBlancas;
        private System.Windows.Forms.Label LblPuntosB;
        private NSGroupBox NSGpbDetalles;
        private System.Windows.Forms.Label LblModo;
        private System.Windows.Forms.Panel PnlVisor;
        private NSGroupBox NSGpbHistorial;
        private NSRadioButton NSRbtAlgebraico;
        private NSRadioButton NSRbtDescriptivo;
        private NSListView NSLvHistorialA;
        private NSListView NSLvHistorialD;
        private System.Windows.Forms.Panel PnlTablero;
        private System.Windows.Forms.Label LblCasillasA;
        private System.Windows.Forms.Label LblCasillasB;
        private System.Windows.Forms.Label LblCasillasC;
        private System.Windows.Forms.Label LblCasillasD;
        private System.Windows.Forms.Label LblCasillasE;
        private System.Windows.Forms.Label LblCasillasF;
        private System.Windows.Forms.Label LblCasillasG;
        private System.Windows.Forms.Label LblCasillasH;
        private System.Windows.Forms.Label LblCasillas1;
        private System.Windows.Forms.Label LblCasillas2;
        private System.Windows.Forms.Label LblCasillas3;
        private System.Windows.Forms.Label LblCasillas4;
        private System.Windows.Forms.Label LblCasillas5;
        private System.Windows.Forms.Label LblCasillas6;
        private System.Windows.Forms.Label LblCasillas7;
        private System.Windows.Forms.Label LblCasillas8;
        private System.Windows.Forms.PictureBox PbxCasilla00;
        private System.Windows.Forms.PictureBox PbxCasilla01;
        private System.Windows.Forms.PictureBox PbxCasilla02;
        private System.Windows.Forms.PictureBox PbxCasilla03;
        private System.Windows.Forms.PictureBox PbxCasilla04;
        private System.Windows.Forms.PictureBox PbxCasilla05;
        private System.Windows.Forms.PictureBox PbxCasilla06;
        private System.Windows.Forms.PictureBox PbxCasilla07;
        private System.Windows.Forms.PictureBox PbxCasilla10;
        private System.Windows.Forms.PictureBox PbxCasilla11;
        private System.Windows.Forms.PictureBox PbxCasilla12;
        private System.Windows.Forms.PictureBox PbxCasilla13;
        private System.Windows.Forms.PictureBox PbxCasilla14;
        private System.Windows.Forms.PictureBox PbxCasilla15;
        private System.Windows.Forms.PictureBox PbxCasilla16;
        private System.Windows.Forms.PictureBox PbxCasilla17;
        private System.Windows.Forms.PictureBox PbxCasilla20;
        private System.Windows.Forms.PictureBox PbxCasilla21;
        private System.Windows.Forms.PictureBox PbxCasilla22;
        private System.Windows.Forms.PictureBox PbxCasilla23;
        private System.Windows.Forms.PictureBox PbxCasilla24;
        private System.Windows.Forms.PictureBox PbxCasilla25;
        private System.Windows.Forms.PictureBox PbxCasilla26;
        private System.Windows.Forms.PictureBox PbxCasilla27;
        private System.Windows.Forms.PictureBox PbxCasilla30;
        private System.Windows.Forms.PictureBox PbxCasilla31;
        private System.Windows.Forms.PictureBox PbxCasilla32;
        private System.Windows.Forms.PictureBox PbxCasilla33;
        private System.Windows.Forms.PictureBox PbxCasilla34;
        private System.Windows.Forms.PictureBox PbxCasilla35;
        private System.Windows.Forms.PictureBox PbxCasilla36;
        private System.Windows.Forms.PictureBox PbxCasilla37;
        private System.Windows.Forms.PictureBox PbxCasilla40;
        private System.Windows.Forms.PictureBox PbxCasilla41;
        private System.Windows.Forms.PictureBox PbxCasilla42;
        private System.Windows.Forms.PictureBox PbxCasilla43;
        private System.Windows.Forms.PictureBox PbxCasilla44;
        private System.Windows.Forms.PictureBox PbxCasilla45;
        private System.Windows.Forms.PictureBox PbxCasilla46;
        private System.Windows.Forms.PictureBox PbxCasilla47;
        private System.Windows.Forms.PictureBox PbxCasilla50;
        private System.Windows.Forms.PictureBox PbxCasilla51;
        private System.Windows.Forms.PictureBox PbxCasilla52;
        private System.Windows.Forms.PictureBox PbxCasilla53;
        private System.Windows.Forms.PictureBox PbxCasilla54;
        private System.Windows.Forms.PictureBox PbxCasilla55;
        private System.Windows.Forms.PictureBox PbxCasilla56;
        private System.Windows.Forms.PictureBox PbxCasilla57;
        private System.Windows.Forms.PictureBox PbxCasilla60;
        private System.Windows.Forms.PictureBox PbxCasilla61;
        private System.Windows.Forms.PictureBox PbxCasilla62;
        private System.Windows.Forms.PictureBox PbxCasilla63;
        private System.Windows.Forms.PictureBox PbxCasilla64;
        private System.Windows.Forms.PictureBox PbxCasilla65;
        private System.Windows.Forms.PictureBox PbxCasilla66;
        private System.Windows.Forms.PictureBox PbxCasilla67;
        private System.Windows.Forms.PictureBox PbxCasilla70;
        private System.Windows.Forms.PictureBox PbxCasilla71;
        private System.Windows.Forms.PictureBox PbxCasilla72;
        private System.Windows.Forms.PictureBox PbxCasilla73;
        private System.Windows.Forms.PictureBox PbxCasilla74;
        private System.Windows.Forms.PictureBox PbxCasilla75;
        private System.Windows.Forms.PictureBox PbxCasilla76;
        private System.Windows.Forms.PictureBox PbxCasilla77;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblLugar;
        private System.Windows.Forms.Label LblEvento;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblNegras;
        private System.Windows.Forms.Label LblBlancas;
        private System.Windows.Forms.Label LblElo;
        private System.Windows.Forms.Label LblDBlancas;
        private System.Windows.Forms.Label LblDNegras;
        private System.Windows.Forms.Label LblDResultado;
        private System.Windows.Forms.Label LblDElo;
        private System.Windows.Forms.Label LblDEvento;
        private System.Windows.Forms.Label LblDLugar;
        private System.Windows.Forms.Label LblDFecha;
        private NSComboBox NSCmbPartidas;
        private NSComboBox NSCmbBlancas;
        private NSComboBox NSCmbNegras;
        private System.Windows.Forms.PictureBox PbxSelBlancas;
        private System.Windows.Forms.PictureBox PbxSelNegras;
        private System.Windows.Forms.Panel PnlJuego;
        private System.Windows.Forms.Panel PnlBlancas;
        private System.Windows.Forms.Label LblAlgoritmoB;
        private System.Windows.Forms.Label LblMovsB;
        private System.Windows.Forms.Label LblDAtaqueB;
        private System.Windows.Forms.PictureBox PbxBlancas;
        private System.Windows.Forms.Label LblAtaqueB;
        private System.Windows.Forms.Label LblDAlgoritmoB;
        private System.Windows.Forms.Label LblDMovsB;
        private System.Windows.Forms.Panel PnlNegras;
        private System.Windows.Forms.Label LblDAlgoritmoN;
        private System.Windows.Forms.Label LblDMovsN;
        private System.Windows.Forms.Label LblAlgoritmoN;
        private System.Windows.Forms.Label LblMovsN;
        private System.Windows.Forms.Label LblDAtaqueN;
        private System.Windows.Forms.PictureBox PbxNegras;
        private System.Windows.Forms.Label LblAtaqueN;
    }
}