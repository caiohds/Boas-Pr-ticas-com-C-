using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta,Investimento investimento)
        {
            double lucro = investimento.Investir(conta.Saldo);
            Console.WriteLine("Lucro do investimento: " + lucro);
            Console.WriteLine("Saldo da conta antes do investimento: " + conta.Saldo);
            conta.Saldo += lucro * 0.75;
            Console.WriteLine("Saldo da conta após o investimento: " + conta.Saldo);
        }
    }
}
