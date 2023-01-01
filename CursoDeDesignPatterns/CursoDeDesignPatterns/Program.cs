using CursoDeDesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        Imposto iss = new ISS();
        Imposto icms = new ICMS();
        Imposto iccc = new ICCC();

        Orcamento orcamento = new Orcamento(4000.0);

        CalculadorDeImposto calculador = new CalculadorDeImposto();

        calculador.RealizaCalculo(orcamento, iccc);
    }
}

