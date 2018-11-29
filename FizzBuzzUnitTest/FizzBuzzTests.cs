using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void StringTest()
        {
            var fizzBuzzCalc = new FizzBuzzCalc();

            string result = FizzBuzzCalc.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void FizzTest()
        {
            var fizzBuzzCalc = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(3);

            Assert.That(output, Is.EqualTo("Fizz"));
        }
        [Test]
        public void BuzzTest()
        {
            var fizzBuzzCalc = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(5);

            Assert.That(output, Is.EqualTo("Buzz"));
        }
        [Test]
        public void FizzBuzzTest()
        {
            var fizzBuzzCalc = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(15);

            Assert.That(output, Is.EqualTo("FizzBuzz"));
        }
        /*
        [Test]
        public void negativeNumberTest()
        {
            var FizzBuzzCalc = new FizzBuzzCalc();

            string output = FizzBuzzCalc.Get(-15);

            Assert.That(output, Is.EqualTo("error"));
        }
        */
    }
}
