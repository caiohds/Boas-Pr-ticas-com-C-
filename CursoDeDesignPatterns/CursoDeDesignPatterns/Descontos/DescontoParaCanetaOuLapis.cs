using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Descontos
{
    public class DescontoParaCanetaOuLapis : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (ExisteCanetaOuLapis(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
        public bool ExisteCanetaOuLapis(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if(item.Nome.Equals("Caneta") || item.Nome.Equals("Lapis"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
