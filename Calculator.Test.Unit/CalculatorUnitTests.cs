﻿using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        [TestCase(4, 0, 4)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(6, 2, 3)]
        [TestCase(-6, -2, 3)]
        [TestCase(-6, 2, -3)]
        public void Divide_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Divide_DivideWithZero_ExceptionThrown()
        {

            Assert.Throws<Exception>( () => _uut.Divide(3, 0));
        }

        //Test af accumulator
        [Test]
        public void Accumulator_Add_SetsLatestValue()
        {
            _uut.Add(2,3);
            Assert.AreEqual(_uut.Accumulator,5 );
        }

        [Test]
        public void Clear_ClearAccumulator_AccumulatorIsZero()
        {
            _uut.Clear();
            Assert.AreEqual(_uut.Accumulator, 0);
        }

    }
}
