namespace task6
{
    public class Invoice
    {
        public string Account { get; set; }
        public string Customer { get; set; }
        public string Provider { get; set; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }
        public double GetEdv()
        {
            return Price * 0.18;
        }
        public double CostCalculation(bool needEdv)
        {
            if (needEdv)
            {
                return Price * Quantity + GetEdv();
            }
            else
            {
                return Price * Quantity;
            }
        }
        public string GetDetails()
        {
            return $"{Account} {Customer} {Provider} {Article} ";
        }
    }
}
