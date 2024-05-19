using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }
    }
}
