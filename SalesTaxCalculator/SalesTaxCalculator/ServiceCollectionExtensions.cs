using Microsoft.Extensions.DependencyInjection;
using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SalesTaxCalculator
{
    public static class ServiceCollectionExtensions
    {
        #region Public static Methods
        public static IServiceCollection AddTaxCalCulatorDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IRoundToNearestMultiple>(s => new RoundToNearestMultipleCalculator(0.05));
            services.AddSingleton<IBasicSalesTax>(s => new BasicSalesTax(10, s.GetRequiredService<IRoundToNearestMultiple>()));
            services.AddSingleton<IImportDutySalesTax>(s => new ImportDutySalesTax(5, s.GetRequiredService<IRoundToNearestMultiple>()));
            services.AddTransient<IReceiptConsoleAppender, ReceiptConsoleAppender>();
            services.AddTransient<IReceiptFormatter, TextReceiptFormatter>();
            services.AddTransient<ITaxAggregator, TaxAggregator>();
            return services;
        } 
        #endregion
    }
}
