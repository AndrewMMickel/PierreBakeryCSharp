using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BreadPastry.Models;

namespace BreadPastry.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInsanceOfBreadClass_Bread()
        {
            Bread newBread = new Bread(50);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void TotalBreadPrice_ReturnBreadPrice_Int()
        {
            Bread newBread = new Bread(9);
            Assert.AreEqual(30, newBread.TotalBreadPrice());
        }
    }
}
