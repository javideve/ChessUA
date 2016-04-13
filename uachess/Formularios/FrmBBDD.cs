using System;
using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmBBDD : Form
    {
        // Constructor
        // Construye form BBDD
        public FrmBBDD()
        {
            // Componentes
            InitializeComponent();

            // Jugador
            NSCmbJugador.SelectedIndex = 0;

            // ELO Jugador
            NSCmbElo.SelectedIndex = 0;

            // Fecha final
            NSTxbFechaFin.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // Evento mostrar formulario
        // Limpia formulario de consultas
        private void FrmBBDD_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                Limpiar();
            }
        }

        // Evento cambio BBDD
        // Actualiza lista jugadores de bbdd seleccionada
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

        // Evento click boton borrar todo
        // Borra todas las bbdd de la aplicacion
        private void NSBtnBorrarTodo_Click(object sender, EventArgs e)
        {
            FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Seguro que quiere borrar todas las BBDD?");
            frmMensaje.ShowDialog();

            if (frmMensaje.seleccion == FrmMensaje.BOTON2)
            {
                if (Program.bbdd.EliminarBDS())
                {
                    frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Borradas con éxito todas las BBDD.");
                    frmMensaje.ShowDialog();

                    Limpiar();

                    if (FrmCPU.bbddAc)
                    {
                        frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Config. de BBDD motor CPU será eliminada."
                            + Environment.NewLine + "Vuelva a configurarla si lo desea.");

                        frmMensaje.ShowDialog();

                        FrmCPU.bbddAc = false;
                        FrmCPU.bbdd = -1;
                        FrmCPU.jugador = 0;
                        FrmCPU.fechaI = "1800/01/01";
                        FrmCPU.fechaF = DateTime.Now.ToString("yyyy/MM/dd");
                    }
                }
                else
                {
                    frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible borrar todas las BBDD.");
                    frmMensaje.ShowDialog();
                }
            }
        }

        // Evento click boton borrar bbdd
        // Borra la bbdd seleccionada
        private void NSBtnBorrarBBDD_Click(object sender, EventArgs e)
        {
            if (NSCmbBBDD.SelectedIndex > 0)
            {
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Seguro que quiere borrar esta BBDD?");
                frmMensaje.ShowDialog();

                if (frmMensaje.seleccion == FrmMensaje.BOTON2)
                {
                    if (Program.bbdd.BorrarBBDD(NSCmbBBDD.Text))
                    {
                        frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Borrada con éxito la BBDD.");
                        frmMensaje.ShowDialog();

                        Limpiar();

                        if (FrmCPU.bbddAc)
                        {
                            frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Config. de BBDD motor CPU será eliminada."
                                + Environment.NewLine + "Vuelva a configurarla si lo desea.");

                            frmMensaje.ShowDialog();

                            FrmCPU.bbddAc = false;
                            FrmCPU.bbdd = -1;
                            FrmCPU.jugador = 0;
                            FrmCPU.fechaI = "1800/01/01";
                            FrmCPU.fechaF = DateTime.Now.ToString("yyyy/MM/dd");
                        }
                    }
                    else
                    {
                        frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible borrar la BBDD.");
                        frmMensaje.ShowDialog();
                    }
                }
            }
        }

        // Evento click items
        // Muestra detalles de movimiento seleccionado
        private void NSLvItems_Click(object sender, EventArgs e)
        {
            if (NSLvItems.Items.Length > 0)
            {
                // Item seleccionado
                NSListView items = (NSListView)sender;

                // Cargar Tablero
                string[] tablero = items.SelectedItems[0].SubItems[6].Text.Split(',');

                // Tablero
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + i + "" + j, true)[0];

                        if (casilla.Tag.ToString()[0] == 'B')
                        {
                            casilla.BackColor = Color.FromArgb(100, 100, 100);
                        }
                        else if (casilla.Tag.ToString()[0] == 'N')
                        {
                            casilla.BackColor = Color.FromArgb(25, 25, 25);
                        }

                        switch (Convert.ToInt32(tablero[i * 8 + j]))
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

                // Cargar movimiento
                string[] movimiento = items.SelectedItems[0].SubItems[3].Text.Split(',');

                int po = Convert.ToInt32(movimiento[0]);
                int xo = Convert.ToInt32(movimiento[1]);
                int yo = Convert.ToInt32(movimiento[2]);
                int pd = Convert.ToInt32(movimiento[3]);
                int xd = Convert.ToInt32(movimiento[4]);
                int yd = Convert.ToInt32(movimiento[5]);
                int me = Convert.ToInt32(movimiento[6]);
                int pe = Convert.ToInt32(movimiento[7]);

                PictureBox casillaO = (PictureBox)Controls.Find("PbxCasilla" + xo + "" + yo, true)[0];
                PictureBox casillaD = (PictureBox)Controls.Find("PbxCasilla" + xd + "" + yd, true)[0];

                // Movimiento NORMAL
                casillaD.Image = casillaO.Image;
                casillaO.Image = null;

                // Movimiento ALPASO blancas
                if (po > 0 && me == Tablero.ALPASO)
                {
                    PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + xd + "" + (yd - 1), true)[0];
                    casilla.Image = null;
                }
                // Movimiento ALPASO negras
                else if (po < 0 && me == Tablero.ALPASO)
                {
                    PictureBox casilla = (PictureBox)Controls.Find("PbxCasilla" + xd + "" + (yd + 1), true)[0];
                    casilla.Image = null;
                }
                // Movimiento ENROQUEC blancas
                else if (po > 0 && me == Tablero.ENROQUEC)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla70", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (xd - 1) + "" + yd, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }
                // Movimiento ENROQUEC negras
                else if (po < 0 && me == Tablero.ENROQUEC)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla77", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (xd - 1) + "" + yd, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }

                // Movimiento ENROQUEL blancas
                else if (po > 0 && me == Tablero.ENROQUEL)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla00", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (xd + 1) + "" + yd, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }

                // Movimiento ENROQUEL negras
                else if (po < 0 && me == Tablero.ENROQUEL)
                {
                    PictureBox casillaTO = (PictureBox)Controls.Find("PbxCasilla07", true)[0];
                    PictureBox casillaTD = (PictureBox)Controls.Find("PbxCasilla" + (xd + 1) + "" + yd, true)[0];

                    casillaTD.Image = casillaTO.Image;
                    casillaTO.Image = null;
                }
                // Movimiento CORONA blancas
                else if (po > 0 && me == Tablero.CORONA)
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
                else if (po < 0 && me == Tablero.CORONA)
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

                // Marcar movimiento
                casillaO.BackColor = Color.LightGreen;
                casillaD.BackColor = Color.LightGreen;

                // Detalles
                ArrayList partida = Program.bbdd.ConsultaObtenerPartidas(items.SelectedItems[0].SubItems[4].Text, items.SelectedItems[0].SubItems[5].Text);

                LblDEvento.Text = partida[2].ToString();
                LblDLugar.Text = partida[3].ToString();
                LblDBlancas.Text = partida[6].ToString() + " [" + partida[7].ToString() + "]";
                LblDNegras.Text = partida[8].ToString() + " [" + partida[9].ToString() + "]";
                LblDResultado.Text = partida[10].ToString();
            }
        }

        // Evento click boton borrar partida
        // Borra la partida asociada a movimiento seleccionado
        private void NSBtnBorrarPartida_Click(object sender, EventArgs e)
        {
            if (NSLvItems.Items.Length > 0)
            {
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Borrar partida asociada a mov seleccionado?");
                frmMensaje.ShowDialog();

                if (frmMensaje.seleccion == FrmMensaje.BOTON2)
                {
                    if (Program.bbdd.BorrarPartida(NSLvItems.SelectedItems[0].SubItems[4].Text, NSLvItems.SelectedItems[0].SubItems[5].Text))
                    {
                        frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Partida borrada con éxito.");
                        frmMensaje.ShowDialog();

                        Limpiar();
                    }
                    else
                    {
                        frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible borrar la partida.");
                        frmMensaje.ShowDialog();
                    }
                }
            }
        }

        // Evento click boton limpiar
        // Limpia formulario de consultas
        private void NSBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Evento click boton buscar
        // Busca movimientos en bbdd
        private void NSBtnBuscar_Click(object sender, EventArgs e)
        {
            FrmMensaje frmMensaje;

            if (Validar())
            {
                BuscarMovimientos();

                if (NSLvItems.Items.Length > 0)
                {
                    NSLvItems._SelectedItems.Clear();
                    NSLvItems._SelectedItems.Add(NSLvItems.Items[0]);
                    NSLvItems.VS.Value = 0;

                    NSLvItems_Click(NSLvItems, null);
                }
            }
            else
            {
                // Mensaje error
                frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible buscar movimientos."
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
            if (NSCmbBBDD.Text != "")
            {
                NSCmbBBDD.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
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

        // Metodo BuscarMovimientos
        // Busca movimientos en bbdd dada
        private bool BuscarMovimientos()
        {
            // Obtener elo minimo y maximo
            int eloMin, eloMax;
            eloMin = 0;
            eloMax = 10000;

            switch (NSCmbElo.SelectedIndex)
            {
                // 1000-1399: Principiante
                case 1:
                    eloMin = 1000;
                    eloMax = 1399;
                    break;

                // 1400-1599: Aficionado
                case 2:
                    eloMin = 1400;
                    eloMax = 1599;
                    break;

                // 1600-1799: Club Medio
                case 3:
                    eloMin = 1600;
                    eloMax = 1799;
                    break;

                // 1800-1999: Club Fuerte
                case 4:
                    eloMin = 1800;
                    eloMax = 1999;
                    break;

                // 2000-2199: Exp. Nacional
                case 5:
                    eloMin = 2000;
                    eloMax = 2199;
                    break;

                // 2200-2299: Ca. Maestro
                case 6:
                    eloMin = 2200;
                    eloMax = 2299;
                    break;

                // 2300-2399: Maestro Fide
                case 7:
                    eloMin = 2300;
                    eloMax = 2399;
                    break;

                // 2400-2499: Maestro Inter
                case 8:
                    eloMin = 2400;
                    eloMax = 2499;
                    break;

                // 2500-2599: Gran Maestro
                case 9:
                    eloMin = 2500;
                    eloMax = 2599;
                    break;

                // 2600-2699: Sup. Maestro
                case 10:
                    eloMin = 2600;
                    eloMax = 2699;
                    break;

                // 2700-2799: Ca. Campeón
                case 11:
                    eloMin = 2700;
                    eloMax = 2799;
                    break;

                // 2800+: Campeón Mundo
                case 12:
                    eloMin = 2800;
                    eloMax = 10000;
                    break;
            }

            NSLvItems.RemoveItems(NSLvItems.Items);

            // Mostrar movimientos
            ArrayList movimientos = Program.bbdd.ConsultaObtenerMovimientos(NSCmbBBDD.Text, NSTxbFechaIni.Text.Replace('/', '-'), 
                                    NSTxbFechaFin.Text.Replace('/', '-'), NSCmbJugador.Text, eloMin + "", eloMax + "");

            if (movimientos != null)
            {
                for (int i = 0; i < movimientos.Count; i+=8)
                {
                    string[] movS = movimientos[i+7].ToString().Split(',');

                    string mov = Chess.NotacionAlgebraicaL(Convert.ToInt32(movS[0]), Convert.ToInt32(movS[1]), Convert.ToInt32(movS[2]),
                                                     Convert.ToInt32(movS[3]), Convert.ToInt32(movS[4]), Convert.ToInt32(movS[5]),
                                                     Convert.ToInt32(movS[6]), Convert.ToInt32(movS[7]), 0, 0);

                    NSLvItems.AddItem(movimientos[i + 3].ToString().Split(' ')[0], movimientos[i + 4].ToString(), movimientos[i + 5].ToString(), mov, movimientos[i + 7].ToString(), movimientos[i].ToString(), movimientos[i + 1].ToString(), movimientos[i + 6].ToString());
                }

                return true;
            }

            return false;
        }

        // Metodo limpiar
        // Limpia los campos de formulario
        private void Limpiar()
        {
            // BBDD
            NSCmbBBDD.Items.Clear();
            NSCmbBBDD.Items.Add("");

            ArrayList bbdds = Program.bbdd.ConsultaObtenerBDS();

            for (int i = 0; i < bbdds.Count; i++)
            {
                NSCmbBBDD.Items.Add(bbdds[i]);
            }

            NSCmbBBDD.SelectedIndex = 0;

            // Consulta
            NSLvItems.RemoveItems(NSLvItems.Items);

            // Jugador
            NSCmbJugador.SelectedItem = 0;

            // Elo
            NSCmbElo.SelectedItem = 0;

            // Fecha inicial/final
            NSTxbFechaIni.Text = "1800/01/01";
            NSTxbFechaFin.Text = DateTime.Now.ToString("yyyy/MM/dd");

            // Tablero
            PbxCasilla00.Image = UAChess.Properties.Resources.PzTorreB;
            PbxCasilla00.BackColor = Color.FromArgb(25,25,25);
            PbxCasilla10.Image = UAChess.Properties.Resources.PzCaballoB;
            PbxCasilla10.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla20.Image = UAChess.Properties.Resources.PzAlfilB;
            PbxCasilla20.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla30.Image = UAChess.Properties.Resources.PzDamaB;
            PbxCasilla30.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla40.Image = UAChess.Properties.Resources.PzReyB;
            PbxCasilla40.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla50.Image = UAChess.Properties.Resources.PzAlfilB;
            PbxCasilla50.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla60.Image = UAChess.Properties.Resources.PzCaballoB;
            PbxCasilla60.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla70.Image = UAChess.Properties.Resources.PzTorreB;
            PbxCasilla70.BackColor = Color.FromArgb(100, 100, 100);

            PbxCasilla01.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla01.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla11.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla11.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla21.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla21.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla31.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla31.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla41.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla41.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla51.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla51.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla61.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla61.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla71.Image = UAChess.Properties.Resources.PzPeonB;
            PbxCasilla71.BackColor = Color.FromArgb(25, 25, 25);

            PbxCasilla02.Image = null;
            PbxCasilla02.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla12.Image = null;
            PbxCasilla12.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla22.Image = null;
            PbxCasilla22.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla32.Image = null;
            PbxCasilla32.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla42.Image = null;
            PbxCasilla42.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla52.Image = null;
            PbxCasilla52.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla62.Image = null;
            PbxCasilla62.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla72.Image = null;
            PbxCasilla72.BackColor = Color.FromArgb(100, 100, 100);

            PbxCasilla03.Image = null;
            PbxCasilla03.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla13.Image = null;
            PbxCasilla13.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla23.Image = null;
            PbxCasilla23.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla33.Image = null;
            PbxCasilla33.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla43.Image = null;
            PbxCasilla43.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla53.Image = null;
            PbxCasilla53.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla63.Image = null;
            PbxCasilla63.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla73.Image = null;
            PbxCasilla73.BackColor = Color.FromArgb(25, 25, 25);

            PbxCasilla04.Image = null;
            PbxCasilla04.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla14.Image = null;
            PbxCasilla14.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla24.Image = null;
            PbxCasilla24.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla34.Image = null;
            PbxCasilla34.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla44.Image = null;
            PbxCasilla44.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla54.Image = null;
            PbxCasilla54.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla64.Image = null;
            PbxCasilla64.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla74.Image = null;
            PbxCasilla74.BackColor = Color.FromArgb(100, 100, 100);

            PbxCasilla05.Image = null;
            PbxCasilla05.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla15.Image = null;
            PbxCasilla15.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla25.Image = null;
            PbxCasilla25.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla35.Image = null;
            PbxCasilla35.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla45.Image = null;
            PbxCasilla45.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla55.Image = null;
            PbxCasilla55.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla65.Image = null;
            PbxCasilla65.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla75.Image = null;
            PbxCasilla75.BackColor = Color.FromArgb(25, 25, 25);

            PbxCasilla06.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla06.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla16.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla16.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla26.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla26.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla36.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla36.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla46.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla46.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla56.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla56.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla66.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla66.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla76.Image = UAChess.Properties.Resources.PzPeonN;
            PbxCasilla76.BackColor = Color.FromArgb(100, 100, 100);

            PbxCasilla07.Image = UAChess.Properties.Resources.PzTorreN;
            PbxCasilla07.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla17.Image = UAChess.Properties.Resources.PzCaballoN;
            PbxCasilla17.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla27.Image = UAChess.Properties.Resources.PzAlfilN;
            PbxCasilla27.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla37.Image = UAChess.Properties.Resources.PzDamaN;
            PbxCasilla37.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla47.Image = UAChess.Properties.Resources.PzReyN;
            PbxCasilla47.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla57.Image = UAChess.Properties.Resources.PzAlfilN;
            PbxCasilla57.BackColor = Color.FromArgb(25, 25, 25);
            PbxCasilla67.Image = UAChess.Properties.Resources.PzCaballoN;
            PbxCasilla67.BackColor = Color.FromArgb(100, 100, 100);
            PbxCasilla77.Image = UAChess.Properties.Resources.PzTorreN;
            PbxCasilla77.BackColor = Color.FromArgb(25, 25, 25);

            // Detalles
            LblDEvento.Text = "";
            LblDLugar.Text = "";
            LblDBlancas.Text = "";
            LblDNegras.Text = "";
            LblDResultado.Text = "";
        }
    }
}