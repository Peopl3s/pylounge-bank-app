using BankApp.Interfaces;
using System.Data;

namespace BankApp.Classes
{
    public class DataBaseConnection : IDbConnector
    {
        private readonly IDbConnection _dbConnection;

        public DataBaseConnection(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void OpenConnection()
        {
            if (_dbConnection.State == ConnectionState.Closed)
            {
                 _dbConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }

        public IDbConnection GetConnection()
        {
            return _dbConnection;
        }

    }
}
