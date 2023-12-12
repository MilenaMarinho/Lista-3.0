using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Quilometros conversao1;
            conversao1 = new Quilometros();
            conversao1.setMilha(double.Parse(txtMilha.Text));
            conversao1.calcular();
            lblResultado.Text = conversao1.getKm().ToString();
        }
    }
}
