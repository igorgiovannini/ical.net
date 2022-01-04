using System.Collections.Generic;
using iCalendar.CalendarComponents;
using iCalendar.DataTypes;

namespace iCalendar
{
    public interface IGetFreeBusy
    {
        FreeBusy GetFreeBusy(FreeBusy freeBusyRequest);
        FreeBusy GetFreeBusy(IDateTime fromInclusive, IDateTime toExclusive);
        FreeBusy GetFreeBusy(Organizer organizer, IEnumerable<Attendee> contacts, IDateTime fromInclusive, IDateTime toExclusive);
    }
}