

namespace DevTDD.Core.Services
{
    public class FibonacciServices
    {
        public static int GetFibonacci(int position)
        {
            if (position < 2) return position;

            int previous = 0, current = 1;

            for (int i = 2; i <= position; i++)
            {
                (previous, current) = (current, previous + current);
            }

            return current;
        }
    }
}
