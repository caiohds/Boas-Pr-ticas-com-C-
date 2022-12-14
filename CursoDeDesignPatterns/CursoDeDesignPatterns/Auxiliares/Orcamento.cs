using CursoDeDesignPatterns.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Auxiliares
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens;
        public EstadoOrcamento Estado { get; set; }
       
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            Estado = new EmAprovacao();
        }
        public void adicionaItem(Item item)
        {
            Itens.Add(item);
        }
        public void AplicaDescontoExtra()
        {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            Estado.Aprova(this);
        }

        public void Reprova()
        {
            Estado.Reprova(this);
        }

        public void Finaliza()
        {
            Estado.Finaliza(this);
        }
    }
}
