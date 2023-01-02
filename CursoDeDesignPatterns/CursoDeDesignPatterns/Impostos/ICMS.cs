using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto proximoImposto) : base(proximoImposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculaProximoImposto(orcamento);
        }
    }
}
