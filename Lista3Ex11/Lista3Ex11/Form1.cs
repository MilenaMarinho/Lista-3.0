using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            PesoIdeal peso1;
            peso1 = new PesoIdeal();
            peso1.setAltura(double.Parse(txtAlt.Text));
            peso1.setPeso(double.Parse(txtPeso.Text));
            peso1.calcular();
            lblResultado.Text = peso1.getClassificacao().ToString();
        }
    }
}
