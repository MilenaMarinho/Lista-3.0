﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Quadrado area1;
            area1 = new Quadrado();
            area1.setDiag(double.Parse(txtDiag.Text));
            area1.calcular();
            lblResultado.Text = area1.getArea().ToString();
        }
    }
}
