namespace CRUD_SQL_ENTITYFRAMEWORK
{
    partial class FRMDatosPersona
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
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            txtnombre = new TextBox();
            dtpDatosPersona = new DateTimePicker();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 25;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(50, 150);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 26;
            label2.Text = "Nacimiento";
            // 
            // btnGuardar
            // 
            btnGuardar.ImeMode = ImeMode.NoControl;
            btnGuardar.Location = new Point(200, 205);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(158, 93);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(336, 31);
            txtnombre.TabIndex = 27;
            // 
            // dtpDatosPersona
            // 
            dtpDatosPersona.CustomFormat = "\"dd/mm/yy\"";
            dtpDatosPersona.Location = new Point(158, 150);
            dtpDatosPersona.Name = "dtpDatosPersona";
            dtpDatosPersona.Size = new Size(336, 31);
            dtpDatosPersona.TabIndex = 24;
            // 
            // FRMDatosPersona
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 303);
            Controls.Add(dtpDatosPersona);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(txtnombre);
            Name = "FRMDatosPersona";
            Text = "FRMDatosPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtnombre;
        private DateTimePicker dtpDatosPersona;
    }
}