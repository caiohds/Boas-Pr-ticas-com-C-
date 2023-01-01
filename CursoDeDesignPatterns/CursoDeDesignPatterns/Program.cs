using CursoDeDesignPatterns;
using CursoDeDesignPatterns.Descontos;

class Program
{
    static void Main(string[] args)
    {
        DescontoPorMaisDe5Itens desconto1 = new DescontoPorMaisDe5Itens();
        DescontoPorValorMaiorQue500 desconto2 = new DescontoPorValorMaiorQue500();
        SemDesconto desconto3 = new SemDesconto();

        desconto1.Proximo = desconto2;
        desconto2.Proximo = desconto3;

        Orcamento orcamento = new Orcamento(600);
        Item item1 = new Item("item1", 50);
        Item item2 = new Item("item2", 50);
        Item item3 = new Item("item3", 50);
        Item item4 = new Item("item4", 50);
        Item item5 = new Item("item5", 50);
        Item item6 = new Item("item6", 50);

        orcamento.adicionaItem(item1);
        orcamento.adicionaItem(item2);
        orcamento.adicionaItem(item3);
        orcamento.adicionaItem(item4);
        orcamento.adicionaItem(item5);

        Console.WriteLine(desconto1.Desconta(orcamento).ToString("C"));
    }
}

