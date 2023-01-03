using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();
        public string Observacoes { get; private set; }

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
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
    }
}
