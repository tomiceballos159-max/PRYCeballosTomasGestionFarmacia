using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRYCeballosTomasGestionFarmacia
{
    public partial class socfrm : Form

    {//zona de variables globales
     //contadores
        int vContadorCritico;
        int vContadorBajo;
        int vContadorMedio;
        int vContadorAlto;

        public socfrm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)

        {
            vContadorCritico = vContadorCritico + 1;

            lblResultadoCritico.BackColor = Color.Red;

        lblResultadoCritico.Text= vContadorCritico.ToString();

        }



        private void socfrm_Load(object sender, EventArgs e)
        {

        }

        private void lblResultadoBajo_Click(object sender, EventArgs e)
        {
            vContadorBajo = vContadorBajo + 1;
            lblResultadoBajo.BackColor = Color.Green;
            lblResultadoBajo.Text = vContadorBajo.ToString();
        }

        private void lblResultadoAlto_Click(object sender, EventArgs e)
        {
            vContadorAlto = vContadorAlto + 1;
            lblResultadoAlto.BackColor = Color.Orange;
            lblResultadoAlto.Text = vContadorAlto.ToString();
        }

        private void lblResultadoMedio_Click(object sender, EventArgs e)
        {
            vContadorMedio = vContadorMedio + 1;
            lblResultadoMedio.BackColor = Color.Yellow;
            lblResultadoMedio.Text = vContadorMedio.ToString();
        }

        private void lblCritico_Click(object sender, EventArgs e)
        {

        }
    }
}
