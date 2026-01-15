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
        public IDbConnection Connection { get; }

        public DbSession(string sqlServerConectionString)
        {
            Connection = new SqlConnection(sqlServerConectionString);
            Connection.Open();
        }

        public DbSession()
        {
            string dbFile = "config.db";
            string connectionString = $"Data Source={dbFile};Version=3;";
            if (!System.IO.File.Exists(dbFile))
                SQLiteConnection.CreateFile(dbFile);

            Connection = new SQLiteConnection(connectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }
    }
}
