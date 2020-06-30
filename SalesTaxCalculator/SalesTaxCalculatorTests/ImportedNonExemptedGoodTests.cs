using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace SalesTaxCalculator.Tests
{
    [TestClass()]
    public class ImportedNonExemptedGoodTests
    {
        [TestMethod()]
        public void GetTotalPrice_OneImportedAndNonExemptedGood_ReturnRightTotalPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var importDutySalesTax = serviceProvider.GetService<IImportDutySalesTax>();
            var unitPrice = 27.99;
            var quantity = 1;
            var importedNonExemptedGood = new ImportedNonExemptedGood("imported bottle of perfume", unitPrice, quantity, importDutySalesTax, basicSalesTax);
            var expected = 32.19;
            var actual = importedNonExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);

            unitPrice = 47.50;
            quantity = 1;
            expected = 54.65;
            importedNonExemptedGood = new ImportedNonExemptedGood("imported bottle of perfume", unitPrice, quantity, importDutySalesTax, basicSalesTax);
            actual = importedNonExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPrice_5ImportedAndNonExemptedGood_ReturnRightTotalPriceTest()
        {
            var serviceProvider = Program.RegisterProvider();
            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var importDutySalesTax = serviceProvider.GetService<IImportDutySalesTax>();
            var unitPrice = 27.99;
            var quantity = 5;
            var expected = 160.95;
            var importedNonExemptedGood = new ImportedNonExemptedGood("imported bottle of perfume", unitPrice, quantity, importDutySalesTax, basicSalesTax);
            var actual = importedNonExemptedGood.GetTotalPrice();
            Assert.AreEqual(expected, actual);
        }

    }
}