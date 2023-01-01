using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Investimento
{
    public class Moderado : Investimento
    {
        public double Investir(double saldo)
        {
            int chance = new Random().Next(101);
            if(chance >= 50)
            {
                return saldo * 0.007;
            }
            return saldo * 0.025;
        }
    }
}
