using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class TextReceiptFormatter : ITextReceiptFormatter
    {
        #region Private fields
        private ITaxAggregator _taxAggregator;
        #endregion
        #region Constructors

        public TextReceiptFormatter(ITaxAggregator taxAggregator)
        {
            this._taxAggregator = taxAggregator;
        }
        #endregion
        #region Public Methods
        public string Format(IList<Good> goods)
        {

            StringBuilder builder = new StringBuilder();
            char bullet = (char)248;

            foreach (var good in goods)
            {

                builder.AppendFormat($"   {bullet} ")
                .Append($"{good.Quantity} {good.Name}: {good.GetTotalPrice():0.00}")
                .AppendLine();
            }

            builder.AppendFormat($"   {bullet} Sales Taxes: {_taxAggregator.AggregateSalesTaxes(goods):0.00}")
                .AppendFormat($" Total: {_taxAggregator.AggregateToTalPriceAfterSalesTaxes(goods):0.00}")
                .AppendLine();
            return builder.ToString();
        }
        #endregion
    }
}
