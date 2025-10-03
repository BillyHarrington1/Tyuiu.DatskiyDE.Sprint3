using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {

            double n = 0.75;
            double productSeries = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow(1.0 / Math.Pow(n, k), 3);
                productSeries *= term;
            }

            return Math.Round(productSeries, 3);
        }
    }
}