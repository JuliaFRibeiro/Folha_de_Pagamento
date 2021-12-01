using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_de_Pagamento.Classe
{
    class Tercerizado : Funcionarios
    {
        // declarando variavel que guarda o valor das despesas
        public double Adicional { get; set; }

        // construtores
        public Tercerizado() { }
        public Tercerizado(string nome, int horas, double thoras, double adicional) : base(nome, horas, thoras)
        {
            Nome = nome;
            Horas = horas;
            THoras = thoras;
            Adicional = adicional;
        }
        // função que calcula o pagamento dos funcionarios tercerizados
        public override double Salario()
        {
            Adicional = Adicional * 110 / 100;
            return Horas * THoras + Adicional;
        }
    }
}