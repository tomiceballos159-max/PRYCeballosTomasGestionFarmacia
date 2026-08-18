namespace PRYCeballosTomasGestionFarmacia
{
    partial class frmAltaMedicacion
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
            lblAltaMedicamente = new Label();
            lblCodigo = new Label();
            lblMedicamento = new Label();
            lblLaboratorio = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // lblAltaMedicamente
            // 
            lblAltaMedicamente.AutoSize = true;
            lblAltaMedicamente.Location = new Point(114, 34);
            lblAltaMedicamente.Name = "lblAltaMedicamente";
            lblAltaMedicamente.Size = new Size(93, 15);
            lblAltaMedicamente.TabIndex = 1;
            lblAltaMedicamente.Text = "Alta Medicacion";
            lblAltaMedicamente.Click += lblAltaMedicamente_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(31, 79);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(31, 114);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 3;
            lblMedicamento.Text = "Medicamento";
            lblMedicamento.Click += label1_Click;
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(31, 145);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 5;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(31, 175);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(31, 206);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // frmAltaMedicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 378);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaMedicamente);
            Name = "frmAltaMedicacion";
            Text = "Alta Medicacion";
            Load += frmAltaMedicacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaMedicamente;
        private Label lblCodigo;
        private Label lblMedicamento;
        private Label lblLaboratorio;
        private Label lblCategoria;
        private Label lblPrecio;
    }
}
