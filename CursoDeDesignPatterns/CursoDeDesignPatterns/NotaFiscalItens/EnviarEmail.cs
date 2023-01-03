using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class EnviarEmail : AcaoAposGerarNota
    {
        public void Exibir(NotaFiscal nota)
        {
            Console.WriteLine("EmailEnviado");
        }
    }
}
