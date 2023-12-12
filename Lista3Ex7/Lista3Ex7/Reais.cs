using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex7
{
    internal class Reais
    {
        private double cotacao;
        private double dolar;
        private double real;

        public Reais()
        {
            this.cotacao = 0;
            this.dolar = 0;
        }

        public Reais(double cotacao, double dolar)
        {
            this.cotacao = cotacao;
            this.dolar = dolar;
        }

        public void setCotacao(double cotacao)
        {
            this.cotacao = cotacao;
        }
        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }

        public double getCotacao()
        {
            return this.cotacao;
        }

        public double getDolar()
        {
            return this.dolar;
        }

        public double getReal()
        {
            return this.real;
        }

        public void calcular()
        {
            this.real = this.dolar * this.cotacao;
        }
    }
}
