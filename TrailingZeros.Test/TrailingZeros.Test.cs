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
                yield return new TestCaseData(new BigInteger(0)).Returns(0);
                yield return new TestCaseData(new BigInteger(1)).Returns(0);
                yield return new TestCaseData(new BigInteger(10)).Returns(1);
                yield return new TestCaseData(new BigInteger(90)).Returns(1);
                yield return new TestCaseData(new BigInteger(99)).Returns(0);
                yield return new TestCaseData(new BigInteger(100)).Returns(2);
                yield return new TestCaseData(new BigInteger(4711000)).Returns(3);
                yield return new TestCaseData(new BigInteger(4711001)).Returns(0);
                yield return new TestCaseData(BigInteger.Parse("12345678900000000000000000000")).Returns(20);
                yield return new TestCaseData(BigInteger.Parse("12345678900000000000000000001")).Returns(0);

                yield return new TestCaseData(new BigInteger(-0)).Returns(0);
                yield return new TestCaseData(new BigInteger(-1)).Returns(0);
                yield return new TestCaseData(new BigInteger(-10)).Returns(1);
                yield return new TestCaseData(new BigInteger(-90)).Returns(1);
                yield return new TestCaseData(new BigInteger(-99)).Returns(0);
                yield return new TestCaseData(new BigInteger(-100)).Returns(2);
                yield return new TestCaseData(new BigInteger(-4711000)).Returns(3);
                yield return new TestCaseData(new BigInteger(-4711001)).Returns(0);
                yield return new TestCaseData(BigInteger.Parse("-12345678900000000000000000000")).Returns(20);
                yield return new TestCaseData(BigInteger.Parse("-12345678900000000000000000001")).Returns(0);
            }
        }

        [TestCaseSource("TrailingZerosData")]
        public int TrailingZerosAreCountedCorrectly(BigInteger value) => value.TrailingZeroCount();
    }
}