using System.Windows.Forms;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    partial class FormAsistencia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            btnGuardar = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro de Asistencias";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new System.Drawing.Point(46, 50);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.Size = new System.Drawing.Size(600, 300);
            dgvAlumnos.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(260, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(146, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Asistencias";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new System.Drawing.Point(495, 370);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new System.Drawing.Size(94, 23);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 420);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAlumnos);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAsistencia";
            Text = "Marcar Asistencia";
            Load += FormAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo = new DataGridViewTextBoxColumn
        {
            Name = "Codigo",
            HeaderText = "Código",
            ReadOnly = true
        };
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn
        {
            Name = "Nombre",
            HeaderText = "Nombre",
            ReadOnly = true
        };
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos = new DataGridViewTextBoxColumn
        {
            Name = "Apellidos",
            HeaderText = "Apellidos",
            ReadOnly = true
        };
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso = new DataGridViewTextBoxColumn
        {
            Name = "Curso",
            HeaderText = "Curso",
            ReadOnly = true
        };
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPresente = new DataGridViewCheckBoxColumn
        {
            Name = "Presente",
            HeaderText = "Presente"
        };
        private Button btnExportar;
    }
}
