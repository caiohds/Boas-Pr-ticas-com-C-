using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional(Imposto imposto) : base(imposto) { }
        public TemplateImpostoCondicional() : base() { }
       
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculaProximoImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculaProximoImposto(orcamento);
        }
        public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
