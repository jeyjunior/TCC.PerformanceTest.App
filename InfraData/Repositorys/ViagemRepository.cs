using Bogus;
using Dapper;
using Domain.Entities;
using InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Repositorys
{
    public class ViagemRepository : Repository
    {
        public ViagemRepository(DbSession session) : base (session)
        {

        }
        public IEnumerable<Viagem> GerarDados(int quantidade)
        {
            var faker = new Faker<Viagem>("pt_BR")
            .RuleFor(v => v.Destino, f => f.Address.City() + ", " + f.Address.Country())
            .RuleFor(v => v.DataInicio, f => f.Date.Between(new DateTime(2020, 1, 1), new DateTime(2030, 12, 31)))
            .RuleFor(v => v.DataFim, (f, v) => v.DataInicio.AddDays(f.Random.Int(1, 30)))
            .RuleFor(v => v.Observacoes, f => f.Lorem.Paragraphs(1));

            return faker.Generate(quantidade);
        }
        public void AdicionarEmLote(List<Viagem> viagens, bool transacionar = false)
        {
            string sql = @"INSERT INTO [dbo].[Viagem] ([Destino], [DataInicio], [DataFim], [Observacoes]) 
                       VALUES (@Destino, @DataInicio, @DataFim, @Observacoes)";

            using (var trans = _session.Connection.BeginTransaction())
            {
                _session.Connection.Execute(sql, viagens, transaction: trans);
                trans.Commit();
            }
        }
        public void Adicionar(Viagem viagem, bool transacionar = false)
        {

        }

        public void LimparTabela()
        {
            _session.Connection.Execute("TRUNCATE TABLE [dbo].[Viagem]");
        }
    }
}
