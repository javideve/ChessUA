using System;
using System.Windows.Forms;
using UAChess.Clases;

namespace UAChess
{
    static class Program
    {
        # region Atributos

        // Conexion bbdd
        static public BBDD bbdd;

        # endregion

        // Punto de entrada
        [STAThread] static void Main()
        {
            // Estilos visuales
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Conexion bbdd
            bbdd = new BBDD();

            // Iniciar aplicacion
            Application.Run(new FrmSplash());
        }
    }
}