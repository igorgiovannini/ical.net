using iCalendar.DataTypes;
using NUnit.Framework;

namespace iCalendar.CoreUnitTests
{
    [TestFixture]
    public class DataTypeTest
    {
        [Test, Category("DataType")]
        public void OrganizerConstructorMustAcceptNull()
        {
            Assert.DoesNotThrow(() => { var o = new Organizer(null); });
        }

        [Test, Category("DataType")]
        public void AttachmentConstructorMustAcceptNull()
        {
            Assert.DoesNotThrow(() => { var o = new Attachment((byte[])null); });
            Assert.DoesNotThrow(() => { var o = new Attachment((string)null); });
        }
    }
}