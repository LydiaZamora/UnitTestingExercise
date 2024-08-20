using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData (3, 4, 8, 15)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {

            Calculator addMethod = new Calculator();           

            var actual = addMethod.AddThree(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(9, 3, 6)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            var subtractMin = new Calculator();

            var actual = subtractMin.SubtractMin(minuend, subtrahend);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(3, 3, 9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var multiplyTwo = new Calculator();

            var actual = multiplyTwo.MultiplyTwo(num1, num2);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(10, 2, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var divideTwo = new Calculator();

            var actual = divideTwo.DivideTwo(num1, num2);

            Assert.Equal(expected, actual);
        }

    }
}
