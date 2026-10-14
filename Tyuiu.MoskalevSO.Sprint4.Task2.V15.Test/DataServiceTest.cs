using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task2.V15.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 24;

            Assert.AreEqual(wait, res);
        }
    }
}