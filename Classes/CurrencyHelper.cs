using System.Xml.Linq;

namespace BankApp.Classes
{
    public static class CurrencyHelper
    {
        public enum Currency
        { RUB, EURO, USD }

        private const string UsaDollarID = "R01235";
        private const string EuroID = "R01239";
        private static HttpClient client = new HttpClient();
        public static string ParseUrl { get; set; } = "https://www.cbr-xml-daily.ru/daily.xml";
        public static async Task<(Decimal, Decimal)> UpdateExchangeRate()
        {
            string responseBody = string.Empty;
            (Decimal, Decimal) result = (0m, 0m);

            HttpResponseMessage response = await client.GetAsync(ParseUrl);
            if (response.IsSuccessStatusCode) 
            { 
                responseBody = await response.Content.ReadAsStringAsync();
              
                XDocument xdoc = XDocument.Parse(responseBody);
                var element = xdoc.Element("ValCurs")?.Elements("Valute");
                
                string usd = element.Where(el => el.Attribute("ID").Value == UsaDollarID)?.Select(el => el.Element("Value").Value).FirstOrDefault();
                string euro = element.Where(el => el.Attribute("ID").Value == EuroID)?.Select(el => el.Element("Value").Value).FirstOrDefault();
          
                if (!string.IsNullOrEmpty(usd) && !string.IsNullOrEmpty(euro))
                    result = (Decimal.Parse(usd.Replace(',', '.')[0..^2]), Decimal.Parse(euro.Replace(',', '.')[0..^2]));
            }
            return result;
        }

        public static Currency GetCurrencyTypeFromString(string currency)
        {
            Currency operationCurrency = Currency.RUB;
            if (Enum.IsDefined(typeof(Currency), currency))
            {
                operationCurrency = (Currency)Enum.Parse(typeof(Currency), currency);
            }
            return operationCurrency;
        }

        public static (Decimal, Decimal) CalculateCurrencyTransfer(string cardCurrency, string cardCurrency2, Decimal sum)
        {
            var (usd, euro) = CurrencyHelper.UpdateExchangeRate().Result;
            Decimal usdToEuro = euro / usd;

            Decimal recalculationSum = 0;
            Decimal commissionSum = 0;

            if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == CurrencyHelper.Currency.RUB
                && CurrencyHelper.GetCurrencyTypeFromString(cardCurrency2) == CurrencyHelper.Currency.USD)
            {
                recalculationSum = (sum /= usd);
            }
            else if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == CurrencyHelper.Currency.RUB
                && CurrencyHelper.GetCurrencyTypeFromString(cardCurrency2) == CurrencyHelper.Currency.EURO)
            {
                recalculationSum = (sum /= euro);
            }
            else if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == CurrencyHelper.Currency.USD
                && CurrencyHelper.GetCurrencyTypeFromString(cardCurrency2) == CurrencyHelper.Currency.RUB)
            {
                recalculationSum = (sum *= usd);
            }
            else if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == CurrencyHelper.Currency.USD
                && CurrencyHelper.GetCurrencyTypeFromString(cardCurrency2) == CurrencyHelper.Currency.EURO)
            {
                recalculationSum = (sum *= usdToEuro);
            }
            else if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == CurrencyHelper.Currency.EURO
                && CurrencyHelper.GetCurrencyTypeFromString(cardCurrency2) == CurrencyHelper.Currency.RUB)
            {
                recalculationSum = (sum *= euro);
            }
            else
            {
                recalculationSum = sum;
                commissionSum = sum * BankOptions.TransferCommission;
            }

            return (recalculationSum, commissionSum);
        }
    }
}
