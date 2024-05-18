namespace task5
{
    public class Order
    {
        private Product[] products;
        public Product[] Products 
        {
            get
            {
                return products;
            }
        }
        public int Limit { get; } = 10;
        public Order()
        {
            products = new Product[0];
        }
        public void AddProduct(Product product)
        {
            if (Limit > products.Length)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("sifaris limite catib");
            }
        }
        public void RemoveProduct(Product product)
        {
            var index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index; i < products.Length; i++)
                    products[i] = products[i + 1];
                Array.Resize(ref products, products.Length - 1);
            }
            else
            {
                Console.WriteLine("Axtardiginiz mehsul sifarisde yoxdur ");
            }
        }
        public void GetProductsDetails()
        {
            foreach (var product in products)
            {
                product.GetDetails();
            }
        }
        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            foreach (var product in products)
                sum += product.Price;
            return sum;
        }
    }
}
