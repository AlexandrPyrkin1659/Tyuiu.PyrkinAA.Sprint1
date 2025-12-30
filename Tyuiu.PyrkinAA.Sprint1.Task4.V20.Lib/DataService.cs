using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PyrkinAA.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            double res = 1 + x / (x - Math.Sqrt(2 + y));
            return Math.Round(res, 3);
        }   
    }
}
