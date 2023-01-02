using CursoDeDesignPatterns.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Estados
{
    public class Finalizado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Ñão é possível aplicar desconto para um orçamento que já foi finalizado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi finalizado!");
        }
    }
}
