using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public static class GestorImagenPerfil
    {
        public static void CargarImagenPerfil(string usuario, PictureBox pictureBox)
        {
            string ruta = Path.Combine(Application.StartupPath, "Imagenes", "Generico.png");

            if (usuario == "Alberth")
                ruta = Path.Combine(Application.StartupPath, "Imagenes", "Alberth.png");
            else if (usuario == "Zavala")
                ruta = Path.Combine(Application.StartupPath, "Imagenes", "Zavala.png");
            else if (usuario == "Brando")
                ruta = Path.Combine(Application.StartupPath, "Imagenes", "Brando.png");
            else if (usuario == "Cohen")
                ruta = Path.Combine(Application.StartupPath, "Imagenes", "Cohen.png");

            if (File.Exists(ruta))
            {
                pictureBox.Image = Image.FromFile(ruta);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("No se encontró la imagen en la ruta:\n" + ruta, "Aviso");
            }
        }
    }
}
