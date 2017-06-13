using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTest;
//11
namespace Unittest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trys xx = new Trys();
            var xxx = xx.square(6);
            Console.WriteLine(xxx);
        }
    }
}
