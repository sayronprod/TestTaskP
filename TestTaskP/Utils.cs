using System.Runtime.CompilerServices;

namespace TestTaskP
{
    public static class Utils
    {
        public static double? ToNumber(this string str)
        {
            double? result = null;
            double number = 0;
            if (double.TryParse(str, out number))
            {
                result = number;
            }
            return result;
        }
    }
}
