

namespace DevTDD.Core.Services
{
    public class FibonacciServices
    {
        public static int GetFibonacci(int position)
        {
            if (position == 0) return 0;
            if (position == 1) return 1;

            return -1;
        }
    }
}
