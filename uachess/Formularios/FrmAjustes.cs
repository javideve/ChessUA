using System;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmAjustes : Form
    {
        // Constructor
        // Construye form ajustes
        public FrmAjustes()
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