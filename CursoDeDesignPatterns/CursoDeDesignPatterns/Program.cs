using CursoDeDesignPatterns;
using CursoDeDesignPatterns.Descontos;

class Program
{
    static void Main(string[] args)
    {
       CalculadorDeDescontos calculador = new CalculadorDeDescontos();

        Orcamento orcamento = new Orcamento(500);

        orcamento.adicionaItem(new Item("Caneta", 50));
        orcamento.adicionaItem(new Item("item2", 50));
        orcamento.adicionaItem(new Item("item3", 50));
        orcamento.adicionaItem(new Item("item4", 50));
        orcamento.adicionaItem(new Item("item5", 50));

        Console.WriteLine(calculador.Calcula(orcamento).ToString("C"));
    }
}

