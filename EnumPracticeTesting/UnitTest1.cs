using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EnumPracticeTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNewWage()
        {
            //arrange
            int baseWage;
            baseWage = 50;
            int newBaseWage;
            newBaseWage = baseWage + 50;

            Assert.AreEqual(100, newBaseWage);
                
        }

        
    }
}
