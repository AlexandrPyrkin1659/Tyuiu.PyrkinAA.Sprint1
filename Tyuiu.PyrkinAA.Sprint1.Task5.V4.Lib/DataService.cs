using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PyrkinAA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            return (time / 60 / 60);
        }
    }
}
