using NUnit.Framework;

namespace NullValue
{
    [TestFixture]
    class NullValue
    {
        [TestCase("Mail", false)]
        [TestCase("", true)]
        public void Check_Nullable_Values_For_Strings(string str, bool expectedValue)
        {
            Assert.AreEqual(str.IsNull(), expectedValue);
        }

        [TestCase(171, false)]
        [TestCase(null, true)]
        public void Check_Nullable_Values_For_Numbers(int? number, bool expectedValue)
        {
            Assert.AreEqual(number.IsNull(), expectedValue);
        }
    }
}
