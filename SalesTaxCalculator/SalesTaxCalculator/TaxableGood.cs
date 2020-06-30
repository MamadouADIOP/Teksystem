using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class TaxableGood : Good
    {

        #region Public Properties
        public ISalesTax[] SalesTaxes { get; }
        public double TotalAppliedSalesTax { get; }
        public double UnitAppliedSalesTax { get; }
        public double UnitPriceAfterTaxApplication { get; }

        public double AppliedSalesTax { get; }
        #endregion

        #region Constructors
        public TaxableGood(
    string name, double unitPrice, int quantity, params ISalesTax[] salesTaxes) : base(name, unitPrice, quantity)
        {
            this.SalesTaxes = salesTaxes;
            AppliedSalesTax = AppySalesTaxes();
            TotalAppliedSalesTax = Quantity * AppliedSalesTax;
            UnitPriceAfterTaxApplication = AppliedSalesTax + UnitPrice;

        }
        #endregion


        #region Public override Methods

        public override double GetTotalPrice()
        {
            return Quantity * UnitPriceAfterTaxApplication;
        }

        #endregion
        #region Protected Virtual Methods
        protected virtual double AppySalesTaxes()
        {
            double salesTaxes = 0.00;
            foreach (var salesTax in SalesTaxes)
            {
                salesTaxes += salesTax.ApplyTax(UnitPrice);

            }

            return salesTaxes;
        } 
        #endregion
    }
}
