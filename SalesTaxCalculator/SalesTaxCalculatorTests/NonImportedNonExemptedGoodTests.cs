using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class NonImportedNonExemptedGoodTests
    {
        [TestMethod()]
        public void GetTotalPrice_OneNonImportedNonExemptedGood_ReturnBasicTaxAppliedInUnitPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var unitPrice = 14.99;
            var quantity = 1;
            var nonImportedNomExemptedGood = new NonImportedNonExemptedGood("music CD", unitPrice, quantity, basicSalesTax);
            double expected = 16.49;
            double actual = Math.Round(nonImportedNomExemptedGood.GetTotalPrice(),2);
            Assert.AreEqual(expected, actual);

            unitPrice = 18.99;
            quantity = 1;
            expected = 20.89;
            nonImportedNomExemptedGood = new NonImportedNonExemptedGood("bottle of perfume", unitPrice, quantity, basicSalesTax);
            actual = Math.Round(nonImportedNomExemptedGood.GetTotalPrice(),2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPrice_5NonImportedNonExemptedGood_ReturnBasicTaxAppliedInEffectiveUnitPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var unitPrice = 14.99;
            var quantity = 5;
            var nonImportedNomExemptedGood = new NonImportedNonExemptedGood("music CD", unitPrice, quantity, basicSalesTax);
            double expected = 82.45;
            double actual = Math.Round(nonImportedNomExemptedGood.GetTotalPrice(), 2);
            Assert.AreEqual(expected, actual);

            unitPrice = 18.99;
            quantity = 5;
            expected = 104.45;
            nonImportedNomExemptedGood = new NonImportedNonExemptedGood("bottle of perfume", unitPrice, quantity, basicSalesTax);
            actual = Math.Round(nonImportedNomExemptedGood.GetTotalPrice(), 2);
            Assert.AreEqual(expected, actual);
        }
    }
}