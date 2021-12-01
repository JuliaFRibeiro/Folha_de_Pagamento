using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_de_Pagamento.Classe
{
    class Normal : Funcionarios
    {
        // construtores
        public Normal() { }
        public Normal(string nome, int horas, double thoras)
        {
            Nome = nome;
            Horas = horas;
            THoras = thoras;
        }
        // função que calcula o pagamento dos funcionarios comuns
        public override double Salario()
        {
            return Horas * THoras;
        }
    }
}
