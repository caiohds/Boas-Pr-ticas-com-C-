using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Impostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            if(orcamento.Valor >= 500)
            {
                return true;
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
