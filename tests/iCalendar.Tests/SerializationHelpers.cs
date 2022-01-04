using iCalendar.CalendarComponents;
using iCalendar.Serialization;

namespace iCalendar.CoreUnitTests
{
    internal class SerializationHelpers
    {
        public static string SerializeToString(CalendarEvent calendarEvent)
            => SerializeToString(new Calendar { Events = { calendarEvent } });

        public static string SerializeToString(Calendar iCalendar)
            => new CalendarSerializer().SerializeToString(iCalendar);
    }
}
