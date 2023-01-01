using Exercicio_Investimento;

class Program
{
    static void Main(string[] args)
    {
        Investimento moderado = new Moderado();
        Investimento conservador = new Conservador();
        Investimento arrojado = new Arrojado();
        ContaBancaria conta = new ContaBancaria(1000);
        RealizadorDeInvestimentos realizaInvestimento = new RealizadorDeInvestimentos();

        realizaInvestimento.RealizaInvestimento(conta, arrojado);
    }
}