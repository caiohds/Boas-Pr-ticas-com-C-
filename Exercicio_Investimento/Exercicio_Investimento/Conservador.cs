using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Investimento
{
    public class Conservador : Investimento
    {
        public double Investir(double saldo)
        {
            return saldo * 0.008;
        }
    }
}
