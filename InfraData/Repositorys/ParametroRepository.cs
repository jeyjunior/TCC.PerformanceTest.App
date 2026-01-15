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
    public class ParametroRepository : Repository
    {
        public ParametroRepository(DbSession session) : base(session)
        {
            InicializarBanco();
        }

        private void InicializarBanco()
        {
            string sql = @"
                CREATE TABLE IF NOT EXISTS Parametro (
                    PK_Parametro INTEGER PRIMARY KEY AUTOINCREMENT,
                    FK_Ambiente INTEGER NOT NULL,
                    Descricao TEXT NOT NULL,
                    StringConexao TEXT NOT NULL
                );";

            _session.Connection.Execute(sql);
        }

        public void Adicionar(Parametro param)
        {
            string sql = @"INSERT   INTO    Parametro (FK_Ambiente, Descricao, StringConexao) 
                           VALUES   (@FK_Ambiente, @Descricao, @StringConexao)";
            var ret = _session.Connection.Execute(sql, param);
        }

        public void Atualizar(Parametro param)
        {
            string sql = @"UPDATE   Parametro 
                           SET      FK_Ambiente = @FK_Ambiente,
                                    Descricao = @Descricao, 
                                    StringConexao = @StringConexao
                           WHERE    PK_Parametro = @PK_Parametro";
            _session.Connection.Execute(sql, param);
        }

        public void Excluir(int pK_Parametro)
        {
            string sql = "DELETE FROM Parametro WHERE PK_Parametro = @PK_Parametro";
            _session.Connection.Execute(sql, new { PK_Parametro = pK_Parametro });
        }

        public IEnumerable<Parametro> ObterLista()
        {
            return _session.Connection.Query<Parametro>("SELECT * FROM Parametro");
        }

        public Parametro Obter(int pK_Parametro)
        {
            return _session.Connection.QueryFirstOrDefault<Parametro>("SELECT * FROM Parametro WHERE PK_Parametro = @PK_Parametro", new { PK_Parametro = pK_Parametro });
        }
    }
}
