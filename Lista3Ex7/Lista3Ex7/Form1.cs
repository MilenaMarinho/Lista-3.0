using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Reais conversao1;
            conversao1 = new Reais();
            conversao1.setCotacao(double.Parse(txtCot.Text));
            conversao1.setDolar(double.Parse(txDol.Text));
            conversao1.calcular();
            lblResultado.Text = conversao1.getReal().ToString("C");
        }
    }
}
