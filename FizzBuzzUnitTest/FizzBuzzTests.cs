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
            new FizzBuzzCalc();


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
        [Test]
        public void Test3()
        {
            var engine = new FizzBuzzCalc();

            const int input = 3;
            string output = FizzBuzzCalc.Get(input);

            Assert.That(output, Is.EqualTo("Fizz"));
        }
        public void Test4()
        {
            var engine = new FizzBuzzCalc();

            const int input = 5;
            string output = FizzBuzzCalc.Get(input);

            Assert.That(output, Is.EqualTo("Buzz"));
        }
        public void Test5()
        {
            var engine = new FizzBuzzCalc();

            const int input = 15;
            string output = FizzBuzzCalc.Get(input);

            Assert.That(output, Is.EqualTo("FizzBuzz"));
        }
    }
}
