using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TransactionHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            var transactionHistory = ClientService.GetClientTransactionHistory(DataStorage.idClient);
            
            ListViewItem lvItem = new ListViewItem(transactionHistory["transaction_type"]);
            lvItem.SubItems.Add(transactionHistory["transaction_destination"]);
            lvItem.SubItems.Add(transactionHistory["transaction_date"]);
            lvItem.SubItems.Add(transactionHistory["transaction_number"]);
            lvItem.SubItems.Add(transactionHistory["transaction_value"]);

            TransactionsListView.Items.Add(lvItem);
            TransactionsListView.Sort();
        }

        private void TransactionsListView_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
    }
}


/*
 *   using (SqlDataReader reader = commandSelectTransactions.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lvItem = new ListViewItem(reader["transaction_type"].ToString());
                        lvItem.SubItems.Add(reader["transaction_destination"].ToString());
                        lvItem.SubItems.Add(reader["transaction_date"].ToString());
                        lvItem.SubItems.Add(reader["transaction_number"].ToString());
                        lvItem.SubItems.Add(reader["transaction_value"].ToString());
                        TransactionsListView.Items.Add(lvItem);
                    }
                }
            }
 */