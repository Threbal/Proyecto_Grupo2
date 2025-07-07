using System;
using System.Windows.Forms;
using EvaluacionEstudiantil_T2_GRUPO2;

namespace SOLID_StudentPerformanceApp
{

    public partial class FormLogin : Form
    {
        public string Profesor { get; private set; }
        public string Curso { get; private set; }

        string connectionString = Conexion.Cadena;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProfesor.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                string usuarioIngresado = txtProfesor.Text.Trim();
                string contrasenaIngresada = txtPassword.Text.Trim();

                using (var conexion = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        string query = "SELECT id, nombre_usuario FROM usuarios WHERE nombre_usuario=@usuario AND contrasena=@contrasena";
                        using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);
                            cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                            var reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                Profesor = reader.GetString("nombre_usuario");
                                Sesion.IdProfesor = reader.GetInt32("id"); // guardar id

                                Form1 mainForm = new Form1(Profesor, Curso);
                                mainForm.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de conexión: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
        }





        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}