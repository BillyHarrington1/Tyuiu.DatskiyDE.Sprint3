using Tyuiu.DatskiyDE.Sprint3.Task1.V27.Lib;
namespace Tyuiu.DatskiyDE.Sprint3.Task1.V27.Test
{  
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void ValidGetSumSeries()
            {
                DataService ds = new DataService();

                double value = 0.75;
                int startValue = 1;
                int stopValue = 5;

                double res = ds.GetMultiplySeries(value, startValue, stopValue);
                double wait = 419028.1;

                Assert.AreEqual(wait, res);
            }
        }
    }
