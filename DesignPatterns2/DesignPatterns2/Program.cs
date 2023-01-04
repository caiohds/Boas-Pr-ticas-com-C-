using DesignPatterns2.Capitulo1;
using DesignPatterns2.Capitulo2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        NotasMusicais notas = new NotasMusicais();
        IList<INota> musica = new List<INota>()
        {
            notas.GetNota("do"),
            notas.GetNota("Re"),
            notas.GetNota("Mi"),
            notas.GetNota("Fa"),
            notas.GetNota("Fa"),
            notas.GetNota("Fa")

        };
        Piano piano = new Piano();
        piano.Toca(musica);
    }
}
