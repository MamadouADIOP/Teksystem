using SalesTaxCalculator.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SalesTaxCalculator
{
    public class TaxAggregator : ITaxAggregator
    {
        #region Constructors
        /// <summary>
        /// Aggregate the sales taxes by summing them
        /// </summary>
        /// <param name="goods">The goods for which the sales taxes should be added</param>
        /// <returns>the aggregated sales taxes</returns>
        public double AggregateSalesTaxes(IList<Good> goods)
        {
            var taxableGoods = goods.Where(g => g is TaxableGood).OfType<TaxableGood>();
            return taxableGoods.Sum(g => g.TotalAppliedSalesTax);
        }
        #endregion

        #region Public Methods
        /// <summary>
        ///  Aggregate the total price by summing the total price considered for the good quantity
        /// </summary>
        /// <param name="goods">The goods for which the sales taxes should be added</param>
        /// <returns>The aggregated total price after application of the sales tax.</returns>
        public double AggregateToTalPriceAfterSalesTaxes(IList<Good> goods)
        {
            return goods.Sum(g => g.GetTotalPrice());

        } 
        #endregion
    }
}
