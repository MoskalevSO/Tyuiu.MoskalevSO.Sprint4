using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task4.V13.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 6, 3, 5, 7, 5 },
                { 3, 5, 7, 4, 5 },
                { 5, 6, 4, 5, 4 },
                { 7, 4, 7, 3, 3 },
                { 4, 6, 5, 5, 6 }
            };
            int res = ds.Calculate(matrix);
            int wait = 44;

            Assert.AreEqual(wait, res);
        }
    }
}