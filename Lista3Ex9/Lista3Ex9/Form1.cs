using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Maiorigual comparação1;
            comparação1 = new Maiorigual();
            comparação1.setV1(double.Parse(txtV1.Text));
            comparação1.setV2(double.Parse(txtV2.Text));
            comparação1.calcular();
            lblResultado.Text = comparação1.getMaiorIgual().ToString();
        }
    }
}
