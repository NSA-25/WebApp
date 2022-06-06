namespace WebApp.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}
