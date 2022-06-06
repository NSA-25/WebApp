namespace WebApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Class { get; set; }
        public ICollection<StoreProduct> StoreProducts { get; set; }
    }
}
