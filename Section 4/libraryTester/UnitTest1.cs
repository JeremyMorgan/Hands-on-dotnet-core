using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringModifier;

namespace libraryTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("returntype")]
        public void TestMUCReturnsString()
        {
            string sample = "Test String";
            Assert.IsInstanceOfType(ChangeMyString.makeAllUppercase(sample), typeof(string));
        }

        [TestMethod]
        [TestCategory("returntype")]
        public void TestMRReturnsString()
        {
           string sample = "Test String";
           Assert.IsInstanceOfType(ChangeMyString.makeReverse(sample), typeof(string));
        }

        [TestMethod]
        [TestCategory("functionality")]
        public void TestMakeAllUppercase()
        {
            string sample = "Test String";
            Assert.AreEqual("TEST STRING", ChangeMyString.makeAllUppercase(sample));
        }

        [TestMethod]
        [TestCategory("functionality")]
        public void TestMakeReverse()
        {
            string sample = "Test String";
            Assert.AreEqual("gnirtS tseT",ChangeMyString.makeReverse(sample));
        }
    }
}
