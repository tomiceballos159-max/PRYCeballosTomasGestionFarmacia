namespace PRYCeballosTomasGestionFarmacia
{
    partial class frmCajaDeTexto
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
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblLaboratorio = new Label();
            lblMedicamento = new Label();
            lblCodigo = new Label();
            lblAltaMedicamente = new Label();
            txtMedicamento = new TextBox();
            txtLaboratorio = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            txtCodigo = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 203);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 172);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoria";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(24, 142);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 11;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(24, 111);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 10;
            lblMedicamento.Text = "Medicamento";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(24, 76);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Codigo";
            // 
            // lblAltaMedicamente
            // 
            lblAltaMedicamente.AutoSize = true;
            lblAltaMedicamente.Location = new Point(86, 28);
            lblAltaMedicamente.Name = "lblAltaMedicamente";
            lblAltaMedicamente.Size = new Size(93, 15);
            lblAltaMedicamente.TabIndex = 8;
            lblAltaMedicamente.Text = "Alta Medicacion";
            lblAltaMedicamente.Click += lblAltaMedicamente_Click;
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(107, 105);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 14;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(107, 134);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 15;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(107, 163);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 17;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(107, 76);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(143, 243);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // frmCajaDeTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 278);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCodigo);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtMedicamento);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaMedicamente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCajaDeTexto";
            Text = "Farmacia Version 2";
            Load += frmCajaDeTexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblLaboratorio;
        private Label lblMedicamento;
        private Label lblCodigo;
        private Label lblAltaMedicamente;
        private TextBox txtMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private Button btnRegistrar;
    }
}