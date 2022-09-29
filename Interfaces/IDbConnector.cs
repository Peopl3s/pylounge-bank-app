using System.Data;

namespace BankApp.Interfaces
{
    public interface IDbConnector
    {
        public void OpenConnection();
        public void CloseConnection();
        public IDbConnection GetConnection();
    }
}
