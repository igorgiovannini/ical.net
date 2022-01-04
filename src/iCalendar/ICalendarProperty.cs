using iCalendar.Collections.Interfaces;
using iCalendar.DataTypes;

namespace iCalendar
{
    public interface ICalendarProperty : ICalendarParameterCollectionContainer, ICalendarObject, IValueObject<object>
    {
        object Value { get; set; }
    }
}