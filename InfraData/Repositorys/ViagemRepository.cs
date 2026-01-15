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
