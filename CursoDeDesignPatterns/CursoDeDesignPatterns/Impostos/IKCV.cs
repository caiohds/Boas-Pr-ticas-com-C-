using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public class IKCV : TemplateImpostoCondicional
    {
        public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            if(orcamento.Valor > 500 && ExisteItemComValorMaiorQue100(orcamento))
            {
                return true;
            }
            return false;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
        public bool ExisteItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
