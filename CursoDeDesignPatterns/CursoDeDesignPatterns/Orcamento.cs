using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns
{
    public class Orcamento
    {
        public double  Valor { get; set; }
        public IList<Item> Itens;
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
        public void adicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
