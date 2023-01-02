using Google.Protobuf.WellKnownTypes;
using NP.Utilities;

namespace NP.Protobuf;

public static class EnumHelper
{
    public static EnumValue ToEnumVal(this System.Enum e)
    {
        return new EnumValue { Name = nameof(e), Number = e.ToInt() };
    }
}
