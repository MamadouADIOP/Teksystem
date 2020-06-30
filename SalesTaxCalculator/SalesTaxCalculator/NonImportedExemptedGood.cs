using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class NonImportedExemptedGood : NonTaxableGood
    {
        #region Constructors

        public NonImportedExemptedGood(string name, double unitPrice, int quantity) : base(name, unitPrice, quantity)
        {

        }
        #endregion
        #region Public Methods

        public override double GetTotalPrice()
        {
            return Quantity * UnitPrice;
        } 
        #endregion
    }
}
