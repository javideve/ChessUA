using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAChess
{
    public partial class FrmMensaje : Form
    {
        # region Atributos

        // Tipo de mensaje
        public const int INFO = 1;
        public const int AVISO = 2;
        public const int ERROR = 3;
        public const int ESPERA = 4;
        public const int CORONA = 5;
        public int tipo;

        // Seleccion
        public const int BOTON1 = 1;
        public const int BOTON2 = 2;
        public const int BOTON3 = 3;
        public const int BOTON4 = 4;
        public int seleccion;

        # endregion

        // Constructor
        // Construye form mensaje
        public FrmMensaje(int tipo, string mensaje)
        {
            // Componentes
            InitializeComponent();

            // Tipo de mensaje
            this.tipo = tipo;

            // Seleccion
            seleccion = 0;

            // Genera mensaje de tipo dado
            Mensaje(tipo, mensaje);
        }

        // Evento mostrar formulario
        // Centra el formulario mostrado
        private void FrmMensaje_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + 125);
        }

        // Evento click boton
        // Selecciona el boton
        private void NSBtn_Click(object sender, EventArgs e)
        {
            // Boton seleccionado
            NSButton boton = (NSButton)sender;

            // Seleccionar boton
            switch (boton.Name)
            {
                // Boton 1
                case "NSBtn1":
                    seleccion = BOTON1;
                    break;

                // Boton 2
                case "NSBtn2":
                    seleccion = BOTON2;
                    break;

                // Boton 3
                case "NSBtn3":
                    seleccion = BOTON3;
                    break;

                // Boton 4
                case "NSBtn4":
                    seleccion = BOTON4;
                    break;
            }

            // Cerrar mensaje
            if (tipo != ESPERA)
            {
                Close();
            }
            else
            {
                NSBtn1.Text = "Espere";
            }

        }

        // Mensaje
        // Genera mensaje de tipo dado
        public bool Mensaje(int tipo, string mensaje)
        {
            // Tipo de mensaje
            this.tipo = tipo;

            // Seleccion
            seleccion = 0;

            // Generar ventana tipo
            switch (tipo)
            {
                // Mensaje INFO
                case INFO:
                    NSLblTitulo.Value2 = "INFO.";
                    PbxImagen.Image = UAChess.Properties.Resources.MsgInfo;
                    NSBtn2.Visible = NSBtn3.Visible = NSBtn4.Visible = false;
                    NSBtn1.Visible = true;
                    NSBtn1.Text = "Aceptar";
                    break;

                // Mensaje AVISO
                case AVISO:
                    NSLblTitulo.Value2 = "AVISO";
                    PbxImagen.Image = UAChess.Properties.Resources.MsgAviso;
                    NSBtn3.Visible = NSBtn4.Visible = false;
                    NSBtn1.Visible = NSBtn2.Visible = true;
                    NSBtn1.Text = "No"; NSBtn2.Text = "Sí";
                    break;

                // Mensaje ERROR
                case ERROR:
                    NSLblTitulo.Value2 = "ERROR";
                    PbxImagen.Image = UAChess.Properties.Resources.MsgError;
                    NSBtn2.Visible = NSBtn3.Visible = NSBtn4.Visible = false;
                    NSBtn1.Visible = true;
                    NSBtn1.Text = "Aceptar";
                    break;

                // Mensaje ESPERA
                case ESPERA:
                    NSLblTitulo.Value2 = "ESPERE";
                    PbxImagen.Image = UAChess.Properties.Resources.AppCargando;
                    NSBtn2.Visible = NSBtn3.Visible = NSBtn4.Visible = false;
                    NSBtn1.Visible = true;
                    NSBtn1.Text = "Abortar";
                    break;

                // Mensaje CORONA
                case CORONA:
                    NSLblTitulo.Value2 = "CORONA.";
                    PbxImagen.Image = UAChess.Properties.Resources.MsgAviso;
                    NSBtn1.Visible = NSBtn2.Visible = NSBtn3.Visible = NSBtn4.Visible = true;
                    NSBtn1.Text = "Dama"; NSBtn2.Text = "Torre"; NSBtn3.Text = "Alfil"; NSBtn4.Text = "Caballo";
                    break;

                default:
                    return false;
            }

            // Mensaje
            Mensaje(mensaje);

            return true;
        }

        // Mensaje
        // Cambia el mensaje mostrado
        public void Mensaje(string mensaje)
        {
            LblMensaje.Text = mensaje;
        }
    }
}