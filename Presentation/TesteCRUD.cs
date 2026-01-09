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
    // Parâmetros que virão da sua UI (via classe estática GlobalConfig que falamos antes)
    private string _connectionString;
    private int _quantidade; // Ex: 100, 1000

    // Lista de objetos prontos para inserir (para não medir o tempo de criação do objeto, só o do banco)
    private List<Viagem> _dadosParaInserir;

    [GlobalSetup]
    public void Setup()
    {
        // 1. Pega configs da UI
        _connectionString = BenchmarkConfig.ConnectionStringAtual;
        _quantidade = BenchmarkConfig.QuantidadeRegistros;

        // 2. Configura o gerador de dados (Bogus)
        // Isso cria dados "fakes" mas realistas
        var faker = new Faker<Viagem>("pt_BR")
            .RuleFor(v => v.Destino, f => f.Address.City() + ", " + f.Address.Country()) // Ex: "Paris, França"
            .RuleFor(v => v.DataInicio, f => f.Date.Between(new DateTime(2020, 1, 1), new DateTime(2030, 12, 31)))
            .RuleFor(v => v.DataFim, (f, v) => v.DataInicio.AddDays(f.Random.Int(1, 30))) // Fim é sempre depois do inicio
            .RuleFor(v => v.Observacoes, f => f.Lorem.Paragraphs(1)); // Gera texto longo aleatório

        // 3. Gera a lista em memória ANTES do teste rodar
        _dadosParaInserir = faker.Generate(_quantidade);
    }

    [Benchmark]
    public void InsertLoteDapper()
    {
        using (var conn = new SqlConnection(_connectionString))
        {
            conn.Open();

            // Dapper com Loop explícito para simular carga
            // Usamos Transação para ser justo (commit único ou por lote é mais rápido, mas aqui faremos 1 a 1 para estressar a rede)

            foreach (var viagem in _dadosParaInserir)
            {
                string sql = @"INSERT INTO [dbo].[Viagem] 
                               ([Destino], [DataInicio], [DataFim], [Observacoes]) 
                               VALUES 
                               (@Destino, @DataInicio, @DataFim, @Observacoes)";

                // O Dapper mapeia as propriedades da classe Viagem para os @Parametros sozinho
                conn.Execute(sql, viagem);
            }
        }
    }

    // Opcional: Teste de "Bulk Insert" (Muito mais rápido, bom para comparar)
    // Se quiser testar, descomente abaixo. O Dapper não faz Bulk nativo do SQL, mas faz insert otimizado.
    /*
    [Benchmark]
    public void InsertBulkSimulado()
    {
        using (var conn = new SqlConnection(_connectionString))
        {
            conn.Open();
            string sql = @"INSERT INTO [dbo].[Viagem] ([Destino], [DataInicio], [DataFim], [Observacoes]) VALUES (@Destino, @DataInicio, @DataFim, @Observacoes)";
            
            // O Dapper entende que é uma lista e faz o insert otimizado automaticamente
            conn.Execute(sql, _dadosParaInserir);
        }
    }
    */
}