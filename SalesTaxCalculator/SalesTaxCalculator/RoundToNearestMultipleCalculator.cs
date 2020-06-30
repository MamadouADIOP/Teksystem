using SalesTaxCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace SalesTaxCalculator
{
    public class RoundToNearestMultipleCalculator : IRoundToNearestMultiple
    {
        #region Private readonly field
        private readonly double _roundPrecision; 
        #endregion

        public RoundToNearestMultipleCalculator(double roundPrecision)
        {
            this._roundPrecision = roundPrecision;
        }

        #region Public Methods
        /// <summary>
        /// Returns the rounding of the input to the nearest up roundPrecision precision
        /// </summary>
        /// <param name="inputToRound">The input parameter to round.</param>
        /// <returns></returns>
        public double RoundUp(double inputToRound)
        {
            double divVal = (1 / (_roundPrecision == 0 ? 1 : _roundPrecision));
            var roundedValue = (double)(Math.Round(inputToRound * divVal)) / divVal;
            if (inputToRound > roundedValue)
            {
                return roundedValue + _roundPrecision;
            }
            return roundedValue;
        } 
        #endregion
    }
}
