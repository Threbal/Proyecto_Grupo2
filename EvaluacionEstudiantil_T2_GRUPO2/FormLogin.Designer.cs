namespace SOLID_StudentPerformanceApp
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnIngresar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtProfesor = new System.Windows.Forms.TextBox();
            txtCurso = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblProfesor = new System.Windows.Forms.Label();
            lblCurso = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new System.Drawing.Point(459, 106);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new System.Drawing.Size(150, 23);
            txtProfesor.TabIndex = 1;
            // 
            // txtCurso
            // 
            txtCurso.Location = new System.Drawing.Point(459, 141);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new System.Drawing.Size(150, 23);
            txtCurso.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(459, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(150, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblProfesor
            // 
            lblProfesor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProfesor.Location = new System.Drawing.Point(339, 111);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new System.Drawing.Size(100, 15);
            lblProfesor.TabIndex = 0;
            lblProfesor.Text = "Nombre:";
            // 
            // lblCurso
            // 
            lblCurso.Location = new System.Drawing.Point(339, 146);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new System.Drawing.Size(100, 15);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new System.Drawing.Point(339, 181);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(100, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(339, 211);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(270, 30);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = EvaluacionEstudiantil_T2_GRUPO2.Properties.Resources.colegio2;
            pictureBox1.Location = new System.Drawing.Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(300, 400);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(400, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 26);
            label1.TabIndex = 8;
            label1.Text = "BIENVENIDO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = EvaluacionEstudiantil_T2_GRUPO2.Properties.Resources.escudo;
            pictureBox2.Location = new System.Drawing.Point(407, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(125, 130);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(635, 406);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblProfesor);
            Controls.Add(txtProfesor);
            Controls.Add(lblCurso);
            Controls.Add(txtCurso);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnIngresar);
            Name = "FormLogin";
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}