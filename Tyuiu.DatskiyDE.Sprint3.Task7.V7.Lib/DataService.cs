using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0;

                if (x + 2 == 0) 
                {
                    fx = 0;
                }
                else
                {
                    double cosX = Math.Cos(x);
                    fx = cosX + (cosX / (x + 2)) - 3 * x;
                }

                result[index] = Math.Round(fx, 2); 
                index++;
            }

            return result;
        }
    }
}
