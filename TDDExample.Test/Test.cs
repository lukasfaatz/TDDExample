using NUnit.Framework;
using System;
using static TDDExample.StringCalculator;



namespace TDDExample.Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void EmptyStringReturnsZero()
        {
            var stringCalculator = new StringCalculator();


            Assert.AreEqual(0, stringCalculator.Calculate(""));
        }

        [Test()]
        public void SingleNumberReturnsValue()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(1, stringCalculator.Calculate("1"));
        }

        [Test()]
        public void TwoNumbersAndCommaDelimited()
        {

            var stringCalculator = new StringCalculator();

            Assert.AreEqual(4, stringCalculator.Calculate("1,3"));
        }

        [Test]
        public void TwoNumbersNewLineDelimited()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(3, stringCalculator.Calculate("1\n2"));
        }

        [Test]
        public void ThreeNumbersDelimited()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(6, stringCalculator.Calculate("1\n2,3"));
        }

        [Test]
        public void NegativeNumbersThrowException()
        {
            var stringCalculator = new StringCalculator();

            Assert.Throws<NegativeNumbersException>(() => stringCalculator.Calculate("-12"));

        }

        [Test]
        public void NumbersGreaterThan1000()
        {
            var stringCalculator = new StringCalculator();

            Assert.Throws<NumberGreaterThanThousandException>(() => stringCalculator.Calculate("1001"));
        }


        [Test()]
        public void OnehundredAddedThirtyIsOnehundredthirty()
        {

            var stringCalculator = new StringCalculator();

            Assert.AreEqual(130, stringCalculator.Calculate("100,30"));
        }

        [Test()]
        public void NumbersMixedWithStrings()
        {

            var stringCalculator = new StringCalculator();

            Assert.AreEqual(2, stringCalculator.Calculate("abc,2"));
        }

        [Test()]
        public void SumOfTenNumbersWithDotAsDelimiter()
        {

            var stringCalculator = new StringCalculator();

            Assert.AreEqual(55, stringCalculator.Calculate("1,2.3.4.5.6.7.8.9.10"));
        }

    }
}
