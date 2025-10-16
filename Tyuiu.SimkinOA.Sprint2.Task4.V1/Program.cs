using Tyuiu.SimkinOA.Sprint2.Task4.V1.Lib;
namespace Tyuiu.SimkinOA.Sprint2.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение Х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Z = " + ds.Calculate(x, y));
        }
    }
}