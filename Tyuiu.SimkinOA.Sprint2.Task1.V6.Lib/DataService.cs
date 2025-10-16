using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SimkinOA.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];



            res[0] = (a == b) | (c < b);
            res[1] = (a == c) & (b > c);
            res[2] = (a != d) || (c > b);
            res[3] = (a != b) && (d > c);
            res[4] = !(a == c);
            res[5] = (b == c) ^ (a == b);

            return res;
        }

    }
}
