namespace WINFORM_2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSQL = new Button();
            btnNoSQL = new Button();
            SuspendLayout();
            // 
            // btnSQL
            // 
            btnSQL.Location = new Point(220, 12);
            btnSQL.Name = "btnSQL";
            btnSQL.Size = new Size(179, 173);
            btnSQL.TabIndex = 0;
            btnSQL.Text = "SQL";
            btnSQL.UseVisualStyleBackColor = true;
            btnSQL.Click += BtnSQL_Click_1;
            // 
            // btnNoSQL
            // 
            btnNoSQL.Location = new Point(24, 12);
            btnNoSQL.Name = "btnNoSQL";
            btnNoSQL.Size = new Size(178, 173);
            btnNoSQL.TabIndex = 0;
            btnNoSQL.Text = "noSQL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 191);
            Controls.Add(btnNoSQL);
            Controls.Add(btnSQL);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica Veterinaria";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSQL;
        private Button btnNoSQL;
    }
}