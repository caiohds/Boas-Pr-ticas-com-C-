using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Impostos;

namespace CursoDeDesignPatterns.Auxiliares
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double impostoFinal = imposto.Calcula(orcamento);
            Console.WriteLine(impostoFinal);
        }
    }
}
