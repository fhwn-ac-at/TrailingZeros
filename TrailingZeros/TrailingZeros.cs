using System.Numerics;

namespace TrailingZeros
{
    public static class TrailingZeroCounter
    {
        public static int TrailingZeroCount(this BigInteger value)
        {
            if (value == 0)
                return 0;

            var count = 0;
            for (; value % 10 == 0; value /= 10, ++count) ;

            return count;
        }
    }
}
