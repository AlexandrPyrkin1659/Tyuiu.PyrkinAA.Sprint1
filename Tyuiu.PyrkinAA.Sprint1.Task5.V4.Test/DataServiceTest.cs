using Tyuiu.PyrkinAA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();

            int x = 13257;
            int res = dataService.SecondsToHours(x);

            int result = Convert.ToInt32(res);

            int wait = 3;

            Assert.AreEqual(wait, result);
        }
    }
}
