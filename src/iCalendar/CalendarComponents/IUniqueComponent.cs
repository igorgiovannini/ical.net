using System;
using System.Collections.Generic;
using iCalendar.DataTypes;

namespace iCalendar.CalendarComponents
{
    public interface IUniqueComponent : ICalendarComponent
    {
        string Uid { get; set; }

        IList<Attendee> Attendees { get; set; }
        IList<string> Comments { get; set; }
        IDateTime DtStamp { get; set; }
        Organizer Organizer { get; set; }
        IList<RequestStatus> RequestStatuses { get; set; }
        Uri Url { get; set; }
    }
}