using System.Reflection.Metadata;
using Tyuiu.PyrkinAA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Hello world";
            bool result = ds.CheckHello(value);
            Assert.IsTrue(result);
        }
    }
}
