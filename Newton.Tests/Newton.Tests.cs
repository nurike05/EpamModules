//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using Module_3._1;


namespace Newton.Tests
{

    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 5, 0.000001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        public void FindRoot_IsCorrect(double number, int degree, double precision, double expectedResult) =>
            Assert.AreEqual(NewtonSqrtN.FindRoot(number, degree, precision), expectedResult, precision);

        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.001, -2, 0.0001)]
        [TestCase(0.01, 2, -1)]
        public void FindRoot_Throws_ArgumentException(double number, int degree, double precision)
            => Assert.Throws<ArgumentException>(() => NewtonSqrtN.FindRoot(number, degree, precision));
    }
}
