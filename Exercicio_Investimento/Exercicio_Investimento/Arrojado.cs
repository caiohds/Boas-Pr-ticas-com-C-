using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Investimento
{
    public class Arrojado : Investimento
    {
        public double Investir(double saldo)
        {
            int chance = new Random().Next(101);
            if(chance <= 20)
            {
                return saldo * 0.05;
            }
            if(chance <= 30)
            {
                return saldo * 0.03;
            }
            return saldo * 0.006;
        }
    }
}
