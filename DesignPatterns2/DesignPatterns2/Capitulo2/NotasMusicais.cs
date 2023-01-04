using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo2
{
    public class NotasMusicais
    {
        private static IDictionary<string,INota> notas = new Dictionary<string, INota>()
        {
            {"do", new Do() },
            {"Re", new Re() },
            {"Mi", new Mi() },
            {"Fa", new Fa() },
            {"Sol", new Sol() },
            {"La", new La()},
            { "Si", new Si() }
        };

        public INota GetNota(string nome)
        {
            return notas[nome];
        }
    }
}
