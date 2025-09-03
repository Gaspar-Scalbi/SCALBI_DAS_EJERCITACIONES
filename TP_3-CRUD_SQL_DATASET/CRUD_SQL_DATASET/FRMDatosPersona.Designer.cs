namespace CRUD_SQL_DATASET
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
            btnGuardar = new Button();
            txtnombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudEdad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(149, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(138, 54);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(150, 31);
            txtnombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 109);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 7;
            label2.Text = "Edad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(138, 107);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 31);
            nudEdad.TabIndex = 11;
            // 
            // FRMDatosPersona
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 264);
            Controls.Add(nudEdad);
            Controls.Add(btnGuardar);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMDatosPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDatosPersona";
            Load += FRMDatosPersona_Load;
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtnombre;
        private Label label2;
        private Label label1;
        private NumericUpDown nudEdad;
    }
}