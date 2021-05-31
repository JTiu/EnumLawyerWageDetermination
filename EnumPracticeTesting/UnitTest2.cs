using enumPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EnumPracticeTesting
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestNewPerson()
        {
            int age = 10;


            Assert.AreEqual(age, 11);


        }
    }
}
