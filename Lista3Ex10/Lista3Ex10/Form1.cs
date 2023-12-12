using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Retangulo area1;
            area1 = new Retangulo();
            area1.setH(double.Parse(txtAlt.Text));
            area1.setB(double.Parse(txtBase.Text));
            area1.calcular();
            lblResultado.Text = area1.getClassificacao().ToString();
        }
    }
}
