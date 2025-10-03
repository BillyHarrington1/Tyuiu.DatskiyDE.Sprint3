using Tyuiu.DatskiyDE.Sprint3.Task0.V30.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
        
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 1.188;

            Assert.AreEqual(wait, res);
        }
    }
}
