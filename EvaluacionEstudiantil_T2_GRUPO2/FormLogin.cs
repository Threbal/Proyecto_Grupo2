using System;
using System.Windows.Forms;

namespace SOLID_StudentPerformanceApp
{
    public partial class FormLogin : Form
    {
        public string Profesor { get; private set; }
        public string Curso { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProfesor.Text) && !string.IsNullOrWhiteSpace(txtCurso.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Profesor = txtProfesor.Text;
                Curso = txtCurso.Text;

                Form1 mainForm = new Form1(Profesor, Curso);
                mainForm.Show();
                this.Close();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProfesor.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}