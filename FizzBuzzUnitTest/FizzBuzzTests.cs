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
            var engine = new FizzBuzzCalc();

            string result = FizzBuzzCalc.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Test2()
        {
            var engine = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(3);

            Assert.That(output, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Test3()
        {
            var engine = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(5);

            Assert.That(output, Is.EqualTo("Buzz"));
        }
        [Test]
        public void Test4()
        {
            var engine = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(15);

            Assert.That(output, Is.EqualTo("FizzBuzz"));
        }
    }
}
