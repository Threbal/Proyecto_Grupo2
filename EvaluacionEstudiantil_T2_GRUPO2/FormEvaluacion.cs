using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOLID_StudentPerformanceApp.Managers;
using SOLID_StudentPerformanceApp.Models;
using SOLID_StudentPerformanceApp.Strategies;
using SOLID_StudentPerformanceApp;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public partial class FormEvaluacion : Form
    {
        private string profesor;
        private string curso;
        public FormEvaluacion(string profesor, string curso)
        {
            InitializeComponent();
            this.profesor = profesor;
            this.curso = curso;

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.TextBox txtNotaT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.TextBox txtNotaT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.TextBox txtNotaT3;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtNotaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var evaluaciones = new List<Evaluacion>
            {
                new Evaluacion { Nota = double.Parse(txtNotaT1.Text), Peso = 0.10 },
                new Evaluacion { Nota = double.Parse(txtNotaT2.Text), Peso = 0.20 },
                new Evaluacion { Nota = double.Parse(txtNotaT3.Text), Peso = 0.30 },
                new Evaluacion { Nota = double.Parse(txtNotaFinal.Text), Peso = 0.40 }
            };

            var estudiante = new Estudiante { Name = txtAlumno.Text };
            var estrategia = new EstrategiaPromedioPonderado();
            var manager = new GestorEvaluaciones(estrategia);

            foreach (var eval in evaluaciones)
                manager.AddEvaluation(eval);

            double rendimiento = manager.GetPerformance();

            lblResultado.Text =
                $"Profesor: {profesor}\n" +
                $"Curso: {curso}\n" +
                $"Estudiante: {txtAlumno.Text}\n" +
                $"Código: {txtCodigo.Text}\n" +
                $"Promedio Final: {rendimiento:F2}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
