namespace WebApp.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public ICollection<StoreProduct> StoreProducts { get; set; }
    }
}
