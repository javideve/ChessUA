using System;
using System.Windows.Forms;
using UAChess.Clases;
using System.Collections;

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
            arm.move(new Movimiento(ArticulacionID.WRIST, Brazo.NEGATIVE, TIME));
        }

        private void NSBtnA1Abajo_Click(object sender, EventArgs e)
        {
            arm.move(new Movimiento(ArticulacionID.WRIST, Brazo.POSITIVE, TIME));
        }

        private void NSBtnPAbrir_Click(object sender, EventArgs e)
        {
            arm.openGripper(true);
        }

        private void NSBtnRCerrar_Click(object sender, EventArgs e)
        {
            //arm.openGripper(false);
            arm.removePiece();
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            Movimiento basee, shoulder, elbow, wrist;
            int baseDir, hombroDir, codoDir, munecaDir, baseTime, hombroTime, codoTime, munecaTime;
            baseDir = (CBBaseDir.Checked) ? Brazo.NEGATIVE : Brazo.POSITIVE;
            hombroDir = (CBHombroDir.Checked) ? Brazo.NEGATIVE : Brazo.POSITIVE;
            codoDir = (CBCodoDir.Checked) ? Brazo.NEGATIVE : Brazo.POSITIVE;
            munecaDir = (CBMuñecaDir.Checked) ? Brazo.NEGATIVE : Brazo.POSITIVE;
            baseTime = int.Parse(TBBaseTime.Text);
            hombroTime = int.Parse(TBHombroTime.Text);
            codoTime = int.Parse(TBCodoTime.Text);
            munecaTime = int.Parse(TBMuñecaTime.Text);

            
            basee = new Movimiento(ArticulacionID.BASE, baseDir, baseTime);
            shoulder = new Movimiento(ArticulacionID.SHOULDER, hombroDir, hombroTime);
            elbow = new Movimiento(ArticulacionID.ELBOW, codoDir, codoTime);
            wrist = new Movimiento(ArticulacionID.WRIST, munecaDir, munecaTime);

            ArrayList movements;
            movements = new ArrayList();

            movements.Add(basee);
            movements.Add(shoulder);
            movements.Add(elbow);
            movements.Add(wrist);

            arm.moveTo(movements);
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