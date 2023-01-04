using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach(INota i in musica)
            {
                Console.Beep(i.Fraquencia, 300);
            }
        }
    }
}
