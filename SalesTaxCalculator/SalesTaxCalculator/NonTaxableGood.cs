using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public abstract class NonTaxableGood : Good
    {
        #region Constructors
        public NonTaxableGood(string name, double unitPrice, int quantity) : base(name, unitPrice, quantity)
        {

        }
    } 
    #endregion
}
