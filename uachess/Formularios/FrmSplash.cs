using System;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmSplash : Form
    {
        # region Atributos

        // Ticks de reloj
        public int ticks;

        // Formulario principal
        public FrmChess frmChess;

        # endregion

        // Constructor
        // Construye form splash
        public FrmSplash()
        {
            // Componentes
            InitializeComponent();

            // Ticks de reloj
            ticks = 0;
        }

        // Sobreescritura CreateParams
        // Evita parpadeos en formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        // Evento timer formulario
        // Muestra splash mientras carga aplicacion
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cargar formulario principal
            if (ticks == 0)
            {
                LblDescripcion.Text = "Cargando módulo principal...";
                frmChess = new FrmChess();
                frmChess.Show();
                frmChess.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario guardar
            else if (ticks == 1)
            {
                LblDescripcion.Text = "Cargando módulo de guardado...";
                frmChess.frmGuardar = new FrmGuardar(frmChess);
                frmChess.frmGuardar.Show();
                frmChess.frmGuardar.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario cargar
            else if (ticks == 2)
            {
                LblDescripcion.Text = "Cargando módulo de carga...";
                frmChess.frmCargar = new FrmCargar(frmChess);
                frmChess.frmCargar.Show();
                frmChess.frmCargar.Hide();
                NSTkbCarga.Value += 10;
            }

            // Cargar formulario ajustes
            else if (ticks == 3)
            {
                LblDescripcion.Text = "Cargando módulo de ajustes...";
                frmChess.frmAjustes = new FrmAjustes();
                frmChess.frmAjustes.Show();
                frmChess.frmAjustes.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario CPU
            else if (ticks == 4)
            {
                LblDescripcion.Text = "Cargando módulo CPU...";
                frmChess.frmCPU = new FrmCPU();
                frmChess.frmCPU.Show();
                frmChess.frmCPU.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario brazo
            else if (ticks == 5)
            {
                LblDescripcion.Text = "Cargando módulo brazo...";
                frmChess.frmBrazo = new FrmBrazo();
                frmChess.frmBrazo.Show();
                frmChess.frmBrazo.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario estadisticas
            else if (ticks == 6)
            {
                LblDescripcion.Text = "Cargando módulo estadísticas...";
                frmChess.frmEstadisticas = new FrmEstadisticas(frmChess.chess);
                frmChess.frmEstadisticas.Show();
                frmChess.frmEstadisticas.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario BBDD
            else if (ticks == 7)
            {
                LblDescripcion.Text = "Cargando módulo BBDD...";
                frmChess.frmBBDD = new FrmBBDD();
                frmChess.frmBBDD.Show();
                frmChess.frmBBDD.Hide();
                NSTkbCarga.Value += 10;
            }
            // Cargar formulario creditos
            else if (ticks == 8)
            {
                LblDescripcion.Text = "Cargando módulo créditos...";
                frmChess.frmCreditos = new FrmCreditos();
                frmChess.frmCreditos.Show();
                frmChess.frmCreditos.Hide();
                NSTkbCarga.Value += 10;
            }
            // Mostrar formulario principal
            else if (ticks == 9)
            {
                LblDescripcion.Text = "Mostrando controles...";
                frmChess.Show();
                NSTkbCarga.Value += 10;
            }
            // Ocultar pantalla de carga
            else
            {
                this.Hide();
                Timer.Enabled = false;
            }

            // Actualizar porcentaje carga
            LblCarga.Text = NSTkbCarga.Value + "%";

            ticks++;
        }
    }
}