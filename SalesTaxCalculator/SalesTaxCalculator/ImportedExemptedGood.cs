using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class ImportedExemptedGood : TaxableGood
    {

        #region Constructors
        public ImportedExemptedGood(string name, double unitPrice, int quantity, IImportDutySalesTax importDutySalesTax) : base(name, unitPrice, quantity, importDutySalesTax)
        {

        } 
        #endregion

    }
}
