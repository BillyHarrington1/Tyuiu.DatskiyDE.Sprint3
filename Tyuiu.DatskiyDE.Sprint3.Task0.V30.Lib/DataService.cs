using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {

        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double productSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                productSeries = (startValue / Math.Sin(Math.Pow(1, -10)));
            }
            return Math.Round(productSeries, 3);
        }
    }
}
    
