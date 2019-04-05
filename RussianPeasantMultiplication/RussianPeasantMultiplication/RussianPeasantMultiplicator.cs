using System.Collections.Generic;
using System.Linq;

namespace RussianPeasantMultiplication
{
    public static class RussianPeasantMultiplicator
    {
        public static int Mul(int left, int right)
        {
            int result = 0;
            Dictionary<int, int> leftRight = new Dictionary<int, int>()
            {
                { left, right }
            };

            do
            {
                left = left / 2;
                right = right * 2;

                leftRight.Add(left, right);
            } while (left != 1);

            foreach (var item in leftRight.Where(lr => lr.Key % 2 != 0))
            {
                result += item.Value;
            }

            return result;
        }
    }
}
