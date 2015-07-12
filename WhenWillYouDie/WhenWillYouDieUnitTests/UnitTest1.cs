using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhenWillYouDie;

namespace WhenWillYouDieUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            int result = DieYearCalculator.CalculateDyingYear("");
            Assert.AreEqual(0, result);
        }
    }
}
