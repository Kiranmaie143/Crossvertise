using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

       public string EventName { get; set; }

        public DateTime EventDate { get; set; }
    }
    public enum Months
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        sep,
        Oct,
        Nov,
        Dec

    };
}
