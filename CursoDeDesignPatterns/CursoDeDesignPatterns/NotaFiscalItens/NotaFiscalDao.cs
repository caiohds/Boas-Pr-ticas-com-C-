using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Exibir(NotaFiscal nota)
        {
            Console.WriteLine("Banco");
        }
    }
}
