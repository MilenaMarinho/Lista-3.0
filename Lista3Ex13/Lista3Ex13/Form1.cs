using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulo formato;
            formato = new Triangulo();
            formato.setV1(double.Parse(txtV1.Text));
            formato.setV2(double.Parse(txtV2.Text));
            formato.setV3(double.Parse(txtV3.Text));
            formato.calcular();
            lblResultado.Text = formato.getClassificacao().ToString();
        }
    }
}
