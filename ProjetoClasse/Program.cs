using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome da pessoa: ");
            string n = Console.ReadLine();
            Console.WriteLine("Digite a idade de {0}: ", n);
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em metros de {0}: ", n);
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a letra equivalente ao sexo (F/M): ");
            string s = Console.ReadLine();

           

            //CALCULAR IMC  
            Console.WriteLine("\n *** Cálculo de IMC *** \n");
            Console.WriteLine("Digite a massa atual de {0} em KG: ", n);
            double m = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(n, i, a, s, m);
            Console.WriteLine("\n\n *** Dados da Pessoa *** \n\n");
            Console.WriteLine(pessoa.ToString());
            Console.WriteLine("O Peso ideal de {0} é: {1}.", n, pessoa.calcularPesoIdeal());

            Console.WriteLine("O IMC de {0} é: {1}.", n, pessoa.calcularIMC() );

            double imc;
            string msg = null;
            imc = ( m / (a * a));

            if (imc < 16)
            {
                msg += "Magreza severa";
            }
            else if (imc < 17)
            {
                msg += "Magreza moderada";
            }
            else if (imc < 18.5)
            {
                msg += "Magreza leve";
            }
            else if (imc < 25)
            {
                msg += "Peso normal";
            }
            else if (imc < 30)
            {
                msg += "Acima do peso";
            }
            else if (imc < 35)
            {
                msg += "Obesidad Grau 1";
            }
            else if (imc < 40)
            {
                msg += "Obesidade Grau 2";
            }
            else
            {
                msg += "Obesidade Grau 3";
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
