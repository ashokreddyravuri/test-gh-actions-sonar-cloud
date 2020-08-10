using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilitiesForTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExpectedToPass()
        {
            var flag = Helpers.ReturnTrue();
            Assert.AreEqual(true, flag);
        }

        [TestMethod]
        public void ExpectedToFail()
        {
            var flag = Helpers.ReturnTrue();
            Assert.AreEqual(false, flag);
        }
    }
}
