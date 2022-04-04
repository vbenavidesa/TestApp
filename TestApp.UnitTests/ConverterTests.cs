using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestApp.UnitTests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void Roman_I_1()
        {
            Assert.AreEqual(1, RomanNumberConverter.FromRoman("I"));
        }

        [TestMethod]
        public void Roman_II_2()
        {
            Assert.AreEqual(2, RomanNumberConverter.FromRoman("II"));
        }

        [TestMethod]
        public void Roman_III_3()
        {
            Assert.AreEqual(3, RomanNumberConverter.FromRoman("III"));
        }

        [TestMethod]
        public void Roman_IV_4()
        {
            Assert.AreEqual(4, RomanNumberConverter.FromRoman("IV"));
        }

        [TestMethod]
        public void Roman_V_5()
        {
            Assert.AreEqual(5, RomanNumberConverter.FromRoman("V"));
        }

        [TestMethod]
        public void Roman_IX_9()
        {
            Assert.AreEqual(9, RomanNumberConverter.FromRoman("IX"));
        }

        [TestMethod]
        public void Roman_X_10()
        {
            Assert.AreEqual(10, RomanNumberConverter.FromRoman("X"));
        }

        [TestMethod]
        public void Roman_XLIX_49()
        {
            Assert.AreEqual(49, RomanNumberConverter.FromRoman("XLIX"));
        }

        [TestMethod]
        public void Roman_L_50()
        {
            Assert.AreEqual(50, RomanNumberConverter.FromRoman("L"));
        }

        [TestMethod]
        public void Roman_C_100()
        {
            Assert.AreEqual(100, RomanNumberConverter.FromRoman("C"));
        }

        [TestMethod]
        public void Roman_CD_400()
        {
            Assert.AreEqual(400, RomanNumberConverter.FromRoman("CD"));
        }

        [TestMethod]
        public void Roman_D_500()
        {
            Assert.AreEqual(500, RomanNumberConverter.FromRoman("D"));
        }

        [TestMethod]
        public void Roman_CM_900()
        {
            Assert.AreEqual(900, RomanNumberConverter.FromRoman("CM"));
        }

        [TestMethod]
        public void Roman_M_1000()
        {
            Assert.AreEqual(1000, RomanNumberConverter.FromRoman("M"));
        }

        [TestMethod]
        public void Roman_MMMMMMMMMMMCMLXXXIV_11984()
        {
            Assert.AreEqual(11984, RomanNumberConverter.FromRoman("MMMMMMMMMMMCMLXXXIV"));
        }
    }
}