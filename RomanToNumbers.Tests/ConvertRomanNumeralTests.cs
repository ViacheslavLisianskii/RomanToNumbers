using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanToNumbers.Tests
{
    [TestClass]
    public class ConvertRomanNumeralTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionIfNumeralIsNull()
        {
            _roman.ConvertToNumber(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionIfNumeralContainsSpace()
        {
            _roman.ConvertToNumber("I V");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionIfNumeralIsEmpty()
        {
            _roman.ConvertToNumber(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionIfNumeralNotUsedInRomanNumerals()
        {
            _roman.ConvertToNumber("Y");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionIfNumeralIsSpace()
        {
            _roman.ConvertToNumber(" ");
        }

        [TestMethod]
        public void ShouldConvertNumeralI()
        {
            var number = _roman.ConvertToNumber("I");
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralIIIIIV()
        {
            var number = _roman.ConvertToNumber("IIIIIV");
            Assert.AreEqual(8, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralMMIV()
        {
            var number = _roman.ConvertToNumber("MMIV");
            Assert.AreEqual(2004, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralDCL()
        {
            var number = _roman.ConvertToNumber("DCL");
            Assert.AreEqual(650, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralCCXXII()
        {
            var number = _roman.ConvertToNumber("CCXXII");
            Assert.AreEqual(222, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralMLXVI()
        {
            var number = _roman.ConvertToNumber("MLXVI");
            Assert.AreEqual(1066, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralMLXIV()
        {
            var number = _roman.ConvertToNumber("MLXIV");
            Assert.AreEqual(1064, number);
        }

        [TestMethod]
        public void ShouldConvertNumeralMCMXLIV()
        {
            var number = _roman.ConvertToNumber("MCMXLIV");
            Assert.AreEqual(1944, number);
        }
        
        private readonly Roman _roman = new Roman();
    }
}
