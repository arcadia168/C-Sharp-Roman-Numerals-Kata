using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ***REMOVED******REMOVED***RomanNumerals;

namespace ***REMOVED******REMOVED***RomanNumeralGeneratorTests
{
    [TestClass]
    public class GenerateRomanNumeralsTests
    {
        static RomanNumeralGenerator testRomanNumeralGeneratorNumeralGenerator = new RomanNumeralGenerator();

        [TestMethod]
        public void RomanNumeralGenerator_1_I()
        {
            //testRomanNumeralGeneratorNumeralGenerator = new RomanNumeralGenerator();
            Assert.AreEqual("I", testRomanNumeralGeneratorNumeralGenerator.generate(1));
        }

        [TestMethod]
        public void RomanNumeralGenerator_2_II()
        {
            //testRomanNumeralGeneratorNumeralGenerator = new RomanNumeralGenerator();
            Assert.AreEqual("II", testRomanNumeralGeneratorNumeralGenerator.generate(2));
        }

        [TestMethod]
        public void RomanNumeralGenerator_3_III()
        {
            Assert.AreEqual("III", testRomanNumeralGeneratorNumeralGenerator.generate(3));
        }

        [TestMethod]
        public void RomanNumeralGenerator_4_IV()
        {
            Assert.AreEqual("IV", testRomanNumeralGeneratorNumeralGenerator.generate(4));
        }

        [TestMethod]
        public void RomanNumeralGenerator_5_V()
        {
            Assert.AreEqual("V", testRomanNumeralGeneratorNumeralGenerator.generate(5));
        }

        [TestMethod]
        public void RomanNumeralGenerator_9_IX()
        {
            Assert.AreEqual("IX", testRomanNumeralGeneratorNumeralGenerator.generate(9));
        }

        [TestMethod]
        public void RomanNumeralGenerator_10_X()
        {
            Assert.AreEqual("X", testRomanNumeralGeneratorNumeralGenerator.generate(10));
        }

        [TestMethod]
        public void RomanNumeralGenerator_49_XLIX()
        {
            Assert.AreEqual("XLIX", testRomanNumeralGeneratorNumeralGenerator.generate(49));
        }

        [TestMethod]
        public void RomanNumeralGenerator_50_L()
        {
            Assert.AreEqual("L", testRomanNumeralGeneratorNumeralGenerator.generate(50));
        }

        [TestMethod]
        public void RomanNumeralGenerator_90_XC()
        {
            Assert.AreEqual("XC", testRomanNumeralGeneratorNumeralGenerator.generate(90));
        }

        [TestMethod]
        public void RomanNumeralGenerator_99_XCIX()
        {
            Assert.AreEqual("XCIX", testRomanNumeralGeneratorNumeralGenerator.generate(99));
        }

        [TestMethod]
        public void RomanNumeralGenerator_100_C()
        {
            Assert.AreEqual("C", testRomanNumeralGeneratorNumeralGenerator.generate(100));
        }

        [TestMethod]
        public void RomanNumeralGenerator_400_CD()
        {
            Assert.AreEqual("CD", testRomanNumeralGeneratorNumeralGenerator.generate(400));
        }

        [TestMethod]
        public void RomanNumeralGenerator_500_D()
        {
            Assert.AreEqual("D", testRomanNumeralGeneratorNumeralGenerator.generate(500));
        }

        [TestMethod]
        public void RomanNumeralGenerator_900_CM()
        {
            Assert.AreEqual("CM", testRomanNumeralGeneratorNumeralGenerator.generate(900));
        }

        [TestMethod]
        public void RomanNumeralGenerator_1000_M()
        {
            Assert.AreEqual("M", testRomanNumeralGeneratorNumeralGenerator.generate(1000));
        }

        [TestMethod]
        public void RomanNumeralGenerator_3999_MMMCMXCIX()
        {
            Assert.AreEqual("MMMCMXCIX", testRomanNumeralGeneratorNumeralGenerator.generate(3999));
        }

        [TestMethod]
        public void RomanNumeralGenerator_4000_MMMM()
        {
            Exception expectedExcetpion = null;

            // Act
            try
            {
                testRomanNumeralGeneratorNumeralGenerator.generate(4000);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void RomanNumeralGenerator_0()
        {
            Exception expectedExcetpion = null;

            // Act
            try
            {
                testRomanNumeralGeneratorNumeralGenerator.generate(0);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void RomanNumeralGenerator_minus1()
        {
            Exception expectedExcetpion = null;

            // Act
            try
            {
                testRomanNumeralGeneratorNumeralGenerator.generate(-1);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
