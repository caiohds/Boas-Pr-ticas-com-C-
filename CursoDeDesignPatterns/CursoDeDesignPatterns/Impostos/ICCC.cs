using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public class ICCC : Imposto
    {
        protected override double Calcula(Orcamento orcamento)
        {
            public ICCC () : base(Imposto proximoImposto){ }
            
            if (orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.05 + CalculaProximoImposto(orcamento);
            }
            if (orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.07 + CalculaProximoImposto(orcamento);
            }
            return orcamento.Valor * 0.08 + 30 + CalculaProximoImposto(orcamento);
        }
    }
}
