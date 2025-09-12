namespace CRUD_SQL_ENTITYFRAMEWORK
{
    partial class TABLA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TABLA));
            btnRefrescar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgvTabla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // btnRefrescar
            // 
            resources.ApplyResources(btnRefrescar, "btnRefrescar");
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnSalir
            // 
            resources.ApplyResources(btnSalir, "btnSalir");
            btnSalir.Name = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnAgregar
            // 
            resources.ApplyResources(btnAgregar, "btnAgregar");
            btnAgregar.Name = "btnAgregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            resources.ApplyResources(btnEliminar, "btnEliminar");
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            resources.ApplyResources(btnModificar, "btnModificar");
            btnModificar.Name = "btnModificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvTabla
            // 
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvTabla, "dgvTabla");
            dgvTabla.MultiSelect = false;
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // TABLA
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefrescar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvTabla);
            Name = "TABLA";
            Load += TABLA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        private Button btnSalir;
        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dgvTabla;
    }
}
