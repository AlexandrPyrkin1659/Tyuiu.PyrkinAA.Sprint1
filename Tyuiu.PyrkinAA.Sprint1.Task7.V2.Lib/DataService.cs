using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PyrkinAA.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sin(x) + Math.Cos(y);
            double denominator = Math.Cos(x) - Math.Sin(y);

            if (Math.Abs(denominator) < 1e-10) // Проверка деления на ~0
                throw new ArgumentException("Знаменатель близок к нулю (cos x - sin y ≈ 0)");

            double tanXY = Math.Tan(x * y);
            double result = (numerator / denominator) * tanXY;

            return Math.Round(result, 3);
        }
    }
}
