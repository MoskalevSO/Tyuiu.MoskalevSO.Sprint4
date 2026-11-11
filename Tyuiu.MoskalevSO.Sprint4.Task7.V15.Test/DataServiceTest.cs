using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string str = "10293847";

            int wait = 4;
            int res = ds.Calculate(n, m, str);

            Assert.AreEqual(wait, res);
        }
    }
}
