using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SOLID_StudentPerformanceApp.Models;
using SOLID_StudentPerformanceApp.Strategies;
using SOLID_StudentPerformanceApp.Managers;
using SOLID_StudentPerformanceApp.Reports;
using EvaluacionEstudiantil_T2_GRUPO2;

namespace SOLID_StudentPerformanceApp
{
    public partial class Form1 : Form
    {
        private string profesor;
        private string curso;
        FormAsistencia formAsistencia;
        FormEvaluacion formEvaluacion;


        public Form1(string profesor, string curso)
        {
            InitializeComponent();
            this.profesor = profesor;
            this.curso = curso;
            this.FormClosed += (s, e) =>
            {
                if (formAsistencia != null)
                    formAsistencia.Close();
                if (formEvaluacion != null)
                    formEvaluacion.Close();
            };

        }

        private void evaluacionEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            formEvaluacion = new FormEvaluacion(profesor, curso);
            formEvaluacion.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(formEvaluacion);
            formEvaluacion.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();

            var formAsistencia = new FormAsistencia();
            formAsistencia.TopLevel = false;
            formAsistencia.FormBorderStyle = FormBorderStyle.None;
            formAsistencia.Dock = DockStyle.Fill;

            this.toolStripContainer1.ContentPanel.Controls.Add(formAsistencia);
            formAsistencia.Show();
        }


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }



        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}