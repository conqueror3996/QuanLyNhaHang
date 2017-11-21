using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QL_Nhà_Hàng;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {       
        class_khachhang kh = new class_khachhang();
        private Login dn;
        [TestInitialize]
        public void setup()
        {
            dn = new Login();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(dn.ktdangnhap("admin","123456"), true);
        }
        public void TestMethod2()
        {
            Assert.AreEqual(dn.ktdangnhap("gtdrgte", "1te"), false);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(kh.kiemtra("", "", "", "", ""), true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "uriew", "ertet", "eretret", "rtr"), false);
        }
    }
}
