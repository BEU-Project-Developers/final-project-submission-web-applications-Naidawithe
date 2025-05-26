namespace sdfnaida.Models
{
    public class Review : BaseEntity
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public int Rating { get; set; } 
        public DateTime Date { get; set; }

        // Foreign keys
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
