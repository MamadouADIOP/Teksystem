using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class ImportDutySalesTax : SalesTaxApplier, IImportDutySalesTax
    {
        #region Constructors
        public ImportDutySalesTax(double rate, IRoundToNearestMultiple roundToNearestMultiple) : base(rate, roundToNearestMultiple)
        {

        } 
        #endregion

    }
}
