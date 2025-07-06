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
    public partial class FormCambioPassword : Form
    {
        public FormCambioPassword()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string actual = txtActual.Text.Trim();
            string nueva = txtNueva.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(nueva) || string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Error");
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("La nueva contraseña no coincide con la confirmación.", "Error");
                return;
            }

            using (var conexion = new MySql.Data.MySqlClient.MySqlConnection(Conexion.Cadena))
            {
                try
                {
                    conexion.Open();

                    // Validar contraseña actual
                    string sql = "SELECT COUNT(*) FROM usuarios WHERE id = @id AND contrasena = @actual";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", Sesion.IdProfesor);
                        cmd.Parameters.AddWithValue("@actual", actual);

                        var existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe == 0)
                        {
                            MessageBox.Show("La contraseña actual es incorrecta.", "Error");
                            return;
                        }
                    }

                    // Actualizar contraseña
                    string sqlUpdate = "UPDATE usuarios SET contrasena = @nueva WHERE id = @id";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlUpdate, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nueva", nueva);
                        cmd.Parameters.AddWithValue("@id", Sesion.IdProfesor);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Contraseña cambiada correctamente.", "Éxito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar contraseña: " + ex.Message);
                }
            }
        }

        private void btnVerNueva_Click(object sender, EventArgs e)
        {
            // alternar el estado
            txtNueva.UseSystemPasswordChar = !txtNueva.UseSystemPasswordChar;
        }

    }
}
