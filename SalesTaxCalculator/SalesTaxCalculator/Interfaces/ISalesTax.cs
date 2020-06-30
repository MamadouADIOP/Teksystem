using System;
using System.Collections.Generic;
using System.Text;
namespace SalesTaxCalculator.Interfaces
{
    public interface ISalesTax
    {
        #region Properties
        /// <summary>
        /// The rate of the sales tax
        /// </summary>
        double Rate
        {
            get;
        }
        #endregion

        #region Method
        /// <summary>
        /// Applies the tax to the given unit price
        /// </summary>
        /// <param name="unitPrice">the unit price to which the tax should be applied</param>
        /// <returns></returns>
        double ApplyTax(double unitPrice); 
        #endregion
    }
}
