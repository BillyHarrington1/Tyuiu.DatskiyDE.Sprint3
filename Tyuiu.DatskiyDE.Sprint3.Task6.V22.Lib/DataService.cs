using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DatskiyDE.Sprint3.Task6.V22.Lib
{
    public class DataService : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int divisorCount = 0;
                for (int d = 1; d <= n; d++)
                {
                    if (n % d == 0)
                        divisorCount++;
                }
                totalSum += divisorCount;
            }

            return totalSum;
        }
    }
}