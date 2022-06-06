namespace WebApp.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Store Store { get; set; }
    }
}
