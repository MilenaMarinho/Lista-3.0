using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex8
{
    internal class Maior
    {
        private double v1;
        private double v2;
        private double maior;

        public Maior()
        {
            this.v1 = 0;
            this.v2 = 0;
        }

        public Maior(double v1, double v2)
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

        public double getMaior()
        {
            return this.maior;
        }

        public void calcular()
        {
            if (this.v1 > this.v2)
            {
                this.maior = this.v1;
            }
            else
            {
                this.maior = this.v2;
            }
        }
    }
}
