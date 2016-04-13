using System;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmCreditos : Form
    {
        // Constructor
        // Construye form creditos
        public FrmCreditos()
        {
            // Componentes
            InitializeComponent();
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}