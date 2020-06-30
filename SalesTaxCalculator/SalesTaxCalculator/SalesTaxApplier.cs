using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class SalesTaxApplier : ISalesTax
    {
        #region Public properties
        public double Rate { get; }
        #endregion
        #region Protected fields
        protected IRoundToNearestMultiple _roundToNearestMultiple { get; }
        #endregion
        #region Constructors

        public SalesTaxApplier(double rate, IRoundToNearestMultiple roundToNearestMultiple)
        {
            Rate = rate;
            _roundToNearestMultiple = roundToNearestMultiple;

        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Apply the tax to the unitPrice passed in argument and return the result
        /// </summary>
        /// <param name="unitPrice">the unit price of the good for which the tax is being calculated</param>
        /// <returns>The sales tax associated with the unitPrice given as argument.</returns>
        public double ApplyTax(double unitPrice)
        {
            return _roundToNearestMultiple.RoundUp(unitPrice * Rate / 100);
        } 
        #endregion
    }
}
