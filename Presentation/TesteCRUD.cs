using BenchmarkDotNet.Attributes;
using Bogus;
using Dapper;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

[MemoryDiagnoser]
[InProcess]
public class TesteCRUD
{
    //private string _connectionString;
    //private int _quantidade; 

    //private List<Viagem> _dadosParaInserir;

    //[GlobalSetup]
    //public void Setup()
    //{
    //    _connectionString = BenchmarkConfig.ConnectionStringAtual;
    //    _quantidade = BenchmarkConfig.QuantidadeRegistros;

    //    var faker = new Faker<Viagem>("pt_BR")
    //        .RuleFor(v => v.Destino, f => f.Address.City() + ", " + f.Address.Country()) // Ex: "Paris, França"
    //        .RuleFor(v => v.DataInicio, f => f.Date.Between(new DateTime(2020, 1, 1), new DateTime(2030, 12, 31)))
    //        .RuleFor(v => v.DataFim, (f, v) => v.DataInicio.AddDays(f.Random.Int(1, 30))) // Fim é sempre depois do inicio
    //        .RuleFor(v => v.Observacoes, f => f.Lorem.Paragraphs(1)); // Gera texto longo aleatório

    //    _dadosParaInserir = faker.Generate(_quantidade);

    //    BenchmarkConfig.QuantidadeRegistrosInseridos = _dadosParaInserir.Count;
    //}

    //[Benchmark]
    //public void InsertLoteDapper()
    //{
    //    using (var conn = new SqlConnection(_connectionString))
    //    {
    //        conn.Open();


    //        foreach (var viagem in _dadosParaInserir)
    //        {
    //            string sql = @"INSERT INTO [dbo].[Viagem] 
    //                           ([Destino], [DataInicio], [DataFim], [Observacoes]) 
    //                           VALUES 
    //                           (@Destino, @DataInicio, @DataFim, @Observacoes)";

    //            conn.Execute(sql, viagem);
    //        }
    //    }
    //}
}