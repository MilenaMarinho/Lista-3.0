using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex6
{
    internal class Quilometros
    {
        private double milha;
        private double km;

        public Quilometros()
        {
            this.milha = 0;
        }

        public Quilometros(double milha)
        {
            this.milha = milha;
        }

        public void setMilha(double milha)
        {
            this.milha = milha;
        }

        public double getMilha()
        {
            return this.milha;
        }

        public double getKm()
        {
            return this.km;
        }

        public void calcular()
        {
            this.km = (this.milha * 1852)/1000;
        }
    }
}
