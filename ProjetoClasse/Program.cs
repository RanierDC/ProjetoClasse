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

            Console.WriteLine("Digite a altura de {0}: ", n);
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a letra equivalente ao sexo (F/M): ");
            string s = Console.ReadLine();

            Pessoa pessoa = new Pessoa(n, i, a, s);
            Console.WriteLine("\n\n *** Dados da Pessoa *** \n\n");
            Console.WriteLine(pessoa.ToString());

            Console.WriteLine("Peso Ideal: {0}", pessoa.calcularPesoIdeal());

            Console.ReadKey();
        }
    }
}
