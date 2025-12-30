using Tyuiu.PyrkinAA.Sprint1.Task1.V3.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task1.V3.Test
{
    [TestClass]
    public sealed class DstaServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res =ds.Calculate(x, y);
            Assert.AreEqual(2.75, res);
        }
    }
}
