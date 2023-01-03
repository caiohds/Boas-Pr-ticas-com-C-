using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.NotaFiscalItens
{
    public class EnviarSms : AcaoAposGerarNota
    {
        public void Exibir(NotaFiscal nota)
        {
            Console.WriteLine("Sms enviado");
        }
    }
}
