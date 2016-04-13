using System;
using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmCPU : Form
    {
        # region Constantes

        // Tipo algoritmo
        public const int MINIMAX = 1;
        public const int ALFABETA = 2;
        public const int DAC = 3;

        # endregion

        # region Atributos

        // Motor

        // Algoritmo
        public static int algoritmo;

        // Tiempo min/max ejecucion
        public static int min, max;

        // Plies algoritmo
        public static int plies;

        // BBDD

        // BBDD
        public static int bbdd;
        public static bool bbddAc;

        // Jugador
        public static int jugador;

        // Elo
        public static int elo;

        // Fecha inicial/final
        public static string fechaI, fechaF;

        # endregion

        // Constructor
        // Construye form cpu
        public FrmCPU()
        {
            // Componentes
            InitializeComponent();

            // Motor

            // Algoritmo
            algoritmo = MINIMAX;
            
            // Tiempo min/max ejecucion
            min = 0; max = 3;

            // Plies algoritmo
            plies = 0;

            // BBDD

            // BBDD
            bbdd = -1;
            bbddAc = false;

            // Jugador
            jugador = 0;

            // Elo
            elo = 0;

            // Fecha inicial/final
            fechaI = "1800/01/01";
            fechaF = DateTime.Now.ToString("yyyy/MM/dd");
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // Evento mostrar formulario
        // Muestra configuracion de cpu en formulario
        private void FrmCPU_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                // Motor

                // Algoritmo
                NSCmbAlgoritmo.SelectedIndex = algoritmo;

                // Tiempo min/max ejecucion
                NSCmbMin.SelectedIndex = min;
                NSCmbMax.SelectedIndex = max;

                // Plies algoritmo
                NSTkbPlies.Value = plies;

                // BBDD

                // Boton bbdd
                if (bbddAc) { NSOobBBDD.Checked = true; } else
                if (!bbddAc) { NSOobBBDD.Checked = false; }

                // BBDD
                LblBBDD.BackColor = Color.Transparent;
                NSCmbBBDD.BackColor = Color.FromArgb(50, 50, 50);
                NSCmbBBDD.Items.Clear();

                ArrayList bbdds = Program.bbdd.ConsultaObtenerBDS();

                for (int i = 0; i < bbdds.Count; i++)
                {
                    NSCmbBBDD.Items.Add(bbdds[i]);
                }

                if (bbdd >= 0)
                {
                    NSCmbBBDD.SelectedIndex = bbdd;
                }

                // Jugador
                NSCmbJugador.Items.Clear();

                if (NSCmbBBDD.Text != null)
                {
                    NSCmbJugador.Items.Add("Todos");

                    ArrayList jugadores = Program.bbdd.ConsultaObtenerJugadores(NSCmbBBDD.Text);

                    for (int i = 0; i < jugadores.Count; i++)
                    {
                        NSCmbJugador.Items.Add(jugadores[i]);
                    }

                    NSCmbJugador.SelectedItem = NSCmbJugador.Items[0];
                }

                if (jugador >= 0)
                {
                    NSCmbJugador.SelectedIndex = jugador;
                }

                // Elo
                NSCmbElo.SelectedIndex = elo;

                // Fecha inicial
                LblFechaIni.BackColor = Color.Transparent;
                NSTxbFechaIni.BackColor = Color.FromArgb(50, 50, 50);
                NSTxbFechaIni.Text = fechaI;

                // Fecha final
                LblFechaFin.BackColor = Color.Transparent;
                NSTxbFechaFin.BackColor = Color.FromArgb(50, 50, 50);
                NSTxbFechaFin.Text = fechaF;
            }
        }

        // Evento cambio valor scroll
        // Muestra plies de cpu
        private void NSTkbPlies_Scroll(object sender)
        {
            LblNumPlies.Text = ": " + NSTkbPlies.Value;
        }

        // Evento activar/desactivar boton
        // Activa/desactiva uso de bbdd en cpu
        private void NSOobBBDD_CheckedChanged(object sender)
        {
            if (NSOobBBDD.Checked == true)
            {
                NSGpbBBDD.Enabled = true;
            }
            else if (NSOobBBDD.Checked == false)
            {
                NSGpbBBDD.Enabled = false;

                LblBBDD.BackColor = Color.Transparent;
                NSCmbBBDD.BackColor = Color.FromArgb(50, 50, 50);
                NSCmbBBDD.SelectedIndex = -1;

                NSCmbJugador.SelectedIndex = 0;

                LblFechaIni.BackColor = Color.Transparent;
                NSTxbFechaIni.BackColor = Color.FromArgb(50, 50, 50);
                NSTxbFechaIni.Text = "1800/01/01";

                LblFechaFin.BackColor = Color.Transparent;
                NSTxbFechaFin.BackColor = Color.FromArgb(50, 50, 50);
                NSTxbFechaFin.Text = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }

        // Evento cambio BBDD
        // Actualiza lista de jugadores de bbdd seleccionada
        private void NSCmbBBDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            NSCmbJugador.Items.Clear();
            NSCmbJugador.Items.Add("Todos");

            ArrayList jugadores = Program.bbdd.ConsultaObtenerJugadores(NSCmbBBDD.Text);

            for (int i = 0; i < jugadores.Count; i++)
            {
                NSCmbJugador.Items.Add(jugadores[i]);
            }

            NSCmbJugador.SelectedItem = NSCmbJugador.Items[0];
        }

        // Evento click boton guardar
        // Guarda la configuracion de cpu
        private void NSBtnGuardar_Click(object sender, EventArgs e)
        {
            FrmMensaje frmMensaje;

            if (Validar())
            {
                // Motor

                // Algoritmo
                algoritmo = NSCmbAlgoritmo.SelectedIndex;

                // Tiempo min/max ejecucion
                min = NSCmbMin.SelectedIndex;
                max = NSCmbMax.SelectedIndex;

                // Plies algoritmo
                plies = NSTkbPlies.Value;

                // BBDD

                if (NSOobBBDD.Checked)
                {
                    // BBDD
                    bbdd = NSCmbBBDD.SelectedIndex;
                    bbddAc = true;

                    // Jugador
                    jugador = NSCmbJugador.SelectedIndex;

                    // Elo
                    elo = NSCmbElo.SelectedIndex;

                    // Fecha inicial/final
                    fechaI = NSTxbFechaIni.Text;
                    fechaF = NSTxbFechaFin.Text;
                }
                else
                {
                    // BBDD
                    bbdd = -1;
                    bbddAc = false;

                    // Jugador
                    jugador = -1;

                    // Elo
                    elo = 0;

                    // Fecha inicial/final
                    fechaI = "1800/01/01";
                    fechaF = DateTime.Now.ToString("yyyy/MM/dd");
                }

                // Mostrar mensaje
                frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Datos guardados con éxito.");
                frmMensaje.ShowDialog();

                Close();
            }
            else
            {
                // Mostrar mensaje error
                frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible guardar datos."
                    + Environment.NewLine + "Corrija los campos erroneos marcados.");

                frmMensaje.ShowDialog();
            }
        }

        // Metodo Validar
        // Valida los campos del formulario
        private bool Validar()
        {
            bool validar = true;

            // BBDD
            if ((NSCmbBBDD.Text != "" && NSOobBBDD.Checked) || !NSOobBBDD.Checked)
            {
                LblBBDD.BackColor = Color.Transparent;
                NSCmbBBDD.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblBBDD.BackColor = Color.Salmon;
                NSCmbBBDD.BackColor = Color.Salmon;

                validar = false;
            }

            // Fecha inicial
            if (new Regex(@"^18|19|20[0-9]{2}/(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])$").Match(NSTxbFechaIni.Text).Success)
            {
                LblFechaIni.BackColor = Color.Transparent;
                NSTxbFechaIni.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblFechaIni.BackColor = Color.Salmon;
                NSTxbFechaIni.BackColor = Color.Salmon;

                validar = false;
            }

            // Fecha final
            if (new Regex(@"^18|19|20[0-9]{2}/(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])$").Match(NSTxbFechaFin.Text).Success)
            {
                LblFechaFin.BackColor = Color.Transparent;
                NSTxbFechaFin.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblFechaFin.BackColor = Color.Salmon;
                NSTxbFechaFin.BackColor = Color.Salmon;

                validar = false;
            }

            return validar;
        }
    }
}