using CursoDeDesignPatterns.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Estados
{
    public class Aprovado : EstadoOrcamento
    {
        private bool descontoDado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoDado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoDado = true;
            }
            else
            {
                throw new Exception("O desconto já foi aplicado!");
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orcamento já está aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orcamento ja foi aprovado, não é possível reprovar");
        }
    }
}
