using CursoDeDesignPatterns.Auxiliares;
using CursoDeDesignPatterns.Descontos;
using CursoDeDesignPatterns.Impostos;

class Program
{
    static void Main(string[] args)
    {
        //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

        // Orcamento orcamento = new Orcamento(500);

        // orcamento.adicionaItem(new Item("Caneta", 50));
        // orcamento.adicionaItem(new Item("item2", 50));
        // orcamento.adicionaItem(new Item("item3", 50));
        // orcamento.adicionaItem(new Item("item4", 50));
        // orcamento.adicionaItem(new Item("item5", 50));

        // Console.WriteLine(calculador.Calcula(orcamento).ToString("C"));

        Orcamento orcamento = new Orcamento(500);

        Imposto imposto = new ICCC(new ICMS(new IKCV()));

        double valor = imposto.Calcula(orcamento);

        Console.WriteLine(valor);
    }
}

