using System;
using System.Windows.Forms;
using UAChess.Clases;

namespace UAChess
{
    public partial class FrmBrazo : Form
    {
        const int TIME = 250;
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
            arm.move(new Movimiento(ArticulacionID.BASE, Brazo.NEGATIVE, TIME));
        }
        private void NSBtnRDer_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.BASE, Brazo.POSITIVE, TIME));
        }

        private void NSBtnA3Arriba_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.SHOULDER, Brazo.NEGATIVE, TIME));
        }

        private void NSBtnA3Abajo_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.SHOULDER, Brazo.POSITIVE, TIME));
        }

        private void NSBtnA2Arriba_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.ELBOW, Brazo.NEGATIVE, TIME));
        }

        private void NSBtnA2Abajo_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.ELBOW, Brazo.POSITIVE, TIME));
        }

        private void NSBtnA1Arriba_Click(object sender, EventArgs e)
        {
            //arm.move(new Movimiento(ArticulacionID.WRIST, Brazo.NEGATIVE, TIME));
            //arm.removePiece();
            
        }

        private void NSBtnA1Abajo_Click(object sender, EventArgs e)
        {
            //arm.move(new Movimiento(ArticulacionID.WRIST, Brazo.POSITIVE, TIME));
        }

        private void NSBtnPAbrir_Click(object sender, EventArgs e)
        {
            arm.openGripper(true);
        }

        private void NSBtnRCerrar_Click(object sender, EventArgs e)
        {
            arm.openGripper(true);
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            arm.moveToRow('A');
            arm.moveToRow('H');
        }

        private void nsButton2_Click(object sender, EventArgs e)
        {
            arm.moveToRow('B');
            arm.moveToRow('G');
        }

        private void nsButton3_Click(object sender, EventArgs e)
        {
            arm.moveToRow('C');
            arm.moveToRow('F');
        }

        private void nsButton4_Click(object sender, EventArgs e)
        {
            arm.moveToRow('D');
            arm.moveToRow('E');
        }
    }
}