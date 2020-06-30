using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class SalesTaxApplierTests
    {
        [TestMethod()]
        public void ApplyTax_WithSalesTaxOf10Percent_ReturnCalculatedTax()
        {
            RoundToNearestMultipleCalculator roundToNearest = new RoundToNearestMultipleCalculator(0.05);
            BasicSalesTax basicSalesTax = new BasicSalesTax(10, roundToNearest);
            var unitPrice = 14.99;
            double expected = 1.5;
            var actual = basicSalesTax.ApplyTax(unitPrice);
            Assert.AreEqual(expected, actual);

            unitPrice = 14.99;
            expected = 1.5;
            actual = basicSalesTax.ApplyTax(unitPrice);
            Assert.AreEqual(expected, actual);
        }
    }
}