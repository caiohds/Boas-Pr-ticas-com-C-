using DesignPatterns2.Capitulo1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        IDbConnection conexao = new ConnectionFactory().GetConnection();
    }
}
