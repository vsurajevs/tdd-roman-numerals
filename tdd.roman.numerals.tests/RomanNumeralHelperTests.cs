using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd.roman.numerals.tests
{
    [TestClass]
    public class RomanNumeralHelperTests
    {
        [TestMethod]
        public void ToRoman_WhenValidInt_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassedFour_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassedFive_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(5);
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassedValidInt_ReturnsUpperCase()
        {
            var result = RomanNumeralHelper.ToRoman(6);
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassedNine_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(9);
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassedNegative_ReturnsCorrectRomanNumber()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => RomanNumeralHelper.ToRoman(-9));
        }

        [TestMethod]
        public void ToRoman_WhenPassedFifty_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(76);
            Assert.AreEqual("LXXVI", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassed123_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(123);
            Assert.AreEqual("CXXIII", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassed500_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(500);
            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassed1900_ReturnsCorrectRomanNumber()
        {
            var result = RomanNumeralHelper.ToRoman(1900);
            Assert.AreEqual("MCM", result);
        }

        [TestMethod]
        public void ToRoman_WhenPassed4000_ReturnsCorrectRomanNumber()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => RomanNumeralHelper.ToRoman(4000));

        }
    }
}
