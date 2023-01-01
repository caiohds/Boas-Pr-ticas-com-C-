using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Investimento
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }
    }
}
