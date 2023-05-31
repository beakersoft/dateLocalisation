using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DateTimeLocalisation.Data.Entities
{
    [Table(nameof(LukeOrders), Schema = "Savant")]
    public class LukeOrders
    {
        [Key]
        public int OrderId { get; set; }

        // just UTC
        public DateTime OrderTimeUtc { get; set; }

        // order datetime with the offset value
        public DateTimeOffset OrderTimeOffset { get; set; }

        //  timezone of the user who placed the order
        public string OrderTimeZone { get; set; }
    }
}