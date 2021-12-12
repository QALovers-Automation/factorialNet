using NLog;

using System.Numerics;

using Factorial;

namespace FactorialNet
{
    class Program
    {
        //Logging
        static readonly Logger log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            BigInteger numberToGenerateFactorial;
            BigInteger factorial;

            if (args.Length != 1)
            {
                log.Error("We need only one argument to generate the factorial. Example: 6");
                return;
            }

            try
            {
                numberToGenerateFactorial = BigInteger.Parse(args[0]);
            }
            catch
            {
                log.Error("We need an integer equal to 0 or greater to generate the factorial.");
                return;
            }

            if (numberToGenerateFactorial.Sign < 0)
            {
                log.Error("We need a positive integer to generate the factorial.");
                return;
            }

            factorial = Utils.CalculateFactorial(numberToGenerateFactorial, 0);

            if (factorial != -1)
                log.Info("The factorial of " + numberToGenerateFactorial + " is: " + factorial.ToString());
            else
                log.Info("Num too big " + numberToGenerateFactorial + " is: " + factorial.ToString());
        }
    }
}
