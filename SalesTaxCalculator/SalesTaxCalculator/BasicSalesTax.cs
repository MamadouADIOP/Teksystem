using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SalesTaxCalculator
{
    public class BasicSalesTax : SalesTaxApplier, IBasicSalesTax
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rate">the rate associated with the sales tax</param>
        public BasicSalesTax(double rate, IRoundToNearestMultiple roundToNearestMultiple) : base(rate, roundToNearestMultiple)
        {

        } 
        #endregion

    }
}
