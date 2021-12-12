using NLog;
using NUnit.Framework;

using System.Numerics;

using Factorial;

namespace TestFactorial
{
    public class Tests
    {
        //Logging
        readonly Logger log = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFactorialZero()
        {
            log.Info("TestFactorialZero");
            BigInteger calculateFactorial = Utils.CalculateFactorial(BigInteger.Zero, 0);
            Assert.Pass("Check if factorial of 0 is 1", (calculateFactorial.ToString().Equals("1")));
        }

		[Test]
		public void TestFactorialNegative()
		{
			log.Info("TestFactorialNegative");
			BigInteger calculateFactorial = Utils.CalculateFactorial(BigInteger.Parse("-1"), 0);
			Assert.Pass("Check if factorial of a negative integer is null", calculateFactorial == -1);
		}

		[Test]
		public void TestFactorial5()
		{
			log.Info("TestFactorial5");
			BigInteger calculateFactorial = Utils.CalculateFactorial(BigInteger.Parse("5"), 0);
			log.Info("\t" + calculateFactorial.ToString());
			Assert.Pass("Check if factorial of 5 is 120", calculateFactorial.ToString().Equals("120"));
		}

		[Test]
		public void TestFactorialBig()
		{
			log.Info("TestFactorial5");
			BigInteger calculateFactorial = Utils.CalculateFactorial(BigInteger.Parse("999999999"), 0);
			log.Info("\tIs null: " + (calculateFactorial == -1));
			Assert.Pass("Check if factorial of a big number is null", calculateFactorial == -1);
		}
	}
}