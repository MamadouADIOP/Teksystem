using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public abstract class Good
    {
        #region public properties
        public int Quantity { get; }
        public string Name { get; }
        public double UnitPrice { get; }
        #endregion
        #region readonly variables
        #endregion
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">the name of the good</param>
        /// <param name="unitPrice"> the unit price of the good</param>
        /// <param name="quantity">The number of items of the given good</param>
        public Good(
            string name, double unitPrice, int quantity)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }
        #endregion
        #region Public Methods

        /// <summary>
        /// Get the total price of all good of this type
        /// </summary>
        /// <returns></returns>
        public abstract double GetTotalPrice(); 
        #endregion
    }
}
