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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
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
            btnAgregar.Location = new Point(630, 74);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(73, 42);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            gridClientes.Location = new Point(147, 74);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.Size = new Size(442, 165);
            gridClientes.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "NOMBRE";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "APELLIDO";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "EMAIL";
            Column4.Name = "Column4";
            // 
            // button1
            // 
            button1.Location = new Point(630, 133);
            button1.Name = "button1";
            button1.Size = new Size(73, 40);
            button1.TabIndex = 5;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SQLForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 287);
            Controls.Add(button1);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}