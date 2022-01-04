using iCalendar.Collections;

namespace iCalendar
{
    public interface ICalendarObjectList<TType> :
        IGroupedCollection<string, TType> where TType : class, ICalendarObject
    {
        TType this[int index] { get; }
    }
}