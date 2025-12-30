using Tyuiu.PyrkinAA.Sprint1.Task7.V2.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;  
            double y = 0.5;
            double result = ds.Calculate(x, y);
            double expected = 2.345; 
            Assert.AreEqual(expected, result);
        }
    }
}
