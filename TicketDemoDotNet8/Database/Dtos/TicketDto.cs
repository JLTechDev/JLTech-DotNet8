namespace Business.Models
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }

    }
}
