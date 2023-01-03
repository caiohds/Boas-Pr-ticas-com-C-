using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal Builder()
        {
            return new NotaFiscal(RazaoSocial,Cnpj,DataDeEmissao, ValorBruto, Impostos,Itens,Observacoes);
        }
        
        public NotaFiscalBuilder ComRazaoSocial(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder DataAtual()
        {
            this.DataDeEmissao = DateTime.Now;
            return this;
        }
        public NotaFiscalBuilder ComItens(ItemDaNota item)
        {
            Itens.Add(item);
            return this;
        }
        public NotaFiscalBuilder ValorTotal()
        {
            foreach(ItemDaNota item in Itens)
            {
                ValorBruto += item.Valor;
            }
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
    }
}
