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
        public void TestMethodLoginTrue()
        {
            Assert.AreEqual(dn.ktdangnhap("admin","123456"), true);
        }
        [TestMethod]
        public void TestMethodLoginFalse()
        {
            Assert.AreEqual(dn.ktdangnhap("gtdrgte", "1te"), false);
        }
        [TestMethod]
        public void TestMethodLoginWithoutUsername()
        {
            Assert.AreEqual(dn.ktdangnhap("", "123456"), false);
        }
        [TestMethod]
        public void TestMethodLoginWithoutPassword()
        {
            Assert.AreEqual(dn.ktdangnhap("admin", ""), false);
        }
        [TestMethod]
        public void TestMethodNhapRong()
        {
            Assert.AreEqual(kh.kiemtra("", "", "", "", ""), true);
        }
        [TestMethod]
        public void TestMethodNhapDayDu()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "uriew", "ertet", "eretret", "rtr"), false);
        }
        [TestMethod]
        public void TestMethodNhapThieuThongTin7()
        {
            Assert.AreEqual(kh.kiemtra("", "uriew", "ertet", "eretret", "rtr"), true);
        }
        [TestMethod]
        public void TestMethodNhapThieuThongTin8()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "", "ertet", "eretret", "rtr"), true);
        }
        [TestMethod]
        public void TestMethodNhapThieuThongTin9()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "qưeqwe", "", "eretret", "rtr"), true);
        }
        [TestMethod]
        public void TestMethodNhapThieuThongTin10()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "xvcxvx", "ertet", "", "rtr"), true);
        }
        [TestMethod]
        public void TestMethodNhapThieuThongTin11()
        {
            Assert.AreEqual(kh.kiemtra("blabla", "hfghgf", "ertet", "eretret", ""), true);
        }
    }
}
