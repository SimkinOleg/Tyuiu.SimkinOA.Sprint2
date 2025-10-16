using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SimkinOA.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 1 == y;
            res[1] = y - 1 != x;
            res[2] = x + 0 < y;
            res[3] = x - 9 > y;
            res[4] = x + 3 <= y;
            res[5] = x - 3 >= y;
            return res;
        }
    }
}

