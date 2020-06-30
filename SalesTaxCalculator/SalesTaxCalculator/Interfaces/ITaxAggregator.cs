using System.Collections.Generic;

namespace SalesTaxCalculator.Interfaces
{
    public interface ITaxAggregator
    {
        #region Methods
        /// <summary>
        /// Aggregate the sales taxes by summing them
        /// </summary>
        /// <param name="goods">The goods for which the sales taxes should be added</param>
        /// <returns>the aggregated sales taxes</returns>
        public double AggregateSalesTaxes(IList<Good> goods);

        /// <summary>
        ///  Aggregate the total price by summing the total price considered for the good quantity
        /// </summary>
        /// <param name="goods">The goods for which the sales taxes should be added</param>
        /// <returns>The aggregated total price after application of the sales tax.</returns>
        public double AggregateToTalPriceAfterSalesTaxes(IList<Good> goods); 
        #endregion
    }
}