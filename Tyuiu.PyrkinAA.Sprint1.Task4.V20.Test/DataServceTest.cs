using Tyuiu.PyrkinAA.Sprint1.Task4.V20.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
