using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Auxiliares;

namespace CursoDeDesignPatterns.Impostos
{
    public abstract class Imposto
    {
        protected Imposto proximoImposto { get; private set; }
        public Imposto(Imposto proximoImposto)
        {
            this.proximoImposto = proximoImposto;
        }
        public Imposto()
        {
            this.proximoImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);
        
        protected double CalculaProximoImposto(Orcamento orcamento)
        {
            if (proximoImposto == null) return 0;
            
            return proximoImposto.Calcula(orcamento);
        }
    }
}
