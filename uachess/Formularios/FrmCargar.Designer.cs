namespace UAChess
{
    partial class FrmCargar
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
            NSListView.NSListViewColumnHeader nsListViewColumnHeader4 = new NSListView.NSListViewColumnHeader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargar));
            this.NSTheme = new NSTheme();
            this.NSRbtBBDD = new NSRadioButton();
            this.NSRbtVisor = new NSRadioButton();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.NSTxbBuscar = new NSTextBox();
            this.NSLvItems = new NSListView();
            this.NSBtnBuscar = new NSButton();
            this.NSLblTitulo = new NSLabel();
            this.NSTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // NSTheme
            // 
            this.NSTheme.AccentOffset = 0;
            this.NSTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NSTheme.Colors = new Bloom[0];
            this.NSTheme.Controls.Add(this.NSRbtBBDD);
            this.NSTheme.Controls.Add(this.NSRbtVisor);
            this.NSTheme.Controls.Add(this.LblCerrar);
            this.NSTheme.Controls.Add(this.NSTxbBuscar);
            this.NSTheme.Controls.Add(this.NSLvItems);
            this.NSTheme.Controls.Add(this.NSBtnBuscar);
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
            this.NSTheme.Text = "Cargar";
            this.NSTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.NSTheme.Transparent = false;
            // 
            // NSRbtBBDD
            // 
            this.NSRbtBBDD.Checked = false;
            this.NSRbtBBDD.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtBBDD.Location = new System.Drawing.Point(82, 274);
            this.NSRbtBBDD.Name = "NSRbtBBDD";
            this.NSRbtBBDD.Size = new System.Drawing.Size(80, 23);
            this.NSRbtBBDD.TabIndex = 3;
            this.NSRbtBBDD.Text = "En BBDD";
            // 
            // NSRbtVisor
            // 
            this.NSRbtVisor.Checked = true;
            this.NSRbtVisor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSRbtVisor.Location = new System.Drawing.Point(7, 274);
            this.NSRbtVisor.Name = "NSRbtVisor";
            this.NSRbtVisor.Size = new System.Drawing.Size(72, 23);
            this.NSRbtVisor.TabIndex = 2;
            this.NSRbtVisor.Text = "En Visor";
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
            // NSTxbBuscar
            // 
            this.NSTxbBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSTxbBuscar.Location = new System.Drawing.Point(168, 274);
            this.NSTxbBuscar.MaxLength = 25;
            this.NSTxbBuscar.Multiline = false;
            this.NSTxbBuscar.Name = "NSTxbBuscar";
            this.NSTxbBuscar.ReadOnly = false;
            this.NSTxbBuscar.Size = new System.Drawing.Size(187, 23);
            this.NSTxbBuscar.TabIndex = 4;
            this.NSTxbBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSTxbBuscar.UseSystemPasswordChar = false;
            // 
            // NSLvItems
            // 
            nsListViewColumnHeader1.Text = "Nombre";
            nsListViewColumnHeader1.Width = 340;
            nsListViewColumnHeader2.Text = "Tipo";
            nsListViewColumnHeader2.Width = 80;
            nsListViewColumnHeader3.Text = "Num";
            nsListViewColumnHeader3.Width = 0;
            nsListViewColumnHeader4.Text = "Ruta";
            nsListViewColumnHeader4.Width = 0;
            this.NSLvItems.Columns = new NSListView.NSListViewColumnHeader[] {
        nsListViewColumnHeader1,
        nsListViewColumnHeader2,
        nsListViewColumnHeader3,
        nsListViewColumnHeader4};
            this.NSLvItems.Items = new NSListView.NSListViewItem[0];
            this.NSLvItems.Location = new System.Drawing.Point(8, 33);
            this.NSLvItems.MultiSelect = false;
            this.NSLvItems.Name = "NSLvItems";
            this.NSLvItems.Size = new System.Drawing.Size(433, 235);
            this.NSLvItems.TabIndex = 1;
            this.NSLvItems.Text = "NSLvItems";
            this.NSLvItems.DoubleClick += new System.EventHandler(this.NSLvItems_DoubleClick);
            // 
            // NSBtnBuscar
            // 
            this.NSBtnBuscar.Location = new System.Drawing.Point(361, 274);
            this.NSBtnBuscar.Name = "NSBtnBuscar";
            this.NSBtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NSBtnBuscar.Size = new System.Drawing.Size(80, 23);
            this.NSBtnBuscar.TabIndex = 5;
            this.NSBtnBuscar.Text = "Buscar PGN";
            this.NSBtnBuscar.Click += new System.EventHandler(this.NSBtnBuscar_Click);
            // 
            // NSLblTitulo
            // 
            this.NSLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSLblTitulo.Location = new System.Drawing.Point(4, 4);
            this.NSLblTitulo.Name = "NSLblTitulo";
            this.NSLblTitulo.Size = new System.Drawing.Size(75, 23);
            this.NSLblTitulo.TabIndex = 0;
            this.NSLblTitulo.Text = "Cargar";
            this.NSLblTitulo.Value1 = " ";
            this.NSLblTitulo.Value2 = "CARGAR";
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.NSTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar";
            this.VisibleChanged += new System.EventHandler(this.FrmCargar_VisibleChanged);
            this.NSTheme.ResumeLayout(false);
            this.NSTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme NSTheme;
        private NSLabel NSLblTitulo;
        private NSListView NSLvItems;
        private NSButton NSBtnBuscar;
        private NSTextBox NSTxbBuscar;
        private System.Windows.Forms.Label LblCerrar;
        private NSRadioButton NSRbtBBDD;
        private NSRadioButton NSRbtVisor;
    }
}