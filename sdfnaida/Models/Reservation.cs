namespace sdfnaida.Models
{
    public class Reservation : BaseEntity
    {
        public int Id { get; set; }

        public DateTime ReservationDate { get; set; }
        public int NumberOfPeople { get; set; }
        public string Note { get; set; }

        // Foreign key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
