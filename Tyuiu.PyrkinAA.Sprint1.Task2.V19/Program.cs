using Tyuiu.PyrkinAA.Sprint1.Task2.V19.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите растояние в дюймах X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Растояние в метрах X = " + ds.ConvertInchToKm(x));
            Console.ReadLine();
        }
    }
}