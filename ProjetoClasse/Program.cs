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

            Pessoa pessoa = new Pessoa(n, i, a, s, m, c);
            Console.WriteLine("\n\n *** Dados da Pessoa *** \n\n");
            Console.WriteLine(pessoa.ToString());
            Console.WriteLine("O IMC de {0} é: {1}, que é considerado {2}.", n, pessoa.calcularIMC() );


            Console.ReadKey();
        }
    }
}
