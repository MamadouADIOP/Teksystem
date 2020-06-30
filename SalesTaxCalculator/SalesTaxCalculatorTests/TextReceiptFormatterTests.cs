using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxCalculator.Interfaces;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class TextReceiptFormatterTests
    {
        [TestMethod()]
        public void Format_GoodListProvidedWithOneQuantity_DisplayCorrectReportTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            char bullet = (char)248;
            List<Good> input1Goods = new List<Good>();
            input1Goods.Add(new NonImportedExemptedGood("book", 12.49, 1));
            input1Goods.Add(new NonImportedNonExemptedGood("music CD", 14.99, 1, basicSalesTax));
            var taxAggregator = new TaxAggregator();
            var textReceiptFormat = new TextReceiptFormatter(taxAggregator);
            var actual = textReceiptFormat.Format(input1Goods);
            var expected = $"   {bullet} 1 book: 12,49\r\n   {bullet} 1 music CD: 16,49\r\n   {bullet} Sales Taxes: 1,50 Total: 28,98\r\n";
            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void Format_GoodListProvidedWithQuantity5_DisplayCorrectReportTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            char bullet = (char)248;
            List<Good> input1Goods = new List<Good>();
            input1Goods.Add(new NonImportedExemptedGood("book", 12.49, 5));
            input1Goods.Add(new NonImportedNonExemptedGood("music CD", 14.99, 5, basicSalesTax));
            var taxAggregator = new TaxAggregator();
            var textReceiptFormat = new TextReceiptFormatter(taxAggregator);
            var actual = textReceiptFormat.Format(input1Goods);
            var expected = $"   {bullet} 5 book: 62,45\r\n   {bullet} 5 music CD: 82,45\r\n   {bullet} Sales Taxes: 7,50 Total: 144,90\r\n";
            Assert.AreEqual(actual, expected);
        }
    }
}