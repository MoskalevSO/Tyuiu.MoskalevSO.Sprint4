using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task3.V15.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 7, 4, 2, 5, 3 },
                { 4, 3, 2, 5, 6 },
                { 6, 3, 4, 7, 5 },
                { 5, 7, 4, 3, 8 },
                { 7, 8, 8, 5, 6 }
            };
            int res = ds.Calculate(matrix);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}