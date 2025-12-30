using Tyuiu.PyrkinAA.Sprint1.Task2.V19.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            int x = 3937;
            var res = ds.ConvertInchToKm(x);
            double roundedRes = Math.Round(res, 3);
            Assert.AreEqual(100, roundedRes, 0.001);
        }
    }
}
