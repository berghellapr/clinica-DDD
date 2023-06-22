namespace WINFORM_2._1
{
    partial class SQLForm
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            gridClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            label1.Click += label1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Calisto MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscar.Location = new Point(106, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(518, 32);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(630, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 36);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(707, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 36);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 74);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.Size = new Size(766, 345);
            gridClientes.TabIndex = 4;
            // 
            // SQLForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridClientes);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Name = "SQLForm";
            Text = "SQLForm";
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAgregar;
        private DataGridView gridClientes;
    }
}