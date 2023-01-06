using DesignPatterns2.Capitulo1;
using DesignPatterns2.Capitulo2;
using DesignPatterns2.Capitulo3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        Historico historico = new Historico();

        Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
        historico.Adiciona(contrato.SalvaEstado());

        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        Console.WriteLine(historico.Pega(0).Contrato.Tipo);
        Console.WriteLine(historico.Pega(1).Contrato.Tipo);
        Console.WriteLine(historico.Pega(2).Contrato.Tipo);
        Console.WriteLine(historico.Pega(0).Contrato.Tipo);
    }
}
