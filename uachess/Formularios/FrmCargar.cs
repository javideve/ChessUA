using System;
using System.IO;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmCargar : Form
    {
        # region Constantes

        // Modo carga
        public const int CARGAVISOR = 1;
        public const int CARGABBDD = 2;

        # endregion

        # region Atributos

        // Modo carga
        public int modo;

        // Numero de items
        public int nitems;

        // Ruta actual
        public string ruta;

        // Formulario padre
        public FrmChess frmChess;

        # endregion

        // Constructor
        // Construye form cargar
        public FrmCargar(FrmChess frmChess)
        {
            // Componentes
            InitializeComponent();

            // Modo carga
            modo = 0;

            // Numero de items
            nitems = 0;

            // Ruta actual
            ruta = "";

            // Mostrar items
            MostrarItems(ruta, "*");

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
        // Inicializa modo de carga de fichero
        private void FrmCargar_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                modo = 0;
            }
        }

        // Evento doble click items
        // Muestra directorio o carga fichero seleccionado
        private void NSLvItems_DoubleClick(object sender, EventArgs e)
        {
            // Item seleccionado
            NSListView items = (NSListView)sender;
            int nitem = Int32.Parse(items.SelectedItems[0].SubItems[1].Text);

            // Tipo item
            string tipo = items.Items[nitem].SubItems[0].Text;

            // Ruta item
            string ruta = items.Items[nitem].SubItems[2].Text;

            // Mostrar directorio
            if (tipo == "Dir.")
            {
                MostrarItems(ruta, "*");
            }
            // Cargar fichero
            else if (tipo == "PGN")
            {
                // Cargar fichero en visor
                if (NSRbtVisor.Checked)
                {
                    // Mostrar mensaje
                    FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Quiere cargar la/s partida/s en visor?");
                    frmMensaje.ShowDialog();

                    if (frmMensaje.seleccion == FrmMensaje.BOTON2)
                    {
                        CargarFichero(ruta);
                        modo = CARGAVISOR;
                        Close();
                    }
                }
                // Cargar fichero en bbdd
                else if (NSRbtBBDD.Checked)
                {
                    // Mostrar mensaje
                    FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.AVISO, "¿Quiere guardar la/s partida/s en BBDD?");
                    frmMensaje.ShowDialog();

                    if (frmMensaje.seleccion == FrmMensaje.BOTON2)
                    {
                        CargarFichero(ruta);
                        modo = CARGABBDD;
                        Close();
                    }
                }
            }

            // Borrar campo busqueda
            NSTxbBuscar.Text = "";
        }

        // Evento click boton buscar
        // Busca el fichero con patron dado en campo de busqueda
        private void NSBtnBuscar_Click(object sender, EventArgs e)
        {
            // Limpiar explorador
            NSLvItems.RemoveItems(NSLvItems.Items);
            nitems = 0;

            // Mostrar ficheros con patron
            if (NSTxbBuscar.Text != "")
            {
                MostrarFicheros(ruta, "*" + NSTxbBuscar.Text + "*");
            }
            // Mostrar todos los items
            else
            {
                MostrarItems(ruta, "*");
            }
        }

        // Metodo MostrarItems
        // Muestra los items de la ruta dada segun patron
        private void MostrarItems(string ruta, string patron)
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
                }
                // Ruta no inicial
                else
                {
                    // Mostrar directorio anterior
                    MostrarAnterior(ruta);

                    // Mostrar ficheros
                    MostrarFicheros(ruta, patron);

                    // Mostrar directorios
                    MostrarDirectorios(ruta);
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
                MostrarItems(this.ruta, "*");

                // Mostrar mensaje error
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible acceder al fichero o dir. seleccionado.");
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
                NSLvItems.AddItem(unidad, "Dir.", nitems + "", unidad);
                nitems++;
            }
        }

        // Metodo MostrarAnterior
        // Muestra el directorio anterior de la ruta dada
        private void MostrarAnterior(string ruta)
        {
            string[] rutaA = ruta.Split('\\');

            NSLvItems.AddItem("...", "Dir.", nitems + "", ruta.Substring(0, ruta.Length - (rutaA[rutaA.Length - 2].Length + 1)));
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

                NSLvItems.AddItem(nombre, "Dir.", nitems + "", directorio + "\\");
                nitems++;
            }
        }

        // Metodo MostrarFicheros
        // Muestra los ficheros de la ruta dada segun patron
        private void MostrarFicheros(string ruta, string patron)
        {
            string[] ficheros = Directory.GetFiles(ruta, patron + ".pgn");

            foreach (string fichero in ficheros)
            {
                string[] fic = fichero.Split('\\');
                string nombre = fic[fic.Length - 1];

                NSLvItems.AddItem(nombre, "PGN", nitems + "", fichero);
                nitems++;
            }
        }

        // Metodo CargarFichero
        // Carga fichero de ruta dada en memoria
        private bool CargarFichero(string ruta)
        {
            try
            {
                // Cargar fichero en memoria
                StreamReader sr = new StreamReader(ruta);
                string fichero = sr.ReadToEnd();
                sr.Close();

                // Guardar ruta y pgn de fichero
                frmChess.ruta = ruta;
                string[] pgn = ruta.Split('\\');
                frmChess.pgn = pgn[pgn.Length - 1].Split('.')[0];

                // Cargar fichero en bloques
                string[] separador = new string[] { System.Environment.NewLine + System.Environment.NewLine };
                frmChess.fichero = fichero.Split(separador, StringSplitOptions.None);

                return true;
            }
            catch
            {
                // Mostrar mensaje error
                FrmMensaje frmMensaje = new FrmMensaje(FrmMensaje.ERROR, "Imposible cargar fichero.");
                frmMensaje.ShowDialog();
            }

            return false;
        }
    }
}