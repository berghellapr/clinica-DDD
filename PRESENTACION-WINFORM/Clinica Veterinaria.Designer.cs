namespace PRESENTACION_WINFORM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNoSQL = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoSQL
            // 
            this.btnNoSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSQL.Location = new System.Drawing.Point(22, 12);
            this.btnNoSQL.Name = "btnNoSQL";
            this.btnNoSQL.Size = new System.Drawing.Size(225, 252);
            this.btnNoSQL.TabIndex = 0;
            this.btnNoSQL.Text = "noSQL";
            this.btnNoSQL.UseVisualStyleBackColor = true;
            this.btnNoSQL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQL.Location = new System.Drawing.Point(299, 12);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(224, 252);
            this.btnSQL.TabIndex = 1;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 283);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnNoSQL);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Clinica Veterinaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoSQL;
        private System.Windows.Forms.Button btnSQL;
    }
}

