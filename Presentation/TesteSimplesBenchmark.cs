using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Bogus;
using Domain.Entities;
using InfraData.Context;
using InfraData.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    // [InProcess] é OBRIGATÓRIO aqui para funcionar a passagem de dados estáticos simples
    [SimpleJob(RunStrategy.ColdStart, launchCount: 1, warmupCount: 0, iterationCount: 1)] // Configuração "Rápida" para testar se funciona
    [InProcess]
    [MemoryDiagnoser]
    public class TesteSimplesBenchmark
    {
        public static string ConexaoAtual;
        public static int QuantidadeAtual;

        private ViagemRepository _repo;
        private DbSession _session;
        private List<Viagem> _dados;

        [GlobalSetup]
        public void Setup()
        {
            // 1. Conecta
            _session = new DbSession(ConexaoAtual);
            _repo = new ViagemRepository(_session);
            
            // 2. Gera dados
            var faker = new Faker<Viagem>("pt_BR")
                .RuleFor(v => v.Destino, f => f.Address.City())
                .RuleFor(v => v.DataInicio, f => f.Date.Future())
                .RuleFor(v => v.DataFim, f => f.Date.Future())
                .RuleFor(v => v.Observacoes, f => f.Lorem.Sentence());

            _dados = faker.Generate(QuantidadeAtual);
            try { _repo.LimparTabela(); } catch { }
        }

        [Benchmark]
        public void RodarInsert()
        {
            _repo.AdicionarEmLote(_dados, transacionar: true);
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _session?.Dispose();
        }
    }
}
