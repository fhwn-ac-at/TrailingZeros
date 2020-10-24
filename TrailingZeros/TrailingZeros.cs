using System.Numerics;

namespace TrailingZeros
{
  public static class TrailingZeroCounter
  {
    public static int TrailingZeroCount(this BigInteger value)
    {
      if (value.IsZero)
        return 0;

      var count = 0;
      for (; (value & BigInteger.One).IsZero; value >>= 1, ++count) ;

      return count;
    }
  }
}
