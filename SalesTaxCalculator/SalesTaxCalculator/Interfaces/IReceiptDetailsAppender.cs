using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator.Interfaces
{
    /// <summary>
    /// This interface exposes the method that the implemented appender should implement in order to display the receipt detail to the user. 
    /// This appender will us help log to console to a file to a database etc...
    /// </summary>
    public interface IReceiptDetailsAppender
    {
        /// <summary>
        /// Write the output associated to the good sales details in a given output type wrapped by the implemented appender
        /// </summary>
        /// <param name="goods">The list of goods to write the receipt to the defined output type.</param>
        void WriteOutput(IList<Good> goods);
    }
}
