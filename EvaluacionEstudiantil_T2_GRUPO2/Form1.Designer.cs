using EvaluacionEstudiantil_T2_GRUPO2;

using System;



namespace SOLID_StudentPerformanceApp

{

    partial class Form1

    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

                components.Dispose();

            base.Dispose(disposing);



        }



        private void InitializeComponent()

        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            evaluacionEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cambioContrase˝aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            perfilDeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { perfilDeProfesorToolStripMenuItem, evaluacionEstudianteToolStripMenuItem, asistenciaToolStripMenuItem, cambioContrase˝aToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(708, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // evaluacionEstudianteToolStripMenuItem
            // 
            evaluacionEstudianteToolStripMenuItem.Name = "evaluacionEstudianteToolStripMenuItem";
            evaluacionEstudianteToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            evaluacionEstudianteToolStripMenuItem.Text = "Evaluacion Estudiante";
            evaluacionEstudianteToolStripMenuItem.Click += evaluacionEstudianteToolStripMenuItem_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            asistenciaToolStripMenuItem.Click += asistenciaToolStripMenuItem_Click;
            // 
            // cambioContrase˝aToolStripMenuItem
            // 
            cambioContrase˝aToolStripMenuItem.Name = "cambioContrase˝aToolStripMenuItem";
            cambioContrase˝aToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            cambioContrase˝aToolStripMenuItem.Text = "Cambio Contrase˝a";
            cambioContrase˝aToolStripMenuItem.Click += cambioContrase˝aToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox1);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(708, 429);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new System.Drawing.Size(708, 429);
            toolStripContainer1.TabIndex = 20;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = EvaluacionEstudiantil_T2_GRUPO2.Properties.Resources.cerrar_sesion;
            pictureBox1.Location = new System.Drawing.Point(751, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(34, 35);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // perfilDeProfesorToolStripMenuItem
            // 
            perfilDeProfesorToolStripMenuItem.Name = "perfilDeProfesorToolStripMenuItem";
            perfilDeProfesorToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            perfilDeProfesorToolStripMenuItem.Text = "Perfil de Profesor";
            perfilDeProfesorToolStripMenuItem.Click += perfilDeProfesorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(708, 453);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Operaciones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }



        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem evaluacionEstudianteToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContrase˝aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilDeProfesorToolStripMenuItem;
    }

}