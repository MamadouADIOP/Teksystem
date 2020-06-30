namespace SalesTaxCalculator.Interfaces
{
    public interface IRoundToNearestMultiple
    {
        #region Properties
        /// <summary>
        /// Round the given input to the upper bound of the number associated with the precision of the interface implementation.
        /// </summary>
        /// <param name="inputToRound">The input double to round to the nearest multiiple</param>
        /// <returns></returns>
        public double RoundUp(double inputToRound); 
        #endregion
    }
}