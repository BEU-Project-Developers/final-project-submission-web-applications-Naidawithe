namespace sdfnaida.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation
        public ICollection<Product> Products { get; set; }
    }

}
