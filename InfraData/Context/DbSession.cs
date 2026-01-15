using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Context
{
    public class DbSession : IDisposable
    {
        private const string DbLocalFile = "config_tcc.db";
        public IDbConnection Connection { get; }

        public DbSession(string sqlServerConectionString)
        {
            Connection = new SqlConnection(sqlServerConectionString);
            Connection.Open();
        }

        public DbSession()
        {
            string connectionString = $"Data Source={DbLocalFile};Version=3;";
            if (!System.IO.File.Exists(DbLocalFile))
                SQLiteConnection.CreateFile(DbLocalFile);

            Connection = new SQLiteConnection(connectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }
    }
}
