using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator
{
    public class ReceiptConsoleAppender : IReceiptConsoleAppender
    {
        #region Private readonly field
        private readonly IReceiptFormatter _formatter;
        #endregion
        #region Constructors

        public ReceiptConsoleAppender(IReceiptFormatter formatter)
        {
            this._formatter = formatter;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="goods"></param>
        public void WriteOutput(IList<Good> goods)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine(_formatter.Format(goods));
        } 
        #endregion
    }
}
