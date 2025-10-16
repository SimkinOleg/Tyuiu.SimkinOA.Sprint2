using Tyuiu.SimkinOA.Sprint2.Task2.V5.Lib;
namespace Tyuiu.SimkinOA.Sprint2.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GeLogicOperations()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}