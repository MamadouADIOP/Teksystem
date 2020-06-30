using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class NonImportedExemptedGoodTests
    {
        [TestMethod()]
        public void GetTotalPrice_OneNonImportedExemptedGood_ReturnExactlyUnitPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var importDutySalesTax = serviceProvider.GetService<IImportDutySalesTax>();
            var unitPrice = 12.49;
            var quantity = 1;
            var nonImportedExemptedGood = new NonImportedExemptedGood("book", unitPrice, quantity);
            var expected = 12.49;
            var actual = nonImportedExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);

            unitPrice = 9.75;
            quantity = 1;
            expected = 9.75;
            nonImportedExemptedGood = new NonImportedExemptedGood("packet of headache pills", unitPrice, quantity);
            actual = nonImportedExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPrice_5NonImportedExemptedGood_ReturnExactlyUnitPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var importDutySalesTax = serviceProvider.GetService<IImportDutySalesTax>();
            var unitPrice = 12.49;
            var quantity = 5;
            var nonImportedExemptedGood = new NonImportedExemptedGood("book", unitPrice, quantity);
            var expected = 62.45;
            var actual = nonImportedExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);

            unitPrice = 9.75;
            quantity = 5;
            expected = 48.75;
            nonImportedExemptedGood = new NonImportedExemptedGood("packet of headache pills", unitPrice, quantity);
            actual = nonImportedExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);
        }
    }
}