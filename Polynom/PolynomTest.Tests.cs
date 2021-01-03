using NUnit.Framework;

namespace Polynom
{
    [TestFixture]
    class PolynomTest
    {
        [TestCase(1, 2, 2, 1, 2, 2, 4, 4)]
        [TestCase(1, 3, 2, 1, 2, 4, 5, 6)]
        public void Polynom_With_One_Degree_Addition(int degree1, int arg11, int arg12, int degree2, int arg21, int arg22, int res1, int res2)
        {
            int[] matrix1 = { arg11, arg12 };
            int[] matrix2 = { arg21, arg22 };
            int[] result = { res1, res2 };
            Polynom A = new Polynom(matrix1, degree1);
            Polynom B = new Polynom(matrix2, degree2);
            Polynom expectedRes = new Polynom(result, degree2);
            Polynom C = A + B;
            Assert.AreEqual(C, expectedRes);
        }

        [TestCase(1, 6, 7, 1, 2, 2, 4, 5)]
        [TestCase(1, 3, 1, 1, 2, 1, 1, 0)]
        public void Polynom_With_One_Degree_Subtraction(int degree1, int arg11, int arg12, int degree2, int arg21, int arg22, int res1, int res2)
        {
            int[] matrix1 = { arg11, arg12 };
            int[] matrix2 = { arg21, arg22 };
            int[] result = { res1, res2 };
            Polynom A = new Polynom(matrix1, degree1);
            Polynom B = new Polynom(matrix2, degree2);
            Polynom expectedRes = new Polynom(result, degree2);
            Polynom C = A - B;
            Assert.AreEqual(C, expectedRes);
        }
    }
}
