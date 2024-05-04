using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Organizer")]
        public string? Name { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; }

        public int EventId { get; set; }

        [DisplayName("Attendies")]
        public List<string>? Attendies { get; set; }


    }
}
