using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public  class NonImportedNonExemptedGood:TaxableGood
    {
        #region Properties

        #endregion
        #region Constructors

        public NonImportedNonExemptedGood(string name, double unitPrice, int quantity, IBasicSalesTax basicSalesTax) : base(name, unitPrice, quantity, basicSalesTax)
        {

        } 
        #endregion

    }
}
