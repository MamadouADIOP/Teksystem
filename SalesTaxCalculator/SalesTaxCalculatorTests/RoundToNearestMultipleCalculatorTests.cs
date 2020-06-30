using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class RoundToNearestMultipleCalculatorTests
    {
        [TestMethod()]
        public void RoundUp_PrecisionIs005_ReturnNearestUpperValue()
        {
            RoundToNearestMultipleCalculator roundToNearest = new RoundToNearestMultipleCalculator(0.05);
            var number = 12.789;
            var expected = 12.80;
            var actual = roundToNearest.RoundUp(number);
            Assert.AreEqual(expected, actual);
            number = 12.735;
            expected = 12.75;
            actual = roundToNearest.RoundUp(number);
            Assert.AreEqual(expected, actual);

            number = 12.70;
            expected = 12.70;
            actual = roundToNearest.RoundUp(number);
            Assert.AreEqual(expected, actual);
        }

    }
}