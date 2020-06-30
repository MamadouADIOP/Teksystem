using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SalesTaxCalculator
{
    public class ImportedNonExemptedGood : TaxableGood
    {

        #region Constructors
        public ImportedNonExemptedGood(string name, double unitPrice, int quantity, IImportDutySalesTax importDutySalesTax, IBasicSalesTax basicSalesTax) : base(name, unitPrice, quantity, basicSalesTax, importDutySalesTax)
        {

        } 
        #endregion
    }
}
