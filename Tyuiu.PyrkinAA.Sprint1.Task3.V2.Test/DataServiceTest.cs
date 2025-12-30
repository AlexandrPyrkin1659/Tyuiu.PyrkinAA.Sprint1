using Tyuiu.PyrkinAA.Sprint1.Task3.V2.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double priceNotebook = 12.5;
            int amountNotebook = 2;
            double pricePencil = 1.75;
            int amountPencil = 5;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(33.75, res);
        }
    }
}
