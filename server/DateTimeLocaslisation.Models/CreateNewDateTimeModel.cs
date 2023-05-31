namespace DateTimeLocalisation.Models
{
    public class CreateNewDateTimeModel
    {
        public DateTime NewDateTime { get; set; }
        public DateTimeOffset NewDateTimeOffset { get; set; }
        public string TimeZone { get; set; }
    }
}