using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Folha_de_Pagamento.Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando lista
            List<Funcionarios> list = new List<Funcionarios>();
            // pede o numero de funcionarios
            Console.WriteLine("Entre com o número de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // informações dos funcionarios
                Console.WriteLine($"Funcionario#{i}: ");
                Console.Write("Tercerizado (S/N): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Total de horas: ");
                double thoras = double.Parse(Console.ReadLine());

                // informações adicionais para os tercerizados
                if (ch == 'S' || ch == 's')
                {
                    Console.WriteLine("Adicional de despesas: ");
                    double adicional = double.Parse(Console.ReadLine());
                    list.Add(new Tercerizado(nome, horas, thoras, adicional));
                }

                // adiciona a lista o funcionario normal
                if (ch == 'n' || ch == 'N')
                {
                    list.Add(new Normal(nome, horas, thoras));
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine();
            // mostra o pagamento de todos os funcionarios
            Console.WriteLine("Pagamento: ");
            foreach (Funcionarios forma in list)
            {
                Console.WriteLine(forma.Nome + " - " + forma.Salario().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

