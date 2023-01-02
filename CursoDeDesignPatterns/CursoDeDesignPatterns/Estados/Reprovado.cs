﻿using CursoDeDesignPatterns.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Estados
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é possível aplicar desconto para um orçamento reprovado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException("O orçamento foi reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já foi reprovado!");
        }
    }
}
