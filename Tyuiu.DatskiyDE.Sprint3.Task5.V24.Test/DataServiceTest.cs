using Tyuiu.DatskiyDE.Sprint3.Task5.V24.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValueI = 1;
            int stopValueI = 3;
            int startValueK = 1;
            int stopValueK = 12;
            int x = 2;

            double res = ds.GetSumSumSeries(x, startValueI, stopValueI, startValueK, stopValueK);
            double wait = -4317.786; 

            Assert.AreEqual(wait, res);
        }
    }
}