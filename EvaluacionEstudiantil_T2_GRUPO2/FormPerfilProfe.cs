using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public partial class FormPerfilProfe : Form
    {
        public FormPerfilProfe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPerfilProfe_Load(object sender, EventArgs e)
        {
            using (var conexion = new MySql.Data.MySqlClient.MySqlConnection(Conexion.Cadena))
            {
                try
                {
                    conexion.Open();
                    string sql = "SELECT nombre, apellido, nombre_usuario, correo FROM usuarios WHERE id = @id";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", Sesion.IdProfesor);

                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombre.Text = $"{reader.GetString("nombre")} {reader.GetString("apellido")}";
                            lblUsuario.Text = reader.GetString("nombre_usuario");
                            lblCorreo.Text = reader.GetString("correo");

                            string usuario = reader.GetString("nombre_usuario");
                            GestorImagenPerfil.CargarImagenPerfil(usuario, pictureBox1);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar perfil: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
