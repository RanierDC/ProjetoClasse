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
        private string imc;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            Sexo = null;
            this.massa = 0.0;
            this.imc = null;
        }

        public Pessoa (string nome, int idade, double altura, string sexo, double massa, string imc)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();
            this.massa = massa;
            this.imc = imc;
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

        public string Imc
        {
            get { return this.imc; }
            set { this.imc = value; }
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

        public string mostrarIMC()
        {
            float imc;
            imc = m / (a * a);

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc == 18.5) || (imc == 25))
            {
                Console.WriteLine("Peso normal");
            }
            if ((imc > 25) || (imc == 30))

            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) || (imc == 35))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
            if ((imc > 35) || (imc == 40))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }
        }

        public override string ToString()
        {
            return (String.Format("Nome: {0} \nIdade: {1} \nAltura: {2} \nSexo: {3}\n ", nome, idade, altura, sexo, imc)); 
        }

    }
}
