namespace Organizer_v
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime(int year, int month, int day, int hour, int minute);
    }
}
