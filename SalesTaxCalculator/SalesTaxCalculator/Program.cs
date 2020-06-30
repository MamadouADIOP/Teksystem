using Microsoft.Extensions.DependencyInjection;
using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;

namespace SalesTaxCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Declare services for dependency injection implementation
            IServiceProvider serviceProvider = RegisterProvider();

            #endregion

            var basicSalesTax = serviceProvider.GetService<IBasicSalesTax>();
            var importDutySalesTax = serviceProvider.GetService<IImportDutySalesTax>();
            //Input 1

            List<Good> input1Goods = new List<Good>();
            input1Goods.Add(new NonImportedExemptedGood("book", 12.49, 1));
            input1Goods.Add(new NonImportedNonExemptedGood("music CD", 14.99, 1, basicSalesTax));
            input1Goods.Add(new NonImportedExemptedGood("chocolateBar", 0.85, 1));

            //Input 2

            List<Good> input2Goods = new List<Good>();
            input2Goods.Add(new ImportedExemptedGood("imported box of chocolates", 10, 1, importDutySalesTax));
            input2Goods.Add(new ImportedNonExemptedGood("imported bottle of perfume", 47.50, 1, importDutySalesTax, basicSalesTax));

            //Input 3

            List<Good> input3Goods = new List<Good>();
            input3Goods.Add(new ImportedNonExemptedGood("imported bottle of perfume", 27.99, 1, importDutySalesTax, basicSalesTax));
            input3Goods.Add(new NonImportedNonExemptedGood("bottle of perfume", 18.99, 1, basicSalesTax));
            input3Goods.Add(new NonImportedExemptedGood("packet of headache pills", 9.75, 1));
            input3Goods.Add(new ImportedExemptedGood("box of imported chocolates", 11.25, 1, importDutySalesTax));

            //Display output

            var receiptDetailAppender = serviceProvider.GetService<IReceiptConsoleAppender>();
            Console.WriteLine("Output");
            Console.WriteLine("Output 1:");
            receiptDetailAppender.WriteOutput(input1Goods);
            Console.WriteLine("Output 2:");
            receiptDetailAppender.WriteOutput(input2Goods);
            Console.WriteLine("Output 3:");
            receiptDetailAppender.WriteOutput(input3Goods);

            Console.ReadKey();
        }

        public static IServiceProvider RegisterProvider()
        {
            var services = new ServiceCollection();
            services.AddTaxCalCulatorDependencies();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
