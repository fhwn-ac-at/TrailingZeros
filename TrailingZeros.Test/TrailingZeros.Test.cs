using System.Numerics;
using System.Collections;

using NUnit.Framework;

namespace TrailingZeros.Test
{
  public class Tests
  {
    private static IEnumerable TrailingZerosData
    {
      get
      {
        yield return new TestCaseData(new BigInteger(0b0)).Returns(0);
        yield return new TestCaseData(new BigInteger(0b1)).Returns(0);
        yield return new TestCaseData(new BigInteger(0b10)).Returns(1);
        yield return new TestCaseData(new BigInteger(0b100)).Returns(2);
        yield return new TestCaseData(new BigInteger(0b101)).Returns(0);
        yield return new TestCaseData(new BigInteger(0b10000000000000)).Returns(13);
        yield return new TestCaseData(BigInteger.Parse("6602334503035104426390978560")).Returns(20);
        yield return new TestCaseData(BigInteger.Parse("6602334503035104426390978561")).Returns(0);

        yield return new TestCaseData(new BigInteger(-0b0)).Returns(0);
        yield return new TestCaseData(new BigInteger(-0b1)).Returns(0);
        yield return new TestCaseData(new BigInteger(-0b10)).Returns(1);
        yield return new TestCaseData(new BigInteger(-0b100)).Returns(2);
        yield return new TestCaseData(new BigInteger(-0b101)).Returns(0);
        yield return new TestCaseData(new BigInteger(-0b10000000000000)).Returns(13);
        yield return new TestCaseData(BigInteger.Parse("-6602334503035104426390978560")).Returns(20);
        yield return new TestCaseData(BigInteger.Parse("-6602334503035104426390978561")).Returns(0);
      }
    }

    [TestCaseSource("TrailingZerosData")]
    public int TrailingZerosAreCountedCorrectly(BigInteger value) => value.TrailingZeroCount();
  }
}
