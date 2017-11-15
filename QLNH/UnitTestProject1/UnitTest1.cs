using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QL_Nhà_Hàng;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Login dn;
        [TestInitialize]
        public void setup()
        {
            dn = new Login();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(dn.KTTenDangNhap("123"), true);
            
            
        }
    }
}
