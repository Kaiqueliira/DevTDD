

namespace DevTDD.Core.Services
{
    public class FibonacciServices
    {
        public static int GetFibonacci(int position)
        {
            if (position == 0) return 0;
            if (position == 1) return 1;

            int previous = 0, current = 1;

            for (int i = 2; i <= position; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }
    }
}
