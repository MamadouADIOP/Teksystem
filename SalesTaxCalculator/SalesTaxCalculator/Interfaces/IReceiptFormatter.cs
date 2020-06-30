using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator.Interfaces
{
    public interface IReceiptFormatter
    {
        /// <summary>
        /// organize the goods details following a certain format as implemented while realising the interface
        /// </summary>
        /// <param name="goods">The list of goods to build a report following a certain format.</param>
        /// <returns></returns>
        string Format(IList<Good> goods);
    }
}
