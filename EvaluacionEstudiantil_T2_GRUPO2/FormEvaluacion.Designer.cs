using SOLID_StudentPerformanceApp.Managers;
using SOLID_StudentPerformanceApp.Models;
using SOLID_StudentPerformanceApp.Strategies;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using SOLID_StudentPerformanceApp;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    partial class FormEvaluacion
    {


        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAlumno = new Label();
            txtAlumno = new TextBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCurso = new Label();
            txtCurso = new TextBox();
            lblT1 = new Label();
            txtNotaT1 = new TextBox();
            lblT2 = new Label();
            txtNotaT2 = new TextBox();
            lblT3 = new Label();
            txtNotaT3 = new TextBox();
            lblFinal = new Label();
            txtNotaFinal = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cerrar_sesion;
            pictureBox1.Location = new System.Drawing.Point(428, 30);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.escudo;
            pictureBox2.Location = new System.Drawing.Point(24, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(86, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // lblAlumno
            // 
            lblAlumno.Location = new System.Drawing.Point(158, 104);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(74, 19);
            lblAlumno.TabIndex = 18;
            lblAlumno.Text = "Nombre Alumno:";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new System.Drawing.Point(238, 100);
            txtAlumno.Margin = new Padding(3, 2, 3, 2);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new System.Drawing.Size(132, 23);
            txtAlumno.TabIndex = 19;
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new System.Drawing.Point(158, 127);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(53, 19);
            lblCodigo.TabIndex = 20;
            lblCodigo.Text = "Código Alumno:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(238, 127);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(132, 23);
            txtCodigo.TabIndex = 21;
            // 
            // lblCurso
            // 
            lblCurso.Location = new System.Drawing.Point(158, 157);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new System.Drawing.Size(74, 20);
            lblCurso.TabIndex = 22;
            lblCurso.Text = "Curso:";
            // 
            // txtCurso
            // 
            txtCurso.Location = new System.Drawing.Point(238, 154);
            txtCurso.Margin = new Padding(3, 2, 3, 2);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new System.Drawing.Size(132, 23);
            txtCurso.TabIndex = 23;
            // 
            // lblT1
            // 
            lblT1.Location = new System.Drawing.Point(158, 191);
            lblT1.Name = "lblT1";
            lblT1.Size = new System.Drawing.Size(96, 16);
            lblT1.TabIndex = 24;
            lblT1.Text = "Nota E1 (10%)";
            // 
            // txtNotaT1
            // 
            txtNotaT1.Location = new System.Drawing.Point(282, 188);
            txtNotaT1.Margin = new Padding(3, 2, 3, 2);
            txtNotaT1.Name = "txtNotaT1";
            txtNotaT1.Size = new System.Drawing.Size(88, 23);
            txtNotaT1.TabIndex = 25;
            // 
            // lblT2
            // 
            lblT2.Location = new System.Drawing.Point(158, 214);
            lblT2.Name = "lblT2";
            lblT2.Size = new System.Drawing.Size(96, 16);
            lblT2.TabIndex = 26;
            lblT2.Text = "Nota E2 (20%)";
            // 
            // txtNotaT2
            // 
            txtNotaT2.Location = new System.Drawing.Point(282, 210);
            txtNotaT2.Margin = new Padding(3, 2, 3, 2);
            txtNotaT2.Name = "txtNotaT2";
            txtNotaT2.Size = new System.Drawing.Size(88, 23);
            txtNotaT2.TabIndex = 27;
            // 
            // lblT3
            // 
            lblT3.Location = new System.Drawing.Point(158, 236);
            lblT3.Name = "lblT3";
            lblT3.Size = new System.Drawing.Size(114, 16);
            lblT3.TabIndex = 28;
            lblT3.Text = "Nota E3 (30%)";
            // 
            // txtNotaT3
            // 
            txtNotaT3.Location = new System.Drawing.Point(282, 232);
            txtNotaT3.Margin = new Padding(3, 2, 3, 2);
            txtNotaT3.Name = "txtNotaT3";
            txtNotaT3.Size = new System.Drawing.Size(88, 23);
            txtNotaT3.TabIndex = 29;
            // 
            // lblFinal
            // 
            lblFinal.Location = new System.Drawing.Point(158, 259);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new System.Drawing.Size(122, 20);
            lblFinal.TabIndex = 30;
            lblFinal.Text = "Examen Final (40%)";
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.Location = new System.Drawing.Point(282, 255);
            txtNotaFinal.Margin = new Padding(3, 2, 3, 2);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.Size = new System.Drawing.Size(88, 23);
            txtNotaFinal.TabIndex = 31;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new System.Drawing.Point(158, 281);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(236, 22);
            btnCalcular.TabIndex = 32;
            btnCalcular.Text = "Calcular Promedio";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.Location = new System.Drawing.Point(158, 311);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new System.Drawing.Size(256, 85);
            lblResultado.TabIndex = 33;
            lblResultado.Text = "Resultado final:";
            lblResultado.Click += lblResultado_Click;
            // 
            // FormEvaluacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(509, 415);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblAlumno);
            Controls.Add(txtAlumno);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCurso);
            Controls.Add(txtCurso);
            Controls.Add(lblT1);
            Controls.Add(txtNotaT1);
            Controls.Add(lblT2);
            Controls.Add(txtNotaT2);
            Controls.Add(lblT3);
            Controls.Add(txtNotaT3);
            Controls.Add(lblFinal);
            Controls.Add(txtNotaFinal);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEvaluacion";
            Text = "FormEvaluacion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }







    }
}