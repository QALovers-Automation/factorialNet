using System;
using System.Numerics;

namespace Factorial
{
    public class Utils
    {
        private const int MAX_RECURSIVE_CALLS = 3000;

        /// <summary>
        /// Calculate factorial of a number.
        /// StackOverflowException is not caugth by .Net: https://docs.microsoft.com/es-es/dotnet/api/system.stackoverflowexception?view=net-6.0#examples
        /// </summary>
        /// <param name="integerF"></param>
        /// <param name="numLlamadas"></param>
        /// <returns></returns>
        public static BigInteger CalculateFactorial(BigInteger integerF, int numLlamadas)
        {
            try
            {
                if (numLlamadas == MAX_RECURSIVE_CALLS)
                    throw new StackOverflowException("Máximo número de llamadas");

                if (integerF == BigInteger.Zero)
                    return BigInteger.One;

                if (integerF.Sign < 0)
                    return -1;

                BigInteger calc = CalculateFactorial(BigInteger.Subtract(integerF, BigInteger.One), ++numLlamadas);
                return integerF * calc;
            }
            catch
            {
                return -1;
            }
        }
    }
}
