namespace PRYCeballosTomasGestionFarmacia
{
    partial class socfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(socfrm));
            lblCritico = new Label();
            lblAlto = new Label();
            lblMedio = new Label();
            lblBajo = new Label();
            lblResultadoBajo = new Label();
            lblResultadoMedio = new Label();
            lblResultadoAlto = new Label();
            lblResultadoCritico = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(23, 76);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(42, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "Critico";
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(23, 105);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(29, 15);
            lblAlto.TabIndex = 1;
            lblAlto.Text = "Alto";
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(23, 134);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(41, 15);
            lblMedio.TabIndex = 2;
            lblMedio.Text = "Medio";
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(23, 163);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(30, 15);
            lblBajo.TabIndex = 3;
            lblBajo.Text = "Bajo";
            // 
            // lblResultadoBajo
            // 
            lblResultadoBajo.AutoSize = true;
            lblResultadoBajo.Location = new Point(143, 163);
            lblResultadoBajo.Name = "lblResultadoBajo";
            lblResultadoBajo.Size = new Size(12, 15);
            lblResultadoBajo.TabIndex = 7;
            lblResultadoBajo.Text = "-";
            lblResultadoBajo.Click += lblResultadoBajo_Click;
            // 
            // lblResultadoMedio
            // 
            lblResultadoMedio.AutoSize = true;
            lblResultadoMedio.Location = new Point(143, 134);
            lblResultadoMedio.Name = "lblResultadoMedio";
            lblResultadoMedio.Size = new Size(12, 15);
            lblResultadoMedio.TabIndex = 6;
            lblResultadoMedio.Text = "-";
            lblResultadoMedio.Click += lblResultadoMedio_Click;
            // 
            // lblResultadoAlto
            // 
            lblResultadoAlto.AutoSize = true;
            lblResultadoAlto.Location = new Point(143, 105);
            lblResultadoAlto.Name = "lblResultadoAlto";
            lblResultadoAlto.Size = new Size(12, 15);
            lblResultadoAlto.TabIndex = 5;
            lblResultadoAlto.Text = "-";
            lblResultadoAlto.Click += lblResultadoAlto_Click;
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(143, 76);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 4;
            lblResultadoCritico.Text = "-";
            lblResultadoCritico.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 15);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(203, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 15);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(203, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 15);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(203, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 15);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // socfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 259);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultadoBajo);
            Controls.Add(lblResultadoMedio);
            Controls.Add(lblResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            Name = "socfrm";
            Text = "socfrm";
            Load += socfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label lblResultadoBajo;
        private Label lblResultadoMedio;
        private Label lblResultadoAlto;
        private Label lblResultadoCritico;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}