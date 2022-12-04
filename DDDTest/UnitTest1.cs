using DDD.WinForm.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary></summary>
namespace DDDTest
{
/// <summary></summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary> 必ず１回目は故意にエラーを出す </summary>
        [TestMethod]
        public void TestMethod1()
        {
           var val = Class1.Add(1, 2);
            Assert.AreEqual(3, val);

        }
    }
}