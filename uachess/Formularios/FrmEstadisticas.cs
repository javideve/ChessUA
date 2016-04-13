using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmEstadisticas : Form
    {
        // Constructor
        // Construye form estadisticas
        public FrmEstadisticas(Chess chess)
        {
            // Componentes
            InitializeComponent();

            // Actualizar estadisticas
            Actualizar(chess);
        }

        // Evento mostrar formulario
        // Centra el formulario mostrado
        private void FrmEstadisticas_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X, Location.Y - 25);
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // Evento click boton tipo grafica
        // Muestra grafica ataque/defensa/movilidad
        private void NSRbtGrafica_Click(object sender, EventArgs e)
        {
            // Boton seleccionado
            NSRadioButton boton = (NSRadioButton)sender;

            // Grafica ataque
            if (boton.Name == "NSRbtAtaque")
            {
                ChrtAtaque.Visible = true;
                ChrtDefensa.Visible = false;
                ChrtMovilidad.Visible = false;
            }
            // Grafica defensa
            else if (boton.Name == "NSRbtDefensa")
            {
                ChrtAtaque.Visible = false;
                ChrtDefensa.Visible = true;
                ChrtMovilidad.Visible = false;
            }
            // Grafica movilidad
            else if (boton.Name == "NSRbtMovilidad")
            {
                ChrtAtaque.Visible = false;
                ChrtDefensa.Visible = false;
                ChrtMovilidad.Visible = true;
            }
        }

        // Metodo Actualizar
        // Actualiza estadisticas de juego
        public void Actualizar(Chess chess)
        {
            // General
            ActualizarGeneral(chess);

            // Graficas
            ActualizarGraficas(chess);

            // Piezas
            ActualizarPiezas(chess);

            // Ultimo mov
            ActualizarUMov(chess);
        }

        // Metodo ActualizarGeneral
        // Actualiza estadisticas generales
        private void ActualizarGeneral(Chess chess)
        {
            // Ataque
            LblDAtaqueB.Text = chess.tablero.ataqueB.ToString("0.00") + "%";
            LblDAtaqueN.Text = chess.tablero.ataqueN.ToString("0.00") + "%";

            // Defensa
            LblDDefensaB.Text = chess.tablero.defensaB.ToString("0.00") + "%";
            LblDDefensaN.Text = chess.tablero.defensaN.ToString("0.00") + "%";

            // Movilidad
            LblDMovilidadB.Text = chess.tablero.movilidadB.ToString("0.00") + "%";
            LblDMovilidadN.Text = chess.tablero.movilidadN.ToString("0.00") + "%";

            // Eficacia
            LblDEficaciaB.Text = chess.tablero.puntosB + "/" + (chess.tablero.nturnosB);
            LblDEficaciaN.Text = chess.tablero.puntosN + "/" + (chess.tablero.nturnosN);
        }

        // Metodo ActualizarGraficas
        // Actualiza estadisticas graficas
        private void ActualizarGraficas(Chess chess)
        {
            // Grafica ataque
            if (chess.ntablero < ChrtAtaque.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtAtaque.Series["SerieB"].Points.Count - 1; i > chess.ntablero; i--)
                {
                    ChrtAtaque.Series["SerieB"].Points.RemoveAt(i);
                    ChrtAtaque.Series["SerieN"].Points.RemoveAt(i);
                }
            }
            else if (chess.ntablero > ChrtAtaque.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtAtaque.Series["SerieB"].Points.Count; i <= chess.ntablero; i++)
                {
                    ChrtAtaque.Series["SerieB"].Points.AddXY(i, chess.htableros[i].ataqueB);
                    ChrtAtaque.Series["SerieN"].Points.AddXY(i, chess.htableros[i].ataqueN);
                }
            }

            // Grafica defensa
            if (chess.ntablero < ChrtDefensa.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtDefensa.Series["SerieB"].Points.Count - 1; i > chess.ntablero; i--)
                {
                    ChrtDefensa.Series["SerieB"].Points.RemoveAt(i);
                    ChrtDefensa.Series["SerieN"].Points.RemoveAt(i);
                }
            }
            else if (chess.ntablero > ChrtDefensa.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtDefensa.Series["SerieB"].Points.Count; i <= chess.ntablero; i++)
                {
                    ChrtDefensa.Series["SerieB"].Points.AddXY(i, chess.htableros[i].defensaB);
                    ChrtDefensa.Series["SerieN"].Points.AddXY(i, chess.htableros[i].defensaN);
                }
            }

            // Grafica movilidad
            if (chess.ntablero < ChrtMovilidad.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtMovilidad.Series["SerieB"].Points.Count - 1; i > chess.ntablero; i--)
                {
                    ChrtMovilidad.Series["SerieB"].Points.RemoveAt(i);
                    ChrtMovilidad.Series["SerieN"].Points.RemoveAt(i);
                }
            }
            else if (chess.ntablero > ChrtMovilidad.Series["SerieB"].Points.Count - 1)
            {
                for (int i = ChrtMovilidad.Series["SerieB"].Points.Count; i <= chess.ntablero; i++)
                {
                    ChrtMovilidad.Series["SerieB"].Points.AddXY(i, chess.htableros[i].movilidadB);
                    ChrtMovilidad.Series["SerieN"].Points.AddXY(i, chess.htableros[i].movilidadN);
                }
            }
        }

        // Metodo ActualizarPiezas
        // Actualiza estadisticas piezas
        private void ActualizarPiezas(Chess chess)
        {
            Tablero tablero = chess.tablero;

            // Piezas blancas

            // Peon torre dama
            ActualizarPeonTDB(tablero);

            // Peon torre rey
            ActualizarPeonTRB(tablero);

            // Peon caballo dama
            ActualizarPeonCDB(tablero);

            // Peon caballo rey
            ActualizarPeonCRB(tablero);

            // Peon alfil dama
            ActualizarPeonADB(tablero);

            // Peon alfil rey
            ActualizarPeonARB(tablero);

            // Peon dama
            ActualizarPeonDB(tablero);

            // Peon rey
            ActualizarPeonRB(tablero);

            // Caballo dama
            ActualizarCaballoDB(tablero);

            // Caballo rey
            ActualizarCaballoRB(tablero);

            // Alfil dama
            ActualizarAlfilDB(tablero);

            // Alfil rey
            ActualizarAlfilRB(tablero);

            // Torre dama
            ActualizarTorreDB(tablero);

            // Torre rey
            ActualizarTorreRB(tablero);

            // Dama
            ActualizarDamaB(tablero);

            // Rey
            ActualizarReyB(tablero);

            // Piezas negras

            // Peon torre dama
            ActualizarPeonTDN(tablero);

            // Peon torre rey
            ActualizarPeonTRN(tablero);

            // Peon caballo dama
            ActualizarPeonCDN(tablero);

            // Peon caballo rey
            ActualizarPeonCRN(tablero);

            // Peon alfil dama
            ActualizarPeonADN(tablero);

            // Peon alfil rey
            ActualizarPeonARN(tablero);

            // Peon dama
            ActualizarPeonDN(tablero);

            // Peon rey
            ActualizarPeonRN(tablero);

            // Caballo dama
            ActualizarCaballoDN(tablero);

            // Caballo rey
            ActualizarCaballoRN(tablero);

            // Alfil dama
            ActualizarAlfilDN(tablero);

            // Alfil rey
            ActualizarAlfilRN(tablero);

            // Torre dama
            ActualizarTorreDN(tablero);

            // Torre rey
            ActualizarTorreRN(tablero);

            // Dama
            ActualizarDamaN(tablero);

            // Rey
            ActualizarReyN(tablero);
        }

        // Metodo ActualizarPeonTDB
        // Actualiza estadisticas peon torre dama blanco
        private void ActualizarPeonTDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonTDB.x != -1 || tablero.peonTDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePTDB.Text = "Peón TD (" + x[tablero.peonTDB.x] + "," + y[tablero.peonTDB.y] + ")";
                LblControlPTDB.Text = "C: " + tablero.peonTDB.NumControlPieza() + " / MP: " + tablero.peonTDB.NumMovimientosPieza();
                LblMovsPTDB.Text = tablero.peonTDB.nmovs + " / " + tablero.peonTDB.umov;

                LblNombrePTDB.ForeColor = Color.Goldenrod;
                PbxPeonTDB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonTDB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonTDB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePTDB.Text += " *C";
                    LblNombrePTDB.ForeColor = Color.LightBlue;
                    PbxPeonTDB.BackColor = Color.LightBlue;

                    switch (tablero.peonTDB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonTDB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonTDB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonTDB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonTDB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePTDB.Text = "Peón TD (CAP.)";
                LblControlPTDB.Text = "C: 0 / MP: 0";

                LblNombrePTDB.ForeColor = Color.Salmon;
                PbxPeonTDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonTRB
        // Actualiza estadisticas peon torre rey blanco
        private void ActualizarPeonTRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonTRB.x != -1 || tablero.peonTRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePTRB.Text = "Peón TR (" + x[tablero.peonTRB.x] + "," + y[tablero.peonTRB.y] + ")";
                LblControlPTRB.Text = "C: " + tablero.peonTRB.NumControlPieza() + " / MP: " + tablero.peonTRB.NumMovimientosPieza();
                LblMovsPTRB.Text = tablero.peonTRB.nmovs + " / " + tablero.peonTRB.umov;

                LblNombrePTRB.ForeColor = Color.Goldenrod;
                PbxPeonTRB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonTRB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonTRB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePTRB.Text += " *C";
                    LblNombrePTRB.ForeColor = Color.LightBlue;
                    PbxPeonTRB.BackColor = Color.LightBlue;

                    switch (tablero.peonTRB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonTRB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonTRB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonTRB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonTRB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePTRB.Text = "Peón TR (CAP.)";
                LblControlPTRB.Text = "C: 0 / MP: 0";

                LblNombrePTRB.ForeColor = Color.Salmon;
                PbxPeonTRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonCDB
        // Actualiza estadisticas peon caballo dama blanco
        private void ActualizarPeonCDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonCDB.x != -1 || tablero.peonCDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePCDB.Text = "Peón CD (" + x[tablero.peonCDB.x] + "," + y[tablero.peonCDB.y] + ")";
                LblControlPCDB.Text = "C: " + tablero.peonCDB.NumControlPieza() + " / MP: " + tablero.peonCDB.NumMovimientosPieza();
                LblMovsPCDB.Text = tablero.peonCDB.nmovs + " / " + tablero.peonCDB.umov;

                LblNombrePCDB.ForeColor = Color.Goldenrod;
                PbxPeonCDB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonCDB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonCDB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePCDB.Text += " *C";
                    LblNombrePCDB.ForeColor = Color.LightBlue;
                    PbxPeonCDB.BackColor = Color.LightBlue;

                    switch (tablero.peonCDB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonCDB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonCDB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonCDB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonCDB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePCDB.Text = "Peón CD (CAP.)";
                LblControlPCDB.Text = "C: 0 / MP: 0";

                LblNombrePCDB.ForeColor = Color.Salmon;
                PbxPeonCDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonCRB
        // Actualiza estadisticas peon caballo rey blanco
        private void ActualizarPeonCRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonCRB.x != -1 || tablero.peonCRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePCRB.Text = "Peón CR (" + x[tablero.peonCRB.x] + "," + y[tablero.peonCRB.y] + ")";
                LblControlPCRB.Text = "C: " + tablero.peonCRB.NumControlPieza() + " / MP: " + tablero.peonCRB.NumMovimientosPieza();
                LblMovsPCRB.Text = tablero.peonCRB.nmovs + " / " + tablero.peonCRB.umov;

                LblNombrePCRB.ForeColor = Color.Goldenrod;
                PbxPeonCRB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonCRB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonCRB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePCRB.Text += " *C";
                    LblNombrePCRB.ForeColor = Color.LightBlue;
                    PbxPeonCRB.BackColor = Color.LightBlue;

                    switch (tablero.peonCRB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonCRB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonCRB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonCRB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonCRB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePCRB.Text = "Peón CR (CAP.)";
                LblControlPCRB.Text = "C: 0 / MP: 0";

                LblNombrePCRB.ForeColor = Color.Salmon;
                PbxPeonCRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonADB
        // Actualiza estadisticas peon alfil dama blanco
        private void ActualizarPeonADB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonADB.x != -1 || tablero.peonADB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePADB.Text = "Peón AD (" + x[tablero.peonADB.x] + "," + y[tablero.peonADB.y] + ")";
                LblControlPADB.Text = "C: " + tablero.peonADB.NumControlPieza() + " / MP: " + tablero.peonADB.NumMovimientosPieza();
                LblMovsPADB.Text = tablero.peonADB.nmovs + " / " + tablero.peonADB.umov;

                LblNombrePADB.ForeColor = Color.Goldenrod;
                PbxPeonADB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonADB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonADB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePADB.Text += " *C";
                    LblNombrePADB.ForeColor = Color.LightBlue;
                    PbxPeonADB.BackColor = Color.LightBlue;

                    switch (tablero.peonADB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonADB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonADB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonADB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonADB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePADB.Text = "Peón AD (CAP.)";
                LblControlPADB.Text = "C: 0 / MP: 0";

                LblNombrePADB.ForeColor = Color.Salmon;
                PbxPeonADB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonARB
        // Actualiza estadisticas peon alfil rey blanco
        private void ActualizarPeonARB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonARB.x != -1 || tablero.peonARB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePARB.Text = "Peón AR (" + x[tablero.peonARB.x] + "," + y[tablero.peonARB.y] + ")";
                LblControlPARB.Text = "C: " + tablero.peonARB.NumControlPieza() + " / MP: " + tablero.peonARB.NumMovimientosPieza();
                LblMovsPARB.Text = tablero.peonARB.nmovs + " / " + tablero.peonARB.umov;

                LblNombrePARB.ForeColor = Color.Goldenrod;
                PbxPeonARB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonARB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonARB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePARB.Text += " *C";
                    LblNombrePARB.ForeColor = Color.LightBlue;
                    PbxPeonARB.BackColor = Color.LightBlue;

                    switch (tablero.peonARB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonARB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonARB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonARB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonARB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePARB.Text = "Peón AR (CAP.)";
                LblControlPARB.Text = "C: 0 / MP: 0";

                LblNombrePARB.ForeColor = Color.Salmon;
                PbxPeonARB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonDB
        // Actualiza estadisticas peon dama blanco
        private void ActualizarPeonDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonDB.x != -1 || tablero.peonDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePDB.Text = "Peón D (" + x[tablero.peonDB.x] + "," + y[tablero.peonDB.y] + ")";
                LblControlPDB.Text = "C: " + tablero.peonDB.NumControlPieza() + " / MP: " + tablero.peonDB.NumMovimientosPieza();
                LblMovsPDB.Text = tablero.peonDB.nmovs + " / " + tablero.peonDB.umov;

                LblNombrePDB.ForeColor = Color.Goldenrod;
                PbxPeonDB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonDB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonDB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePDB.Text += " *C";
                    LblNombrePDB.ForeColor = Color.LightBlue;
                    PbxPeonDB.BackColor = Color.LightBlue;

                    switch (tablero.peonDB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonDB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonDB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonDB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonDB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePDB.Text = "Peón D (CAP.)";
                LblControlPDB.Text = "C: 0 / MP: 0";

                LblNombrePDB.ForeColor = Color.Salmon;
                PbxPeonDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonRB
        // Actualiza estadisticas peon rey blanco
        private void ActualizarPeonRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonRB.x != -1 || tablero.peonRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePRB.Text = "Peón R (" + x[tablero.peonRB.x] + "," + y[tablero.peonRB.y] + ")";
                LblControlPRB.Text = "C: " + tablero.peonRB.NumControlPieza() + " / MP: " + tablero.peonRB.NumMovimientosPieza();
                LblMovsPRB.Text = tablero.peonRB.nmovs + " / " + tablero.peonRB.umov;

                LblNombrePRB.ForeColor = Color.Goldenrod;
                PbxPeonRB.BackColor = Color.FromArgb(50, 50, 50);

                PbxPeonRB.Image = UAChess.Properties.Resources.PzPeonB;

                // Coronacion
                if (tablero.peonRB.tipo != Pieza.IDPEONB)
                {
                    LblNombrePRB.Text += " *C";
                    LblNombrePRB.ForeColor = Color.LightBlue;
                    PbxPeonRB.BackColor = Color.LightBlue;

                    switch (tablero.peonRB.tipo)
                    {
                        case Pieza.IDCABALLOB:
                            PbxPeonRB.Image = UAChess.Properties.Resources.PzCaballoB;
                            break;

                        case Pieza.IDALFILB:
                            PbxPeonRB.Image = UAChess.Properties.Resources.PzAlfilB;
                            break;

                        case Pieza.IDTORREB:
                            PbxPeonRB.Image = UAChess.Properties.Resources.PzTorreB;
                            break;

                        case Pieza.IDDAMAB:
                            PbxPeonRB.Image = UAChess.Properties.Resources.PzDamaB;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePRB.Text = "Peón R (CAP.)";
                LblControlPRB.Text = "C: 0 / MP: 0";

                LblNombrePRB.ForeColor = Color.Salmon;
                PbxPeonRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarCaballoDB
        // Actualiza estadisticas caballo dama blanco
        private void ActualizarCaballoDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.caballoDB.x != -1 || tablero.caballoDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreCDB.Text = "Caballo D (" + x[tablero.caballoDB.x] + "," + y[tablero.caballoDB.y] + ")";
                LblControlCDB.Text = "C: " + tablero.caballoDB.NumControlPieza() + " / MP: " + tablero.caballoDB.NumMovimientosPieza();
                LblMovsCDB.Text = tablero.caballoDB.nmovs + " / " + tablero.caballoDB.umov;

                LblNombreCDB.ForeColor = Color.Goldenrod;
                PbxCaballoDB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreCDB.Text = "Caballo D (CAP.)";
                LblControlCDB.Text = "C: 0 / MP: 0";

                LblNombreCDB.ForeColor = Color.Salmon;
                PbxCaballoDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarCaballoRB
        // Actualiza estadisticas caballo rey blanco
        private void ActualizarCaballoRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.caballoRB.x != -1 || tablero.caballoRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreCRB.Text = "Caballo R (" + x[tablero.caballoRB.x] + "," + y[tablero.caballoRB.y] + ")";
                LblControlCRB.Text = "C: " + tablero.caballoRB.NumControlPieza() + " / MP: " + tablero.caballoRB.NumMovimientosPieza();
                LblMovsCRB.Text = tablero.caballoRB.nmovs + " / " + tablero.caballoRB.umov;

                LblNombreCRB.ForeColor = Color.Goldenrod;
                PbxCaballoRB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreCRB.Text = "Caballo R (CAP.)";
                LblControlCRB.Text = "C: 0 / MP: 0";

                LblNombreCRB.ForeColor = Color.Salmon;
                PbxCaballoRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarAlfilDB
        // Actualiza estadisticas alfil dama blanco
        private void ActualizarAlfilDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.alfilDB.x != -1 || tablero.alfilDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreADB.Text = "Alfil D (" + x[tablero.alfilDB.x] + "," + y[tablero.alfilDB.y] + ")";
                LblControlADB.Text = "C: " + tablero.alfilDB.NumControlPieza() + " / MP: " + tablero.alfilDB.NumMovimientosPieza();
                LblMovsADB.Text = tablero.alfilDB.nmovs + " / " + tablero.alfilDB.umov;

                LblNombreADB.ForeColor = Color.Goldenrod;
                PbxAlfilDB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreADB.Text = "Alfil D (CAP.)";
                LblControlADB.Text = "C: 0 / MP: 0";

                LblNombreADB.ForeColor = Color.Salmon;
                PbxAlfilDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarAlfilRB
        // Actualiza estadisticas alfil rey blanco
        private void ActualizarAlfilRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.alfilRB.x != -1 || tablero.alfilRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreARB.Text = "Alfil R (" + x[tablero.alfilRB.x] + "," + y[tablero.alfilRB.y] + ")";
                LblControlARB.Text = "C: " + tablero.alfilRB.NumControlPieza() + " / MP: " + tablero.alfilRB.NumMovimientosPieza();
                LblMovsARB.Text = tablero.alfilRB.nmovs + " / " + tablero.alfilRB.umov;

                LblNombreARB.ForeColor = Color.Goldenrod;
                PbxAlfilRB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreARB.Text = "Alfil R (CAP.)";
                LblControlARB.Text = "C: 0 / MP: 0";

                LblNombreARB.ForeColor = Color.Salmon;
                PbxAlfilRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarTorreDB
        // Actualiza estadisticas torre dama blanca
        private void ActualizarTorreDB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.torreDB.x != -1 || tablero.torreDB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreTDB.Text = "Torre D (" + x[tablero.torreDB.x] + "," + y[tablero.torreDB.y] + ")";
                LblControlTDB.Text = "C: " + tablero.torreDB.NumControlPieza() + " / MP: " + tablero.torreDB.NumMovimientosPieza();
                LblMovsTDB.Text = tablero.torreDB.nmovs + " / " + tablero.torreDB.umov;

                LblNombreTDB.ForeColor = Color.Goldenrod;
                PbxTorreDB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreTDB.Text = "Torre D (CAP.)";
                LblControlTDB.Text = "C: 0 / MP: 0";

                LblNombreTDB.ForeColor = Color.Salmon;
                PbxTorreDB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarTorreRB
        // Actualiza estadisticas torre rey blanca
        private void ActualizarTorreRB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.torreRB.x != -1 || tablero.torreRB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreTRB.Text = "Torre R (" + x[tablero.torreRB.x] + "," + y[tablero.torreRB.y] + ")";
                LblControlTRB.Text = "C: " + tablero.torreRB.NumControlPieza() + " / MP: " + tablero.torreRB.NumMovimientosPieza();
                LblMovsTRB.Text = tablero.torreRB.nmovs + " / " + tablero.torreRB.umov;

                LblNombreTRB.ForeColor = Color.Goldenrod;
                PbxTorreRB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreTRB.Text = "Torre R (CAP.)";
                LblControlTRB.Text = "C: 0 / MP: 0";

                LblNombreTRB.ForeColor = Color.Salmon;
                PbxTorreRB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarDamaB
        // Actualiza estadisticas dama blanca
        private void ActualizarDamaB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.damaB.x != -1 || tablero.damaB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreDB.Text = "Dama (" + x[tablero.damaB.x] + "," + y[tablero.damaB.y] + ")";
                LblControlDB.Text = "C: " + tablero.damaB.NumControlPieza() + " / MP: " + tablero.damaB.NumMovimientosPieza();
                LblMovsDB.Text = tablero.damaB.nmovs + " / " + tablero.damaB.umov;

                LblNombreDB.ForeColor = Color.Goldenrod;
                PbxDamaB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreDB.Text = "Dama (CAP.)";
                LblControlDB.Text = "C: 0 / MP: 0";

                LblNombreDB.ForeColor = Color.Salmon;
                PbxDamaB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarReyB
        // Actualiza estadisticas rey blanco
        private void ActualizarReyB(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.reyB.x != -1 || tablero.reyB.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreRB.Text = "Rey (" + x[tablero.reyB.x] + "," + y[tablero.reyB.y] + ")";
                LblControlRB.Text = "C: " + tablero.reyB.NumControlPieza() + " / MP: " + tablero.reyB.NumMovimientosPieza();
                LblMovsRB.Text = tablero.reyB.nmovs + " / " + tablero.reyB.umov;

                LblNombreRB.ForeColor = Color.Goldenrod;
                PbxReyB.BackColor = Color.FromArgb(60, 60, 60);
            }
            // Pieza capturada
            else
            {
                LblNombreRB.Text = "Rey (CAP.)";
                LblControlRB.Text = "C: 0 / MP: 0";

                LblNombreRB.ForeColor = Color.Salmon;
                PbxReyB.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonTDN
        // Actualiza estadisticas peon torre dama negro
        private void ActualizarPeonTDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonTDN.x != -1 || tablero.peonTDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePTDN.Text = "Peón TD (" + x[tablero.peonTDN.x] + "," + y[tablero.peonTDN.y] + ")";
                LblControlPTDN.Text = "C: " + tablero.peonTDN.NumControlPieza() + " / MP: " + tablero.peonTDN.NumMovimientosPieza();
                LblMovsPTDN.Text = tablero.peonTDN.nmovs + " / " + tablero.peonTDN.umov;

                LblNombrePTDN.ForeColor = Color.Goldenrod;
                PbxPeonTDN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonTDN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonTDN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePTDN.Text += " *C";
                    LblNombrePTDN.ForeColor = Color.LightBlue;
                    PbxPeonTDN.BackColor = Color.LightBlue;

                    switch (tablero.peonTDN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonTDN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonTDN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonTDN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonTDN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePTDN.Text = "Peón TD (CAP.)";
                LblControlPTDN.Text = "C: 0 / MP: 0";

                LblNombrePTDN.ForeColor = Color.Salmon;
                PbxPeonTDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonTRN
        // Actualiza estadisticas peon torre rey negro
        private void ActualizarPeonTRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonTRN.x != -1 || tablero.peonTRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePTRN.Text = "Peón TR (" + x[tablero.peonTRN.x] + "," + y[tablero.peonTRN.y] + ")";
                LblControlPTRN.Text = "C: " + tablero.peonTRN.NumControlPieza() + " / MP: " + tablero.peonTRN.NumMovimientosPieza();
                LblMovsPTRN.Text = tablero.peonTRN.nmovs + " / " + tablero.peonTRN.umov;

                LblNombrePTRN.ForeColor = Color.Goldenrod;
                PbxPeonTRN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonTRN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonTRN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePTRN.Text += " *C";
                    LblNombrePTRN.ForeColor = Color.LightBlue;
                    PbxPeonTRN.BackColor = Color.LightBlue;

                    switch (tablero.peonTRN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonTRN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonTRN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonTRN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonTRN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePTRN.Text = "Peón TR (CAP.)";
                LblControlPTRN.Text = "C: 0 / MP: 0";

                LblNombrePTRN.ForeColor = Color.Salmon;
                PbxPeonTRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonCDN
        // Actualiza estadisticas peon caballo dama negro
        private void ActualizarPeonCDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonCDN.x != -1 || tablero.peonCDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePCDN.Text = "Peón CD (" + x[tablero.peonCDN.x] + "," + y[tablero.peonCDN.y] + ")";
                LblControlPCDN.Text = "C: " + tablero.peonCDN.NumControlPieza() + " / MP: " + tablero.peonCDN.NumMovimientosPieza();
                LblMovsPCDN.Text = tablero.peonCDN.nmovs + " / " + tablero.peonCDN.umov;

                LblNombrePCDN.ForeColor = Color.Goldenrod;
                PbxPeonCDN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonCDN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonCDN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePCDN.Text += " *C";
                    LblNombrePCDN.ForeColor = Color.LightBlue;
                    PbxPeonCDN.BackColor = Color.LightBlue;

                    switch (tablero.peonCDN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonCDN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonCDN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonCDN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonCDN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePCDN.Text = "Peón CD (CAP.)";
                LblControlPCDN.Text = "C: 0 / MP: 0";

                LblNombrePCDN.ForeColor = Color.Salmon;
                PbxPeonCDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonCRN
        // Actualiza estadisticas peon caballo rey negro
        private void ActualizarPeonCRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonCRN.x != -1 || tablero.peonCRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePCRN.Text = "Peón CR (" + x[tablero.peonCRN.x] + "," + y[tablero.peonCRN.y] + ")";
                LblControlPCRN.Text = "C: " + tablero.peonCRN.NumControlPieza() + " / MP: " + tablero.peonCRN.NumMovimientosPieza();
                LblMovsPCRN.Text = tablero.peonCRN.nmovs + " / " + tablero.peonCRN.umov;

                LblNombrePCRN.ForeColor = Color.Goldenrod;
                PbxPeonCRN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonCRN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonCRN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePCRN.Text += " *C";
                    LblNombrePCRN.ForeColor = Color.LightBlue;
                    PbxPeonCRN.BackColor = Color.LightBlue;

                    switch (tablero.peonCRN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonCRN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonCRN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonCRN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonCRN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePCRN.Text = "Peón CR (CAP.)";
                LblControlPCRN.Text = "C: 0 / MP: 0";

                LblNombrePCRN.ForeColor = Color.Salmon;
                PbxPeonCRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonADN
        // Actualiza estadisticas peon alfil dama negro
        private void ActualizarPeonADN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonADN.x != -1 || tablero.peonADN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePADN.Text = "Peón AD (" + x[tablero.peonADN.x] + "," + y[tablero.peonADN.y] + ")";
                LblControlPADN.Text = "C: " + tablero.peonADN.NumControlPieza() + " / MP: " + tablero.peonADN.NumMovimientosPieza();
                LblMovsPADN.Text = tablero.peonADN.nmovs + " / " + tablero.peonADN.umov;

                LblNombrePADN.ForeColor = Color.Goldenrod;
                PbxPeonADN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonADN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonADN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePADN.Text += " *C";
                    LblNombrePADN.ForeColor = Color.LightBlue;
                    PbxPeonADN.BackColor = Color.LightBlue;

                    switch (tablero.peonADN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonADN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonADN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonADN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonADN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePADN.Text = "Peón AD (CAP.)";
                LblControlPADN.Text = "C: 0 / MP: 0";

                LblNombrePADN.ForeColor = Color.Salmon;
                PbxPeonADN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonARN
        // Actualiza estadisticas peon alfil rey negro
        private void ActualizarPeonARN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonARN.x != -1 || tablero.peonARN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePARN.Text = "Peón AR (" + x[tablero.peonARN.x] + "," + y[tablero.peonARN.y] + ")";
                LblControlPARN.Text = "C: " + tablero.peonARN.NumControlPieza() + " / MP: " + tablero.peonARN.NumMovimientosPieza();
                LblMovsPARN.Text = tablero.peonARN.nmovs + " / " + tablero.peonARN.umov;

                LblNombrePARN.ForeColor = Color.Goldenrod;
                PbxPeonARN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonARN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonARN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePARN.Text += " *C";
                    LblNombrePARN.ForeColor = Color.LightBlue;
                    PbxPeonARN.BackColor = Color.LightBlue;

                    switch (tablero.peonARN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonARN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonARN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonARN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonARN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePARN.Text = "Peón AR (CAP.)";
                LblControlPARN.Text = "C: 0 / MP: 0";

                LblNombrePARN.ForeColor = Color.Salmon;
                PbxPeonARN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonDN
        // Actualiza estadisticas peon dama negro
        private void ActualizarPeonDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonDN.x != -1 || tablero.peonDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePDN.Text = "Peón D (" + x[tablero.peonDN.x] + "," + y[tablero.peonDN.y] + ")";
                LblControlPDN.Text = "C: " + tablero.peonDN.NumControlPieza() + " / MP: " + tablero.peonDN.NumMovimientosPieza();
                LblMovsPDN.Text = tablero.peonDN.nmovs + " / " + tablero.peonDN.umov;

                LblNombrePDN.ForeColor = Color.Goldenrod;
                PbxPeonDN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonDN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonDN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePDN.Text += " *C";
                    LblNombrePDN.ForeColor = Color.LightBlue;
                    PbxPeonDN.BackColor = Color.LightBlue;

                    switch (tablero.peonDN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonDN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonDN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonDN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonDN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePDN.Text = "Peón D (CAP.)";
                LblControlPDN.Text = "C: 0 / MP: 0";

                LblNombrePDN.ForeColor = Color.Salmon;
                PbxPeonDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarPeonRN
        // Actualiza estadisticas peon rey negro
        private void ActualizarPeonRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.peonRN.x != -1 || tablero.peonRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombrePRN.Text = "Peón R (" + x[tablero.peonRN.x] + "," + y[tablero.peonRN.y] + ")";
                LblControlPRN.Text = "C: " + tablero.peonRN.NumControlPieza() + " / MP: " + tablero.peonRN.NumMovimientosPieza();
                LblMovsPRN.Text = tablero.peonRN.nmovs + " / " + tablero.peonRN.umov;

                LblNombrePRN.ForeColor = Color.Goldenrod;
                PbxPeonRN.BackColor = Color.FromArgb(60, 60, 60);

                PbxPeonRN.Image = UAChess.Properties.Resources.PzPeonN;

                // Coronacion
                if (tablero.peonRN.tipo != Pieza.IDPEONN)
                {
                    LblNombrePRN.Text += " *C";
                    LblNombrePRN.ForeColor = Color.LightBlue;
                    PbxPeonRN.BackColor = Color.LightBlue;

                    switch (tablero.peonRN.tipo)
                    {
                        case Pieza.IDCABALLON:
                            PbxPeonRN.Image = UAChess.Properties.Resources.PzCaballoN;
                            break;

                        case Pieza.IDALFILN:
                            PbxPeonRN.Image = UAChess.Properties.Resources.PzAlfilN;
                            break;

                        case Pieza.IDTORREN:
                            PbxPeonRN.Image = UAChess.Properties.Resources.PzTorreN;
                            break;

                        case Pieza.IDDAMAN:
                            PbxPeonRN.Image = UAChess.Properties.Resources.PzDamaN;
                            break;
                    }
                }
            }
            // Pieza capturada
            else
            {
                LblNombrePRN.Text = "Peón R (CAP.)";
                LblControlPRN.Text = "C: 0 / MP: 0";

                LblNombrePRN.ForeColor = Color.Salmon;
                PbxPeonRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarCaballoDN
        // Actualiza estadisticas caballo dama negro
        private void ActualizarCaballoDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.caballoDN.x != -1 || tablero.caballoDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreCDN.Text = "Caballo D (" + x[tablero.caballoDN.x] + "," + y[tablero.caballoDN.y] + ")";
                LblControlCDN.Text = "C: " + tablero.caballoDN.NumControlPieza() + " / MP: " + tablero.caballoDN.NumMovimientosPieza();
                LblMovsCDN.Text = tablero.caballoDN.nmovs + " / " + tablero.caballoDN.umov;

                LblNombreCDN.ForeColor = Color.Goldenrod;
                PbxCaballoDN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreCDN.Text = "Caballo D (CAP.)";
                LblControlCDN.Text = "C: 0 / MP: 0";

                LblNombreCDN.ForeColor = Color.Salmon;
                PbxCaballoDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarCaballoRN
        // Actualiza estadisticas caballo rey negro
        private void ActualizarCaballoRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.caballoRN.x != -1 || tablero.caballoRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreCRN.Text = "Caballo R (" + x[tablero.caballoRN.x] + "," + y[tablero.caballoRN.y] + ")";
                LblControlCRN.Text = "C: " + tablero.caballoRN.NumControlPieza() + " / MP: " + tablero.caballoRN.NumMovimientosPieza();
                LblMovsCRN.Text = tablero.caballoRN.nmovs + " / " + tablero.caballoRN.umov;

                LblNombreCRN.ForeColor = Color.Goldenrod;
                PbxCaballoRN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreCRN.Text = "Caballo R (CAP.)";
                LblControlCRN.Text = "C: 0 / MP: 0";

                LblNombreCRN.ForeColor = Color.Salmon;
                PbxCaballoRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarAlfilDN
        // Actualiza estadisticas alfil dama negro
        private void ActualizarAlfilDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.alfilDN.x != -1 || tablero.alfilDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreADN.Text = "Alfil D (" + x[tablero.alfilDN.x] + "," + y[tablero.alfilDN.y] + ")";
                LblControlADN.Text = "C: " + tablero.alfilDN.NumControlPieza() + " / MP: " + tablero.alfilDN.NumMovimientosPieza();
                LblMovsADN.Text = tablero.alfilDN.nmovs + " / " + tablero.alfilDN.umov;

                LblNombreADN.ForeColor = Color.Goldenrod;
                PbxAlfilDN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreADN.Text = "Alfil D (CAP.)";
                LblControlADN.Text = "C: 0 / MP: 0";

                LblNombreADN.ForeColor = Color.Salmon;
                PbxAlfilDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarAlfilRN
        // Actualiza estadisticas alfil rey negro
        private void ActualizarAlfilRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.alfilRN.x != -1 || tablero.alfilRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreARN.Text = "Alfil R (" + x[tablero.alfilRN.x] + "," + y[tablero.alfilRN.y] + ")";
                LblControlARN.Text = "C: " + tablero.alfilRN.NumControlPieza() + " / MP: " + tablero.alfilRN.NumMovimientosPieza();
                LblMovsARN.Text = tablero.alfilRN.nmovs + " / " + tablero.alfilRN.umov;

                LblNombreARN.ForeColor = Color.Goldenrod;
                PbxAlfilRN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreARN.Text = "Alfil R (CAP.)";
                LblControlARN.Text = "C: 0 / MP: 0";

                LblNombreARN.ForeColor = Color.Salmon;
                PbxAlfilRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarTorreDN
        // Actualiza estadisticas torre dama negra
        private void ActualizarTorreDN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.torreDN.x != -1 || tablero.torreDN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreTDN.Text = "Torre D (" + x[tablero.torreDN.x] + "," + y[tablero.torreDN.y] + ")";
                LblControlTDN.Text = "C: " + tablero.torreDN.NumControlPieza() + " / MP: " + tablero.torreDN.NumMovimientosPieza();
                LblMovsTDN.Text = tablero.torreDN.nmovs + " / " + tablero.torreDN.umov;

                LblNombreTDN.ForeColor = Color.Goldenrod;
                PbxTorreDN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreTDN.Text = "Torre D (CAP.)";
                LblControlTDN.Text = "C: 0 / MP: 0";

                LblNombreTDN.ForeColor = Color.Salmon;
                PbxTorreDN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarTorreRN
        // Actualiza estadisticas torre rey negra
        private void ActualizarTorreRN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.torreRN.x != -1 || tablero.torreRN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreTRN.Text = "Torre R (" + x[tablero.torreRN.x] + "," + y[tablero.torreRN.y] + ")";
                LblControlTRN.Text = "C: " + tablero.torreRN.NumControlPieza() + " / MP: " + tablero.torreRN.NumMovimientosPieza();
                LblMovsTRN.Text = tablero.torreRN.nmovs + " / " + tablero.torreRN.umov;

                LblNombreTRN.ForeColor = Color.Goldenrod;
                PbxTorreRN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreTRN.Text = "Torre R (CAP.)";
                LblControlTRN.Text = "C: 0 / MP: 0";

                LblNombreTRN.ForeColor = Color.Salmon;
                PbxTorreRN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarDamaN
        // Actualiza estadisticas dama negra
        private void ActualizarDamaN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.damaN.x != -1 || tablero.damaN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreDN.Text = "Dama (" + x[tablero.damaN.x] + "," + y[tablero.damaN.y] + ")";
                LblControlDN.Text = "C: " + tablero.damaN.NumControlPieza() + " / MP: " + tablero.damaN.NumMovimientosPieza();
                LblMovsDN.Text = tablero.damaN.nmovs + " / " + tablero.damaN.umov;

                LblNombreDN.ForeColor = Color.Goldenrod;
                PbxDamaN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreDN.Text = "Dama (CAP.)";
                LblControlDN.Text = "C: 0 / MP: 0";

                LblNombreDN.ForeColor = Color.Salmon;
                PbxDamaN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarReyN
        // Actualiza estadisticas rey negro
        private void ActualizarReyN(Tablero tablero)
        {
            // Pieza no capturada
            if (tablero.reyN.x != -1 || tablero.reyN.y != -1)
            {
                // Notacion coordenadas
                char[] x = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                char[] y = { '1', '2', '3', '4', '5', '6', '7', '8' };

                // Estadisticas
                LblNombreRN.Text = "Rey (" + x[tablero.reyN.x] + "," + y[tablero.reyN.y] + ")";
                LblControlRN.Text = "C: " + tablero.reyN.NumControlPieza() + " / MP: " + tablero.reyN.NumMovimientosPieza();
                LblMovsRN.Text = tablero.reyN.nmovs + " / " + tablero.reyN.umov;

                LblNombreRN.ForeColor = Color.Goldenrod;
                PbxReyN.BackColor = Color.FromArgb(50, 50, 50);
            }
            // Pieza capturada
            else
            {
                LblNombreRN.Text = "Rey (CAP.)";
                LblControlRN.Text = "C: 0 / MP: 0";

                LblNombreRN.ForeColor = Color.Salmon;
                PbxReyN.BackColor = Color.Salmon;
            }
        }

        // Metodo ActualizarUMov
        // Marca pieza de ultimo mov realizado
        private void ActualizarUMov(Chess chess)
        {
            if (chess.tablero.nmovs > 0)
            {
                int xd = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 4];
                int yd = chess.tablero.hmovs[(chess.tablero.nmovs - 1) * 10 + 5];

                switch (chess.tablero.matriz[xd][yd].pieza)
                {
                    // Piezas blancas

                    // Peon torre dama
                    case Pieza.PEONTDB:
                        LblNombrePTDB.ForeColor = Color.LightGreen;
                        PbxPeonTDB.BackColor = Color.LightGreen;
                        break;

                    // Peon torre rey
                    case Pieza.PEONTRB:
                        LblNombrePTRB.ForeColor = Color.LightGreen;
                        PbxPeonTRB.BackColor = Color.LightGreen;
                        break;

                    // Peon caballo dama
                    case Pieza.PEONCDB:
                        LblNombrePCDB.ForeColor = Color.LightGreen;
                        PbxPeonCDB.BackColor = Color.LightGreen;
                        break;

                    // Peon caballo rey
                    case Pieza.PEONCRB:
                        LblNombrePCRB.ForeColor = Color.LightGreen;
                        PbxPeonCRB.BackColor = Color.LightGreen;
                        break;

                    // Peon alfil dama
                    case Pieza.PEONADB:
                        LblNombrePADB.ForeColor = Color.LightGreen;
                        PbxPeonADB.BackColor = Color.LightGreen;
                        break;

                    // Peon alfil rey
                    case Pieza.PEONARB:
                        LblNombrePARB.ForeColor = Color.LightGreen;
                        PbxPeonARB.BackColor = Color.LightGreen;
                        break;

                    // Peon dama
                    case Pieza.PEONDB:
                        LblNombrePDB.ForeColor = Color.LightGreen;
                        PbxPeonDB.BackColor = Color.LightGreen;
                        break;

                    // Peon rey
                    case Pieza.PEONRB:
                        LblNombrePRB.ForeColor = Color.LightGreen;
                        PbxPeonRB.BackColor = Color.LightGreen;
                        break;

                    // Caballo dama
                    case Pieza.CABALLODB:
                        LblNombreCDB.ForeColor = Color.LightGreen;
                        PbxCaballoDB.BackColor = Color.LightGreen;
                        break;

                    // Caballo rey
                    case Pieza.CABALLORB:
                        LblNombreCRB.ForeColor = Color.LightGreen;
                        PbxCaballoRB.BackColor = Color.LightGreen;
                        break;

                    // Alfil dama
                    case Pieza.ALFILDB:
                        LblNombreADB.ForeColor = Color.LightGreen;
                        PbxAlfilDB.BackColor = Color.LightGreen;
                        break;

                    // Alfil rey
                    case Pieza.ALFILRB:
                        LblNombreARB.ForeColor = Color.LightGreen;
                        PbxAlfilRB.BackColor = Color.LightGreen;
                        break;

                    // Torre dama
                    case Pieza.TORREDB:
                        LblNombreTDB.ForeColor = Color.LightGreen;
                        PbxTorreDB.BackColor = Color.LightGreen;
                        break;

                    // Torre rey
                    case Pieza.TORRERB:
                        LblNombreTRB.ForeColor = Color.LightGreen;
                        PbxTorreRB.BackColor = Color.LightGreen;
                        break;

                    // Dama
                    case Pieza.DAMAB:
                        LblNombreDB.ForeColor = Color.LightGreen;
                        PbxDamaB.BackColor = Color.LightGreen;
                        break;

                    // Rey
                    case Pieza.REYB:
                        LblNombreRB.ForeColor = Color.LightGreen;
                        PbxReyB.BackColor = Color.LightGreen;
                        break;

                    // Piezas negras

                    // Peon torre dama
                    case Pieza.PEONTDN:
                        LblNombrePTDN.ForeColor = Color.LightGreen;
                        PbxPeonTDN.BackColor = Color.LightGreen;
                        break;

                    // Peon torre rey
                    case Pieza.PEONTRN:
                        LblNombrePTRN.ForeColor = Color.LightGreen;
                        PbxPeonTRN.BackColor = Color.LightGreen;
                        break;

                    // Peon caballo dama
                    case Pieza.PEONCDN:
                        LblNombrePCDN.ForeColor = Color.LightGreen;
                        PbxPeonCDN.BackColor = Color.LightGreen;
                        break;

                    // Peon caballo rey
                    case Pieza.PEONCRN:
                        LblNombrePCRN.ForeColor = Color.LightGreen;
                        PbxPeonCRN.BackColor = Color.LightGreen;
                        break;

                    // Peon alfil dama
                    case Pieza.PEONADN:
                        LblNombrePADN.ForeColor = Color.LightGreen;
                        PbxPeonADN.BackColor = Color.LightGreen;
                        break;

                    // Peon alfil rey
                    case Pieza.PEONARN:
                        LblNombrePARN.ForeColor = Color.LightGreen;
                        PbxPeonARN.BackColor = Color.LightGreen;
                        break;

                    // Peon dama
                    case Pieza.PEONDN:
                        LblNombrePDN.ForeColor = Color.LightGreen;
                        PbxPeonDN.BackColor = Color.LightGreen;
                        break;

                    // Peon rey
                    case Pieza.PEONRN:
                        LblNombrePRN.ForeColor = Color.LightGreen;
                        PbxPeonRN.BackColor = Color.LightGreen;
                        break;

                    // Caballo dama
                    case Pieza.CABALLODN:
                        LblNombreCDN.ForeColor = Color.LightGreen;
                        PbxCaballoDN.BackColor = Color.LightGreen;
                        break;

                    // Caballo rey
                    case Pieza.CABALLORN:
                        LblNombreCRN.ForeColor = Color.LightGreen;
                        PbxCaballoRN.BackColor = Color.LightGreen;
                        break;

                    // Alfil dama
                    case Pieza.ALFILDN:
                        LblNombreADN.ForeColor = Color.LightGreen;
                        PbxAlfilDN.BackColor = Color.LightGreen;
                        break;

                    // Alfil rey
                    case Pieza.ALFILRN:
                        LblNombreARN.ForeColor = Color.LightGreen;
                        PbxAlfilRN.BackColor = Color.LightGreen;
                        break;

                    // Torre dama
                    case Pieza.TORREDN:
                        LblNombreTDN.ForeColor = Color.LightGreen;
                        PbxTorreDN.BackColor = Color.LightGreen;
                        break;

                    // Torre rey
                    case Pieza.TORRERN:
                        LblNombreTRN.ForeColor = Color.LightGreen;
                        PbxTorreRN.BackColor = Color.LightGreen;
                        break;

                    // Dama
                    case Pieza.DAMAN:
                        LblNombreDN.ForeColor = Color.LightGreen;
                        PbxDamaN.BackColor = Color.LightGreen;
                        break;

                    // Rey
                    case Pieza.REYN:
                        LblNombreRN.ForeColor = Color.LightGreen;
                        PbxReyN.BackColor = Color.LightGreen;
                        break;
                }
            }
        }
    }
}