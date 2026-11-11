using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task5.V28.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { -1,  2, -3,  0,  1 },
                {  3, -6,  2, -2,  0 },
                { -4,  1, -5,  3, -1 },
                {  0,  0, -2,  2,  1 },
                { -3,  3,  1, -1, -6 }
            };

            int[,] wait = {
                { 0, 2, 0, 0, 1 },
                { 3, 0, 2, 0, 0 },
                { 0, 1, 0, 3, 0 },
                { 0, 0, 0, 2, 1 },
                { 0, 3, 1, 0, 0 }
            };

            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}