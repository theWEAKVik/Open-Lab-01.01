using NUnit.Framework;

namespace Open_Lab_01._01
{
    [TestFixture]
    public class Tests
    {
        private Exercise exercise;

        [SetUp]
        public void SetUp()
        {
            exercise = new Exercise();
        }

        [Test]
        public void ExpectedFalse([Range(10, 100)] int input) =>
            Assert.That(exercise.IsLessThan10(input.ToString()), Is.False,
                $"It is expected that result is false for number {input}.");

        [Test]
        public void ExpectedTrue([Range(-100, 9)] int input) =>
            Assert.That(exercise.IsLessThan10(input.ToString()), Is.True,
                $"It is expected that result is true for number {input}.");
    }
}