using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint4.Task5.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -6, -5, -4, -3, -2 },
                { -1,  0,  1,  2,  3 },
                {  3,  2,  1,  0, -1 },
                { -2, -3, -4, -5, -6 },
                {  0,  1, -1,  2, -2 }
            };

            int[,] wait = new int[5, 5]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 1, 2, 3 },
                { 3, 2, 1, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 1, 0, 2, 0 }
            };

            int[,] res = ds.GetMatrix(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}