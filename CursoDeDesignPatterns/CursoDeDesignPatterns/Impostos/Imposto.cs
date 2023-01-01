using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Impostos
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
