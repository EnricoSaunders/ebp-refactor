using System;
using System.Data;
using System.Data.SqlClient;

namespace EBP.Core.DataAccess
{
    public interface IDbConnection : IDisposable 
    {
        void Open();
        void Close();
        SqlConnection GetConnection();
        bool IsOpen { get; }
    }

    public interface IConnectionFactory
    {
        IDbConnection CreateConnection(string connectionStringName);
    }
}