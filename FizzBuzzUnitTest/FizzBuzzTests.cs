using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Test1()
        {
            var fizBuzz = new FizzBuzzCalc();


            string result = FizzBuzzCalc.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Test2()
        {
            var engine = new FizzBuzzCalc();

            const int input = 2;
            string output = FizzBuzzCalc.Get(input);

            Assert.That(output, Is.EqualTo("2"));
        }
    }
}
