using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{

    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string sexo;
        private double massa;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            Sexo = null;
            this.massa = 0.0;
        }

        public Pessoa (string nome, int idade, double altura, string sexo, double massa)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();
            this.massa = massa;
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }   
        }

        public double Massa
        {
            get { return massa; }
            set { massa = value; }
        }

        public double calcularPesoIdeal()
        {
            if(sexo.Equals("MASCULINO"))
            {
                return (72.7 * altura) - 58;
            }
            else
            {
                return (62.1 * altura) - 44.7;
            }
        }

        public double calcularIMC()
        {
            if(sexo.Equals("MASCULINO"))
            {
                return massa / (altura * altura);
            }
            else
            {
                return massa / (altura * altura);
            }
        }

        

        public override string ToString()
        {
            return (String.Format("Nome: {0} \nIdade: {1} \nAltura: {2} \nSexo: {3}\n ", nome, idade, altura, sexo)); 
        }

    }
}
