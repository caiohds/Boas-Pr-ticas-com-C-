using CursoDeDesignPatterns.Auxiliares;
using CursoDeDesignPatterns.Descontos;
using CursoDeDesignPatterns.Impostos;
using CursoDeDesignPatterns.NotaFiscalItens;

class Program
{
    static void Main(string[] args)
    {
        NotaFiscalBuilder construtor = new NotaFiscalBuilder();
        construtor.AdicionaAcao(new EnviarEmail());
        construtor.AdicionaAcao(new EnviarSms());
        construtor.AdicionaAcao(new NotaFiscalDao());
        construtor.AdicionaAcao(new Multiplicador(3));
        construtor.ComRazaoSocial("abcdesfs")
        .ComCnpj("123132132-2")
        .DataAtual()
        .ComItens(new ItemDaNota("ab", 100))
        .ComItens(new ItemDaNota("bc",200))
        .ComObservacoes("observacão");

        NotaFiscal nf = construtor.Builder();

        Console.WriteLine("Valor Bruto:" + nf.ValorBruto);
        Console.WriteLine("Imposto total: " + nf.Impostos);
    }
}

