using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }
        public void Exibir(NotaFiscal nota)
        {
            Console.WriteLine("Valor multiplicado pelo fator: " + nota.ValorBruto * Fator);
        }
        public Multiplicador(double fator)
        {
            Fator = fator;
        }
    }
}
