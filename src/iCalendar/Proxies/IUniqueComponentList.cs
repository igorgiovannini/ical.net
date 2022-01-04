using System.Collections.Generic;
using iCalendar.CalendarComponents;

namespace iCalendar.Proxies
{
    public interface IUniqueComponentList<TComponentType> :
        ICalendarObjectList<TComponentType> where TComponentType : class, IUniqueComponent
    {
        TComponentType this[string uid] { get; set; }
        void AddRange(IEnumerable<TComponentType> collection);
    }
}