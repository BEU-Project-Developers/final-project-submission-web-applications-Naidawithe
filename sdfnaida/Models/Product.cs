namespace sdfnaida.Models
{
    public class Product :BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        // Foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation
        public ICollection<Review> Reviews { get; set; }
    }

}
