using System;

namespace iCalendar.Serialization
{
    public interface ISerializerFactory
    {
        ISerializer Build(Type objectType, SerializationContext ctx);
    }
}