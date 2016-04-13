using System;
using System.Windows.Forms;
using UAChess.Clases;

namespace UAChess
{
    public partial class FrmBrazo : Form
    {
        Brazo arm;
        // Constructor
        // Construye form brazo
        public FrmBrazo()
        {
            // Componentes
            InitializeComponent();
            arm = new Brazo();
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void NSBtnRIzq_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.BASE, Brazo.NEGATIVE, 250);
        }

        private void NSBtnRDer_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.BASE, Brazo.POSITIVE, 250);
        }

        private void NSBtnA3Arriba_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.SHOULDER, Brazo.NEGATIVE, 250);
        }

        private void NSBtnA3Abajo_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.SHOULDER, Brazo.POSITIVE, 250);
        }

        private void NSBtnA2Arriba_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.ELBOW, Brazo.NEGATIVE, 250);
        }

        private void NSBtnA2Abajo_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.ELBOW, Brazo.POSITIVE, 250);
        }

        private void NSBtnA1Arriba_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.WRIST, Brazo.NEGATIVE, 250);
        }

        private void NSBtnA1Abajo_Click(object sender, EventArgs e)
        {
            arm.move(ArticulacionID.WRIST, Brazo.POSITIVE, 250);
        }

        private void NSBtnPAbrir_Click(object sender, EventArgs e)
        {
            arm.openGripper(true);
        }

        private void NSBtnRCerrar_Click(object sender, EventArgs e)
        {
            arm.openGripper(true);
        }
    }
}