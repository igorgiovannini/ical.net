namespace iCalendar.Collections
{
    public interface IGroupedObject<TGroup>
    {
        TGroup Group { get; set; }
    }
}
