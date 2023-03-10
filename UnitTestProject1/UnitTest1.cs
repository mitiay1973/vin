using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
        [TestMethod]
        public void Proverka_vin_JHMCM56557C404453()
        {
            Assert.AreEqual(class1.CheckVIN("JHMCM56557C404453"), true);
        }
        [TestMethod]
        public void Proverka_vin_IHMCM56557C404453()
        {
            Assert.AreEqual(class1.CheckVIN("IHMCM56557C404453"), false);
        }
        [TestMethod]
        public void Proverka_vin_XTA210990Y2766389()
        {
            Assert.AreEqual(class1.CheckVIN("XTA210990Y2766389"), true);
        }
        [TestMethod]
        public void Proverka_vin_XOA210990Y27663898()
        {
            Assert.AreEqual(class1.CheckVIN("XOA210990Y27663898"), false);
        }
        [TestMethod]
        public void Proverka_vin_Z8NAJL00050366148()
        {
            Assert.AreEqual(class1.CheckVIN("Z8NAJL00050366148"), true);
        }
        [TestMethod]
        public void Proverka_vin_Z8NQJL00050366()
        {
            Assert.AreEqual(class1.CheckVIN("Z8NAJL00050366"), false);
        }
        [TestMethod]
        public void Proverka_vin_()
        {
            Assert.AreEqual(class1.CheckVIN(""), false);
        }
        [TestMethod]
        public void Proverka_vin_123()
        {
            Assert.AreEqual(class1.CheckVIN("123"), false);
        }
        [TestMethod]
        public void Country_JHMCM56557C404453()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM56557C404453"), "Северная Америка");
        }
        [TestMethod]
        public void Country_XTA210990Y2766389()
        {
            Assert.AreEqual(class1.GetVINCountry("XTA210990Y2766389"), "Океания");
        }
        [TestMethod]
        public void Country_Z8NAJL00050A66148()
        {
            Assert.AreEqual(class1.GetVINCountry("Z8NAJL00050A66148"), "Африка");
        }
        [TestMethod]
        public void Country_Z8NAJL00050J66152()
        {
            Assert.AreEqual(class1.GetVINCountry("Z8NAJL00050J66152"), "Азия");
        }
        [TestMethod]
        public void Country_JHMCM56557CY04453()
        {
            Assert.AreEqual(class1.GetVINCountry("JHMCM56557CY04453"), "Европа");
        }
        [TestMethod]
        public void Country_()
        {
            Assert.AreEqual(class1.GetVINCountry(""), "");
        }
        [TestMethod]
        public void Country_0000000()
        {
            Assert.AreEqual(class1.GetVINCountry("0000000"), "");
        }
    }
}
