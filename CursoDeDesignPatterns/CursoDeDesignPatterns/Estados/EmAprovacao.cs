using CursoDeDesignPatterns.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Estados
{
    public class EmAprovacao : EstadoOrcamento
    {
        private bool descontoDado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoDado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                orcamento.descontoDado = true;
            }
            else
            {
                throw new Exception("O desconto já foi aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orcamento ainda está em aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
