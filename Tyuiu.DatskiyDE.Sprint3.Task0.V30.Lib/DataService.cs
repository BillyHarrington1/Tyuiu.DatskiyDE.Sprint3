using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double productSeries = 1.0;           
            double sin1 = Math.Sin(1.0); 
            double denominator = Math.Pow(sin1, -10);

            for (int i = startValue; i <= stopValue; i++)
            {
                productSeries *= i / denominator; 
            }

            return Math.Round(productSeries, 3);
        }
    }
}

