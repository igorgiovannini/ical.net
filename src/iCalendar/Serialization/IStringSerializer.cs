using System.IO;

namespace iCalendar.Serialization
{
    public interface IStringSerializer : ISerializer
    {
        string SerializeToString(object obj);
        object Deserialize(TextReader tr);
    }
}