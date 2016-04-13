namespace UAChess
{
    partial class FrmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LblDEficaciaN = new System.Windows.Forms.Label();
            this.LblDMovilidadN = new System.Windows.Forms.Label();
            this.LblDDefensaN = new System.Windows.Forms.Label();
            this.LblDAtaqueN = new System.Windows.Forms.Label();
            this.LblDEficaciaB = new System.Windows.Forms.Label();
            this.LblDMovilidadB = new System.Windows.Forms.Label();
            this.LblDDefensaB = new System.Windows.Forms.Label();
            this.LblDAtaqueB = new System.Windows.Forms.Label();
            this.LblMovsTRB = new System.Windows.Forms.Label();
            this.LblControlTRB = new System.Windows.Forms.Label();
            this.LblMovsCRB = new System.Windows.Forms.Label();
            this.LblControlCRB = new System.Windows.Forms.Label();
            this.LblMovsARB = new System.Windows.Forms.Label();
            this.LblControlARB = new System.Windows.Forms.Label();
            this.LblMovsRB = new System.Windows.Forms.Label();
            this.LblControlRB = new System.Windows.Forms.Label();
            this.LblMovsDB = new System.Windows.Forms.Label();
            this.LblControlDB = new System.Windows.Forms.Label();
            this.LblMovsADB = new System.Windows.Forms.Label();
            this.LblControlADB = new System.Windows.Forms.Label();
            this.LblMovsCDB = new System.Windows.Forms.Label();
            this.LblControlCDB = new System.Windows.Forms.Label();
            this.LblMovsTDB = new System.Windows.Forms.Label();
            this.LblControlTDB = new System.Windows.Forms.Label();
            this.LblMovsPTRB = new System.Windows.Forms.Label();
            this.LblControlPTRB = new System.Windows.Forms.Label();
            this.LblMovsPCRB = new System.Windows.Forms.Label();
            this.LblControlPCRB = new System.Windows.Forms.Label();
            this.LblMovsPARB = new System.Windows.Forms.Label();
            this.LblControlPARB = new System.Windows.Forms.Label();
            this.LblMovsPRB = new System.Windows.Forms.Label();
            this.LblControlPRB = new System.Windows.Forms.Label();
            this.LblMovsPDB = new System.Windows.Forms.Label();
            this.LblControlPDB = new System.Windows.Forms.Label();
            this.LblMovsPADB = new System.Windows.Forms.Label();
            this.LblControlPADB = new System.Windows.Forms.Label();
            this.LblMovsPCDB = new System.Windows.Forms.Label();
            this.LblControlPCDB = new System.Windows.Forms.Label();
            this.LblMovsPTDB = new System.Windows.Forms.Label();
            this.LblControlPTDB = new System.Windows.Forms.Label();
            this.LblMovsTRN = new System.Windows.Forms.Label();
            this.LblControlTRN = new System.Windows.Forms.Label();
            this.LblMovsCRN = new System.Windows.Forms.Label();
            this.LblControlCRN = new System.Windows.Forms.Label();
            this.LblMovsARN = new System.Windows.Forms.Label();
            this.LblControlARN = new System.Windows.Forms.Label();
            this.LblMovsRN = new System.Windows.Forms.Label();
            this.LblControlRN = new System.Windows.Forms.Label();
            this.LblMovsDN = new System.Windows.Forms.Label();
            this.LblControlDN = new System.Windows.Forms.Label();
            this.LblMovsADN = new System.Windows.Forms.Label();
            this.LblControlADN = new System.Windows.Forms.Label();
            this.LblMovsCDN = new System.Windows.Forms.Label();
            this.LblControlCDN = new System.Windows.Forms.Label();
            this.LblMovsTDN = new System.Windows.Forms.Label();
            this.LblControlTDN = new System.Windows.Forms.Label();
            this.LblMovsPTRN = new System.Windows.Forms.Label();
            this.LblControlPTRN = new System.Windows.Forms.Label();
            this.LblMovsPCRN = new System.Windows.Forms.Label();
            this.LblControlPCRN = new System.Windows.Forms.Label();
            this.LblMovsPARN = new System.Windows.Forms.Label();
            this.LblControlPARN = new System.Windows.Forms.Label();
            this.LblMovsPRN = new System.Windows.Forms.Label();
            this.LblControlPRN = new System.Windows.Forms.Label();
            this.LblMovsPDN = new System.Windows.Forms.Label();
            this.LblControlPDN = new System.Windows.Forms.Label();
            this.LblMovsPADN = new System.Windows.Forms.Label();
            this.LblControlPADN = new System.Windows.Forms.Label();
            this.LblMovsPCDN = new System.Windows.Forms.Label();
            this.LblControlPCDN = new System.Windows.Forms.Label();
            this.LblMovsPTDN = new System.Windows.Forms.Label();
            this.LblControlPTDN = new System.Windows.Forms.Label();
            this.NSTheme = new NSTheme();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.NSGpbGeneral = new NSGroupBox();
            this.PnlNegras = new System.Windows.Forms.Panel();
            this.LblMovilidadN = new System.Windows.Forms.Label();
            this.LblEficaciaN = new System.Windows.Forms.Label();
            this.LblAtaqueN = new System.Windows.Forms.Label();
            this.LblDefensaN = new System.Windows.Forms.Label();
            this.PbxNegras = new System.Windows.Forms.PictureBox();
            this.PnlBlancas = new System.Windows.Forms.Panel();
            this.LblMovilidadB = new System.Windows.Forms.Label();
            this.PbxBlancas = new System.Windows.Forms.PictureBox();
            this.LblEficaciaB = new System.Windows.Forms.Label();
            this.LblAtaqueB = new System.Windows.Forms.Label();
            this.LblDefensaB = new System.Windows.Forms.Label();
            this.NSGpbGrafica = new NSGroupBox();
            this.NSRbtMovilidad = new NSRadioButton();
            this.NSRbtDefensa = new NSRadioButton();
            this.NSRbtAtaque = new NSRadioButton();
            this.ChrtAtaque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChrtDefensa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChrtMovilidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NSGpbPiezas = new NSGroupBox();
            this.PnlPiezasMayorB = new System.Windows.Forms.Panel();
            this.PbxTorreRB = new System.Windows.Forms.PictureBox();
            this.LblNombreTRB = new System.Windows.Forms.Label();
            this.PbxCaballoRB = new System.Windows.Forms.PictureBox();
            this.LblNombreCRB = new System.Windows.Forms.Label();
            this.PbxAlfilRB = new System.Windows.Forms.PictureBox();
            this.LblNombreARB = new System.Windows.Forms.Label();
            this.PbxReyB = new System.Windows.Forms.PictureBox();
            this.LblNombreRB = new System.Windows.Forms.Label();
            this.PbxDamaB = new System.Windows.Forms.PictureBox();
            this.LblNombreDB = new System.Windows.Forms.Label();
            this.PbxAlfilDB = new System.Windows.Forms.PictureBox();
            this.LblNombreADB = new System.Windows.Forms.Label();
            this.PbxCaballoDB = new System.Windows.Forms.PictureBox();
            this.LblNombreCDB = new System.Windows.Forms.Label();
            this.PbxTorreDB = new System.Windows.Forms.PictureBox();
            this.LblNombreTDB = new System.Windows.Forms.Label();
            this.PnlPiezasMenorB = new System.Windows.Forms.Panel();
            this.PbxPeonTRB = new System.Windows.Forms.PictureBox();
            this.LblNombrePTRB = new System.Windows.Forms.Label();
            this.PbxPeonCRB = new System.Windows.Forms.PictureBox();
            this.LblNombrePCRB = new System.Windows.Forms.Label();
            this.PbxPeonARB = new System.Windows.Forms.PictureBox();
            this.LblNombrePARB = new System.Windows.Forms.Label();
            this.PbxPeonRB = new System.Windows.Forms.PictureBox();
            this.LblNombrePRB = new System.Windows.Forms.Label();
            this.PbxPeonDB = new System.Windows.Forms.PictureBox();
            this.LblNombrePDB = new System.Windows.Forms.Label();
            this.PbxPeonADB = new System.Windows.Forms.PictureBox();
            this.LblNombrePADB = new System.Windows.Forms.Label();
            this.PbxPeonCDB = new System.Windows.Forms.PictureBox();
            this.LblNombrePCDB = new System.Windows.Forms.Label();
            this.PbxPeonTDB = new System.Windows.Forms.PictureBox();
            this.LblNombrePTDB = new System.Windows.Forms.Label();
            this.PnlPiezasMayorN = new System.Windows.Forms.Panel();
            this.PbxTorreRN = new System.Windows.Forms.PictureBox();
            this.LblNombreTRN = new System.Windows.Forms.Label();
            this.PbxCaballoRN = new System.Windows.Forms.PictureBox();
            this.LblNombreCRN = new System.Windows.Forms.Label();
            this.PbxAlfilRN = new System.Windows.Forms.PictureBox();
            this.LblNombreARN = new System.Windows.Forms.Label();
            this.PbxReyN = new System.Windows.Forms.PictureBox();
            this.LblNombreRN = new System.Windows.Forms.Label();
            this.PbxDamaN = new System.Windows.Forms.PictureBox();
            this.LblNombreDN = new System.Windows.Forms.Label();
            this.PbxAlfilDN = new System.Windows.Forms.PictureBox();
            this.LblNombreADN = new System.Windows.Forms.Label();
            this.PbxCaballoDN = new System.Windows.Forms.PictureBox();
            this.LblNombreCDN = new System.Windows.Forms.Label();
            this.PbxTorreDN = new System.Windows.Forms.PictureBox();
            this.LblNombreTDN = new System.Windows.Forms.Label();
            this.PnlPiezasMenorN = new System.Windows.Forms.Panel();
            this.PbxPeonTRN = new System.Windows.Forms.PictureBox();
            this.LblNombrePTRN = new System.Windows.Forms.Label();
            this.PbxPeonCRN = new System.Windows.Forms.PictureBox();
            this.LblNombrePCRN = new System.Windows.Forms.Label();
            this.PbxPeonARN = new System.Windows.Forms.PictureBox();
            this.LblNombrePARN = new System.Windows.Forms.Label();
            this.PbxPeonRN = new System.Windows.Forms.PictureBox();
            this.LblNombrePRN = new System.Windows.Forms.Label();
            this.PbxPeonDN = new System.Windows.Forms.PictureBox();
            this.LblNombrePDN = new System.Windows.Forms.Label();
            this.PbxPeonADN = new System.Windows.Forms.PictureBox();
            this.LblNombrePADN = new System.Windows.Forms.Label();
            this.PbxPeonCDN = new System.Windows.Forms.PictureBox();
            this.LblNombrePCDN = new System.Windows.Forms.Label();
            this.PbxPeonTDN = new System.Windows.Forms.PictureBox();
            this.LblNombrePTDN = new System.Windows.Forms.Label();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            this.NSGpbGeneral.SuspendLayout();
            this.PnlNegras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNegras)).BeginInit();
            this.PnlBlancas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlancas)).BeginInit();
            this.NSGpbGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtDefensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtMovilidad)).BeginInit();
            this.NSGpbPiezas.SuspendLayout();
            this.PnlPiezasMayorB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxReyB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDamaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreDB)).BeginInit();
            this.PnlPiezasMenorB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonARB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonADB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTDB)).BeginInit();
            this.PnlPiezasMayorN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxReyN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDamaN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreDN)).BeginInit();
            this.PnlPiezasMenorN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonARN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonADN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTDN)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.ToolTipTitle = "Información";
            // 
            // LblDEficaciaN
            // 
            this.LblDEficaciaN.BackColor = System.Drawing.Color.Transparent;
            this.LblDEficaciaN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDEficaciaN.ForeColor = System.Drawing.Color.White;
            this.LblDEficaciaN.Location = new System.Drawing.Point(108, 54);
            this.LblDEficaciaN.Name = "LblDEficaciaN";
            this.LblDEficaciaN.Size = new System.Drawing.Size(70, 15);
            this.LblDEficaciaN.TabIndex = 0;
            this.LblDEficaciaN.Text = "XX/XXX";
            this.LblDEficaciaN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDEficaciaN, "Valor Piezas Capturadas / Número Movs");
            // 
            // LblDMovilidadN
            // 
            this.LblDMovilidadN.BackColor = System.Drawing.Color.Transparent;
            this.LblDMovilidadN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDMovilidadN.ForeColor = System.Drawing.Color.White;
            this.LblDMovilidadN.Location = new System.Drawing.Point(38, 54);
            this.LblDMovilidadN.Name = "LblDMovilidadN";
            this.LblDMovilidadN.Size = new System.Drawing.Size(70, 15);
            this.LblDMovilidadN.TabIndex = 0;
            this.LblDMovilidadN.Text = "XXX.X%";
            this.LblDMovilidadN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDMovilidadN, "Movs Posibles / Total Movs Posibles");
            // 
            // LblDDefensaN
            // 
            this.LblDDefensaN.BackColor = System.Drawing.Color.Transparent;
            this.LblDDefensaN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDDefensaN.ForeColor = System.Drawing.Color.White;
            this.LblDDefensaN.Location = new System.Drawing.Point(108, 19);
            this.LblDDefensaN.Name = "LblDDefensaN";
            this.LblDDefensaN.Size = new System.Drawing.Size(70, 15);
            this.LblDDefensaN.TabIndex = 0;
            this.LblDDefensaN.Text = "XXX.X%";
            this.LblDDefensaN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDDefensaN, "Valor Piezas / Total Valor Piezas");
            // 
            // LblDAtaqueN
            // 
            this.LblDAtaqueN.BackColor = System.Drawing.Color.Transparent;
            this.LblDAtaqueN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAtaqueN.ForeColor = System.Drawing.Color.White;
            this.LblDAtaqueN.Location = new System.Drawing.Point(38, 19);
            this.LblDAtaqueN.Name = "LblDAtaqueN";
            this.LblDAtaqueN.Size = new System.Drawing.Size(70, 15);
            this.LblDAtaqueN.TabIndex = 0;
            this.LblDAtaqueN.Text = "XXX.X%";
            this.LblDAtaqueN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDAtaqueN, "Casillas Controladas / Total Casillas");
            // 
            // LblDEficaciaB
            // 
            this.LblDEficaciaB.BackColor = System.Drawing.Color.Transparent;
            this.LblDEficaciaB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDEficaciaB.ForeColor = System.Drawing.Color.White;
            this.LblDEficaciaB.Location = new System.Drawing.Point(108, 54);
            this.LblDEficaciaB.Name = "LblDEficaciaB";
            this.LblDEficaciaB.Size = new System.Drawing.Size(70, 15);
            this.LblDEficaciaB.TabIndex = 0;
            this.LblDEficaciaB.Text = "XX/XXX";
            this.LblDEficaciaB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDEficaciaB, "Valor Piezas Capturadas / Número Movs");
            // 
            // LblDMovilidadB
            // 
            this.LblDMovilidadB.BackColor = System.Drawing.Color.Transparent;
            this.LblDMovilidadB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDMovilidadB.ForeColor = System.Drawing.Color.White;
            this.LblDMovilidadB.Location = new System.Drawing.Point(38, 54);
            this.LblDMovilidadB.Name = "LblDMovilidadB";
            this.LblDMovilidadB.Size = new System.Drawing.Size(70, 15);
            this.LblDMovilidadB.TabIndex = 0;
            this.LblDMovilidadB.Text = "XXX.X%";
            this.LblDMovilidadB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDMovilidadB, "Movs Posibles / Total Movs Posibles");
            // 
            // LblDDefensaB
            // 
            this.LblDDefensaB.BackColor = System.Drawing.Color.Transparent;
            this.LblDDefensaB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDDefensaB.ForeColor = System.Drawing.Color.White;
            this.LblDDefensaB.Location = new System.Drawing.Point(108, 19);
            this.LblDDefensaB.Name = "LblDDefensaB";
            this.LblDDefensaB.Size = new System.Drawing.Size(70, 15);
            this.LblDDefensaB.TabIndex = 0;
            this.LblDDefensaB.Text = "XXX.X%";
            this.LblDDefensaB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDDefensaB, "Valor Piezas / Total Valor Piezas");
            // 
            // LblDAtaqueB
            // 
            this.LblDAtaqueB.BackColor = System.Drawing.Color.Transparent;
            this.LblDAtaqueB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAtaqueB.ForeColor = System.Drawing.Color.White;
            this.LblDAtaqueB.Location = new System.Drawing.Point(38, 19);
            this.LblDAtaqueB.Name = "LblDAtaqueB";
            this.LblDAtaqueB.Size = new System.Drawing.Size(70, 15);
            this.LblDAtaqueB.TabIndex = 0;
            this.LblDAtaqueB.Text = "XXX.X%";
            this.LblDAtaqueB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblDAtaqueB, "Casillas Controladas / Total Casillas");
            // 
            // LblMovsTRB
            // 
            this.LblMovsTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsTRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsTRB.Location = new System.Drawing.Point(48, 355);
            this.LblMovsTRB.Name = "LblMovsTRB";
            this.LblMovsTRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsTRB.TabIndex = 0;
            this.LblMovsTRB.Text = "XX / XXXXX";
            this.LblMovsTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsTRB, "Número Movs / Último Mov");
            // 
            // LblControlTRB
            // 
            this.LblControlTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlTRB.ForeColor = System.Drawing.Color.White;
            this.LblControlTRB.Location = new System.Drawing.Point(48, 341);
            this.LblControlTRB.Name = "LblControlTRB";
            this.LblControlTRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlTRB.TabIndex = 0;
            this.LblControlTRB.Text = "C: XX / MP: XX";
            this.LblControlTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlTRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsCRB
            // 
            this.LblMovsCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsCRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsCRB.Location = new System.Drawing.Point(48, 309);
            this.LblMovsCRB.Name = "LblMovsCRB";
            this.LblMovsCRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsCRB.TabIndex = 0;
            this.LblMovsCRB.Text = "XX / XXXXX";
            this.LblMovsCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsCRB, "Número Movs / Último Mov");
            // 
            // LblControlCRB
            // 
            this.LblControlCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlCRB.ForeColor = System.Drawing.Color.White;
            this.LblControlCRB.Location = new System.Drawing.Point(48, 295);
            this.LblControlCRB.Name = "LblControlCRB";
            this.LblControlCRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlCRB.TabIndex = 0;
            this.LblControlCRB.Text = "C: XX / MP: XX";
            this.LblControlCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlCRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsARB
            // 
            this.LblMovsARB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsARB.ForeColor = System.Drawing.Color.White;
            this.LblMovsARB.Location = new System.Drawing.Point(48, 263);
            this.LblMovsARB.Name = "LblMovsARB";
            this.LblMovsARB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsARB.TabIndex = 0;
            this.LblMovsARB.Text = "XX / XXXXX";
            this.LblMovsARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsARB, "Número Movs / Último Mov");
            // 
            // LblControlARB
            // 
            this.LblControlARB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlARB.ForeColor = System.Drawing.Color.White;
            this.LblControlARB.Location = new System.Drawing.Point(48, 249);
            this.LblControlARB.Name = "LblControlARB";
            this.LblControlARB.Size = new System.Drawing.Size(92, 12);
            this.LblControlARB.TabIndex = 0;
            this.LblControlARB.Text = "C: XX / MP: XX";
            this.LblControlARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlARB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsRB
            // 
            this.LblMovsRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsRB.Location = new System.Drawing.Point(48, 217);
            this.LblMovsRB.Name = "LblMovsRB";
            this.LblMovsRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsRB.TabIndex = 0;
            this.LblMovsRB.Text = "XX / XXXXX";
            this.LblMovsRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsRB, "Número Movs / Último Mov");
            // 
            // LblControlRB
            // 
            this.LblControlRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlRB.ForeColor = System.Drawing.Color.White;
            this.LblControlRB.Location = new System.Drawing.Point(48, 203);
            this.LblControlRB.Name = "LblControlRB";
            this.LblControlRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlRB.TabIndex = 0;
            this.LblControlRB.Text = "C: XX / MP: XX";
            this.LblControlRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsDB
            // 
            this.LblMovsDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsDB.Location = new System.Drawing.Point(48, 171);
            this.LblMovsDB.Name = "LblMovsDB";
            this.LblMovsDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsDB.TabIndex = 0;
            this.LblMovsDB.Text = "XX / XXXXX";
            this.LblMovsDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsDB, "Número Movs / Último Mov");
            // 
            // LblControlDB
            // 
            this.LblControlDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlDB.ForeColor = System.Drawing.Color.White;
            this.LblControlDB.Location = new System.Drawing.Point(48, 157);
            this.LblControlDB.Name = "LblControlDB";
            this.LblControlDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlDB.TabIndex = 0;
            this.LblControlDB.Text = "C: XX / MP: XX";
            this.LblControlDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsADB
            // 
            this.LblMovsADB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsADB.ForeColor = System.Drawing.Color.White;
            this.LblMovsADB.Location = new System.Drawing.Point(48, 125);
            this.LblMovsADB.Name = "LblMovsADB";
            this.LblMovsADB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsADB.TabIndex = 0;
            this.LblMovsADB.Text = "XX / XXXXX";
            this.LblMovsADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsADB, "Número Movs / Último Mov");
            // 
            // LblControlADB
            // 
            this.LblControlADB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlADB.ForeColor = System.Drawing.Color.White;
            this.LblControlADB.Location = new System.Drawing.Point(48, 111);
            this.LblControlADB.Name = "LblControlADB";
            this.LblControlADB.Size = new System.Drawing.Size(92, 12);
            this.LblControlADB.TabIndex = 0;
            this.LblControlADB.Text = "C: XX / MP: XX";
            this.LblControlADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlADB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsCDB
            // 
            this.LblMovsCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsCDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsCDB.Location = new System.Drawing.Point(48, 79);
            this.LblMovsCDB.Name = "LblMovsCDB";
            this.LblMovsCDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsCDB.TabIndex = 0;
            this.LblMovsCDB.Text = "XX / XXXXX";
            this.LblMovsCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsCDB, "Número Movs / Último Mov");
            // 
            // LblControlCDB
            // 
            this.LblControlCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlCDB.ForeColor = System.Drawing.Color.White;
            this.LblControlCDB.Location = new System.Drawing.Point(48, 65);
            this.LblControlCDB.Name = "LblControlCDB";
            this.LblControlCDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlCDB.TabIndex = 0;
            this.LblControlCDB.Text = "C: XX / MP: XX";
            this.LblControlCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlCDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsTDB
            // 
            this.LblMovsTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsTDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsTDB.Location = new System.Drawing.Point(48, 33);
            this.LblMovsTDB.Name = "LblMovsTDB";
            this.LblMovsTDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsTDB.TabIndex = 0;
            this.LblMovsTDB.Text = "XX / XXXXX";
            this.LblMovsTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsTDB, "Número Movs / Último Mov");
            // 
            // LblControlTDB
            // 
            this.LblControlTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlTDB.ForeColor = System.Drawing.Color.White;
            this.LblControlTDB.Location = new System.Drawing.Point(48, 19);
            this.LblControlTDB.Name = "LblControlTDB";
            this.LblControlTDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlTDB.TabIndex = 0;
            this.LblControlTDB.Text = "C: XX / MP: XX";
            this.LblControlTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlTDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPTRB
            // 
            this.LblMovsPTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPTRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPTRB.Location = new System.Drawing.Point(48, 355);
            this.LblMovsPTRB.Name = "LblMovsPTRB";
            this.LblMovsPTRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPTRB.TabIndex = 0;
            this.LblMovsPTRB.Text = "XX / XXXXX";
            this.LblMovsPTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPTRB, "Número Movs / Último Mov");
            // 
            // LblControlPTRB
            // 
            this.LblControlPTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPTRB.ForeColor = System.Drawing.Color.White;
            this.LblControlPTRB.Location = new System.Drawing.Point(48, 341);
            this.LblControlPTRB.Name = "LblControlPTRB";
            this.LblControlPTRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPTRB.TabIndex = 0;
            this.LblControlPTRB.Text = "C: XX / MP: XX";
            this.LblControlPTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPTRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPCRB
            // 
            this.LblMovsPCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPCRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPCRB.Location = new System.Drawing.Point(48, 309);
            this.LblMovsPCRB.Name = "LblMovsPCRB";
            this.LblMovsPCRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPCRB.TabIndex = 0;
            this.LblMovsPCRB.Text = "XX / XXXXX";
            this.LblMovsPCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPCRB, "Número Movs / Último Mov");
            // 
            // LblControlPCRB
            // 
            this.LblControlPCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPCRB.ForeColor = System.Drawing.Color.White;
            this.LblControlPCRB.Location = new System.Drawing.Point(48, 295);
            this.LblControlPCRB.Name = "LblControlPCRB";
            this.LblControlPCRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPCRB.TabIndex = 0;
            this.LblControlPCRB.Text = "C: XX / MP: XX";
            this.LblControlPCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPCRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPARB
            // 
            this.LblMovsPARB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPARB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPARB.Location = new System.Drawing.Point(48, 263);
            this.LblMovsPARB.Name = "LblMovsPARB";
            this.LblMovsPARB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPARB.TabIndex = 0;
            this.LblMovsPARB.Text = "XX / XXXXX";
            this.LblMovsPARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPARB, "Número Movs / Último Mov");
            // 
            // LblControlPARB
            // 
            this.LblControlPARB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPARB.ForeColor = System.Drawing.Color.White;
            this.LblControlPARB.Location = new System.Drawing.Point(48, 249);
            this.LblControlPARB.Name = "LblControlPARB";
            this.LblControlPARB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPARB.TabIndex = 0;
            this.LblControlPARB.Text = "C: XX / MP: XX";
            this.LblControlPARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPARB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPRB
            // 
            this.LblMovsPRB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPRB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPRB.Location = new System.Drawing.Point(48, 217);
            this.LblMovsPRB.Name = "LblMovsPRB";
            this.LblMovsPRB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPRB.TabIndex = 0;
            this.LblMovsPRB.Text = "XX / XXXXX";
            this.LblMovsPRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPRB, "Número Movs / Último Mov");
            // 
            // LblControlPRB
            // 
            this.LblControlPRB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPRB.ForeColor = System.Drawing.Color.White;
            this.LblControlPRB.Location = new System.Drawing.Point(48, 203);
            this.LblControlPRB.Name = "LblControlPRB";
            this.LblControlPRB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPRB.TabIndex = 0;
            this.LblControlPRB.Text = "C: XX / MP: XX";
            this.LblControlPRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPRB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPDB
            // 
            this.LblMovsPDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPDB.Location = new System.Drawing.Point(48, 171);
            this.LblMovsPDB.Name = "LblMovsPDB";
            this.LblMovsPDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPDB.TabIndex = 0;
            this.LblMovsPDB.Text = "XX / XXXXX";
            this.LblMovsPDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPDB, "Número Movs / Último Mov");
            // 
            // LblControlPDB
            // 
            this.LblControlPDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPDB.ForeColor = System.Drawing.Color.White;
            this.LblControlPDB.Location = new System.Drawing.Point(48, 157);
            this.LblControlPDB.Name = "LblControlPDB";
            this.LblControlPDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPDB.TabIndex = 0;
            this.LblControlPDB.Text = "C: XX / MP: XX";
            this.LblControlPDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPADB
            // 
            this.LblMovsPADB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPADB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPADB.Location = new System.Drawing.Point(48, 125);
            this.LblMovsPADB.Name = "LblMovsPADB";
            this.LblMovsPADB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPADB.TabIndex = 0;
            this.LblMovsPADB.Text = "XX / XXXXX";
            this.LblMovsPADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPADB, "Número Movs / Último Mov");
            // 
            // LblControlPADB
            // 
            this.LblControlPADB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPADB.ForeColor = System.Drawing.Color.White;
            this.LblControlPADB.Location = new System.Drawing.Point(48, 111);
            this.LblControlPADB.Name = "LblControlPADB";
            this.LblControlPADB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPADB.TabIndex = 0;
            this.LblControlPADB.Text = "C: XX / MP: XX";
            this.LblControlPADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPADB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPCDB
            // 
            this.LblMovsPCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPCDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPCDB.Location = new System.Drawing.Point(48, 79);
            this.LblMovsPCDB.Name = "LblMovsPCDB";
            this.LblMovsPCDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPCDB.TabIndex = 0;
            this.LblMovsPCDB.Text = "XX / XXXXX";
            this.LblMovsPCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPCDB, "Número Movs / Último Mov");
            // 
            // LblControlPCDB
            // 
            this.LblControlPCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPCDB.ForeColor = System.Drawing.Color.White;
            this.LblControlPCDB.Location = new System.Drawing.Point(48, 65);
            this.LblControlPCDB.Name = "LblControlPCDB";
            this.LblControlPCDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPCDB.TabIndex = 0;
            this.LblControlPCDB.Text = "C: XX / MP: XX";
            this.LblControlPCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPCDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPTDB
            // 
            this.LblMovsPTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPTDB.ForeColor = System.Drawing.Color.White;
            this.LblMovsPTDB.Location = new System.Drawing.Point(48, 33);
            this.LblMovsPTDB.Name = "LblMovsPTDB";
            this.LblMovsPTDB.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPTDB.TabIndex = 0;
            this.LblMovsPTDB.Text = "XX / XXXXX";
            this.LblMovsPTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPTDB, "Número Movs / Último Mov");
            // 
            // LblControlPTDB
            // 
            this.LblControlPTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPTDB.ForeColor = System.Drawing.Color.White;
            this.LblControlPTDB.Location = new System.Drawing.Point(48, 19);
            this.LblControlPTDB.Name = "LblControlPTDB";
            this.LblControlPTDB.Size = new System.Drawing.Size(92, 12);
            this.LblControlPTDB.TabIndex = 0;
            this.LblControlPTDB.Text = "C: XX / MP: XX";
            this.LblControlPTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPTDB, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsTRN
            // 
            this.LblMovsTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsTRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsTRN.Location = new System.Drawing.Point(48, 355);
            this.LblMovsTRN.Name = "LblMovsTRN";
            this.LblMovsTRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsTRN.TabIndex = 0;
            this.LblMovsTRN.Text = "XX / XXXXX";
            this.LblMovsTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsTRN, "Número Movs / Último Mov");
            // 
            // LblControlTRN
            // 
            this.LblControlTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlTRN.ForeColor = System.Drawing.Color.White;
            this.LblControlTRN.Location = new System.Drawing.Point(48, 341);
            this.LblControlTRN.Name = "LblControlTRN";
            this.LblControlTRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlTRN.TabIndex = 0;
            this.LblControlTRN.Text = "C: XX / MP: XX";
            this.LblControlTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlTRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsCRN
            // 
            this.LblMovsCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsCRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsCRN.Location = new System.Drawing.Point(48, 309);
            this.LblMovsCRN.Name = "LblMovsCRN";
            this.LblMovsCRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsCRN.TabIndex = 0;
            this.LblMovsCRN.Text = "XX / XXXXX";
            this.LblMovsCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsCRN, "Número Movs / Último Mov");
            // 
            // LblControlCRN
            // 
            this.LblControlCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlCRN.ForeColor = System.Drawing.Color.White;
            this.LblControlCRN.Location = new System.Drawing.Point(48, 295);
            this.LblControlCRN.Name = "LblControlCRN";
            this.LblControlCRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlCRN.TabIndex = 0;
            this.LblControlCRN.Text = "C: XX / MP: XX";
            this.LblControlCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlCRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsARN
            // 
            this.LblMovsARN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsARN.ForeColor = System.Drawing.Color.White;
            this.LblMovsARN.Location = new System.Drawing.Point(48, 263);
            this.LblMovsARN.Name = "LblMovsARN";
            this.LblMovsARN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsARN.TabIndex = 0;
            this.LblMovsARN.Text = "XX / XXXXX";
            this.LblMovsARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsARN, "Número Movs / Último Mov");
            // 
            // LblControlARN
            // 
            this.LblControlARN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlARN.ForeColor = System.Drawing.Color.White;
            this.LblControlARN.Location = new System.Drawing.Point(48, 249);
            this.LblControlARN.Name = "LblControlARN";
            this.LblControlARN.Size = new System.Drawing.Size(92, 12);
            this.LblControlARN.TabIndex = 0;
            this.LblControlARN.Text = "C: XX / MP: XX";
            this.LblControlARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlARN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsRN
            // 
            this.LblMovsRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsRN.Location = new System.Drawing.Point(48, 217);
            this.LblMovsRN.Name = "LblMovsRN";
            this.LblMovsRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsRN.TabIndex = 0;
            this.LblMovsRN.Text = "XX / XXXXX";
            this.LblMovsRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsRN, "Número Movs / Último Mov");
            // 
            // LblControlRN
            // 
            this.LblControlRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlRN.ForeColor = System.Drawing.Color.White;
            this.LblControlRN.Location = new System.Drawing.Point(48, 203);
            this.LblControlRN.Name = "LblControlRN";
            this.LblControlRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlRN.TabIndex = 0;
            this.LblControlRN.Text = "C: XX / MP: XX";
            this.LblControlRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsDN
            // 
            this.LblMovsDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsDN.Location = new System.Drawing.Point(48, 171);
            this.LblMovsDN.Name = "LblMovsDN";
            this.LblMovsDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsDN.TabIndex = 0;
            this.LblMovsDN.Text = "XX / XXXXX";
            this.LblMovsDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsDN, "Número Movs / Último Mov");
            // 
            // LblControlDN
            // 
            this.LblControlDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlDN.ForeColor = System.Drawing.Color.White;
            this.LblControlDN.Location = new System.Drawing.Point(48, 157);
            this.LblControlDN.Name = "LblControlDN";
            this.LblControlDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlDN.TabIndex = 0;
            this.LblControlDN.Text = "C: XX / MP: XX";
            this.LblControlDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsADN
            // 
            this.LblMovsADN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsADN.ForeColor = System.Drawing.Color.White;
            this.LblMovsADN.Location = new System.Drawing.Point(48, 125);
            this.LblMovsADN.Name = "LblMovsADN";
            this.LblMovsADN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsADN.TabIndex = 105;
            this.LblMovsADN.Text = "XX / XXXXX";
            this.LblMovsADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsADN, "Número Movs / Último Mov");
            // 
            // LblControlADN
            // 
            this.LblControlADN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlADN.ForeColor = System.Drawing.Color.White;
            this.LblControlADN.Location = new System.Drawing.Point(48, 111);
            this.LblControlADN.Name = "LblControlADN";
            this.LblControlADN.Size = new System.Drawing.Size(92, 12);
            this.LblControlADN.TabIndex = 0;
            this.LblControlADN.Text = "C: XX / MP: XX";
            this.LblControlADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlADN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsCDN
            // 
            this.LblMovsCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsCDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsCDN.Location = new System.Drawing.Point(48, 79);
            this.LblMovsCDN.Name = "LblMovsCDN";
            this.LblMovsCDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsCDN.TabIndex = 0;
            this.LblMovsCDN.Text = "XX / XXXXX";
            this.LblMovsCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsCDN, "Número Movs / Último Mov");
            // 
            // LblControlCDN
            // 
            this.LblControlCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlCDN.ForeColor = System.Drawing.Color.White;
            this.LblControlCDN.Location = new System.Drawing.Point(48, 65);
            this.LblControlCDN.Name = "LblControlCDN";
            this.LblControlCDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlCDN.TabIndex = 0;
            this.LblControlCDN.Text = "C: XX / MP: XX";
            this.LblControlCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlCDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsTDN
            // 
            this.LblMovsTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsTDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsTDN.Location = new System.Drawing.Point(48, 33);
            this.LblMovsTDN.Name = "LblMovsTDN";
            this.LblMovsTDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsTDN.TabIndex = 0;
            this.LblMovsTDN.Text = "XX / XXXXX";
            this.LblMovsTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsTDN, "Número Movs / Último Mov");
            // 
            // LblControlTDN
            // 
            this.LblControlTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlTDN.ForeColor = System.Drawing.Color.White;
            this.LblControlTDN.Location = new System.Drawing.Point(48, 19);
            this.LblControlTDN.Name = "LblControlTDN";
            this.LblControlTDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlTDN.TabIndex = 0;
            this.LblControlTDN.Text = "C: XX / MP: XX";
            this.LblControlTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlTDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPTRN
            // 
            this.LblMovsPTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPTRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPTRN.Location = new System.Drawing.Point(48, 355);
            this.LblMovsPTRN.Name = "LblMovsPTRN";
            this.LblMovsPTRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPTRN.TabIndex = 0;
            this.LblMovsPTRN.Text = "XX / XXXXX";
            this.LblMovsPTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPTRN, "Número Movs / Último Mov");
            // 
            // LblControlPTRN
            // 
            this.LblControlPTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPTRN.ForeColor = System.Drawing.Color.White;
            this.LblControlPTRN.Location = new System.Drawing.Point(48, 341);
            this.LblControlPTRN.Name = "LblControlPTRN";
            this.LblControlPTRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPTRN.TabIndex = 0;
            this.LblControlPTRN.Text = "C: XX / MP: XX";
            this.LblControlPTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPTRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPCRN
            // 
            this.LblMovsPCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPCRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPCRN.Location = new System.Drawing.Point(48, 309);
            this.LblMovsPCRN.Name = "LblMovsPCRN";
            this.LblMovsPCRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPCRN.TabIndex = 0;
            this.LblMovsPCRN.Text = "XX / XXXXX";
            this.LblMovsPCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPCRN, "Número Movs / Último Mov");
            // 
            // LblControlPCRN
            // 
            this.LblControlPCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPCRN.ForeColor = System.Drawing.Color.White;
            this.LblControlPCRN.Location = new System.Drawing.Point(48, 295);
            this.LblControlPCRN.Name = "LblControlPCRN";
            this.LblControlPCRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPCRN.TabIndex = 0;
            this.LblControlPCRN.Text = "C: XX / MP: XX";
            this.LblControlPCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPCRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPARN
            // 
            this.LblMovsPARN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPARN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPARN.Location = new System.Drawing.Point(48, 263);
            this.LblMovsPARN.Name = "LblMovsPARN";
            this.LblMovsPARN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPARN.TabIndex = 0;
            this.LblMovsPARN.Text = "XX / XXXXX";
            this.LblMovsPARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPARN, "Número Movs / Último Mov");
            // 
            // LblControlPARN
            // 
            this.LblControlPARN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPARN.ForeColor = System.Drawing.Color.White;
            this.LblControlPARN.Location = new System.Drawing.Point(48, 249);
            this.LblControlPARN.Name = "LblControlPARN";
            this.LblControlPARN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPARN.TabIndex = 0;
            this.LblControlPARN.Text = "C: XX / MP: XX";
            this.LblControlPARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPARN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPRN
            // 
            this.LblMovsPRN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPRN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPRN.Location = new System.Drawing.Point(48, 217);
            this.LblMovsPRN.Name = "LblMovsPRN";
            this.LblMovsPRN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPRN.TabIndex = 0;
            this.LblMovsPRN.Text = "XX / XXXXX";
            this.LblMovsPRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPRN, "Número Movs / Último Mov");
            // 
            // LblControlPRN
            // 
            this.LblControlPRN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPRN.ForeColor = System.Drawing.Color.White;
            this.LblControlPRN.Location = new System.Drawing.Point(48, 203);
            this.LblControlPRN.Name = "LblControlPRN";
            this.LblControlPRN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPRN.TabIndex = 0;
            this.LblControlPRN.Text = "C: XX / MP: XX";
            this.LblControlPRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPRN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPDN
            // 
            this.LblMovsPDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPDN.Location = new System.Drawing.Point(48, 171);
            this.LblMovsPDN.Name = "LblMovsPDN";
            this.LblMovsPDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPDN.TabIndex = 0;
            this.LblMovsPDN.Text = "XX / XXXXX";
            this.LblMovsPDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPDN, "Número Movs / Último Mov");
            // 
            // LblControlPDN
            // 
            this.LblControlPDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPDN.ForeColor = System.Drawing.Color.White;
            this.LblControlPDN.Location = new System.Drawing.Point(48, 157);
            this.LblControlPDN.Name = "LblControlPDN";
            this.LblControlPDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPDN.TabIndex = 0;
            this.LblControlPDN.Text = "C: XX / MP: XX";
            this.LblControlPDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPADN
            // 
            this.LblMovsPADN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPADN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPADN.Location = new System.Drawing.Point(48, 125);
            this.LblMovsPADN.Name = "LblMovsPADN";
            this.LblMovsPADN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPADN.TabIndex = 0;
            this.LblMovsPADN.Text = "XX / XXXXX";
            this.LblMovsPADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPADN, "Número Movs / Último Mov");
            // 
            // LblControlPADN
            // 
            this.LblControlPADN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPADN.ForeColor = System.Drawing.Color.White;
            this.LblControlPADN.Location = new System.Drawing.Point(48, 111);
            this.LblControlPADN.Name = "LblControlPADN";
            this.LblControlPADN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPADN.TabIndex = 0;
            this.LblControlPADN.Text = "C: XX / MP: XX";
            this.LblControlPADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPADN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPCDN
            // 
            this.LblMovsPCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPCDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPCDN.Location = new System.Drawing.Point(48, 79);
            this.LblMovsPCDN.Name = "LblMovsPCDN";
            this.LblMovsPCDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPCDN.TabIndex = 0;
            this.LblMovsPCDN.Text = "XX / XXXXX";
            this.LblMovsPCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPCDN, "Número Movs / Último Mov");
            // 
            // LblControlPCDN
            // 
            this.LblControlPCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPCDN.ForeColor = System.Drawing.Color.White;
            this.LblControlPCDN.Location = new System.Drawing.Point(48, 65);
            this.LblControlPCDN.Name = "LblControlPCDN";
            this.LblControlPCDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPCDN.TabIndex = 0;
            this.LblControlPCDN.Text = "C: XX / MP: XX";
            this.LblControlPCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPCDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // LblMovsPTDN
            // 
            this.LblMovsPTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovsPTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovsPTDN.ForeColor = System.Drawing.Color.White;
            this.LblMovsPTDN.Location = new System.Drawing.Point(48, 33);
            this.LblMovsPTDN.Name = "LblMovsPTDN";
            this.LblMovsPTDN.Size = new System.Drawing.Size(92, 12);
            this.LblMovsPTDN.TabIndex = 0;
            this.LblMovsPTDN.Text = "XX / XXXXX";
            this.LblMovsPTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblMovsPTDN, "Número Movs / Último Mov");
            // 
            // LblControlPTDN
            // 
            this.LblControlPTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblControlPTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlPTDN.ForeColor = System.Drawing.Color.White;
            this.LblControlPTDN.Location = new System.Drawing.Point(48, 19);
            this.LblControlPTDN.Name = "LblControlPTDN";
            this.LblControlPTDN.Size = new System.Drawing.Size(92, 12);
            this.LblControlPTDN.TabIndex = 0;
            this.LblControlPTDN.Text = "C: XX / MP: XX";
            this.LblControlPTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.LblControlPTDN, "C: Casillas Controladas / MP: Movs Posibles");
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.NSGpbGeneral);
            this.NSTheme.Controls.Add(this.NSGpbGrafica);
            this.NSTheme.Controls.Add(this.NSGpbPiezas);
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
            this.NSTheme.Size = new System.Drawing.Size(620, 650);
            this.NSTheme.SmartBounds = true;
            this.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NSTheme.TabIndex = 0;
            this.NSTheme.Text = "Estadísticas";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LblCerrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.White;
            this.LblCerrar.Location = new System.Drawing.Point(593, 4);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(18, 18);
            this.LblCerrar.TabIndex = 0;
            this.LblCerrar.Text = "x";
            this.LblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // NSGpbGeneral
            // 
            this.NSGpbGeneral.Controls.Add(this.PnlNegras);
            this.NSGpbGeneral.Controls.Add(this.PnlBlancas);
            this.NSGpbGeneral.DrawSeperator = false;
            this.NSGpbGeneral.Location = new System.Drawing.Point(8, 36);
            this.NSGpbGeneral.Name = "NSGpbGeneral";
            this.NSGpbGeneral.Size = new System.Drawing.Size(205, 190);
            this.NSGpbGeneral.SubTitle = "";
            this.NSGpbGeneral.TabIndex = 0;
            this.NSGpbGeneral.Text = "General";
            this.NSGpbGeneral.Title = "General";
            // 
            // PnlNegras
            // 
            this.PnlNegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlNegras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNegras.Controls.Add(this.LblDEficaciaN);
            this.PnlNegras.Controls.Add(this.LblDMovilidadN);
            this.PnlNegras.Controls.Add(this.LblDDefensaN);
            this.PnlNegras.Controls.Add(this.LblDAtaqueN);
            this.PnlNegras.Controls.Add(this.LblMovilidadN);
            this.PnlNegras.Controls.Add(this.LblEficaciaN);
            this.PnlNegras.Controls.Add(this.LblAtaqueN);
            this.PnlNegras.Controls.Add(this.LblDefensaN);
            this.PnlNegras.Controls.Add(this.PbxNegras);
            this.PnlNegras.Location = new System.Drawing.Point(7, 109);
            this.PnlNegras.Name = "PnlNegras";
            this.PnlNegras.Size = new System.Drawing.Size(190, 75);
            this.PnlNegras.TabIndex = 0;
            // 
            // LblMovilidadN
            // 
            this.LblMovilidadN.BackColor = System.Drawing.Color.Transparent;
            this.LblMovilidadN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovilidadN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblMovilidadN.Location = new System.Drawing.Point(38, 39);
            this.LblMovilidadN.Name = "LblMovilidadN";
            this.LblMovilidadN.Size = new System.Drawing.Size(70, 12);
            this.LblMovilidadN.TabIndex = 0;
            this.LblMovilidadN.Text = "Movilidad:";
            this.LblMovilidadN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEficaciaN
            // 
            this.LblEficaciaN.BackColor = System.Drawing.Color.Transparent;
            this.LblEficaciaN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEficaciaN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblEficaciaN.Location = new System.Drawing.Point(108, 39);
            this.LblEficaciaN.Name = "LblEficaciaN";
            this.LblEficaciaN.Size = new System.Drawing.Size(70, 12);
            this.LblEficaciaN.TabIndex = 0;
            this.LblEficaciaN.Text = "Eficacia:";
            this.LblEficaciaN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAtaqueN
            // 
            this.LblAtaqueN.BackColor = System.Drawing.Color.Transparent;
            this.LblAtaqueN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtaqueN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAtaqueN.Location = new System.Drawing.Point(38, 4);
            this.LblAtaqueN.Name = "LblAtaqueN";
            this.LblAtaqueN.Size = new System.Drawing.Size(70, 12);
            this.LblAtaqueN.TabIndex = 0;
            this.LblAtaqueN.Text = "Ataque:";
            this.LblAtaqueN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDefensaN
            // 
            this.LblDefensaN.BackColor = System.Drawing.Color.Transparent;
            this.LblDefensaN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefensaN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDefensaN.Location = new System.Drawing.Point(108, 4);
            this.LblDefensaN.Name = "LblDefensaN";
            this.LblDefensaN.Size = new System.Drawing.Size(70, 12);
            this.LblDefensaN.TabIndex = 0;
            this.LblDefensaN.Text = "Defensa:";
            this.LblDefensaN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxNegras
            // 
            this.PbxNegras.BackColor = System.Drawing.Color.Goldenrod;
            this.PbxNegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxNegras.Location = new System.Drawing.Point(-1, -1);
            this.PbxNegras.Name = "PbxNegras";
            this.PbxNegras.Size = new System.Drawing.Size(25, 75);
            this.PbxNegras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxNegras.TabIndex = 61;
            this.PbxNegras.TabStop = false;
            this.PbxNegras.Tag = "";
            // 
            // PnlBlancas
            // 
            this.PnlBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlBlancas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBlancas.Controls.Add(this.LblDEficaciaB);
            this.PnlBlancas.Controls.Add(this.LblDMovilidadB);
            this.PnlBlancas.Controls.Add(this.LblDDefensaB);
            this.PnlBlancas.Controls.Add(this.LblDAtaqueB);
            this.PnlBlancas.Controls.Add(this.LblMovilidadB);
            this.PnlBlancas.Controls.Add(this.PbxBlancas);
            this.PnlBlancas.Controls.Add(this.LblEficaciaB);
            this.PnlBlancas.Controls.Add(this.LblAtaqueB);
            this.PnlBlancas.Controls.Add(this.LblDefensaB);
            this.PnlBlancas.Location = new System.Drawing.Point(7, 28);
            this.PnlBlancas.Name = "PnlBlancas";
            this.PnlBlancas.Size = new System.Drawing.Size(190, 75);
            this.PnlBlancas.TabIndex = 0;
            // 
            // LblMovilidadB
            // 
            this.LblMovilidadB.BackColor = System.Drawing.Color.Transparent;
            this.LblMovilidadB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovilidadB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblMovilidadB.Location = new System.Drawing.Point(38, 39);
            this.LblMovilidadB.Name = "LblMovilidadB";
            this.LblMovilidadB.Size = new System.Drawing.Size(70, 12);
            this.LblMovilidadB.TabIndex = 0;
            this.LblMovilidadB.Text = "Movilidad:";
            this.LblMovilidadB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxBlancas
            // 
            this.PbxBlancas.BackColor = System.Drawing.Color.White;
            this.PbxBlancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxBlancas.Location = new System.Drawing.Point(-1, -1);
            this.PbxBlancas.Name = "PbxBlancas";
            this.PbxBlancas.Size = new System.Drawing.Size(25, 75);
            this.PbxBlancas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBlancas.TabIndex = 61;
            this.PbxBlancas.TabStop = false;
            this.PbxBlancas.Tag = "";
            // 
            // LblEficaciaB
            // 
            this.LblEficaciaB.BackColor = System.Drawing.Color.Transparent;
            this.LblEficaciaB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEficaciaB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblEficaciaB.Location = new System.Drawing.Point(108, 39);
            this.LblEficaciaB.Name = "LblEficaciaB";
            this.LblEficaciaB.Size = new System.Drawing.Size(70, 12);
            this.LblEficaciaB.TabIndex = 0;
            this.LblEficaciaB.Text = "Eficacia:";
            this.LblEficaciaB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAtaqueB
            // 
            this.LblAtaqueB.BackColor = System.Drawing.Color.Transparent;
            this.LblAtaqueB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtaqueB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblAtaqueB.Location = new System.Drawing.Point(38, 4);
            this.LblAtaqueB.Name = "LblAtaqueB";
            this.LblAtaqueB.Size = new System.Drawing.Size(70, 12);
            this.LblAtaqueB.TabIndex = 0;
            this.LblAtaqueB.Text = "Ataque:";
            this.LblAtaqueB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDefensaB
            // 
            this.LblDefensaB.BackColor = System.Drawing.Color.Transparent;
            this.LblDefensaB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefensaB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblDefensaB.Location = new System.Drawing.Point(108, 4);
            this.LblDefensaB.Name = "LblDefensaB";
            this.LblDefensaB.Size = new System.Drawing.Size(70, 12);
            this.LblDefensaB.TabIndex = 0;
            this.LblDefensaB.Text = "Defensa:";
            this.LblDefensaB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NSGpbGrafica
            // 
            this.NSGpbGrafica.Controls.Add(this.NSRbtMovilidad);
            this.NSGpbGrafica.Controls.Add(this.NSRbtDefensa);
            this.NSGpbGrafica.Controls.Add(this.NSRbtAtaque);
            this.NSGpbGrafica.Controls.Add(this.ChrtAtaque);
            this.NSGpbGrafica.Controls.Add(this.ChrtDefensa);
            this.NSGpbGrafica.Controls.Add(this.ChrtMovilidad);
            this.NSGpbGrafica.DrawSeperator = false;
            this.NSGpbGrafica.Location = new System.Drawing.Point(219, 36);
            this.NSGpbGrafica.Name = "NSGpbGrafica";
            this.NSGpbGrafica.Size = new System.Drawing.Size(390, 190);
            this.NSGpbGrafica.SubTitle = "";
            this.NSGpbGrafica.TabIndex = 0;
            this.NSGpbGrafica.Text = "Gráfica";
            this.NSGpbGrafica.Title = "Gráfica";
            // 
            // NSRbtMovilidad
            // 
            this.NSRbtMovilidad.Checked = false;
            this.NSRbtMovilidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtMovilidad.Location = new System.Drawing.Point(268, 3);
            this.NSRbtMovilidad.Name = "NSRbtMovilidad";
            this.NSRbtMovilidad.Size = new System.Drawing.Size(80, 23);
            this.NSRbtMovilidad.TabIndex = 3;
            this.NSRbtMovilidad.Text = "Movilidad";
            this.NSRbtMovilidad.Click += new System.EventHandler(this.NSRbtGrafica_Click);
            // 
            // NSRbtDefensa
            // 
            this.NSRbtDefensa.Checked = false;
            this.NSRbtDefensa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtDefensa.Location = new System.Drawing.Point(192, 3);
            this.NSRbtDefensa.Name = "NSRbtDefensa";
            this.NSRbtDefensa.Size = new System.Drawing.Size(70, 23);
            this.NSRbtDefensa.TabIndex = 2;
            this.NSRbtDefensa.Text = "Defensa";
            this.NSRbtDefensa.Click += new System.EventHandler(this.NSRbtGrafica_Click);
            // 
            // NSRbtAtaque
            // 
            this.NSRbtAtaque.Checked = true;
            this.NSRbtAtaque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtAtaque.Location = new System.Drawing.Point(116, 3);
            this.NSRbtAtaque.Name = "NSRbtAtaque";
            this.NSRbtAtaque.Size = new System.Drawing.Size(70, 23);
            this.NSRbtAtaque.TabIndex = 1;
            this.NSRbtAtaque.Text = "Ataque";
            this.NSRbtAtaque.Click += new System.EventHandler(this.NSRbtGrafica_Click);
            // 
            // ChrtAtaque
            // 
            this.ChrtAtaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChrtArea";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.ChrtAtaque.ChartAreas.Add(chartArea1);
            this.ChrtAtaque.Location = new System.Drawing.Point(3, 28);
            this.ChrtAtaque.Name = "ChrtAtaque";
            this.ChrtAtaque.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChrtAtaque.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Goldenrod};
            series1.BorderWidth = 3;
            series1.ChartArea = "ChrtArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "SerieB";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChrtArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Name = "SerieN";
            this.ChrtAtaque.Series.Add(series1);
            this.ChrtAtaque.Series.Add(series2);
            this.ChrtAtaque.Size = new System.Drawing.Size(380, 160);
            this.ChrtAtaque.TabIndex = 0;
            this.ChrtAtaque.Text = "Ataque";
            // 
            // ChrtDefensa
            // 
            this.ChrtDefensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Gray;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChrtArea";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.ChrtDefensa.ChartAreas.Add(chartArea2);
            this.ChrtDefensa.Location = new System.Drawing.Point(3, 28);
            this.ChrtDefensa.Name = "ChrtDefensa";
            this.ChrtDefensa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChrtDefensa.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Goldenrod};
            series3.BorderWidth = 3;
            series3.ChartArea = "ChrtArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Name = "SerieN";
            series3.YValuesPerPoint = 2;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChrtArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Name = "SerieB";
            series4.YValuesPerPoint = 2;
            this.ChrtDefensa.Series.Add(series3);
            this.ChrtDefensa.Series.Add(series4);
            this.ChrtDefensa.Size = new System.Drawing.Size(380, 160);
            this.ChrtDefensa.TabIndex = 0;
            this.ChrtDefensa.Text = "Defensa";
            this.ChrtDefensa.Visible = false;
            // 
            // ChrtMovilidad
            // 
            this.ChrtMovilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.IsLabelAutoFit = false;
            chartArea3.AxisX2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.IsLabelAutoFit = false;
            chartArea3.AxisY2.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Gray;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChrtArea";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.ChrtMovilidad.ChartAreas.Add(chartArea3);
            this.ChrtMovilidad.Location = new System.Drawing.Point(3, 28);
            this.ChrtMovilidad.Name = "ChrtMovilidad";
            this.ChrtMovilidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChrtMovilidad.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Goldenrod};
            series5.BorderWidth = 3;
            series5.ChartArea = "ChrtArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Name = "SerieB";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChrtArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Name = "SerieN";
            this.ChrtMovilidad.Series.Add(series5);
            this.ChrtMovilidad.Series.Add(series6);
            this.ChrtMovilidad.Size = new System.Drawing.Size(380, 160);
            this.ChrtMovilidad.TabIndex = 0;
            this.ChrtMovilidad.Text = "Movilidad";
            this.ChrtMovilidad.Visible = false;
            // 
            // NSGpbPiezas
            // 
            this.NSGpbPiezas.Controls.Add(this.PnlPiezasMayorB);
            this.NSGpbPiezas.Controls.Add(this.PnlPiezasMenorB);
            this.NSGpbPiezas.Controls.Add(this.PnlPiezasMayorN);
            this.NSGpbPiezas.Controls.Add(this.PnlPiezasMenorN);
            this.NSGpbPiezas.DrawSeperator = false;
            this.NSGpbPiezas.Location = new System.Drawing.Point(8, 232);
            this.NSGpbPiezas.Name = "NSGpbPiezas";
            this.NSGpbPiezas.Size = new System.Drawing.Size(600, 410);
            this.NSGpbPiezas.SubTitle = "";
            this.NSGpbPiezas.TabIndex = 0;
            this.NSGpbPiezas.Text = "Piezas";
            this.NSGpbPiezas.Title = "Piezas";
            // 
            // PnlPiezasMayorB
            // 
            this.PnlPiezasMayorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PnlPiezasMayorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsTRB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxTorreRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlTRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreTRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsCRB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxCaballoRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlCRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreCRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsARB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxAlfilRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlARB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreARB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsRB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxReyB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreRB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsDB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxDamaB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsADB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxAlfilDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlADB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreADB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsCDB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxCaballoDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlCDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreCDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblMovsTDB);
            this.PnlPiezasMayorB.Controls.Add(this.PbxTorreDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblControlTDB);
            this.PnlPiezasMayorB.Controls.Add(this.LblNombreTDB);
            this.PnlPiezasMayorB.Location = new System.Drawing.Point(7, 29);
            this.PnlPiezasMayorB.Name = "PnlPiezasMayorB";
            this.PnlPiezasMayorB.Size = new System.Drawing.Size(145, 375);
            this.PnlPiezasMayorB.TabIndex = 0;
            // 
            // PbxTorreRB
            // 
            this.PbxTorreRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxTorreRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxTorreRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxTorreRB.Image = global::UAChess.Properties.Resources.PzTorreB;
            this.PbxTorreRB.Location = new System.Drawing.Point(3, 327);
            this.PbxTorreRB.Name = "PbxTorreRB";
            this.PbxTorreRB.Size = new System.Drawing.Size(40, 40);
            this.PbxTorreRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTorreRB.TabIndex = 122;
            this.PbxTorreRB.TabStop = false;
            this.PbxTorreRB.Tag = "";
            // 
            // LblNombreTRB
            // 
            this.LblNombreTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreTRB.Location = new System.Drawing.Point(48, 327);
            this.LblNombreTRB.Name = "LblNombreTRB";
            this.LblNombreTRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreTRB.TabIndex = 0;
            this.LblNombreTRB.Text = "Torre R (X,X)";
            this.LblNombreTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxCaballoRB
            // 
            this.PbxCaballoRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxCaballoRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCaballoRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxCaballoRB.Image = global::UAChess.Properties.Resources.PzCaballoB;
            this.PbxCaballoRB.Location = new System.Drawing.Point(3, 281);
            this.PbxCaballoRB.Name = "PbxCaballoRB";
            this.PbxCaballoRB.Size = new System.Drawing.Size(40, 40);
            this.PbxCaballoRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCaballoRB.TabIndex = 118;
            this.PbxCaballoRB.TabStop = false;
            this.PbxCaballoRB.Tag = "";
            // 
            // LblNombreCRB
            // 
            this.LblNombreCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreCRB.Location = new System.Drawing.Point(48, 281);
            this.LblNombreCRB.Name = "LblNombreCRB";
            this.LblNombreCRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreCRB.TabIndex = 0;
            this.LblNombreCRB.Text = "Caballo R (X,X)";
            this.LblNombreCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxAlfilRB
            // 
            this.PbxAlfilRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxAlfilRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxAlfilRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlfilRB.Image = global::UAChess.Properties.Resources.PzAlfilB;
            this.PbxAlfilRB.Location = new System.Drawing.Point(3, 235);
            this.PbxAlfilRB.Name = "PbxAlfilRB";
            this.PbxAlfilRB.Size = new System.Drawing.Size(40, 40);
            this.PbxAlfilRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlfilRB.TabIndex = 114;
            this.PbxAlfilRB.TabStop = false;
            this.PbxAlfilRB.Tag = "";
            // 
            // LblNombreARB
            // 
            this.LblNombreARB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreARB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreARB.Location = new System.Drawing.Point(48, 235);
            this.LblNombreARB.Name = "LblNombreARB";
            this.LblNombreARB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreARB.TabIndex = 0;
            this.LblNombreARB.Text = "Alfil R (X,X)";
            this.LblNombreARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxReyB
            // 
            this.PbxReyB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxReyB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxReyB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxReyB.Image = global::UAChess.Properties.Resources.PzReyB;
            this.PbxReyB.Location = new System.Drawing.Point(3, 189);
            this.PbxReyB.Name = "PbxReyB";
            this.PbxReyB.Size = new System.Drawing.Size(40, 40);
            this.PbxReyB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxReyB.TabIndex = 110;
            this.PbxReyB.TabStop = false;
            this.PbxReyB.Tag = "";
            // 
            // LblNombreRB
            // 
            this.LblNombreRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreRB.Location = new System.Drawing.Point(48, 189);
            this.LblNombreRB.Name = "LblNombreRB";
            this.LblNombreRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreRB.TabIndex = 0;
            this.LblNombreRB.Text = "Rey (X,X)";
            this.LblNombreRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxDamaB
            // 
            this.PbxDamaB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxDamaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxDamaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxDamaB.Image = global::UAChess.Properties.Resources.PzDamaB;
            this.PbxDamaB.Location = new System.Drawing.Point(3, 143);
            this.PbxDamaB.Name = "PbxDamaB";
            this.PbxDamaB.Size = new System.Drawing.Size(40, 40);
            this.PbxDamaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDamaB.TabIndex = 106;
            this.PbxDamaB.TabStop = false;
            this.PbxDamaB.Tag = "";
            // 
            // LblNombreDB
            // 
            this.LblNombreDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreDB.Location = new System.Drawing.Point(48, 143);
            this.LblNombreDB.Name = "LblNombreDB";
            this.LblNombreDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreDB.TabIndex = 0;
            this.LblNombreDB.Text = "Dama (X,X)";
            this.LblNombreDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxAlfilDB
            // 
            this.PbxAlfilDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxAlfilDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxAlfilDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlfilDB.Image = global::UAChess.Properties.Resources.PzAlfilB;
            this.PbxAlfilDB.Location = new System.Drawing.Point(3, 97);
            this.PbxAlfilDB.Name = "PbxAlfilDB";
            this.PbxAlfilDB.Size = new System.Drawing.Size(40, 40);
            this.PbxAlfilDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlfilDB.TabIndex = 102;
            this.PbxAlfilDB.TabStop = false;
            this.PbxAlfilDB.Tag = "";
            // 
            // LblNombreADB
            // 
            this.LblNombreADB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreADB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreADB.Location = new System.Drawing.Point(48, 97);
            this.LblNombreADB.Name = "LblNombreADB";
            this.LblNombreADB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreADB.TabIndex = 0;
            this.LblNombreADB.Text = "Alfil D (X,X)";
            this.LblNombreADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxCaballoDB
            // 
            this.PbxCaballoDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxCaballoDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCaballoDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxCaballoDB.Image = global::UAChess.Properties.Resources.PzCaballoB;
            this.PbxCaballoDB.Location = new System.Drawing.Point(3, 51);
            this.PbxCaballoDB.Name = "PbxCaballoDB";
            this.PbxCaballoDB.Size = new System.Drawing.Size(40, 40);
            this.PbxCaballoDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCaballoDB.TabIndex = 98;
            this.PbxCaballoDB.TabStop = false;
            this.PbxCaballoDB.Tag = "";
            // 
            // LblNombreCDB
            // 
            this.LblNombreCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreCDB.Location = new System.Drawing.Point(48, 51);
            this.LblNombreCDB.Name = "LblNombreCDB";
            this.LblNombreCDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreCDB.TabIndex = 0;
            this.LblNombreCDB.Text = "Caballo D (X,X)";
            this.LblNombreCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxTorreDB
            // 
            this.PbxTorreDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxTorreDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxTorreDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxTorreDB.Image = global::UAChess.Properties.Resources.PzTorreB;
            this.PbxTorreDB.Location = new System.Drawing.Point(3, 5);
            this.PbxTorreDB.Name = "PbxTorreDB";
            this.PbxTorreDB.Size = new System.Drawing.Size(40, 40);
            this.PbxTorreDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTorreDB.TabIndex = 48;
            this.PbxTorreDB.TabStop = false;
            this.PbxTorreDB.Tag = "";
            // 
            // LblNombreTDB
            // 
            this.LblNombreTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreTDB.Location = new System.Drawing.Point(48, 5);
            this.LblNombreTDB.Name = "LblNombreTDB";
            this.LblNombreTDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombreTDB.TabIndex = 0;
            this.LblNombreTDB.Text = "Torre D (X,X)";
            this.LblNombreTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlPiezasMenorB
            // 
            this.PnlPiezasMenorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlPiezasMenorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPTRB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonTRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPTRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePTRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPCRB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonCRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPCRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePCRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPARB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonARB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPARB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePARB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPRB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePRB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPDB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPADB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonADB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPADB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePADB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPCDB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonCDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPCDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePCDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblMovsPTDB);
            this.PnlPiezasMenorB.Controls.Add(this.PbxPeonTDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblControlPTDB);
            this.PnlPiezasMenorB.Controls.Add(this.LblNombrePTDB);
            this.PnlPiezasMenorB.Location = new System.Drawing.Point(154, 29);
            this.PnlPiezasMenorB.Name = "PnlPiezasMenorB";
            this.PnlPiezasMenorB.Size = new System.Drawing.Size(145, 375);
            this.PnlPiezasMenorB.TabIndex = 0;
            // 
            // PbxPeonTRB
            // 
            this.PbxPeonTRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonTRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonTRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonTRB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonTRB.Location = new System.Drawing.Point(3, 327);
            this.PbxPeonTRB.Name = "PbxPeonTRB";
            this.PbxPeonTRB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonTRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonTRB.TabIndex = 122;
            this.PbxPeonTRB.TabStop = false;
            this.PbxPeonTRB.Tag = "";
            // 
            // LblNombrePTRB
            // 
            this.LblNombrePTRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePTRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePTRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePTRB.Location = new System.Drawing.Point(48, 327);
            this.LblNombrePTRB.Name = "LblNombrePTRB";
            this.LblNombrePTRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePTRB.TabIndex = 0;
            this.LblNombrePTRB.Text = "Peón TR (X,X)";
            this.LblNombrePTRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonCRB
            // 
            this.PbxPeonCRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonCRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonCRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonCRB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonCRB.Location = new System.Drawing.Point(3, 281);
            this.PbxPeonCRB.Name = "PbxPeonCRB";
            this.PbxPeonCRB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonCRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonCRB.TabIndex = 118;
            this.PbxPeonCRB.TabStop = false;
            this.PbxPeonCRB.Tag = "";
            // 
            // LblNombrePCRB
            // 
            this.LblNombrePCRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePCRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePCRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePCRB.Location = new System.Drawing.Point(48, 281);
            this.LblNombrePCRB.Name = "LblNombrePCRB";
            this.LblNombrePCRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePCRB.TabIndex = 0;
            this.LblNombrePCRB.Text = "Peón CR (X,X)";
            this.LblNombrePCRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonARB
            // 
            this.PbxPeonARB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonARB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonARB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonARB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonARB.Location = new System.Drawing.Point(3, 235);
            this.PbxPeonARB.Name = "PbxPeonARB";
            this.PbxPeonARB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonARB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonARB.TabIndex = 114;
            this.PbxPeonARB.TabStop = false;
            this.PbxPeonARB.Tag = "";
            // 
            // LblNombrePARB
            // 
            this.LblNombrePARB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePARB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePARB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePARB.Location = new System.Drawing.Point(48, 235);
            this.LblNombrePARB.Name = "LblNombrePARB";
            this.LblNombrePARB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePARB.TabIndex = 0;
            this.LblNombrePARB.Text = "Peón AR (X,X)";
            this.LblNombrePARB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonRB
            // 
            this.PbxPeonRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonRB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonRB.Location = new System.Drawing.Point(3, 189);
            this.PbxPeonRB.Name = "PbxPeonRB";
            this.PbxPeonRB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonRB.TabIndex = 110;
            this.PbxPeonRB.TabStop = false;
            this.PbxPeonRB.Tag = "";
            // 
            // LblNombrePRB
            // 
            this.LblNombrePRB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePRB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePRB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePRB.Location = new System.Drawing.Point(48, 189);
            this.LblNombrePRB.Name = "LblNombrePRB";
            this.LblNombrePRB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePRB.TabIndex = 0;
            this.LblNombrePRB.Text = "Peón R (X,X)";
            this.LblNombrePRB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonDB
            // 
            this.PbxPeonDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonDB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonDB.Location = new System.Drawing.Point(3, 143);
            this.PbxPeonDB.Name = "PbxPeonDB";
            this.PbxPeonDB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonDB.TabIndex = 106;
            this.PbxPeonDB.TabStop = false;
            this.PbxPeonDB.Tag = "";
            // 
            // LblNombrePDB
            // 
            this.LblNombrePDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePDB.Location = new System.Drawing.Point(48, 143);
            this.LblNombrePDB.Name = "LblNombrePDB";
            this.LblNombrePDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePDB.TabIndex = 0;
            this.LblNombrePDB.Text = "Peón D (X,X)";
            this.LblNombrePDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonADB
            // 
            this.PbxPeonADB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonADB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonADB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonADB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonADB.Location = new System.Drawing.Point(3, 97);
            this.PbxPeonADB.Name = "PbxPeonADB";
            this.PbxPeonADB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonADB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonADB.TabIndex = 102;
            this.PbxPeonADB.TabStop = false;
            this.PbxPeonADB.Tag = "";
            // 
            // LblNombrePADB
            // 
            this.LblNombrePADB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePADB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePADB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePADB.Location = new System.Drawing.Point(48, 97);
            this.LblNombrePADB.Name = "LblNombrePADB";
            this.LblNombrePADB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePADB.TabIndex = 0;
            this.LblNombrePADB.Text = "Peón AD (X,X)";
            this.LblNombrePADB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonCDB
            // 
            this.PbxPeonCDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonCDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonCDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonCDB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonCDB.Location = new System.Drawing.Point(3, 51);
            this.PbxPeonCDB.Name = "PbxPeonCDB";
            this.PbxPeonCDB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonCDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonCDB.TabIndex = 98;
            this.PbxPeonCDB.TabStop = false;
            this.PbxPeonCDB.Tag = "";
            // 
            // LblNombrePCDB
            // 
            this.LblNombrePCDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePCDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePCDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePCDB.Location = new System.Drawing.Point(48, 51);
            this.LblNombrePCDB.Name = "LblNombrePCDB";
            this.LblNombrePCDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePCDB.TabIndex = 0;
            this.LblNombrePCDB.Text = "Peón CD (X,X)";
            this.LblNombrePCDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonTDB
            // 
            this.PbxPeonTDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxPeonTDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonTDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonTDB.Image = global::UAChess.Properties.Resources.PzPeonB;
            this.PbxPeonTDB.Location = new System.Drawing.Point(3, 5);
            this.PbxPeonTDB.Name = "PbxPeonTDB";
            this.PbxPeonTDB.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonTDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonTDB.TabIndex = 48;
            this.PbxPeonTDB.TabStop = false;
            this.PbxPeonTDB.Tag = "";
            // 
            // LblNombrePTDB
            // 
            this.LblNombrePTDB.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePTDB.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePTDB.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePTDB.Location = new System.Drawing.Point(48, 5);
            this.LblNombrePTDB.Name = "LblNombrePTDB";
            this.LblNombrePTDB.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePTDB.TabIndex = 0;
            this.LblNombrePTDB.Text = "Peón TD (X,X)";
            this.LblNombrePTDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlPiezasMayorN
            // 
            this.PnlPiezasMayorN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PnlPiezasMayorN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsTRN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxTorreRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlTRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreTRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsCRN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxCaballoRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlCRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreCRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsARN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxAlfilRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlARN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreARN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsRN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxReyN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreRN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsDN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxDamaN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsADN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxAlfilDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlADN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreADN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsCDN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxCaballoDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlCDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreCDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblMovsTDN);
            this.PnlPiezasMayorN.Controls.Add(this.PbxTorreDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblControlTDN);
            this.PnlPiezasMayorN.Controls.Add(this.LblNombreTDN);
            this.PnlPiezasMayorN.Location = new System.Drawing.Point(448, 29);
            this.PnlPiezasMayorN.Name = "PnlPiezasMayorN";
            this.PnlPiezasMayorN.Size = new System.Drawing.Size(145, 375);
            this.PnlPiezasMayorN.TabIndex = 0;
            // 
            // PbxTorreRN
            // 
            this.PbxTorreRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxTorreRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxTorreRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxTorreRN.Image = global::UAChess.Properties.Resources.PzTorreN;
            this.PbxTorreRN.Location = new System.Drawing.Point(3, 327);
            this.PbxTorreRN.Name = "PbxTorreRN";
            this.PbxTorreRN.Size = new System.Drawing.Size(40, 40);
            this.PbxTorreRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTorreRN.TabIndex = 122;
            this.PbxTorreRN.TabStop = false;
            this.PbxTorreRN.Tag = "";
            // 
            // LblNombreTRN
            // 
            this.LblNombreTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreTRN.Location = new System.Drawing.Point(48, 327);
            this.LblNombreTRN.Name = "LblNombreTRN";
            this.LblNombreTRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreTRN.TabIndex = 0;
            this.LblNombreTRN.Text = "Torre R (X,X)";
            this.LblNombreTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxCaballoRN
            // 
            this.PbxCaballoRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxCaballoRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCaballoRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxCaballoRN.Image = global::UAChess.Properties.Resources.PzCaballoN;
            this.PbxCaballoRN.Location = new System.Drawing.Point(3, 281);
            this.PbxCaballoRN.Name = "PbxCaballoRN";
            this.PbxCaballoRN.Size = new System.Drawing.Size(40, 40);
            this.PbxCaballoRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCaballoRN.TabIndex = 118;
            this.PbxCaballoRN.TabStop = false;
            this.PbxCaballoRN.Tag = "";
            // 
            // LblNombreCRN
            // 
            this.LblNombreCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreCRN.Location = new System.Drawing.Point(48, 281);
            this.LblNombreCRN.Name = "LblNombreCRN";
            this.LblNombreCRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreCRN.TabIndex = 0;
            this.LblNombreCRN.Text = "Caballo R (X,X)";
            this.LblNombreCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxAlfilRN
            // 
            this.PbxAlfilRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxAlfilRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxAlfilRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlfilRN.Image = global::UAChess.Properties.Resources.PzAlfilN;
            this.PbxAlfilRN.Location = new System.Drawing.Point(3, 235);
            this.PbxAlfilRN.Name = "PbxAlfilRN";
            this.PbxAlfilRN.Size = new System.Drawing.Size(40, 40);
            this.PbxAlfilRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlfilRN.TabIndex = 114;
            this.PbxAlfilRN.TabStop = false;
            this.PbxAlfilRN.Tag = "";
            // 
            // LblNombreARN
            // 
            this.LblNombreARN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreARN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreARN.Location = new System.Drawing.Point(48, 235);
            this.LblNombreARN.Name = "LblNombreARN";
            this.LblNombreARN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreARN.TabIndex = 0;
            this.LblNombreARN.Text = "Alfil R (X,X)";
            this.LblNombreARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxReyN
            // 
            this.PbxReyN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxReyN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxReyN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxReyN.Image = global::UAChess.Properties.Resources.PzReyN;
            this.PbxReyN.Location = new System.Drawing.Point(3, 189);
            this.PbxReyN.Name = "PbxReyN";
            this.PbxReyN.Size = new System.Drawing.Size(40, 40);
            this.PbxReyN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxReyN.TabIndex = 110;
            this.PbxReyN.TabStop = false;
            this.PbxReyN.Tag = "";
            // 
            // LblNombreRN
            // 
            this.LblNombreRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreRN.Location = new System.Drawing.Point(48, 189);
            this.LblNombreRN.Name = "LblNombreRN";
            this.LblNombreRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreRN.TabIndex = 0;
            this.LblNombreRN.Text = "Rey (X,X)";
            this.LblNombreRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxDamaN
            // 
            this.PbxDamaN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxDamaN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxDamaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxDamaN.Image = global::UAChess.Properties.Resources.PzDamaN;
            this.PbxDamaN.Location = new System.Drawing.Point(3, 143);
            this.PbxDamaN.Name = "PbxDamaN";
            this.PbxDamaN.Size = new System.Drawing.Size(40, 40);
            this.PbxDamaN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDamaN.TabIndex = 106;
            this.PbxDamaN.TabStop = false;
            this.PbxDamaN.Tag = "";
            // 
            // LblNombreDN
            // 
            this.LblNombreDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreDN.Location = new System.Drawing.Point(48, 143);
            this.LblNombreDN.Name = "LblNombreDN";
            this.LblNombreDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreDN.TabIndex = 0;
            this.LblNombreDN.Text = "Dama (X,X)";
            this.LblNombreDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxAlfilDN
            // 
            this.PbxAlfilDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxAlfilDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxAlfilDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlfilDN.Image = global::UAChess.Properties.Resources.PzAlfilN;
            this.PbxAlfilDN.Location = new System.Drawing.Point(3, 97);
            this.PbxAlfilDN.Name = "PbxAlfilDN";
            this.PbxAlfilDN.Size = new System.Drawing.Size(40, 40);
            this.PbxAlfilDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlfilDN.TabIndex = 102;
            this.PbxAlfilDN.TabStop = false;
            this.PbxAlfilDN.Tag = "";
            // 
            // LblNombreADN
            // 
            this.LblNombreADN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreADN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreADN.Location = new System.Drawing.Point(48, 97);
            this.LblNombreADN.Name = "LblNombreADN";
            this.LblNombreADN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreADN.TabIndex = 0;
            this.LblNombreADN.Text = "Alfil D (X,X)";
            this.LblNombreADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxCaballoDN
            // 
            this.PbxCaballoDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxCaballoDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxCaballoDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxCaballoDN.Image = global::UAChess.Properties.Resources.PzCaballoN;
            this.PbxCaballoDN.Location = new System.Drawing.Point(3, 51);
            this.PbxCaballoDN.Name = "PbxCaballoDN";
            this.PbxCaballoDN.Size = new System.Drawing.Size(40, 40);
            this.PbxCaballoDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCaballoDN.TabIndex = 98;
            this.PbxCaballoDN.TabStop = false;
            this.PbxCaballoDN.Tag = "";
            // 
            // LblNombreCDN
            // 
            this.LblNombreCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreCDN.Location = new System.Drawing.Point(48, 51);
            this.LblNombreCDN.Name = "LblNombreCDN";
            this.LblNombreCDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreCDN.TabIndex = 0;
            this.LblNombreCDN.Text = "Caballo D (X,X)";
            this.LblNombreCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxTorreDN
            // 
            this.PbxTorreDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PbxTorreDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxTorreDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxTorreDN.Image = global::UAChess.Properties.Resources.PzTorreN;
            this.PbxTorreDN.Location = new System.Drawing.Point(3, 5);
            this.PbxTorreDN.Name = "PbxTorreDN";
            this.PbxTorreDN.Size = new System.Drawing.Size(40, 40);
            this.PbxTorreDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTorreDN.TabIndex = 48;
            this.PbxTorreDN.TabStop = false;
            this.PbxTorreDN.Tag = "";
            // 
            // LblNombreTDN
            // 
            this.LblNombreTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombreTDN.Location = new System.Drawing.Point(48, 5);
            this.LblNombreTDN.Name = "LblNombreTDN";
            this.LblNombreTDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombreTDN.TabIndex = 0;
            this.LblNombreTDN.Text = "Torre D (X,X)";
            this.LblNombreTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlPiezasMenorN
            // 
            this.PnlPiezasMenorN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPTRN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonTRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPTRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePTRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPCRN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonCRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPCRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePCRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPARN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonARN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPARN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePARN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPRN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePRN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPDN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPADN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonADN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPADN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePADN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPCDN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonCDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPCDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePCDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblMovsPTDN);
            this.PnlPiezasMenorN.Controls.Add(this.PbxPeonTDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblControlPTDN);
            this.PnlPiezasMenorN.Controls.Add(this.LblNombrePTDN);
            this.PnlPiezasMenorN.Location = new System.Drawing.Point(301, 29);
            this.PnlPiezasMenorN.Name = "PnlPiezasMenorN";
            this.PnlPiezasMenorN.Size = new System.Drawing.Size(145, 375);
            this.PnlPiezasMenorN.TabIndex = 0;
            // 
            // PbxPeonTRN
            // 
            this.PbxPeonTRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonTRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonTRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonTRN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonTRN.Location = new System.Drawing.Point(3, 327);
            this.PbxPeonTRN.Name = "PbxPeonTRN";
            this.PbxPeonTRN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonTRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonTRN.TabIndex = 122;
            this.PbxPeonTRN.TabStop = false;
            this.PbxPeonTRN.Tag = "";
            // 
            // LblNombrePTRN
            // 
            this.LblNombrePTRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePTRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePTRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePTRN.Location = new System.Drawing.Point(48, 327);
            this.LblNombrePTRN.Name = "LblNombrePTRN";
            this.LblNombrePTRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePTRN.TabIndex = 0;
            this.LblNombrePTRN.Text = "Peón TR (X,X)";
            this.LblNombrePTRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonCRN
            // 
            this.PbxPeonCRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonCRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonCRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonCRN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonCRN.Location = new System.Drawing.Point(3, 281);
            this.PbxPeonCRN.Name = "PbxPeonCRN";
            this.PbxPeonCRN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonCRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonCRN.TabIndex = 118;
            this.PbxPeonCRN.TabStop = false;
            this.PbxPeonCRN.Tag = "";
            // 
            // LblNombrePCRN
            // 
            this.LblNombrePCRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePCRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePCRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePCRN.Location = new System.Drawing.Point(48, 281);
            this.LblNombrePCRN.Name = "LblNombrePCRN";
            this.LblNombrePCRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePCRN.TabIndex = 0;
            this.LblNombrePCRN.Text = "Peón CR (X,X)";
            this.LblNombrePCRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonARN
            // 
            this.PbxPeonARN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonARN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonARN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonARN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonARN.Location = new System.Drawing.Point(3, 235);
            this.PbxPeonARN.Name = "PbxPeonARN";
            this.PbxPeonARN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonARN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonARN.TabIndex = 114;
            this.PbxPeonARN.TabStop = false;
            this.PbxPeonARN.Tag = "";
            // 
            // LblNombrePARN
            // 
            this.LblNombrePARN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePARN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePARN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePARN.Location = new System.Drawing.Point(48, 235);
            this.LblNombrePARN.Name = "LblNombrePARN";
            this.LblNombrePARN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePARN.TabIndex = 0;
            this.LblNombrePARN.Text = "Peón AR (X,X)";
            this.LblNombrePARN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonRN
            // 
            this.PbxPeonRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonRN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonRN.Location = new System.Drawing.Point(3, 189);
            this.PbxPeonRN.Name = "PbxPeonRN";
            this.PbxPeonRN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonRN.TabIndex = 110;
            this.PbxPeonRN.TabStop = false;
            this.PbxPeonRN.Tag = "";
            // 
            // LblNombrePRN
            // 
            this.LblNombrePRN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePRN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePRN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePRN.Location = new System.Drawing.Point(48, 189);
            this.LblNombrePRN.Name = "LblNombrePRN";
            this.LblNombrePRN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePRN.TabIndex = 0;
            this.LblNombrePRN.Text = "Peón R (X,X)";
            this.LblNombrePRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonDN
            // 
            this.PbxPeonDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonDN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonDN.Location = new System.Drawing.Point(3, 143);
            this.PbxPeonDN.Name = "PbxPeonDN";
            this.PbxPeonDN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonDN.TabIndex = 106;
            this.PbxPeonDN.TabStop = false;
            this.PbxPeonDN.Tag = "";
            // 
            // LblNombrePDN
            // 
            this.LblNombrePDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePDN.Location = new System.Drawing.Point(48, 143);
            this.LblNombrePDN.Name = "LblNombrePDN";
            this.LblNombrePDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePDN.TabIndex = 0;
            this.LblNombrePDN.Text = "Peón D (X,X)";
            this.LblNombrePDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonADN
            // 
            this.PbxPeonADN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonADN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonADN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonADN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonADN.Location = new System.Drawing.Point(3, 97);
            this.PbxPeonADN.Name = "PbxPeonADN";
            this.PbxPeonADN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonADN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonADN.TabIndex = 102;
            this.PbxPeonADN.TabStop = false;
            this.PbxPeonADN.Tag = "";
            // 
            // LblNombrePADN
            // 
            this.LblNombrePADN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePADN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePADN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePADN.Location = new System.Drawing.Point(48, 97);
            this.LblNombrePADN.Name = "LblNombrePADN";
            this.LblNombrePADN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePADN.TabIndex = 0;
            this.LblNombrePADN.Text = "Peón AD (X,X)";
            this.LblNombrePADN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonCDN
            // 
            this.PbxPeonCDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonCDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonCDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonCDN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonCDN.Location = new System.Drawing.Point(3, 51);
            this.PbxPeonCDN.Name = "PbxPeonCDN";
            this.PbxPeonCDN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonCDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonCDN.TabIndex = 98;
            this.PbxPeonCDN.TabStop = false;
            this.PbxPeonCDN.Tag = "";
            // 
            // LblNombrePCDN
            // 
            this.LblNombrePCDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePCDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePCDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePCDN.Location = new System.Drawing.Point(48, 51);
            this.LblNombrePCDN.Name = "LblNombrePCDN";
            this.LblNombrePCDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePCDN.TabIndex = 0;
            this.LblNombrePCDN.Text = "Peón CD (X,X)";
            this.LblNombrePCDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxPeonTDN
            // 
            this.PbxPeonTDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PbxPeonTDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPeonTDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPeonTDN.Image = global::UAChess.Properties.Resources.PzPeonN;
            this.PbxPeonTDN.Location = new System.Drawing.Point(3, 5);
            this.PbxPeonTDN.Name = "PbxPeonTDN";
            this.PbxPeonTDN.Size = new System.Drawing.Size(40, 40);
            this.PbxPeonTDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPeonTDN.TabIndex = 48;
            this.PbxPeonTDN.TabStop = false;
            this.PbxPeonTDN.Tag = "";
            // 
            // LblNombrePTDN
            // 
            this.LblNombrePTDN.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePTDN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePTDN.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblNombrePTDN.Location = new System.Drawing.Point(48, 5);
            this.LblNombrePTDN.Name = "LblNombrePTDN";
            this.LblNombrePTDN.Size = new System.Drawing.Size(92, 12);
            this.LblNombrePTDN.TabIndex = 0;
            this.LblNombrePTDN.Text = "Peón TD (X,X)";
            this.LblNombrePTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Estadísticas";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "ESTADÍS.";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 650);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.Shown += new System.EventHandler(this.FrmEstadisticas_Shown);
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            this.NSGpbGeneral.ResumeLayout(false);
            this.PnlNegras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxNegras)).EndInit();
            this.PnlBlancas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlancas)).EndInit();
            this.NSGpbGrafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtDefensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtMovilidad)).EndInit();
            this.NSGpbPiezas.ResumeLayout(false);
            this.PnlPiezasMayorB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxReyB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDamaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreDB)).EndInit();
            this.PnlPiezasMenorB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonARB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonADB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTDB)).EndInit();
            this.PnlPiezasMayorN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxReyN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDamaN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlfilDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaballoDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTorreDN)).EndInit();
            this.PnlPiezasMenorN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonARN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonADN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonCDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPeonTDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private System.Windows.Forms.PictureBox PbxTorreDB;
        private System.Windows.Forms.Label LblNombreTDB;
        private System.Windows.Forms.Label LblControlTDB;
        private System.Windows.Forms.Panel PnlPiezasMayorB;
        private System.Windows.Forms.Label LblMovsTDB;
        private System.Windows.Forms.Panel PnlPiezasMayorN;
        private System.Windows.Forms.Label LblMovsTRN;
        private System.Windows.Forms.PictureBox PbxTorreRN;
        private System.Windows.Forms.Label LblControlTRN;
        private System.Windows.Forms.Label LblNombreTRN;
        private System.Windows.Forms.Label LblMovsCRN;
        private System.Windows.Forms.PictureBox PbxCaballoRN;
        private System.Windows.Forms.Label LblControlCRN;
        private System.Windows.Forms.Label LblNombreCRN;
        private System.Windows.Forms.Label LblMovsARN;
        private System.Windows.Forms.PictureBox PbxAlfilRN;
        private System.Windows.Forms.Label LblControlARN;
        private System.Windows.Forms.Label LblNombreARN;
        private System.Windows.Forms.Label LblMovsRN;
        private System.Windows.Forms.PictureBox PbxReyN;
        private System.Windows.Forms.Label LblControlRN;
        private System.Windows.Forms.Label LblNombreRN;
        private System.Windows.Forms.Label LblMovsDN;
        private System.Windows.Forms.PictureBox PbxDamaN;
        private System.Windows.Forms.Label LblControlDN;
        private System.Windows.Forms.Label LblNombreDN;
        private System.Windows.Forms.Label LblMovsADN;
        private System.Windows.Forms.PictureBox PbxAlfilDN;
        private System.Windows.Forms.Label LblControlADN;
        private System.Windows.Forms.Label LblNombreADN;
        private System.Windows.Forms.Label LblMovsCDN;
        private System.Windows.Forms.PictureBox PbxCaballoDN;
        private System.Windows.Forms.Label LblControlCDN;
        private System.Windows.Forms.Label LblNombreCDN;
        private System.Windows.Forms.Label LblMovsTDN;
        private System.Windows.Forms.PictureBox PbxTorreDN;
        private System.Windows.Forms.Label LblControlTDN;
        private System.Windows.Forms.Label LblNombreTDN;
        private System.Windows.Forms.Panel PnlPiezasMenorN;
        private System.Windows.Forms.Label LblMovsPTRN;
        private System.Windows.Forms.PictureBox PbxPeonTRN;
        private System.Windows.Forms.Label LblControlPTRN;
        private System.Windows.Forms.Label LblNombrePTRN;
        private System.Windows.Forms.Label LblMovsPCRN;
        private System.Windows.Forms.PictureBox PbxPeonCRN;
        private System.Windows.Forms.Label LblControlPCRN;
        private System.Windows.Forms.Label LblNombrePCRN;
        private System.Windows.Forms.Label LblMovsPARN;
        private System.Windows.Forms.PictureBox PbxPeonARN;
        private System.Windows.Forms.Label LblControlPARN;
        private System.Windows.Forms.Label LblNombrePARN;
        private System.Windows.Forms.Label LblMovsPRN;
        private System.Windows.Forms.PictureBox PbxPeonRN;
        private System.Windows.Forms.Label LblControlPRN;
        private System.Windows.Forms.Label LblNombrePRN;
        private System.Windows.Forms.Label LblMovsPDN;
        private System.Windows.Forms.PictureBox PbxPeonDN;
        private System.Windows.Forms.Label LblControlPDN;
        private System.Windows.Forms.Label LblNombrePDN;
        private System.Windows.Forms.Label LblMovsPADN;
        private System.Windows.Forms.PictureBox PbxPeonADN;
        private System.Windows.Forms.Label LblControlPADN;
        private System.Windows.Forms.Label LblNombrePADN;
        private System.Windows.Forms.Label LblMovsPCDN;
        private System.Windows.Forms.PictureBox PbxPeonCDN;
        private System.Windows.Forms.Label LblControlPCDN;
        private System.Windows.Forms.Label LblNombrePCDN;
        private System.Windows.Forms.Label LblMovsPTDN;
        private System.Windows.Forms.PictureBox PbxPeonTDN;
        private System.Windows.Forms.Label LblControlPTDN;
        private System.Windows.Forms.Label LblNombrePTDN;
        private System.Windows.Forms.Panel PnlPiezasMenorB;
        private System.Windows.Forms.Label LblMovsPTRB;
        private System.Windows.Forms.PictureBox PbxPeonTRB;
        private System.Windows.Forms.Label LblControlPTRB;
        private System.Windows.Forms.Label LblNombrePTRB;
        private System.Windows.Forms.Label LblMovsPCRB;
        private System.Windows.Forms.PictureBox PbxPeonCRB;
        private System.Windows.Forms.Label LblControlPCRB;
        private System.Windows.Forms.Label LblNombrePCRB;
        private System.Windows.Forms.Label LblMovsPARB;
        private System.Windows.Forms.PictureBox PbxPeonARB;
        private System.Windows.Forms.Label LblControlPARB;
        private System.Windows.Forms.Label LblNombrePARB;
        private System.Windows.Forms.Label LblMovsPRB;
        private System.Windows.Forms.PictureBox PbxPeonRB;
        private System.Windows.Forms.Label LblControlPRB;
        private System.Windows.Forms.Label LblNombrePRB;
        private System.Windows.Forms.Label LblMovsPDB;
        private System.Windows.Forms.PictureBox PbxPeonDB;
        private System.Windows.Forms.Label LblControlPDB;
        private System.Windows.Forms.Label LblNombrePDB;
        private System.Windows.Forms.Label LblMovsPADB;
        private System.Windows.Forms.PictureBox PbxPeonADB;
        private System.Windows.Forms.Label LblControlPADB;
        private System.Windows.Forms.Label LblNombrePADB;
        private System.Windows.Forms.Label LblMovsPCDB;
        private System.Windows.Forms.PictureBox PbxPeonCDB;
        private System.Windows.Forms.Label LblControlPCDB;
        private System.Windows.Forms.Label LblNombrePCDB;
        private System.Windows.Forms.Label LblMovsPTDB;
        private System.Windows.Forms.PictureBox PbxPeonTDB;
        private System.Windows.Forms.Label LblControlPTDB;
        private System.Windows.Forms.Label LblNombrePTDB;
        private System.Windows.Forms.Label LblMovsTRB;
        private System.Windows.Forms.PictureBox PbxTorreRB;
        private System.Windows.Forms.Label LblControlTRB;
        private System.Windows.Forms.Label LblNombreTRB;
        private System.Windows.Forms.Label LblMovsCRB;
        private System.Windows.Forms.PictureBox PbxCaballoRB;
        private System.Windows.Forms.Label LblControlCRB;
        private System.Windows.Forms.Label LblNombreCRB;
        private System.Windows.Forms.Label LblMovsARB;
        private System.Windows.Forms.PictureBox PbxAlfilRB;
        private System.Windows.Forms.Label LblControlARB;
        private System.Windows.Forms.Label LblNombreARB;
        private System.Windows.Forms.Label LblMovsRB;
        private System.Windows.Forms.PictureBox PbxReyB;
        private System.Windows.Forms.Label LblControlRB;
        private System.Windows.Forms.Label LblNombreRB;
        private System.Windows.Forms.Label LblMovsDB;
        private System.Windows.Forms.PictureBox PbxDamaB;
        private System.Windows.Forms.Label LblControlDB;
        private System.Windows.Forms.Label LblNombreDB;
        private System.Windows.Forms.Label LblMovsADB;
        private System.Windows.Forms.PictureBox PbxAlfilDB;
        private System.Windows.Forms.Label LblControlADB;
        private System.Windows.Forms.Label LblNombreADB;
        private System.Windows.Forms.Label LblMovsCDB;
        private System.Windows.Forms.PictureBox PbxCaballoDB;
        private System.Windows.Forms.Label LblControlCDB;
        private System.Windows.Forms.Label LblNombreCDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtAtaque;
        private NSGroupBox NSGpbGeneral;
        private NSGroupBox NSGpbGrafica;
        private NSGroupBox NSGpbPiezas;
        private System.Windows.Forms.PictureBox PbxBlancas;
        private System.Windows.Forms.Label LblDefensaB;
        private System.Windows.Forms.Label LblAtaqueB;
        private System.Windows.Forms.Label LblMovilidadB;
        private System.Windows.Forms.Label LblEficaciaB;
        private System.Windows.Forms.Panel PnlBlancas;
        private System.Windows.Forms.Panel PnlNegras;
        private System.Windows.Forms.PictureBox PbxNegras;
        private System.Windows.Forms.Label LblDEficaciaB;
        private System.Windows.Forms.Label LblDMovilidadB;
        private System.Windows.Forms.Label LblDDefensaB;
        private System.Windows.Forms.Label LblDAtaqueB;
        private System.Windows.Forms.Label LblDEficaciaN;
        private System.Windows.Forms.Label LblDMovilidadN;
        private System.Windows.Forms.Label LblDDefensaN;
        private System.Windows.Forms.Label LblDAtaqueN;
        private System.Windows.Forms.Label LblMovilidadN;
        private System.Windows.Forms.Label LblEficaciaN;
        private System.Windows.Forms.Label LblAtaqueN;
        private System.Windows.Forms.Label LblDefensaN;
        private System.Windows.Forms.Label LblCerrar;
        private NSRadioButton NSRbtMovilidad;
        private NSRadioButton NSRbtDefensa;
        private NSRadioButton NSRbtAtaque;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtDefensa;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtMovilidad;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}