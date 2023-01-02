using CursoDeDesignPatterns.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Impostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base(){ }
        public ImpostoMuitoAlto(Imposto? proximoImposto) : base(proximoImposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaProximoImposto(orcamento);
        }
    }
}
