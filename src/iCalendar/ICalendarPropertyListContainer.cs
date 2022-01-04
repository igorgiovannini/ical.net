namespace iCalendar
{
    public interface ICalendarPropertyListContainer : ICalendarObject
    {
        CalendarPropertyList Properties { get; }
    }
}