using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0.0;
            int k = startValue;

            do
            {
                double Fimoz = Math.Sin(k) + 2 * Math.Pow(value, k);
                double term = Math.Pow(1.0 / Fimoz, k);
                sum += term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}