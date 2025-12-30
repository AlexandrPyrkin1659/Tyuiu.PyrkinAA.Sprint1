using Tyuiu.PyrkinAA.Sprint1.Task4.V20.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task4.V20.Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine(" Ввидите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(1 + x) / Math.Abs(x - Math.Sqrt(2 + y)) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
