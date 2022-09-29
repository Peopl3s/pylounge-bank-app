using System.Data;

namespace BankApp.Classes
{
    public static class TransactionHelper
    {
        public static (string, DateTime) GenerateTransactionDateNumber()
        {
            const int TransactionNumberLength = 10;

            var transactionDate = DateTime.Now;
            var transactionNumber = "p";

            Random rand = new Random();
            for (int i = 0; i < TransactionNumberLength; i++)
            {
                transactionNumber += Convert.ToString(rand.Next(0, 10));
            }
            return (transactionNumber, transactionDate);
        }

        public static void MakeTransaction(IDbConnection connection, List<IDbCommand> commands)
        {
            var transaction = connection.BeginTransaction();
            foreach (var command in commands)
            {
                if (command != null)
                    command.Transaction = transaction;
            }

            try
            {
                foreach (var command in commands)
                {
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
        }
    }
}
