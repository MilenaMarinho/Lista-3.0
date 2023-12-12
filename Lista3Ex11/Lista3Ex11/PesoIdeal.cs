using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex11
{
    internal class PesoIdeal
    {

        private double peso;
        private double altura;
        private double relacao;
        private string classificacao;

        public PesoIdeal()
        {
            this.peso = 0;
            this.altura = 0;
        }

        public PesoIdeal(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public double setAltura()
        {
            return this.altura;
        }
        public string getClassificacao()
        {
            return this.classificacao;
        }
        public void calcular()
        {
            this.relacao = this.peso / Math.Pow(this.altura, 2);

            if (this.relacao < 20)
            {
                this.classificacao = "Abaixo do Peso";
            }
            else
            {
                if (this.relacao < 25)
                {
                    this.classificacao = "Peso Ideal";
                }
                else
                {
                    this.classificacao = "Acima do Peso";
                }
            }
        }
    }
}
