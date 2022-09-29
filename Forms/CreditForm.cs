using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MyCreditPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {
            CreditSumTextBox.Text = CreditSumTrackBar.Value.ToString();
            CreditMonthTextBox.Text = CreditMonthTrackBar.Value.ToString();

            MyCreditPanel.Visible = false;
            PaymentButton.Visible = false;

            var creditInfo = BankService.GetCreditInfo(DataStorage.cardNumber);

            
            creditInfo.TryGetValue("id_credit", out string idCredit);
            
            
            if (!string.IsNullOrEmpty(idCredit))
            {
                var totalSum = Convert.ToDecimal(creditInfo["credit_total_sum"]);
                var sum = Convert.ToDecimal(creditInfo["credit_sum"]);

                Decimal creditTotalSumToCheck = Convert.ToDecimal(creditInfo["credit_total_sum"]);
                Decimal creditSumToCheck = Convert.ToDecimal(creditInfo["credit_sum"]);
                DateTime date = Convert.ToDateTime(creditInfo["credit_date"]);

                if (creditSumToCheck >= creditTotalSumToCheck)
                {
                    BankService.CloseCredit(DataStorage.cardNumber);
                }

                MyCreditPanel.Visible = true;
                PaymentButton.Visible = true;

                PaidSumLabel.Text = Math.Round(Convert.ToDecimal(sum), 2).ToString();
                RemainSumLabel.Text = Math.Round(Convert.ToDecimal(totalSum), 2).ToString();
                RegistrationDateLabel.Text = date.ToShortDateString();

                var repaymentInfo = BankService.GetRepaymentCreditInfo(idCredit);
                PaySumLabel.Text = Math.Round(Convert.ToDecimal(repaymentInfo["repayment_sum"]), 2).ToString();
                PayDayLabel.Text = Convert.ToDateTime(repaymentInfo["repayment_date"]).ToShortDateString();
            }
        }

        private void showCalculatedCredit()
        {
            CreditPercentLabel.Text = (BankOptions.CreditMonthlyRate * 100).ToString();

            Decimal sum = Convert.ToDecimal(CreditSumTextBox.Text);
            int numberOfMonths = Convert.ToInt32(CreditMonthTextBox.Text);

            Decimal result = BankService.CalculateCredit(sum, numberOfMonths);
            
            CreditMontlyPaymentLabel.Text = Math.Round(result, 2).ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreditForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CreditSumTrackBar_Scroll(object sender, EventArgs e)
        {
            CreditSumTextBox.Text = CreditSumTrackBar.Value.ToString();
        }

        private void CreditSumTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreditSumTextBox_Click(object sender, EventArgs e)
        {
            CreditSumTrackBar.Value = Convert.ToInt32(CreditSumTextBox.Text);
            showCalculatedCredit();
        }

        private void CreditMonthTrackBar_Scroll(object sender, EventArgs e)
        {
            CreditMonthTextBox.Text = CreditMonthTrackBar.Value.ToString();
        }

        private void CreditMonthTextBox_Click(object sender, EventArgs e)
        {
            CreditMonthTrackBar.Value = Convert.ToInt32(CreditMonthTextBox.Text);
            showCalculatedCredit();
        }

        private void ApplyCreditButton_Click(object sender, EventArgs e)
        {
            DataStorage.attempts = 3;
            CreditSumTrackBar.Value = Convert.ToInt32(CreditSumTextBox.Text);
            CreditMonthTrackBar.Value = Convert.ToInt32(CreditMonthTextBox.Text);

            showCalculatedCredit();

            DataStorage.bankCard = DataStorage.cardNumber;

            if (DataStorage.attempts > 0)
            {
                var totalSum = Convert.ToDecimal(CreditMontlyPaymentLabel.Text) * Convert.ToDecimal(CreditMonthTextBox.Text);
                DateTime creditDate = DateTime.Now;
                var repaymentDate = creditDate.AddMonths(1);
                var payment = CreditMontlyPaymentLabel.Text;

                var idCredit = BankService.OpenCredit(DataStorage.cardNumber, totalSum, creditDate);

                var pay = CreditSumTextBox.Text;

                BankService.UpdateCreditRepayment(DataStorage.cardNumber, idCredit, repaymentDate, pay);

                MessageBox.Show("Кредит оформлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var creditInfo = BankService.GetCreditInfo(DataStorage.cardNumber);

                var creditTakeDate = Convert.ToDateTime(creditInfo["credit_date"].ToString());
                var creditSum = Convert.ToDecimal(creditInfo["credit_sum"].ToString());
                var creditTotalSum = Convert.ToDecimal(creditInfo["credit_total_sum"].ToString());
                var toPayDate = Convert.ToDateTime(creditInfo["repayment_date"].ToString());
                var creditToPaySum = Convert.ToDecimal(creditInfo["repayment_sum"].ToString());

                RegistrationDateLabel.Text = creditTakeDate.ToShortDateString();
                PaidSumLabel.Text = Math.Round(creditSum, 2).ToString();
                RemainSumLabel.Text = Math.Round(creditTotalSum, 2).ToString();
                PayDayLabel.Text = toPayDate.ToShortDateString();
                PaySumLabel.Text = Math.Round(creditToPaySum, 2).ToString();

                ApplyCreditButton.Visible = true;
                MyCreditPanel.Visible = true;
                PaymentButton.Visible = true;
            }
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            DateTime toPayDate = Convert.ToDateTime(PayDayLabel.Text);
            toPayDate = toPayDate.AddMonths(1);

            var sumToPay = PaySumLabel.Text;
            var bankCardInfo = BankService.GetBankCardInfo(DataStorage.cardNumber);
            var cardBalanceCheck = Convert.ToDecimal(bankCardInfo["bank_card_balance"].ToString());

            Decimal checkSum = Convert.ToDecimal(PaidSumLabel.Text);
            Decimal checkTotalSum = Convert.ToDecimal(RemainSumLabel.Text);
            bool checkStatus = false;
            
            if (checkSum >= checkTotalSum)
            {
                MessageBox.Show("Кредит погашен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                checkStatus = true;
            }

            if (checkStatus == false)
            {
                bool error = false;
                Decimal paymentSum = Convert.ToDecimal(PaySumLabel.Text);

                if (paymentSum > cardBalanceCheck)
                {
                    MessageBox.Show("Ошибк. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (error == false)
                {
                    BankService.MakeRepaymentCreditService(toPayDate, sumToPay, DataStorage.cardNumber);

                    var creditInfo = BankService.GetCreditInfo(DataStorage.cardNumber);
                    DateTime dateRepay = Convert.ToDateTime(creditInfo["repayment_date"]);
                    Decimal toPaySum = Convert.ToDecimal(creditInfo["credit_sum"]);

                    PaidSumLabel.Text = Math.Round(toPaySum, 2).ToString();
                    PayDayLabel.Text = dateRepay.ToShortDateString();
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }
    }
}
