using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            return checked((short)num);
        }

        public static long FloatToLong(float num)
        {
            return (long)Math.Round(num);
        }
    }
}
