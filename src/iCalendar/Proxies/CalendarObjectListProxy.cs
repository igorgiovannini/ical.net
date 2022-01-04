using System.Linq;
using iCalendar.Collections;
using iCalendar.Collections.Proxies;

namespace iCalendar.Proxies
{
    public class CalendarObjectListProxy<TType> : GroupedCollectionProxy<string, ICalendarObject, TType>, ICalendarObjectList<TType>
        where TType : class, ICalendarObject
    {
        public CalendarObjectListProxy(IGroupedCollection<string, ICalendarObject> list) : base(list) {}

        public virtual TType this[int index] => this.Skip(index).FirstOrDefault();
    }
}