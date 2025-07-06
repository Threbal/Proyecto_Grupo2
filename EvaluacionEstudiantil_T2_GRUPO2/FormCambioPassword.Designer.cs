namespace EvaluacionEstudiantil_T2_GRUPO2
{
    partial class FormCambioPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            txtActual = new System.Windows.Forms.TextBox();
            txtNueva = new System.Windows.Forms.TextBox();
            txtConfirmar = new System.Windows.Forms.TextBox();
            btnCambiar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnVerNueva = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtActual
            // 
            txtActual.Location = new System.Drawing.Point(151, 88);
            txtActual.Name = "txtActual";
            txtActual.Size = new System.Drawing.Size(207, 23);
            txtActual.TabIndex = 0;
            txtActual.UseSystemPasswordChar = true;
            // 
            // txtNueva
            // 
            txtNueva.Location = new System.Drawing.Point(151, 147);
            txtNueva.Name = "txtNueva";
            txtNueva.Size = new System.Drawing.Size(207, 23);
            txtNueva.TabIndex = 1;
            txtNueva.UseSystemPasswordChar = true;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new System.Drawing.Point(151, 213);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new System.Drawing.Size(207, 23);
            txtConfirmar.TabIndex = 2;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new System.Drawing.Point(168, 262);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new System.Drawing.Size(129, 23);
            btnCambiar.TabIndex = 3;
            btnCambiar.Text = "ejecutar el cambio";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(151, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Cntraseña Actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(151, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(151, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirmar Contraseña";
            // 
            // btnVerNueva
            // 
            btnVerNueva.Location = new System.Drawing.Point(392, 147);
            btnVerNueva.Name = "btnVerNueva";
            btnVerNueva.Size = new System.Drawing.Size(52, 23);
            btnVerNueva.TabIndex = 7;
            btnVerNueva.Text = "Ver";
            btnVerNueva.UseVisualStyleBackColor = true;
            btnVerNueva.Click += btnVerNueva_Click;
            // 
            // FormCambioPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 397);
            Controls.Add(btnVerNueva);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtNueva);
            Controls.Add(txtActual);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormCambioPassword";
            Text = "FormCambioPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerNueva;
    }
}