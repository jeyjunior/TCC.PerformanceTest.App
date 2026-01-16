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
        public ViagemRepository(DbSession session) : base(session)
        {
            InicializarTabela();
        }

        private void InicializarTabela()
        {
            string sql = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Viagem]') AND type in (N'U'))
                BEGIN
                    CREATE TABLE [dbo].[Viagem](
                        [PK_Viagem] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        [Destino] VARCHAR(200) NOT NULL,
                        [DataInicio] DATETIME NOT NULL,
                        [DataFim] DATETIME NOT NULL,
                        [Observacoes] VARCHAR(MAX) NULL
                    );
                END";

            _session.Connection.Execute(sql);
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
