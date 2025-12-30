using Tyuiu.PyrkinAA.Sprint1.Task3.V2.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook = 12.5;
            int amountNotebook = 2;
            double pricePencil = 1.75;
            int amountPencil = 5;

            Console.WriteLine("Ценна тетради = " + priceNotebook);
            Console.WriteLine("Количество тетрадей = " + amountNotebook);
            Console.WriteLine("Цена карандаша = " + pricePencil);
            Console.WriteLine("Количество карандашей = " + amountPencil);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Цена покупок = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            Console.ReadKey();
        }
    }
}

