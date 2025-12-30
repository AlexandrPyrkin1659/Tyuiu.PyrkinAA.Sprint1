using Tyuiu.PyrkinAA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.PyrkinAA.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int x;

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(dataService.SecondsToHours(x));
        }
    }
}
