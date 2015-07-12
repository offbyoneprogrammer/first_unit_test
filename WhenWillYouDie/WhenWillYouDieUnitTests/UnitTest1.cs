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

        [TestMethod]
        public void MartinStringTest()
        {
            int result = DieYearCalculator.CalculateDyingYear("Martin");
            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void OffByOneProgrammerStringTest()
        {
            int result = DieYearCalculator.CalculateDyingYear("OffByOneProgrammer");
            Assert.AreEqual(12, result);
        }
    }
}
