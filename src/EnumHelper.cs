using Google.Protobuf.WellKnownTypes;
using NP.Utilities;

namespace NP.Protobuf;

public static class EnumHelper
{
    public static EnumValue ToEnumVal(this System.Enum e)
    {
        return new EnumValue { Name = System.Enum.GetName(e.GetType(), e), Number = e.ToInt() };
    }

    public static ShortMsg ToShortMsg(this System.Enum topic) 
    {
        return new ShortMsg
        {
            MsgSentTime = Timestamp.FromDateTime(DateTime.UtcNow),
            Topic = topic.ToEnumVal()
        };
    }
}
