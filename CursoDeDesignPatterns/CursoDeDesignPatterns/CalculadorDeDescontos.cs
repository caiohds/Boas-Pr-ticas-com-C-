using CursoDeDesignPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            DescontoPorMaisDe5Itens desconto1 = new DescontoPorMaisDe5Itens();
            DescontoPorValorMaiorQue500 desconto2 = new DescontoPorValorMaiorQue500();
            DescontoParaCanetaOuLapis desconto3 = new DescontoParaCanetaOuLapis();
            SemDesconto desconto4 = new SemDesconto();


            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;
            desconto3.Proximo = desconto4;

            return desconto1.Desconta(orcamento);
        }
    }
}
