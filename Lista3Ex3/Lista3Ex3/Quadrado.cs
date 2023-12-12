using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex3
{
    internal class Quadrado
    {
        private double diagonal;
        private double area;

        public Quadrado()
        {
            this.diagonal = 0;
        }

        public Quadrado(double diag)
        {
            this.diagonal = diag;
        }

        public void setDiag(double diag)
        {
            this.diagonal = diag;
        }

        public double getDiag()
        {
            return this.diagonal;
        }

        public double getArea()
        {
            return this.area;
        }

        public void calcular()
        {

            this.area = Math.Pow(this.diagonal / Math.Sqrt(2), 2);

        }

    }
}
