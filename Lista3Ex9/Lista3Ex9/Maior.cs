using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex9
{
    internal class Maiorigual
    {
        private double v1;
        private double v2;
        private string maiorigual;

        public Maiorigual()
        {
            this.v1 = 0;
            this.v2 = 0;
        }

        public Maiorigual(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void setV1(double v1)
        {
            this.v1 = v1;
        }
        public void setV2(double v2)
        {
            this.v2 = v2;
        }

        public double getV1()
        {
            return this.v1;
        }

        public double getV2()
        {
            return this.v2;
        }

        public string getMaiorIgual()
        {
            return this.maiorigual;
        }

        public void calcular()
        {
            if (this.v1 == this.v2)
            {
                this.maiorigual = "Valores Idênticos";
            }
            else
            {
                if (this.v1 > this.v2)
                {
                    this.maiorigual = "O 1º Valor é o Maior";
                }
                else
                {
                    this.maiorigual = "O 2º Valor é o Maior";
                }
            }
        }
    }
}
