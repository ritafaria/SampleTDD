using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanToDecimalTests
{
    [TestClass]
    public class RomanToDecimalConversationTests
    {
        [TestMethod]
        public void VerifyDecimalValueForSingleRomanSymbol()
        {
            string romanStr = "V";

            int val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(10, val);

            romanStr = "C";
            val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(100, val);
        }

        [TestMethod]
        public void VerifyDecimalValueForRepeatingRomanSymbol()
        {
            string romanStr = "II";

            int val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(2, val);

            romanStr = "XXX";
            val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(30, val);

            romanStr = "CC";
            val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(200, val);
        }

        [TestMethod]
        public void VerifyDecimalValueForRomansubtractivenotation()
        {
            string romanStr = "IV";

            int val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(4, val);

            romanStr = "CD";
            val = RomanToDecimalConverter(romanStr);
            Assert.AreEqual(400, val);
        }
    }
}
