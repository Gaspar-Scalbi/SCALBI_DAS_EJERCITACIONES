namespace ado_multiplestablas
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
            btnSalir = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgvTabla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(406, 332);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 28);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(300, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 10;
            label1.Text = "GESTIÓNAR TABLA SQL";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(287, 301);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 27);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(406, 301);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 27);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(287, 332);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(78, 28);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(100, 114);
            dgvTabla.Margin = new Padding(2);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowHeadersWidth = 62;
            dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabla.Size = new Size(576, 169);
            dgvTabla.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvTabla);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dgvTabla;
    }
}
