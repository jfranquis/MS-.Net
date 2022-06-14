namespace productsApi.Data
{
    public class product
    {
        internal readonly object Name;

        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int Inventory { get; set; }
    }
}
