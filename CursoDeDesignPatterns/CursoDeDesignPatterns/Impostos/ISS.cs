using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public class ISS : Imposto
    {
        public ISS(): base() { }
        public ISS(Imposto proximoimposto): base(proximoimposto) { }
        
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaProximoImposto(orcamento);
        }
    }
}
