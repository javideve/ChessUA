using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmChess : Form
    {
        # region Constantes

        // Modo aplicacion
        public const int PAUSA = 0;
        public const int JUEGO = 1;
        public const int VISOR = 2;

        // Modo jugador
        public const int HUM = 1;
        public const int CPU = 2;
        
        # endregion

        #region Atributos

        // Modo aplicacion
        public int modo;

        // Modo jugador
        public int modoB, modoN;

        // Estructura
        public Chess chess;

        // Casilla / Pieza / UMov
        public int casillaX, casillaY;
        public int piezaX, piezaY;
        public int umovXO, umovYO;
        public int umovXD, umovYD;

        // Movimientos marcados
        // [x, y, ...]
        public int[] control, movimientos;

        // Historial algebraico / descriptivo
        public string[] historialA, historialD;

        // Fichero

        // Ruta y nombre
        public string ruta, pgn;

        // [detalles, movs, ...]
        public string[] fichero;

        // Hilo
        public Thread hilo;

        // Formularios
        public FrmGuardar frmGuardar;
        public FrmCargar frmCargar;
        public FrmAjustes frmAjustes;
        public FrmCPU frmCPU;
        public FrmBrazo frmBrazo;
        public FrmEstadisticas frmEstadisticas;
        public FrmBBDD frmBBDD;
        public FrmCreditos frmCreditos;

        // Formulario cargando
        public FrmMensaje frmCargando;

        # endregion

        // Constructor
        // Construye form chess
        public FrmChess()
        {
            // Componentes
            InitializeComponent();

            // Modo aplicacion
            modo = PAUSA;

            // Modo jugador
            modoB = HUM; NSCmbBlancas.SelectedIndex = 0;
            modoN = CPU; NSCmbNegras.SelectedIndex = 1;

            // Estructura
            chess = new Chess();

            // Casilla / Pieza / UMov
            casillaX = casillaY = -1;
            piezaX = piezaY = -1;
            umovXO = umovYO = -1;
            umovXD = umovYD = -1;

            // Movimientos marcados
            movimientos = Chess.Vector(new int[27 * 2], -1);
            control = Chess.Vector(new int[27 * 2], -1);

            // Historial algebraico / descriptivo
            historialA = new string[Chess.NTABLEROS];
            historialD = new string[Chess.NTABLEROS];

            // Fichero
            ruta = pgn = null;
            fichero = null;

            // Hilo
            CheckForIllegalCrossThreadCalls = false;
            hilo = null;

            // Guardar tablero inicial
            GuardarTablero();
            Modo(PAUSA);
        }

        // Evento mostrar formulario
        // Centra el formulario mostrado
        private void FrmChess_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X, Location.Y + 54);
        }

        // Evento cerrar formulario
        // Cierra la aplicacion
        private void FrmChess_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (hilo != null) { hilo.Abort(); }

            Application.Exit();
        }

        // Evento apuntar iconos
        // Marca icono apuntado por raton
        private void PbxIco_MouseEnter(object sender, EventArgs e)
        {
            // Icono apuntado
            PictureBox icono = (PictureBox) sender;

            switch (icono.Name)
            {
                // Menu
                case "PbxIcoNuevo":
                    LblIcoNuevo.Visible = true;
                    PbxIcoNuevo.Image = UAChess.Properties.Resources.IcoNuevoS;
                    break;

                case "PbxIcoJugar":
                    LblIcoJugar.Visible = true;
                    if (PbxIcoJugar.Tag.ToString() == "Jugar")
                    { PbxIcoJugar.Image = UAChess.Properties.Resources.IcoReproducirS; } else
                    { PbxIcoJugar.Image = UAChess.Properties.Resources.IcoPausarS; }
                    break;

                case "PbxIcoGuardar":
                    LblIcoGuardar.Visible = true;
                    PbxIcoGuardar.Image = UAChess.Properties.Resources.IcoGuardarS;
                    break;

                case "PbxIcoCargar":
                    LblIcoCargar.Visible = true;
                    PbxIcoCargar.Image = UAChess.Properties.Resources.IcoCargarS;
                    break;

                case "PbxIcoAjustes":
                    LblIcoAjustes.Visible = true;
                    PbxIcoAjustes.Image = UAChess.Properties.Resources.IcoAjustesS;
                    break;

                case "PbxIcoCPU":
                    LblIcoCPU.Visible = true;
                    PbxIcoCPU.Image = UAChess.Properties.Resources.IcoCPUS;
                    break;

                case "PbxIcoBrazo":
                    LblIcoBrazo.Visible = true;
                    PbxIcoBrazo.Image = UAChess.Properties.Resources.IcoBrazoS;
                    break;

                case "PbxIcoEstadisticas":
                    LblIcoEstadisticas.Visible = true;
                    PbxIcoEstadisticas.Image = UAChess.Properties.Resources.IcoEstadisticasS;
                    break;

                case "PbxIcoBBDD":
                    LblIcoBBDD.Visible = true;
                    PbxIcoBBDD.Image = UAChess.Properties.Resources.IcoBBDDS;
                    break;

                case "PbxIcoCreditos":
                    LblIcoCreditos.Visible = true;
                    PbxIcoCreditos.Image = UAChess.Properties.Resources.IcoCreditosS;
                    break;

                // Historial
                case "PbxIcoReproducir":
                    if (PbxIcoReproducir.Tag.ToString() == "Reproducir")
                    { PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoReproducirS; } else
                    { PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoPausarS; }
                    break;

                case "PbxIcoAtras":
                    PbxIcoAtras.Image = UAChess.Properties.Resources.IcoAtrasS;
                    break;

                case "PbxIcoAdelante":
                    PbxIcoAdelante.Image = UAChess.Properties.Resources.IcoAdelanteS;
                    break;

                case "PbxIcoInicio":
                    PbxIcoInicio.Image = UAChess.Properties.Resources.IcoInicioS;
                    break;

                case "PbxIcoFinal":
                    PbxIcoFinal.Image = UAChess.Properties.Resources.IcoFinalS;
                    break;

                case "PbxIcoDeshacer":
                    PbxIcoDeshacer.Image = UAChess.Properties.Resources.IcoDeshacerS;
                    break;
            }
        }

        // Evento desapuntar iconos
        // Desmarca icono apuntado por raton
        private void PbxIco_MouseLeave(object sender, EventArgs e)
        {
            // Icono desapuntado
            PictureBox icono = (PictureBox) sender;

            switch (icono.Name)
            {
                // Menu
                case "PbxIcoNuevo":
                    LblIcoNuevo.Visible = false;
                    PbxIcoNuevo.Image = UAChess.Properties.Resources.IcoNuevo;
                    break;

                case "PbxIcoJugar":
                    LblIcoJugar.Visible = false;
                    if (PbxIcoJugar.Tag.ToString() == "Jugar")
                    { PbxIcoJugar.Image = UAChess.Properties.Resources.IcoReproducirS; } else
                    { PbxIcoJugar.Image = UAChess.Properties.Resources.IcoPausarS; }
                    break;

                case "PbxIcoGuardar":
                    LblIcoGuardar.Visible = false;
                    PbxIcoGuardar.Image = UAChess.Properties.Resources.IcoGuardar;
                    break;

                case "PbxIcoCargar":
                    LblIcoCargar.Visible = false;
                    PbxIcoCargar.Image = UAChess.Properties.Resources.IcoCargar;
                    break;

                case "PbxIcoAjustes":
                    LblIcoAjustes.Visible = false;
                    PbxIcoAjustes.Image = UAChess.Properties.Resources.IcoAjustes;
                    break;

                case "PbxIcoCPU":
                    LblIcoCPU.Visible = false;
                    PbxIcoCPU.Image = UAChess.Properties.Resources.IcoCPU;
                    break;

                case "PbxIcoBrazo":
                    LblIcoBrazo.Visible = false;
                    PbxIcoBrazo.Image = UAChess.Properties.Resources.IcoBrazo;
                    break;

                case "PbxIcoEstadisticas":
                    LblIcoEstadisticas.Visible = false;
                    PbxIcoEstadisticas.Image = UAChess.Properties.Resources.IcoEstadisticas;
                    break;

                case "PbxIcoBBDD":
                    LblIcoBBDD.Visible = false;
                    PbxIcoBBDD.Image = UAChess.Properties.Resources.IcoBBDD;
                    break;

                case "PbxIcoCreditos":
                    LblIcoCreditos.Visible = false;
                    PbxIcoCreditos.Image = UAChess.Properties.Resources.IcoCreditos;
                    break;

                // Historial
                case "PbxIcoReproducir":
                    if (PbxIcoReproducir.Tag.ToString() == "Reproducir")
                    { PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoReproducir; } else
                    { PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoPausar; }
                    break;

                case "PbxIcoAtras":
                    PbxIcoAtras.Image = UAChess.Properties.Resources.IcoAtras;
                    break;

                case "PbxIcoAdelante":
                    PbxIcoAdelante.Image = UAChess.Properties.Resources.IcoAdelante;
                    break;

                case "PbxIcoInicio":
                    PbxIcoInicio.Image = UAChess.Properties.Resources.IcoInicio;
                    break;

                case "PbxIcoFinal":
                    PbxIcoFinal.Image = UAChess.Properties.Resources.IcoFinal;
                    break;

                case "PbxIcoDeshacer":
                    PbxIcoDeshacer.Image = UAChess.Properties.Resources.IcoDeshacer;
                    break;
            }
        }

        // Evento apuntar casillas
        // Marca casilla apuntada por raton
        private void PbxCasilla_MouseEnter(object sender, EventArgs e)
        {
            if (modo == JUEGO)
            {
                // Casilla apuntada
                PictureBox casilla = (PictureBox)sender;
                casillaX = Int32.Parse(casilla.Name[10] + "");
                casillaY = Int32.Parse(casilla.Name[11] + "");

                // Marcar casilla blanca
                if (casilla.Tag.ToString()[0] == 'B')
                {
                    if (casilla.Tag.ToString()[1] == 'Y' || casilla.Tag.ToString()[1] == 'Z')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBA;
                    }
                    else
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBS;
                    }
                }
                // Marcar casilla negra
                else if (casilla.Tag.ToString()[0] == 'N')
                {
                    if (casilla.Tag.ToString()[1] == 'Y' || casilla.Tag.ToString()[1] == 'Z')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNA;
                    }
                    else
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNS;
                    }
                }

                // Marcar coordenadas X
                switch (casilla.Name[10])
                {
                    case '0':
                        LblCasillasA.ForeColor = Color.Red;
                        break;

                    case '1':
                        LblCasillasB.ForeColor = Color.Red;
                        break;

                    case '2':
                        LblCasillasC.ForeColor = Color.Red;
                        break;

                    case '3':
                        LblCasillasD.ForeColor = Color.Red;
                        break;

                    case '4':
                        LblCasillasE.ForeColor = Color.Red;
                        break;

                    case '5':
                        LblCasillasF.ForeColor = Color.Red;
                        break;

                    case '6':
                        LblCasillasG.ForeColor = Color.Red;
                        break;

                    case '7':
                        LblCasillasH.ForeColor = Color.Red;
                        break;
                }

                // Marcar coordenadas Y
                switch (casilla.Name[11])
                {
                    case '0':
                        LblCasillas1.ForeColor = Color.Red;
                        break;

                    case '1':
                        LblCasillas2.ForeColor = Color.Red;
                        break;

                    case '2':
                        LblCasillas3.ForeColor = Color.Red;
                        break;

                    case '3':
                        LblCasillas4.ForeColor = Color.Red;
                        break;

                    case '4':
                        LblCasillas5.ForeColor = Color.Red;
                        break;

                    case '5':
                        LblCasillas6.ForeColor = Color.Red;
                        break;

                    case '6':
                        LblCasillas7.ForeColor = Color.Red;
                        break;

                    case '7':
                        LblCasillas8.ForeColor = Color.Red;
                        break;
                }
            }
        }

        // Evento desapuntar casillas
        // Desmarca casilla apuntada por raton
        private void PbxCasilla_MouseLeave(object sender, EventArgs e)
        {
            if (modo == JUEGO)
            {
                // Casilla desapuntada
                PictureBox casilla = (PictureBox)sender;
                casillaX = casillaY = -1;

                // Desmarcar casilla blanca
                if (casilla.Tag.ToString()[0] == 'B')
                {
                    if (casilla.Tag.ToString()[1] == 'Y')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBR;
                    }
                    else if (casilla.Tag.ToString()[1] == 'Z')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBA;
                    }
                    else if (casilla.Tag.ToString()[1] == 'W')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBV;
                    }
                    else
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaB;
                    }
                }
                // Desmarcar casilla negra
                else if (casilla.Tag.ToString()[0] == 'N')
                {
                    if (casilla.Tag.ToString()[1] == 'Y')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNR;
                    }
                    else if (casilla.Tag.ToString()[1] == 'Z')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNA;
                    }
                    else if (casilla.Tag.ToString()[1] == 'W')
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNV;
                    }
                    else
                    {
                        casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaN;
                    }
                }

                // Desmarcar coordenadas X
                switch (casilla.Name[10])
                {
                    case '0':
                        LblCasillasA.ForeColor = Color.Goldenrod;
                        break;

                    case '1':
                        LblCasillasB.ForeColor = Color.Goldenrod;
                        break;

                    case '2':
                        LblCasillasC.ForeColor = Color.Goldenrod;
                        break;

                    case '3':
                        LblCasillasD.ForeColor = Color.Goldenrod;
                        break;

                    case '4':
                        LblCasillasE.ForeColor = Color.Goldenrod;
                        break;

                    case '5':
                        LblCasillasF.ForeColor = Color.Goldenrod;
                        break;

                    case '6':
                        LblCasillasG.ForeColor = Color.Goldenrod;
                        break;

                    case '7':
                        LblCasillasH.ForeColor = Color.Goldenrod;
                        break;
                }

                // Desmarcar coordenadas Y
                switch (casilla.Name[11])
                {
                    case '0':
                        LblCasillas1.ForeColor = Color.Goldenrod;
                        break;

                    case '1':
                        LblCasillas2.ForeColor = Color.Goldenrod;
                        break;

                    case '2':
                        LblCasillas3.ForeColor = Color.Goldenrod;
                        break;

                    case '3':
                        LblCasillas4.ForeColor = Color.Goldenrod;
                        break;

                    case '4':
                        LblCasillas5.ForeColor = Color.Goldenrod;
                        break;

                    case '5':
                        LblCasillas6.ForeColor = Color.Goldenrod;
                        break;

                    case '6':
                        LblCasillas7.ForeColor = Color.Goldenrod;
                        break;

                    case '7':
                        LblCasillas8.ForeColor = Color.Goldenrod;
                        break;
                }
            }
        }

        // Evento mantener click derecho en casillas
        // Marca piezas que controlan casilla apuntada
        private void PbxCasilla_MouseDown(object sender, MouseEventArgs e)
        {
            if (modo == JUEGO && e.Button == MouseButtons.Right)
            {
                DesmarcarTablero();

                Pieza[] piezas = chess.tablero.ControlCasilla(casillaX, casillaY, 0);

                for (int i = 0; i < piezas.Length && piezas[i] != null; i++)
                {
                    MarcarCasilla(piezas[i].x, piezas[i].y, "Azul");
                }
            }
        }

        // Evento soltar click derecho en casillas
        // Desmarca piezas que controlan casilla apuntada
        private void PbxCasilla_MouseUp(object sender, MouseEventArgs e)
        {
            if (modo == JUEGO && e.Button == MouseButtons.Right)
            {
                Pieza[] piezas = chess.tablero.ControlCasilla(casillaX, casillaY, 0);

                for (int i = 0; i < piezas.Length && piezas[i] != null; i++)
                {
                    MarcarCasilla(piezas[i].x, piezas[i].y, "Normal");
                }
            }
        }

        // Evento click icono nuevo
        // Inicia / Reinicia una partida
        private void PbxIcoNuevo_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje
            FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Seguro que quiere iniciar una nueva partida?"
                + Environment.NewLine + "Se perderán los datos no guardados si lo hace.");

            frmMensaje.ShowDialog();

            // Reiniciar partida
            if (frmMensaje.seleccion == FrmMensaje.BOTON2) { Reset(); }
        }

        // Evento click icono jugar
        // Inicia / Pausa el juego
        private void PbxIcoJugar_Click(object sender, EventArgs e)
        {
            // Modo Pausa / Juego
            if (modo == PAUSA) { Modo(JUEGO); } else

            // Modo Juego / Pausa
            if (modo == JUEGO) { Modo(PAUSA); } else

            // Modo Visor / Juego
            if (modo == VISOR)
            {
                // Mostrar mensaje
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Desea continuar el juego de la partida cargada?");
                frmMensaje.ShowDialog();

                // Cambiar a modo juego
                if (frmMensaje.seleccion == FrmMensaje.BOTON2) { Modo(JUEGO); }
            }
        }

        // Evento click icono guardar
        // Muestra formulario guardar
        private void PbxIcoGuardar_Click(object sender, EventArgs e)
        {
            frmGuardar.ShowDialog();
        }

        // Evento click icono cargar
        // Muestra formulario cargar
        private void PbxIcoCargar_Click(object sender, EventArgs e)
        {
            frmCargar.ShowDialog();

            // Cargar en visor
            if (frmCargar.modo == FrmCargar.CARGAVISOR)
            {
                Reset(); Modo(VISOR);

                hilo = new Thread(new ThreadStart(CargarPartidasVisor));
                hilo.Start();
            }
            // Cargar en bbdd
            else if (frmCargar.modo == FrmCargar.CARGABBDD)
            {
                // Comprobar si bbdd ya cargada
                if (Program.bbdd.ConsultaExisteBD(pgn))
                {
                    // Mostrar mensaje error
                    FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible cargar partida/s en BBDD." 
                        + Environment.NewLine + "PGN con mismo nombre ya almacenado.");

                    frmMensaje.ShowDialog();

                    return;
                }

                // Mostrar mensaje cargando
                frmCargando = new FrmMensaje(FrmMensaje.ESPERA, "Cargando partida/s en BBDD...");
                frmCargando.Show();

                Enabled = false;
                hilo = new Thread(new ThreadStart(CargarPartidasBBDD));
                hilo.Start();
            }
        }

        // Metodo CargarPartidasVisor
        // Carga partidas guardadas en visor (*hilo*)
        private void CargarPartidasVisor()
        {
            // Mostrar partidas
            MostrarPartidas();

            // Mostrar mensaje
            FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Se han cargado " + NSCmbPartidas.Items.Count + " partida/s."
                + Environment.NewLine + "Seleccione una en el panel visor para visualizarla.");

            frmMensaje.ShowDialog();

            hilo.Abort();
        }

        // Metodo CargaPartidasBBDD
        // Carga partidas guardadas en bbdd (*hilo*)
        private void CargarPartidasBBDD()
        {
            int n = fichero.Length / 2;

            // Cargar partidas
            for (int i = 0; i < n; i++)
            {
                // Cargar partida i
                frmCargando.Mensaje("Cargando partida " + (i + 1) + " de " + n + " en BBDD...");
                CargarPartida(i, FrmCargar.CARGABBDD);

                // Abortar carga
                if (frmCargando.seleccion == FrmMensaje.BOTON1)
                {
                    Enabled = true;

                    // Mostrar mensaje cargando
                    frmCargando.Hide();
                    frmCargando = new FrmMensaje(FrmMensaje.INFO, "Se han cargado " + (i + 1) + " partida/s en BBDD");
                    frmCargando.ShowDialog();

                    hilo.Abort();
                }
            }

            Enabled = true;

            // Mostrar mensaje cargando
            frmCargando.Hide();
            frmCargando = new FrmMensaje(FrmMensaje.INFO, "Se han cargado " + n + " partida/s en BBDD");
            frmCargando.ShowDialog();

            hilo.Abort();
        }

        // Evento click icono ajustes
        // Muestra formulario ajustes
        private void PbxIcoAjustes_Click(object sender, EventArgs e)
        {
            frmAjustes.ShowDialog();
        }

        // Evento click icono CPU
        // Muestra formulario cpu
        private void PbxIcoCPU_Click(object sender, EventArgs e)
        {
            frmCPU.ShowDialog();
        }

        // Evento click icono brazo
        // Muestra formulario brazo
        private void PbxIcoBrazo_Click(object sender, EventArgs e)
        {
            frmBrazo.ShowDialog();
        }

        // Evento click icono estadisticas
        // Muestra formulario estadisticas
        private void PbxIcoEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas.Show();
        }

        // Evento click icono BBDD
        // Muestra formulario bbdd
        private void PbxIcoBBDD_Click(object sender, EventArgs e)
        {
            frmBBDD.ShowDialog();
        }

        // Evento click icono creditos
        // Muestra formulario creditos
        private void PbxIcoCreditos_Click(object sender, EventArgs e)
        {
            frmCreditos.ShowDialog();
        }

        // Evento cambio modo jugador
        // Cambia modo de jugador
        private void NSCmbJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combo seleccionado
            NSComboBox combo = (NSComboBox)sender;

            // Modo jugador blancas
            if (combo.Name == "NSCmbBlancas")
            {
                if (combo.SelectedIndex == 0) { modoB = HUM; } else
                if (combo.SelectedIndex == 1) { modoB = CPU; }
            }
            // Modo jugador negras
            else if (combo.Name == "NSCmbNegras")
            {
                if (combo.SelectedIndex == 0) { modoN = HUM; } else
                if (combo.SelectedIndex == 1) { modoN = CPU; }
            }
        }

        // Evento cambio partida visor
        // Carga partida seleccionada en visor
        private void NSCmbPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            PbxIcoInicio_Click(null, null);
            PbxIcoDeshacer_Click(null, null);

            // Mostrar mensaje cargando
            frmCargando = new FrmMensaje(FrmMensaje.ESPERA, "Cargando partida " + (NSCmbPartidas.SelectedIndex + 1) + " en visor...");
            frmCargando.Show();
            Enabled = false;

            hilo = new Thread(new ThreadStart(NSCmbPartida));
            hilo.Start();
        }

        // Metodo NSCmbPartida
        // Carga partida seleccionada en visor (*hilo*)
        private void NSCmbPartida()
        {
            CargarPartida(NSCmbPartidas.SelectedIndex, FrmCargar.CARGAVISOR);
            this.ActiveControl = LblModo;

            frmCargando.Hide();
            Enabled = true;

            hilo.Abort();
        }

        // Evento desapuntar combo partidas
        // Quita foco de combo para evitar cambio partida
        private void NSCmbPartidas_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = LblModo;
        }

        // Evento click boton tipo historial
        // Muestra historial algebraico/descriptivo
        private void NSRbtHistorial_Click(object sender, EventArgs e)
        {
            // Boton seleccionado
            NSRadioButton boton = (NSRadioButton)sender;

            // Historial algebraico
            if (boton.Name == "NSRbtAlgebraico")
            {
                NSLvHistorialA.Visible = true;
                NSLvHistorialD.Visible = false;
            }
            // Historial descriptivo
            else if (boton.Name == "NSRbtDescriptivo")
            {
                NSLvHistorialD.Visible = true;
                NSLvHistorialA.Visible = false;
            }
        }

        // Evento click items historial
        // Muestra el estado de tablero seleccionado
        private void NSLvHistorial_Click(object sender, EventArgs e)
        {
            if (modo == JUEGO) { Modo(PAUSA); }

            // Item seleccionado
            NSListView historial = (NSListView)sender;
            int nitem = Int32.Parse(historial.SelectedItems[0].SubItems[0].Text);

            // Cargar tablero
            CargarTablero(nitem);

            // Seleccionar items historial
            NSLvHistorialA._SelectedItems.Clear();
            NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[nitem]);
            NSLvHistorialD._SelectedItems.Clear();
            NSLvHistorialD._SelectedItems.Add(NSLvHistorialD.Items[nitem]);

            // Mover scroll
            NSLvHistorialA.VS.Value = Math.Min(NSLvHistorialA.VS.SmallChange * nitem, NSLvHistorialA.VS.Maximum);
            NSLvHistorialD.VS.Value = Math.Min(NSLvHistorialD.ItemHeight * nitem, NSLvHistorialD.VS.Maximum);
        }

        // Evento click icono inicio historial
        // Muestra el estado inicial del tablero
        private void PbxIcoInicio_Click(object sender, EventArgs e)
        {
            NSLvHistorialA._SelectedItems.Clear();
            NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[0]);

            NSLvHistorial_Click(NSLvHistorialA, null);
        }

        // Evento click icono final historial
        // Muestra el estado final del tablero
        private void PbxIcoFinal_Click(object sender, EventArgs e)
        {
            NSLvHistorialA._SelectedItems.Clear();
            NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[chess.ntableros - 1]);

            NSLvHistorial_Click(NSLvHistorialA, null);
        }

        // Evento click icono atras historial
        // Muestra el estado anterior del tablero
        private void PbxIcoAtras_Click(object sender, EventArgs e)
        {
            if (chess.ntablero - 1 >= 0)
            {
                NSLvHistorialA._SelectedItems.Clear();
                NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[chess.ntablero - 1]);

                NSLvHistorial_Click(NSLvHistorialA, null);
            }
        }

        // Evento click icono adelante historial
        // Muestra el estado siguiente del tablero
        private void PbxIcoAdelante_Click(object sender, EventArgs e)
        {
            if (chess.ntablero + 1 < chess.ntableros)
            {
                NSLvHistorialA._SelectedItems.Clear();
                NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[chess.ntablero + 1]);

                NSLvHistorial_Click(NSLvHistorialA, null);
            }
        }

        // Evento click icono deshacer historial
        // Restaura el estado del tablero seleccionado
        private void PbxIcoDeshacer_Click(object sender, EventArgs e)
        {
            // Eliminar items
            for (int i = chess.ntableros - 1; i > chess.ntablero; i--)
            {
                NSLvHistorialA.RemoveItemAt(i);
                NSLvHistorialD.RemoveItemAt(i);

                historialA[i] = null;
                historialD[i] = null;
            }

            // Restaurar tablero
            RestaurarTablero(chess.ntablero);
        }

        // Evento click icono reproducir historial
        // Reproduce los estados guardados del tablero
        private void PbxIcoReproducir_Click(object sender, EventArgs e)
        {
            // Reproducir
            if (PbxIcoReproducir.Tag.ToString() == "Reproducir")
            {
                PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoPausar;
                PbxIcoReproducir.Tag = "Pausar";

                hilo = new Thread(new ThreadStart(ReproducirHistorial));
                hilo.Start();
            }
            // Pausar
            else if (PbxIcoReproducir.Tag.ToString() == "Pausar")
            {
                PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoReproducir;
                PbxIcoReproducir.Tag = "Reproducir";

                hilo.Abort();

                DesmarcarTablero();
                NSLvHistorial_Click(NSLvHistorialA, null);
            }
        }

        // Metodo ReproducirHistorial
        // Reproduce los estados guardados del tablero (*hilo*)
        private void ReproducirHistorial()
        {
            for (int i = chess.ntablero + 1; i < chess.ntableros; i++)
            {
                int xo = chess.htableros[i].hmovs[(chess.htableros[i].nmovs - 1) * 10 + 1];
                int yo = chess.htableros[i].hmovs[(chess.htableros[i].nmovs - 1) * 10 + 2];
                int xd = chess.htableros[i].hmovs[(chess.htableros[i].nmovs - 1) * 10 + 4];
                int yd = chess.htableros[i].hmovs[(chess.htableros[i].nmovs - 1) * 10 + 5];

                DesmarcarTablero();

                // Casilla origen
                MarcarCasilla(xo, yo, "Azul");

                Thread.Sleep(500);

                // Movimientos pieza
                MarcarMovimientos(xo, yo);

                Thread.Sleep(500);

                // Casilla destino
                MarcarCasilla(xd, yd, "Azul");

                Thread.Sleep(500);

                NSLvHistorialA._SelectedItems.Clear();
                NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[i]);
                NSLvHistorial_Click(NSLvHistorialA, null);

                Thread.Sleep(500);
            }

            PbxIcoReproducir.Image = UAChess.Properties.Resources.IcoReproducir;
            PbxIcoReproducir.Tag = "Reproducir";

            hilo.Abort();
        }

        // Evento click casillas tablero
        // Muestra posibles movimientos y mueve piezas en tablero
        private void PbxCasilla_Click(object sender, EventArgs e)
        {
            if (modo == JUEGO && ((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                // Tablero
                int[][] tablero = chess.tablero.MatrizTipo();

                // Casilla seleccionada
                int x = casillaX; int y = casillaY;
                PictureBox casilla = (PictureBox)sender;

                // Mover pieza
                if (piezaX != -1 && piezaY != -1 && casilla.Tag.ToString()[1] == 'Y')
                {
                    Pieza pieza = chess.tablero.matriz[piezaX][piezaY];

                    // Movimiento ALPASO blancas
                    if (pieza.tipo == Pieza.IDPEONB && pieza.x != x && tablero[x][y] == 0)
                    {
                        Mover(pieza, x, y, Tablero.ALPASO, x);
                    }
                    // Movimiento ALPASO negras
                    else if (pieza.tipo == Pieza.IDPEONN && pieza.x != x && tablero[x][y] == 0)
                    {
                        Mover(pieza, x, y, Tablero.ALPASO, x);
                    }
                    // Movimiento ENROQUEC blancas
                    else if (pieza.tipo == Pieza.IDREYB && x - piezaX == 2)
                    {
                        Mover(pieza, x, y, Tablero.ENROQUEC, Pieza.IDREYB);
                    }
                    // Movimiento ENROQUEC negras
                    else if (pieza.tipo == Pieza.IDREYN && x - piezaX == 2)
                    {
                        Mover(pieza, x, y, Tablero.ENROQUEC, Pieza.IDREYN);
                    }
                    // Movimiento ENROQUEL blancas
                    else if (pieza.tipo == Pieza.IDREYB && x - piezaX == -2)
                    {
                        Mover(pieza, x, y, Tablero.ENROQUEL, Pieza.IDREYB);
                    }
                    // Movimiento ENROQUEL negras
                    else if (pieza.tipo == Pieza.IDREYN && x - piezaX == -2)
                    {
                        Mover(pieza, x, y, Tablero.ENROQUEL, Pieza.IDREYN);
                    }
                    // Movimiento CORONA blancas
                    else if (pieza.tipo == Pieza.IDPEONB && y == 7)
                    {
                        int corona = 0;

                        // Mostrar mensaje
                        FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.CORONA, "Peon blanco coronado."
                            + Environment.NewLine + "Elija pieza a la que promocionar.");

                        frmMensaje.ShowDialog();

                        // Promocion
                        switch (frmMensaje.seleccion)
                        {
                            case FrmMensaje.BOTON1:
                                corona = Pieza.IDDAMAB;
                                break;

                            case FrmMensaje.BOTON2:
                                corona = Pieza.IDTORREB;
                                break;

                            case FrmMensaje.BOTON3:
                                corona = Pieza.IDALFILB;
                                break;

                            case FrmMensaje.BOTON4:
                                corona = Pieza.IDCABALLOB;
                                break;
                        }

                        Mover(pieza, x, y, Tablero.CORONA, corona);
                    }
                    // Movimiento CORONA negras
                    else if (pieza.tipo == Pieza.IDPEONN && y == 0)
                    {
                        int corona = 0;

                        // Mostrar mensaje
                        FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.CORONA, "Peon negro coronado."
                            + Environment.NewLine + "Elija pieza a la que promocionar.");

                        frmMensaje.ShowDialog();

                        // Promocion
                        switch (frmMensaje.seleccion)
                        {
                            case FrmMensaje.BOTON1:
                                corona = Pieza.IDDAMAN;
                                break;

                            case FrmMensaje.BOTON2:
                                corona = Pieza.IDTORREN;
                                break;

                            case FrmMensaje.BOTON3:
                                corona = Pieza.IDALFILN;
                                break;

                            case FrmMensaje.BOTON4:
                                corona = Pieza.IDCABALLON;
                                break;
                        }

                        Mover(pieza, x, y, Tablero.CORONA, corona);
                    }
                    // Movimiento NORMAL
                    else
                    {
                        Mover(pieza, x, y, Tablero.NORMAL, 0);
                    }
                }
                // Marcar movimientos
                else if ((chess.tablero.turno == Pieza.BLANCA && tablero[x][y]  >= 0) ||
                         (chess.tablero.turno == Pieza.NEGRA && tablero[x][y] <= 0))
                {
                    MarcarMovimientos(x, y);
                }
            }
        }

        // Metodo Reset
        // Reinicia aplicacion
        private void Reset()
        {
            PbxIcoInicio_Click(null, null);
            PbxIcoDeshacer_Click(null, null);

            Modo(PAUSA);
        }

        // Metodo Modo
        // Establece modo de aplicacion
        private bool Modo(int modo)
        {
            switch (modo)
            {
                // Modo pausa
                case PAUSA:
                    ModoPAUSA();
                    break;

                // Modo juego
                case JUEGO:
                    ModoJUEGO();
                    break;

                // Modo visor
                case VISOR:
                    ModoVISOR();
                    break;

                default:
                    return false;
            }

            return true;
        }

        // Metodo ModoPAUSA
        // Establece modo de aplicacion (PAUSA)
        private void ModoPAUSA()
        {
            // Modo
            modo = PAUSA;

            // Icono menu
            PbxIcoJugar.Tag = LblIcoJugar.Text = "Jugar";
            PbxIcoJugar.Image = UAChess.Properties.Resources.IcoReproducirS;

            // Panel de datos
            PbxSelBlancas.Visible = PbxSelNegras.Visible = false;
            NSCmbBlancas.Enabled = NSCmbNegras.Enabled = true;

            if (modoB == HUM) { NSCmbBlancas.SelectedIndex = 0; } else
            if (modoB == CPU) { NSCmbBlancas.SelectedIndex = 1; }
            if (modoN == HUM) { NSCmbNegras.SelectedIndex = 0; } else
            if (modoN == CPU) { NSCmbNegras.SelectedIndex = 1; }

            LblModo.Text = "Aplicación en modo pausa";
            LblModo.BackColor = Color.White;
            PnlJuego.Visible = true;
            PnlVisor.Visible = false;

            // Datos visor
            NSCmbPartidas.Items.Clear();

            LblDEvento.Text = "";
            LblDLugar.Text = "";
            LblDFecha.Text = "";
            LblDElo.Text = "";
            LblDBlancas.Text = "";
            LblDNegras.Text = "";
            LblDResultado.Text = "";

            // Tablero
            PnlTablero.Cursor = Cursors.No;
            DesmarcarTablero();

            LblCasillasA.ForeColor = LblCasillasB.ForeColor = Color.White;
            LblCasillasC.ForeColor = LblCasillasD.ForeColor = Color.White;
            LblCasillasE.ForeColor = LblCasillasF.ForeColor = Color.White;
            LblCasillasG.ForeColor = LblCasillasH.ForeColor = Color.White;
            LblCasillas1.ForeColor = LblCasillas2.ForeColor = Color.White;
            LblCasillas3.ForeColor = LblCasillas4.ForeColor = Color.White;
            LblCasillas5.ForeColor = LblCasillas6.ForeColor = Color.White;
            LblCasillas7.ForeColor = LblCasillas8.ForeColor = Color.White;
        }

        // Metodo ModoJUEGO
        // Establece modo de aplicacion (JUEGO)
        private void ModoJUEGO()
        {
            // Modo
            modo = JUEGO;

            // Icono menu
            PbxIcoJugar.Tag = LblIcoJugar.Text = "Pausar";
            PbxIcoJugar.Image = UAChess.Properties.Resources.IcoPausarS;

            // Panel de datos
            if (chess.tablero.turno == Pieza.BLANCA) { PbxSelBlancas.Visible = true; } else
            if (chess.tablero.turno == Pieza.NEGRA) { PbxSelNegras.Visible = true; }
            
            NSCmbBlancas.Enabled = NSCmbNegras.Enabled = false;

            LblModo.Text = "Aplicación en modo ejecución";
            LblModo.BackColor = Color.Goldenrod;
            PnlJuego.Visible = true;
            PnlVisor.Visible = false;

            // Datos visor
            NSCmbPartidas.Items.Clear();
            ruta = pgn = null;
            fichero = null;

            LblDEvento.Text = "";
            LblDLugar.Text = "";
            LblDFecha.Text = "";
            LblDElo.Text = "";
            LblDBlancas.Text = "";
            LblDNegras.Text = "";
            LblDResultado.Text = "";

            // Tablero
            PnlTablero.Cursor = Cursors.Hand;
            DesmarcarTablero();

            LblCasillasA.ForeColor = LblCasillasB.ForeColor = Color.Goldenrod;
            LblCasillasC.ForeColor = LblCasillasD.ForeColor = Color.Goldenrod;
            LblCasillasE.ForeColor = LblCasillasF.ForeColor = Color.Goldenrod;
            LblCasillasG.ForeColor = LblCasillasH.ForeColor = Color.Goldenrod;
            LblCasillas1.ForeColor = LblCasillas2.ForeColor = Color.Goldenrod;
            LblCasillas3.ForeColor = LblCasillas4.ForeColor = Color.Goldenrod;
            LblCasillas5.ForeColor = LblCasillas6.ForeColor = Color.Goldenrod;
            LblCasillas7.ForeColor = LblCasillas8.ForeColor = Color.Goldenrod;

            // Restaurar ultimo movimiento
            NSLvHistorialA._SelectedItems.Clear();
            NSLvHistorialA._SelectedItems.Add(NSLvHistorialA.Items[chess.ntableros - 1]);
            NSLvHistorialD._SelectedItems.Clear();
            NSLvHistorialD._SelectedItems.Add(NSLvHistorialD.Items[chess.ntableros - 1]);

            NSLvHistorialA.Refresh();
            NSLvHistorialD.Refresh();

            // Mover scroll
            NSLvHistorialA.VS.Value = Math.Min(NSLvHistorialA.VS.SmallChange * (chess.ntableros - 1), NSLvHistorialA.VS.Maximum);
            NSLvHistorialD.VS.Value = Math.Min(NSLvHistorialD.ItemHeight * (chess.ntableros - 1), NSLvHistorialD.VS.Maximum);

            // Cargar tablero
            CargarTablero(chess.ntableros - 1);
        }

        // Metodo ModoVISOR
        // Establece modo de aplicacion (VISOR)
        private void ModoVISOR()
        {
            // Modo
            modo = VISOR;

            // Icono menu
            PbxIcoJugar.Tag = LblIcoJugar.Text = "Jugar";
            PbxIcoJugar.Image = UAChess.Properties.Resources.IcoReproducirS;

            // Panel de datos
            PbxSelBlancas.Visible = PbxSelNegras.Visible = false;
            NSCmbBlancas.Enabled = NSCmbNegras.Enabled = false;
            NSCmbBlancas.Text = NSCmbNegras.Text = "";

            LblModo.Text = "Aplicación en modo visor";
            LblModo.BackColor = Color.White;
            PnlJuego.Visible = false;
            PnlVisor.Visible = true;

            // Tablero
            PnlTablero.Cursor = Cursors.No;
            DesmarcarTablero();

            LblCasillasA.ForeColor = LblCasillasB.ForeColor = Color.White;
            LblCasillasC.ForeColor = LblCasillasD.ForeColor = Color.White;
            LblCasillasE.ForeColor = LblCasillasF.ForeColor = Color.White;
            LblCasillasG.ForeColor = LblCasillasH.ForeColor = Color.White;
            LblCasillas1.ForeColor = LblCasillas2.ForeColor = Color.White;
            LblCasillas3.ForeColor = LblCasillas4.ForeColor = Color.White;
            LblCasillas5.ForeColor = LblCasillas6.ForeColor = Color.White;
            LblCasillas7.ForeColor = LblCasillas8.ForeColor = Color.White;
        }

        // Metodo MarcarCasilla
        // Marca la casilla dada de un color
        private bool MarcarCasilla(int x, int y, string c)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            {
                // Casilla a marcar
                PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + x + "" + y, true)[0];

                // Casilla blanca
                if (casilla.Tag.ToString()[0] == 'B')
                {
                    switch (c)
                    {
                        // Color rojo (Y)
                        case "Rojo":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBR;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'Y');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'Y');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'Y');
                            break;

                        // Color azul (Z)
                        case "Azul":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBA;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'Z');
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'Z');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'Z');
                            break;

                        // Color verde (W)
                        case "Verde":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaBV;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'W');
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'W');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'W');
                            break;

                        // Sin color (X)
                        default:
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaB;
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'X');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'X');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'X');
                            break;
                    }
                }
                // Casilla negra
                else if (casilla.Tag.ToString()[0] == 'N')
                {
                    switch (c)
                    {
                        // Color rojo (Y)
                        case "Rojo":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNR;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'Y');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'Y');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'Y');
                            break;

                        // Color azul (Z)
                        case "Azul":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNA;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'Z');
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'Z');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'Z');
                            break;

                        // Color verde (W)
                        case "Verde":
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaNV;
                            casilla.Tag = casilla.Tag.ToString().Replace('X', 'W');
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'W');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'W');
                            break;

                        // Sin color (X)
                        default:
                            casilla.BackgroundImage = UAChess.Properties.Resources.TblCasillaN;
                            casilla.Tag = casilla.Tag.ToString().Replace('Y', 'X');
                            casilla.Tag = casilla.Tag.ToString().Replace('Z', 'X');
                            casilla.Tag = casilla.Tag.ToString().Replace('W', 'X');
                            break;
                    }
                }

                return true;
            }

            return false;
        }

        // Metodo MarcarControl
        // Marca movimientos control de pieza dada
        private bool MarcarControl(int x, int y)
        {
            // Desmarcar movimientos
            DesmarcarControl();

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && chess.tablero.matriz[x][y] != null)
            {
                // Pieza a marcar
                Pieza pieza = chess.tablero.matriz[x][y];

                // Marcar pieza
                piezaX = x; piezaY = y;
                MarcarCasilla(piezaX, piezaY, "Azul");

                // Marcar movimientos
                int[] movs = pieza.controlV;

                for (int i = 0; i < movs.Length && movs[i] != -1; i += 2)
                {
                    control[i] = movs[i]; control[i + 1] = movs[i + 1];
                    MarcarCasilla(control[i], control[i + 1], "Rojo");
                }

                return true;
            }

            return false;
        }

        // Metodo DesmarcarControl
        // Desmarca movimientos control
        private void DesmarcarControl()
        {
            // Desmarcar pieza
            MarcarCasilla(piezaX, piezaY, "Normal");
            piezaX = piezaY = -1;

            // Desmarcar movimientos
            for (int i = 0; i < control.Length && control[i] != -1; i += 2)
            {
                MarcarCasilla(control[i], control[i + 1], "Normal");
            }

            Chess.Vector(control, -1);
        }

        // Metodo MarcarMovimientos
        // Marca movimientos posibles de pieza dada
        private bool MarcarMovimientos(int x, int y)
        {
            // Desmarcar movimientos
            DesmarcarMovimientos();

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && chess.tablero.matriz[x][y] != null)
            {
                // Pieza a marcar
                Pieza pieza = chess.tablero.matriz[x][y];

                // Marcar pieza
                piezaX = x; piezaY = y;
                MarcarCasilla(piezaX, piezaY, "Azul");

                // Marcar movimientos
                int[] movs = pieza.movimientosV;

                for (int i = 0, j = 0; i < movs.Length && movs[i] != 0; i += 8, j += 2)
                {
                    movimientos[j] = movs[i + 4]; movimientos[j + 1] = movs[i + 5];
                    MarcarCasilla(movimientos[j], movimientos[j + 1], "Rojo");
                }

                return true;
            }

            return false;
        }

        // Metodo DesmarcarMovimientos
        // Desmarca movimientos posibles
        private void DesmarcarMovimientos()
        {
            // Desmarcar pieza
            MarcarCasilla(piezaX, piezaY, "Normal");
            piezaX = piezaY = -1;

            // Desmarcar movimientos
            for (int i = 0; i < movimientos.Length && movimientos[i] != -1; i += 2)
            {
                MarcarCasilla(movimientos[i], movimientos[i + 1], "Normal");
            }

            Chess.Vector(movimientos, -1);

            // Desmarcar umov
            MarcarCasilla(umovXO, umovYO, "Normal");
            MarcarCasilla(umovXD, umovYD, "Normal");
            umovXO = umovYO = umovXD = umovYD = -1;
        }

        // Metodo DesmarcarTablero
        // Desmarca movimientos control y posibles
        private void DesmarcarTablero()
        {
            DesmarcarControl();
            DesmarcarMovimientos();
        }

        // Metodo Mover
        // Mueve la pieza a la casilla dada
        private bool Mover(Pieza pieza, int x, int y, int me, int pe)
        {
            int xo = pieza.x, yo = pieza.y;

            if (chess.tablero.Mover(pieza, x, y, me, pe))
            {
                // Turno
                if (chess.tablero.turno == Pieza.BLANCA && modo == JUEGO)
                {
                    PbxSelBlancas.Visible = true;
                    PbxSelNegras.Visible = false;
                }
                else if (chess.tablero.turno == Pieza.NEGRA && modo == JUEGO)
                {
                    PbxSelBlancas.Visible = false;
                    PbxSelNegras.Visible = true;
                }

                // Puntos
                LblPuntosB.Text = chess.tablero.puntosB + " puntos";
                LblPuntosN.Text = chess.tablero.puntosN + " puntos";

                // Tablero
                PictureBox casillaO = (PictureBox)Controls.Find("PbxCasilla" + xo + "" + yo, true)[0];
                PictureBox casillaD = (PictureBox)Controls.Find("PbxCasilla" + x + "" + y, true)[0];

                // Movimiento NORMAL
                casillaD.Image = casillaO.Image;
                casillaO.Image = null;

                // Movimiento ALPASO blancas
                if (pieza.color == Pieza.BLANCA && me == Tablero.ALPASO)
                {
                    PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + x + "" + (y - 1), true)[0];
                    casilla.Image = null;
                }
                // Movimiento ALPASO negras
                else if (pieza.color == Pieza.NEGRA && me == Tablero.ALPASO)
                {
                    PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + x + "" + (y + 1), true)[0];
                    casilla.Image = null;
                }
                // Movimiento ENROQUEC blancas
                else if (pieza.color == Pieza.BLANCA && me == Tablero.ENROQUEC)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla70", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (x - 1) + "" + y, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }
                // Movimiento ENROQUEC negras
                else if (pieza.color == Pieza.NEGRA && me == Tablero.ENROQUEC)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla77", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (x - 1) + "" + y, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }

                // Movimiento ENROQUEL blancas
                else if (pieza.color == Pieza.BLANCA && me == Tablero.ENROQUEL)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla00", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (x + 1) + "" + y, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }

                // Movimiento ENROQUEL negras
                else if (pieza.color == Pieza.NEGRA && me == Tablero.ENROQUEL)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla07", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (x + 1) + "" + y, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }
                // Movimiento CORONA blancas
                else if (pieza.color == Pieza.BLANCA && me == Tablero.CORONA)
                {
                    // Promocion
                    switch (pe)
                    {
                        case Pieza.IDDAMAB:
                            casillaD.Image = UAChess.Properties.Resources.PzDamaB;
                            break;

                        case Pieza.IDTORREB:
                            casillaD.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDALFILB:
                            casillaD.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDCABALLOB:
                            casillaD.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;
                    }
                }
                // Movimiento CORONA negras
                else if (pieza.color == Pieza.NEGRA && me == Tablero.CORONA)
                {
                    // Promocion
                    switch (pe)
                    {
                        case Pieza.IDDAMAN:
                            casillaD.Image = UAChess.Properties.Resources.PzDamaN;
                            break;

                        case Pieza.IDTORREN:
                            casillaD.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDALFILN:
                            casillaO.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDCABALLON:
                            casillaO.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;
                    }
                }

                // Marcar ultimo movimiento
                DesmarcarTablero();

                MarcarCasilla(xo, yo, "Verde");
                MarcarCasilla(x, y, "Verde");

                umovXO = xo; umovYO = yo;
                umovXD = x; umovYD = y;

                // Guardar el tablero actual
                GuardarTablero();

                // Estadisticas
                ActualizarEstadisticas();

                return true;
            }

            return false;
        }

        // Metodo GuardarTablero
        // Guarda estado actual del tablero
        private bool GuardarTablero()
        {
            if (chess.GuardarTablero())
            {
                int po, xo, yo, pd, xd, yd, me, pe, j, jm;
                string movimientoA, movimientoD;

                movimientoA = movimientoD = "";

                if (chess.ntableros - 1 != 0)
                {
                    po = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10];
                    xo = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 1];
                    yo = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 2];
                    pd = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 3];
                    xd = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 4];
                    yd = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 5];
                    me = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 6];
                    pe = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 7];
                    j = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 8];
                    jm = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 9];

                    movimientoA = Chess.NotacionAlgebraicaC(po, xo, yo, pd, xd, yd, me, pe, j, jm, chess.tablero);
                    movimientoD = Chess.NotacionDescriptiva(po, xo, yo, pd, xd, yd, me, pe, j, jm);
                }
                else if (chess.ntableros - 1 == 0)
                {
                    movimientoA = movimientoD = "Estado inicial";
                }

                // Historial algebraico
                NSLvHistorialA.AddItem((chess.ntableros - 1) + ". " + movimientoA, (chess.ntableros - 1) + "");
                historialA[chess.ntableros - 1] = movimientoA;

                // Historial descriptivo
                NSLvHistorialD.AddItem(movimientoD, (chess.ntableros - 1) + "");
                historialD[chess.ntableros - 1] = movimientoD;

                return true;
            }

            return false;
        }

        // Metodo CargarTablero
        // Carga estado anterior del tablero
        private bool CargarTablero(int ntablero)
        {
            if (chess.CargarTablero(ntablero))
            {
                // Marcar ultimo movimiento
                DesmarcarTablero();

                if (chess.tablero.nmovs > 0)
                {
                    umovXO = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 1];
                    umovYO = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 2];
                    MarcarCasilla(umovXO, umovYO, "Verde");

                    umovXD = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 4];
                    umovYD = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 5];
                    MarcarCasilla(umovXD, umovYD, "Verde");
                }

                // Puntos
                LblPuntosB.Text = chess.tablero.puntosB + " puntos";
                LblPuntosN.Text = chess.tablero.puntosN + " puntos";

                // Tablero
                int[][] tablero = chess.tablero.MatrizTipo();

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + i + "" + j, true)[0];

                        switch (tablero[i][j])
                        {
                            // Peones
                            case Pieza.IDPEONB:
                                casilla.Image = UAChess.Properties.Resources.PzPeonB;
                                break;

                            case Pieza.IDPEONN:
                                casilla.Image = UAChess.Properties.Resources.PzPeonN;
                                break;

                            // Caballos
                            case Pieza.IDCABALLOB:
                                casilla.Image = UAChess.Properties.Resources.PzCaballoB;
                                break;

                            case Pieza.IDCABALLON:
                                casilla.Image = UAChess.Properties.Resources.PzCaballoN;
                                break;

                            // Alfiles
                            case Pieza.IDALFILB:
                                casilla.Image = UAChess.Properties.Resources.PzAlfilB;
                                break;

                            case Pieza.IDALFILN:
                                casilla.Image = UAChess.Properties.Resources.PzAlfilN;
                                break;

                            // Torres
                            case Pieza.IDTORREB:
                                casilla.Image = UAChess.Properties.Resources.PzTorreB;
                                break;

                            case Pieza.IDTORREN:
                                casilla.Image = UAChess.Properties.Resources.PzTorreN;
                                break;

                            // Damas
                            case Pieza.IDDAMAB:
                                casilla.Image = UAChess.Properties.Resources.PzDamaB;
                                break;

                            case Pieza.IDDAMAN:
                                casilla.Image = UAChess.Properties.Resources.PzDamaN;
                                break;

                            // Reyes
                            case Pieza.IDREYB:
                                casilla.Image = UAChess.Properties.Resources.PzReyB;
                                break;

                            case Pieza.IDREYN:
                                casilla.Image = UAChess.Properties.Resources.PzReyN;
                                break;

                            // Vacio
                            default:
                                casilla.Image = null;
                                break;
                        }
                    }
                }

                // Estadisticas
                ActualizarEstadisticas();

                return true;
            }

            return false;
        }

        // Metodo RestaurarTablero
        // Restaura estado anterior del tablero
        private bool RestaurarTablero(int ntablero)
        {
            if (CargarTablero(ntablero))
            {
                if (chess.RestaurarTablero(ntablero)) { return true; }
            }

            return false;
        }

        // Metodo MostrarPartidas
        // Muestra las partidas a cargar en combo
        private void MostrarPartidas()
        {
            for (int i = 0; i < fichero.Length - 1; i += 2)
            {
                int x = fichero[i].IndexOf("[Date \"") + +"[Date \"".Length;
                int y = fichero[i].IndexOf("\"]", x);

                NSCmbPartidas.Items.Add("Partida " + (i / 2 + 1) + " || " + fichero[i].Substring(x, y - x));
            }
        }

        // Metodo CargarPartida
        // Carga la partida dada
        private bool CargarPartida(int num, int modo)
        {
            // Cargar partida
            if (CargarDetallesPartida(num, modo) && CargarMovimientosPartida(num, modo))
            {
                PbxIcoInicio_Click(null, null);
                return true;
            }

            // Mostrar mensaje error
            FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible cargar la partida " + num + "."
                + Environment.NewLine + "Partida con formato no válido.");

            frmMensaje.ShowDialog();

            return false;
        }

        // Metodo CargarDetallesPartida
        // Carga detalles de la partida dada
        private bool CargarDetallesPartida(int num, int modo)
        {
            num = num * 2;

            if (fichero != null && num < fichero.Length)
            {
                int x, y;

                string detalles = Regex.Replace(fichero[num], Environment.NewLine, " ");
                detalles = Regex.Replace(detalles, @"\s+", " ");

                // Evento
                string evento = "";

                if (detalles.Contains("[Event \""))
                {
                    x = detalles.IndexOf("[Event \"") + "[Event \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    evento = detalles.Substring(x, y - x);
                }

                // Sitio
                string sitio = "";

                if (detalles.Contains("[Site \""))
                {
                    x = detalles.IndexOf("[Site \"") + "[Site \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    sitio = detalles.Substring(x, y - x);
                }

                // Fecha
                string fecha = "";

                if (detalles.Contains("[Date \""))
                {
                    x = detalles.IndexOf("[Date \"") + "[Date \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    fecha = detalles.Substring(x, y - x);
                }

                // Ronda
                string ronda = "";

                if (detalles.Contains("[Round \""))
                {
                    x = detalles.IndexOf("[Round \"") + "[Round \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    ronda = detalles.Substring(x, y - x);
                }

                // Blancas
                string blancas = "";

                if (detalles.Contains("[White \""))
                {
                    x = detalles.IndexOf("[White \"") + "[White \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    blancas = detalles.Substring(x, y - x);
                }

                // Negras
                string negras = "";

                if (detalles.Contains("[Black \""))
                {
                    x = detalles.IndexOf("[Black \"") + "[Black \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    negras = detalles.Substring(x, y - x);
                }

                // Resultado
                string resultado = "";

                if (detalles.Contains("[Result \""))
                {
                    x = detalles.IndexOf("[Result \"") + "[Result \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    resultado = detalles.Substring(x, y - x);
                }

                // ELO Blancas
                string eloBlancas = "0";

                if (detalles.Contains("[WhiteElo \""))
                {
                    x = detalles.IndexOf("[WhiteElo \"") + "[WhiteElo \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    eloBlancas = detalles.Substring(x, y - x);
                }

                if (eloBlancas == "") { eloBlancas = "0"; };

                // ELO Negras
                string eloNegras = "0";

                if (detalles.Contains("[BlackElo \""))
                {
                    x = detalles.IndexOf("[BlackElo \"") + "[BlackElo \"".Length;
                    y = detalles.IndexOf("\"]", x);

                    eloNegras = detalles.Substring(x, y - x);
                }

                if (eloNegras == "") { eloNegras = "0"; };

                // Cargar en visor
                LblDEvento.Text = evento + "/" + ronda;
                LblDLugar.Text = sitio;
                LblDFecha.Text = fecha;
                LblDElo.Text = eloBlancas + "/" + eloNegras;
                LblDBlancas.Text = blancas;
                LblDNegras.Text = negras;
                LblDResultado.Text = resultado;

                // Cargar en bbdd
                if (modo == FrmCargar.CARGABBDD)
                {
                    // Adaptar fecha a bbdd
                    string[] fechabd = null;

                    if (fecha != "") { fechabd = fecha.Split('/'); }

                    if (fechabd[0] == "????" || fechabd[0] == "??") { fechabd[0] = "1800"; };
                    if (fechabd[1] == "??") { fechabd[1] = "01"; };
                    if (fechabd[2] == "??") { fechabd[2] = "01"; };

                    fecha = fechabd[0] + "-" + fechabd[1] + "-" + fechabd[2];

                    // Insertar partida en bbdd
                    if (!Program.bbdd.InsertarPartida(pgn, (num / 2 + 1) + "", evento, sitio, fecha, ronda, 
                        blancas, eloBlancas, negras, eloNegras, resultado))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        /*
        // Metodo CargarMovimientosPartida
        // Carga los movimientos de la partida dada
        private bool CargarMovimientosPartida(int num, int modo)
        {
            int nmov = 0;
            num = num * 2 + 1;

            Tablero tablero = new Tablero();

            if (fichero != null && num < fichero.Length)
            {
                string movimientos = Regex.Replace(fichero[num], Environment.NewLine, " ");
                movimientos = Regex.Replace(movimientos, @"\.", " ");
                movimientos = Regex.Replace(movimientos, @"\s+", " ");

                string[] movimiento = movimientos.Split(' ');

                // Color
                int c = Pieza.BLANCA;

                // Movimiento
                int[] mov = new int[8];

                for (int i = 0; i < movimiento.Length; i++)
                {
                    mov = Chess.VectorNotacion(movimiento[i], c, tablero);

                    // Color
                    if (mov[0] != 0)
                    {
                        if (c == Pieza.BLANCA) { c = Pieza.NEGRA; }
                        else if (c == Pieza.NEGRA) { c = Pieza.BLANCA; }
                    }

                    // Cargar en visor
                    if (modo == FrmCargar.CARGAVISOR && mov[0] != 0)
                    {
                        tablero.Mover(tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                        Mover(chess.tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                    }
                    // Cargar en bbdd
                    else if (modo == FrmCargar.CARGABBDD && mov[0] != 0)
                    {
                        // Adaptar jugador a bbdd
                        string jugador = "";

                        if (nmov % 2 == 0)
                        {
                            jugador = LblDBlancas.Text;
                        }
                        else
                        {
                            jugador = LblDNegras.Text;
                        }

                        // Adaptar elo a bbdd
                        string elo = "0";

                        if (nmov % 2 == 0)
                        {
                            elo = LblDElo.Text.Split('/')[0];
                        }
                        else
                        {
                            elo = LblDElo.Text.Split('/')[1];
                        }

                        // Adaptar fecha a bbdd
                        string[] fechabd = null;

                        if (LblDFecha.Text != "") { fechabd = LblDFecha.Text.Split('/'); }

                        if (fechabd[0] == "????" || fechabd[0] == "??") { fechabd[0] = "1800"; };
                        if (fechabd[1] == "??") { fechabd[1] = "01"; };
                        if (fechabd[2] == "??") { fechabd[2] = "01"; };

                        string fecha = fechabd[0] + "-" + fechabd[1] + "-" + fechabd[2];

                        // Adaptar tablero a bbdd
                        string tablerobd = "";

                        int[][] tableroM = tablero.MatrizTipo();

                        for (int x = 0; x < 8; x++)
                        {
                            for (int y = 0; y < 8; y++)
                            {
                                tablerobd += tableroM[x][y] + ",";
                            }
                        }

                        // Adaptar movimiento a bbdd
                        string movimientobd = mov[0] + "," + mov[1] + "," + mov[2] + "," + mov[3] + "," + 
                            mov[4] + "," + mov[5] + "," + mov[6] + "," + mov[7];

                        // Insertar movimiento en bbdd
                        if (!Program.bbdd.InsertarMovimiento(pgn, (num / 2 + 1) + "", (nmov + 1) + "", fecha, 
                            jugador, elo, tablerobd, movimientobd))
                        {
                            return false;
                        }

                        tablero.Mover(tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                    }

                    nmov++;
                }
            }

            return true;
        }
        */

        // Metodo CargarMovimientosPartida
        // Carga los movimientos de la partida dada
        private bool CargarMovimientosPartida(int num, int modo)
        {
            int nmov = 0;
            num = num * 2 + 1;

            Tablero tablero = new Tablero();

            if (fichero != null && num < fichero.Length)
            {
                string movimientos = Regex.Replace(fichero[num], Environment.NewLine, " ");
                movimientos = Regex.Replace(movimientos, @"\.", " ");
                movimientos = Regex.Replace(movimientos, @"\s+", " ");

                string[] movimiento = movimientos.Split(' ');

                // [nmov, movB, movN ...]
                for (int i = 1; i < movimiento.Length; i += 3)
                {
                    // Color
                    int c = Pieza.NEGRA;

                    // [movB, movN ...]
                    for (int j = i; j < i + 2; j++)
                    {
                        // Movimiento
                        int[] mov = new int[8];

                        // Color
                        if (c == Pieza.BLANCA) { c = Pieza.NEGRA; }
                        else if (c == Pieza.NEGRA) { c = Pieza.BLANCA; }

                        mov = Chess.VectorNotacion(movimiento[j], c, tablero);

                        // Cargar en visor
                        if (modo == FrmCargar.CARGAVISOR && mov[0] != 0)
                        {
                            tablero.Mover(tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                            Mover(chess.tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                        }
                        // Cargar en bbdd
                        else if (modo == FrmCargar.CARGABBDD && mov[0] != 0)
                        {
                            // Adaptar jugador a bbdd
                            string jugador = "";

                            if (nmov % 2 == 0)
                            {
                                jugador = LblDBlancas.Text;
                            }
                            else
                            {
                                jugador = LblDNegras.Text;
                            }

                            // Adaptar elo a bbdd
                            string elo = "0";

                            if (nmov % 2 == 0)
                            {
                                elo = LblDElo.Text.Split('/')[0];
                            }
                            else
                            {
                                elo = LblDElo.Text.Split('/')[1];
                            }

                            // Adaptar fecha a bbdd
                            string[] fechabd = null;

                            if (LblDFecha.Text != "") { fechabd = LblDFecha.Text.Split('/'); }

                            if (fechabd[0] == "????" || fechabd[0] == "??") { fechabd[0] = "1800"; };
                            if (fechabd[1] == "??") { fechabd[1] = "01"; };
                            if (fechabd[2] == "??") { fechabd[2] = "01"; };

                            string fecha = fechabd[0] + "-" + fechabd[1] + "-" + fechabd[2];

                            // Adaptar tablero a bbdd
                            string tablerobd = "";

                            int[][] tableroM = tablero.MatrizTipo();

                            for (int x = 0; x < 8; x++)
                            {
                                for (int y = 0; y < 8; y++)
                                {
                                    tablerobd += tableroM[x][y] + ",";
                                }
                            }

                            // Adaptar movimiento a bbdd
                            string movimientobd = mov[0] + "," + mov[1] + "," + mov[2] + "," + mov[3] + "," +
                                mov[4] + "," + mov[5] + "," + mov[6] + "," + mov[7];

                            // Insertar movimiento en bbdd
                            if (!Program.bbdd.InsertarMovimiento(pgn, (num / 2 + 1) + "", (nmov + 1) + "", fecha,
                                jugador, elo, tablerobd, movimientobd))
                            {
                                return false;
                            }

                            tablero.Mover(tablero.matriz[mov[1]][mov[2]], mov[4], mov[5], mov[6], mov[7]);
                        }

                        nmov++;
                    }
                }
            }

            return true;
        }

        // Metodo ActualizarEstadisticas
        // Actualiza las estadisticas de la aplicacion
        private void ActualizarEstadisticas()
        {
            // Formulario chess
            LblDAtaqueB.Text = (int)chess.tablero.ataqueB + "% / " + (int)chess.tablero.defensaB + "%";
            LblDAtaqueN.Text = (int)chess.tablero.ataqueN + "% / " + (int)chess.tablero.defensaN + "%";

            LblDMovsB.Text = chess.tablero.nmovsB + " movs";
            LblDMovsN.Text = chess.tablero.nmovsN + " movs";

            // Formulario estadisticas
            frmEstadisticas.Actualizar(chess);
        }
    }
}