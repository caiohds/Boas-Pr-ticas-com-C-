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
        protected Imposto proximoImposto { get; set; }
        public Imposto(Imposto proximoImposto)
        {
            this.proximoImposto = proximoImposto;
        }

        protected abstract double Calcula(Orcamento orcamento);
    }
}
