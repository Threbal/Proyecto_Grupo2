namespace EvaluacionEstudiantil_T2_GRUPO2
{
    partial class FormAsistencia
    {
     
        private System.ComponentModel.IContainer components = null;

  
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            dgvAlumnos = new System.Windows.Forms.DataGridView();
            btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9F);
            label1.Location = new System.Drawing.Point(46, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro de Asistencias";
            label1.Click += label1_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new System.Drawing.Point(46, 73);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new System.Drawing.Size(414, 261);
            dgvAlumnos.TabIndex = 1;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9F);
            btnGuardar.Location = new System.Drawing.Point(160, 363);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(146, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Asistencias";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(509, 415);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAlumnos);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormAsistencia";
            Text = "Marcar Asistencia";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnGuardar;
    }
}