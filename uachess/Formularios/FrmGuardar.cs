using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmGuardar : Form
    {
        # region Atributos

        // Numero de items
        public int nitems;

        // Ruta actual
        public string ruta;

        // Formulario padre
        public FrmChess frmChess;

        # endregion

        // Constructor
        // Construye form guardar
        public FrmGuardar(FrmChess frmChess)
        {
            // Componentes
            InitializeComponent();

            // Numero de items
            nitems = 0;

            // Ruta actual
            ruta = "";

            // Mostrar items
            MostrarItems(ruta);

            // Formulario padre
            this.frmChess = frmChess;
        }

        // Evento click etiqueta cerrar
        // Oculta formulario
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // Evento mostrar formulario
        // Inicializa campos de formulario
        private void FrmGuardar_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                // Fecha
                NSTxbFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");

                // Ronda
                NSCmbRonda.SelectedIndex = 0;

                // Resultado
                NSCmbResultado.SelectedIndex = 0;

                // Evento
                NSTxbEvento.Text = "UAChess Event";

                // Lugar
                NSTxbLugar.Text = "UAChess";

                // Blancas
                NSTxbBlancas.Text = "Jugador Blancas";

                // Negras
                NSTxbNegras.Text = "Jugador Negras";

                // Fichero
                NSTxbFichero.Text = "Partida";

                // Validar
                this.ActiveControl = LblFecha;
                Validar();
            }
        }

        // Evento doble click items
        // Muestra directorio seleccionado
        private void NSLvItems_DoubleClick(object sender, EventArgs e)
        {
            // Item seleccionado
            NSListView items = (NSListView)sender;
            int nitem = Int32.Parse(items.SelectedItems[0].SubItems[0].Text);

            // Ruta item
            string ruta = items.Items[nitem].SubItems[1].Text;

            // Mostrar directorio
            MostrarItems(ruta);
        }

        // Evento cambio nombre fichero
        // Muestra ruta donde guardar fichero
        private void NSTxbFichero_TextChanged(object sender, EventArgs e)
        {
            if (ruta != "")
            {
                string[] rutaS = ruta.Split('\\');
                LblDirectorio.Text = rutaS[rutaS.Length - 2] + "\\" + NSTxbFichero.Text + ".pgn";
            }
        }

        // Evento click boton guardar
        // Guarda la partida actual
        private void NSBtnGuardar_Click(object sender, EventArgs e)
        {
            FrmMensaje frmMensaje;

            if (Validar())
            {
                // Comprobar sobreescritura de fichero
                if (File.Exists(ruta + NSTxbFichero.Text + ".pgn"))
                {
                    // Mostrar mensaje
                    frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "El fichero ya existe en la ruta dada."
                        + Environment.NewLine + "¿Desea sobreescribir el fichero?");

                    frmMensaje.ShowDialog();

                    if (frmMensaje.seleccion == FrmMensaje.BOTON1) { return; } 
                }

                // Guardar fichero
                if (GuardarFichero(ruta + NSTxbFichero.Text + ".pgn"))
                {
                    // Mostrar mensaje
                    frmMensaje = new FrmMensaje(FrmMensaje.INFO, "Partida guardada con éxito.");
                    frmMensaje.ShowDialog();

                    Hide();
                }
                else
                {
                    // Mostrar mensaje error
                    frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible guardar fichero.");
                    frmMensaje.ShowDialog();
                }
            }
            else
            {
                // Mostrar mensaje error
                frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible guardar partida."
                    + Environment.NewLine + "Corrija los campos erroneos marcados.");

                frmMensaje.ShowDialog();
            }
        }

        // Metodo MostrarItems
        // Muestra los items de la ruta dada
        private void MostrarItems(string ruta)
        {
            try
            {
                // Limpiar explorador
                NSLvItems.RemoveItems(NSLvItems.Items);
                nitems = 0;

                // Ruta inicial
                if (ruta == "")
                {
                    // Mostrar unidades
                    MostrarUnidades();

                    // Mostrar directorio de guardado
                    LblDirectorio.Text = "No seleccionado";
                }
                // Ruta no inicial
                else
                {
                    // Mostrar directorio anterior
                    MostrarAnterior(ruta);

                    // Mostrar directorios
                    MostrarDirectorios(ruta);

                    // Mostrar directorio de guardado
                    string[] rutaS = ruta.Split('\\');
                    LblDirectorio.Text = rutaS[rutaS.Length - 2] + "\\" + NSTxbFichero.Text + ".pgn";
                }

                // Seleccionar primer item en explorador
                NSLvItems._SelectedItems.Clear();
                NSLvItems._SelectedItems.Add(NSLvItems.Items[0]);
                NSLvItems.VS.Value = 0;

                // Cambiar ruta actual
                this.ruta = ruta;
            }
            catch
            {
                // Mostrar items ruta anterior
                MostrarItems(this.ruta);

                // Mostar mensaje error
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible acceder al directorio seleccionado.");
                frmMensaje.ShowDialog();
            }
        }

        // Metodo MostrarUnidades
        // Muestra las unidades del sistema
        private void MostrarUnidades()
        {
            string[] unidades = Directory.GetLogicalDrives();

            foreach (string unidad in unidades)
            {
                NSLvItems.AddItem(unidad, nitems + "", unidad);
                nitems++;
            }
        }

        // Metodo MostrarAnterior
        // Muestra el directorio anterior de la ruta dada
        private void MostrarAnterior(string ruta)
        {
            string[] rutaA = ruta.Split('\\');

            NSLvItems.AddItem("...", nitems + "", ruta.Substring(0, ruta.Length - (rutaA[rutaA.Length - 2].Length + 1)));
            nitems++;
        }

        // Metodo MostrarDirectorios
        // Muestra los directorios de la ruta dada
        private void MostrarDirectorios(string ruta)
        {
            string[] directorios = Directory.GetDirectories(ruta);

            foreach (string directorio in directorios)
            {
                string[] dir = directorio.Split('\\');
                string nombre = dir[dir.Length - 1];

                NSLvItems.AddItem(nombre, nitems + "", directorio + "\\");
                nitems++;
            }
        }

        // Metodo Validar
        // Valida los campos del formulario
        private bool Validar()
        {
            bool validar = true;

            // Fecha
            if (new Regex(@"^18|19|20[0-9]{2}/(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])$").Match(NSTxbFecha.Text).Success)
            {
                LblFecha.BackColor = Color.Transparent;
                NSTxbFecha.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblFecha.BackColor = Color.Salmon;
                NSTxbFecha.BackColor = Color.Salmon;

                validar = false;
            }

            // Evento
            if (NSTxbEvento.Text != "")
            {
                LblEvento.BackColor = Color.Transparent;
                NSTxbEvento.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblEvento.BackColor = Color.Salmon;
                NSTxbEvento.BackColor = Color.Salmon;

                validar = false;
            }

            // Lugar
            if (NSTxbLugar.Text != "")
            {
                LblLugar.BackColor = Color.Transparent;
                NSTxbLugar.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblLugar.BackColor = Color.Salmon;
                NSTxbLugar.BackColor = Color.Salmon;

                validar = false;
            }

            // Blancas
            if (NSTxbBlancas.Text != "")
            {
                LblBlancas.BackColor = Color.Transparent;
                NSTxbBlancas.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblBlancas.BackColor = Color.Salmon;
                NSTxbBlancas.BackColor = Color.Salmon;

                validar = false;
            }

            // Negras
            if (NSTxbNegras.Text != "")
            {
                LblNegras.BackColor = Color.Transparent;
                NSTxbNegras.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblNegras.BackColor = Color.Salmon;
                NSTxbNegras.BackColor = Color.Salmon;

                validar = false;
            }

            // Directorio
            if (ruta != "")
            {
                LblDirectorio.ForeColor = Color.White;
            }
            else
            {
                LblDirectorio.ForeColor = Color.Salmon;

                validar = false;
            }

            // Fichero
            if (NSTxbFichero.Text != "")
            {
                LblFichero.BackColor = Color.Transparent;
                NSTxbFichero.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                LblFichero.BackColor = Color.Salmon;
                NSTxbFichero.BackColor = Color.Salmon;

                validar = false;
            }

            return validar;
        }

        // Metodo GuardarFichero
        // Guarda fichero en ruta dada
        private bool GuardarFichero(string ruta)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);

                // Etiquetas
                sw.WriteLine("[Event \"" + NSTxbEvento.Text + "\"]");
                sw.WriteLine("[Site \"" + NSTxbLugar.Text + "\"]");
                sw.WriteLine("[Date \"" + NSTxbFecha.Text + "\"]");
                sw.WriteLine("[Round \"" + NSCmbRonda.Text + "\"]");
                sw.WriteLine("[White \"" + NSTxbBlancas.Text + "\"]");
                sw.WriteLine("[Black \"" + NSTxbNegras.Text + "\"]");
                sw.WriteLine("[Result \"" + NSCmbResultado.Text + "\"]");

                sw.WriteLine("");

                // Movimientos
                for (int i = 1, j = 0; i < frmChess.historialA.Length && frmChess.historialA[i] != null; i+=2, j++)
                {
                    // Espacio
                    if (j != 0) { sw.Write(" "); };

                    // Movimiento blanca
                    sw.Write((i/2 + 1) + ". " + frmChess.historialA[i]);

                    // Movimiento negra
                    if (frmChess.historialA[i + 1] != null)
                    {
                        sw.Write(" " + frmChess.historialA[i + 1]);
                    }

                    // Nueva linea
                    if (j == 4) { sw.Write(Environment.NewLine); j = -1; }
                }

                // Resultado
                sw.Write("  " + NSCmbResultado.Text);

                sw.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}