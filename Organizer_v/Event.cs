
using System.Globalization;

namespace Organizer_v
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; } 

        //(int year, int month, int day, Calendar calendar)//
    }
}
