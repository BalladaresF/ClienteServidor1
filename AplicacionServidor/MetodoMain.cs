using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesRentaUned; //esta librería contiene las clases utilizadas en la aplicación.

namespace WindowsFormsApp1
{
    internal static class MetodoMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PantallaPrincipal form = new PantallaPrincipal();
            Application.Run(new PantallaPrincipal());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        
    }
}

/* Fuente del código para que un textBox solo acepte números:
 * https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
 * 
 * El DataGridView que muestra y selecciona los vehículos en RegistrarVehículoSucursal está basado en el siguiente video:
 * https://www.youtube.com/watch?v=_iJuxh08TdQ&ab_channel=VetrivelD
 * 
 * Video que explica la creadión de DLLs:
 * https://www.youtube.com/watch?v=JAU8Cc7jX_Y&ab_channel=Inform%C3%A1ticayProgramaci%C3%B3n
 * 
 * El código que inserta datos a SQL, el que los muestra y el uso de TcpListener está basado en la tercera sesión virtual de Programación Avanzada:
 * https://www.youtube.com/watch?v=wK6Kexsq8ZM&list=WL&index=100&ab_channel=C%C3%A1tedraTecnolog%C3%ADadeSistemas%2FInform%C3%A1ticaUNEDCR
 * 
 * Menciones honoríficas;
 * https://stackoverflow.com/questions/9079466/visual-studio-popup-the-operation-could-not-be-completed
 */