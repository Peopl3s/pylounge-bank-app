using static BankApp.Classes.CurrencyHelper;

namespace BankApp.Classes
{
    public static class BankOptions
    {
        public enum CardVendor
        { MIR, VISA, MasterCard }

        public const int CardValidityPeriodYears = 4;
        public const int PaymentPeriodMounths = 1;
        public const Decimal TransferCommission = 1.04m;
        public const Decimal CommissionCoefficient = 2m;
        public const Decimal CreditMonthlyRate = 0.01m;

        public static Currency CurrencyByDefault { get; set; } = Currency.RUB;
        public static CardVendor CardVendorByDefault { get; set; } = CardVendor.VISA;

        public static CardVendor GetCardVendorTypeFromString(string cardVendor)
        {
            CardVendor operationCardVendor = CardVendorByDefault;
            if (Enum.IsDefined(typeof(CardVendor), cardVendor))
            {
                operationCardVendor = (CardVendor)Enum.Parse(typeof(CardVendor), cardVendor);
            }
            return operationCardVendor;
        }

        public static string GenerateCvvCode()
        {
            const int CvvCodeLength = 3;
            string cvvCode = string.Empty;

            Random rnd = new();
            for (int i = 0; i < CvvCodeLength; i++)
            {
                cvvCode += Convert.ToString(rnd.Next(0, 10));
            }
            return cvvCode;
        }

        public static string GenerateCardNumber(string cardPaymentSystem)
        {
            const int CardNumberLength = 15;
            Dictionary<CardVendor, char> paymentSystemLeadNum = new()
            {
                {CardVendor.VISA, '4' },
                {CardVendor.MasterCard, '5' },
                {CardVendor.MIR, '2' },
            };

            string cardNumber = string.Empty;
            cardNumber += paymentSystemLeadNum[GetCardVendorTypeFromString(cardPaymentSystem)];

            Random rnd = new();
            for (int i = 0; i < CardNumberLength; i++)
            {
                cardNumber += Convert.ToString(rnd.Next(0, 10));
            }

            return cardNumber;
        }

    }
}
