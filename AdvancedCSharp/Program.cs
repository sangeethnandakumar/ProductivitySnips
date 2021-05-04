using System;

namespace AdvancedCSharp
{
    public class Program
    {
        public delegate double AreaFunctionPointer(int rad);

        private static void Main(string[] args)
        {
            //Using delegates
            var area = CallViaDelegate(CalculateArea, 20);
            var areafun = CallViaFuncDelegate(CalculateArea, 20);
        }

        private static double CallViaDelegate(AreaFunctionPointer function, int rad)
        {
            return function.Invoke(rad);
        }

        private static double CallViaFuncDelegate(Func<int, double> function, int rad)
        {
            return function.Invoke(rad);
        }

        private static double CalculateArea(int rad)
        {
            return 3.14 * rad * rad;
        }
    }
}