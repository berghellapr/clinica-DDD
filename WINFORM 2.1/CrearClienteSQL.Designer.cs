namespace WINFORM_2._1
{
    partial class CrearClienteSQL
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(124, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 29);
            txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(124, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 29);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 129);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(124, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 29);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 79);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(213, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(68, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(124, 173);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(68, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // CrearClienteSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 234);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "CrearClienteSQL";
            Text = "CrearClienteSQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}