using iCalendar.Collections;

namespace iCalendar
{
    /// <summary>
    /// A collection of calendar objects.
    /// </summary>
    public class CalendarObjectList : GroupedList<string, ICalendarObject>, ICalendarObjectList<ICalendarObject>
    {
        public CalendarObjectList(ICalendarObject parent) {}
    }
}