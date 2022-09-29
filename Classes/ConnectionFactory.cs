using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace BankApp.Classes
{

    public static class ConnectionFactory
    {
        public enum DataProvider
        { SqlServer, OleDb, Odbc, None }

        public static  IDbConnection? getConnection(DataProvider dataProvider, string connectionString)
        {
            IDbConnection? connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
                    connection = new SqlConnection(connectionString);
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection(connectionString);
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection(connectionString);
                    break;
            }
            return connection;
        }

        public static  DataProvider getProviderType(string providerName)
        {
            string dataProviderStnng = providerName;
            DataProvider dataProvider = DataProvider.None;
            if (Enum.IsDefined(typeof(DataProvider), dataProviderStnng))
            {
                dataProvider = (DataProvider)Enum.Parse(typeof(DataProvider), dataProviderStnng);
            }
            return dataProvider;
        }
    }
}
