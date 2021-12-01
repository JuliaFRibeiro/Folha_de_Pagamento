using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_de_Pagamento.Classe
{
    abstract class Funcionarios
    {
        // declarando variantes base para os funcionarios
        public String Nome { get; set; }
        public int Horas { get; set; }
        public double THoras { get; set; }

        // construtores
        public Funcionarios() { }
        public Funcionarios(string nome, int horas, double thoras)
        {
            Nome = nome;
            Horas = horas;
            THoras = thoras;
        }

        // função para guardar o valor do pagamento
        public abstract double Salario();
    }
}
