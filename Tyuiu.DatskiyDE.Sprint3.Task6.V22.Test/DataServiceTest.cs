using Tyuiu.DatskiyDE.Sprint3.Task6.V22.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 31;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 55;

            Assert.AreEqual(expected, result);
        }
    }
}