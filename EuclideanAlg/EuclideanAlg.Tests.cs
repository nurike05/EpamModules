using NUnit.Framework;

namespace EuclideanAlg
{
    [TestFixture]
    class EuclideanAlg
    {
        [TestCase(74, 4, ExpectedResult = 2)]
        [TestCase(171, 9, ExpectedResult = 9)]
        [TestCase(85, 15, ExpectedResult = 5)]
        [TestCase(271, 9, ExpectedResult = 1)]
        public int EuclideanMethod_TwoParam_GCD_WithoutTime(int first, int second)
        {
            return EuclideanGCD.EuclideanMethod(first, second);
        }

        [TestCase(74, 4, -4, ExpectedResult = 2)]
        [TestCase(40, 8, 16, ExpectedResult = 8)]
        [TestCase(85, 15, 10, ExpectedResult = 5)]
        [TestCase(27, 171, 18, ExpectedResult = 9)]
        public int EuclideanMethod_ThreeParam_GCD_WithoutTime(int first, int second, int third)
        {
            return EuclideanGCD.EuclideanMethod(first, second, third);
        }

        //[TestCase(74, 4, ExpectedResult = 2)]
        //[TestCase(171, 9, ExpectedResult = 9)]
        //[TestCase(85, 15, ExpectedResult = 5)]
        //[TestCase(271, 9, ExpectedResult = 1)]
        //public void SteinMethod_TwoParam_GCD_WithoutTime(int first, int second, int result)
        //{
        //    Assert.AreEqual(EuclideanGCD.SteinMethod(first, second), result);
        //}

        //[TestCase(74, 4, -4, ExpectedResult = 2)]
        //[TestCase(40, 8, 16, ExpectedResult = 8)]
        //[TestCase(85, 15, 10, ExpectedResult = 5)]
        //[TestCase(27, 171, 18, ExpectedResult = 9)]
        //public int SteinMethod_ThreeParam_GCD_WithoutTime(int first, int second, int third)
        //{
        //    return EuclideanGCD.SteinMethod(first, second, third);
        //}
    }
}
