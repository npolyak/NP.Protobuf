using Google.Protobuf.WellKnownTypes;
using NP.Utilities;

namespace NP.Protobuf;

public static class EnumHelper
{
    public static EnumValue ToEnumVal(this System.Enum e)
    {
        return new EnumValue { Name = System.Enum.GetName(e.GetType(), e), Number = e.ToInt() };
    }
}
