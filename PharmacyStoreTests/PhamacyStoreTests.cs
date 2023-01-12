namespace PharmacyStoreTests
{
    using System;
    using System.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PharmacyStore;




    [TestClass]
    public class PharmacyStoreTests : InjectionChecker
    {
        [TestMethod]
        public void TestMethod1()
        {
            InjectionChecker test_injection = new InjectionChecker();
            String test_text = "Drop table users";
            bool test_result = test_injection.WordCheck(test_text);
            Assert.AreEqual(true, test_result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            InjectionChecker test_injection = new InjectionChecker();
            String test_text = "Select * from medicine";
            bool test_result = test_injection.WordCheck(test_text);
            Assert.AreEqual(false, test_result);


        }
        [TestMethod]
        public void TestMethod3()
        {
            InjectionChecker test_injection = new InjectionChecker();
            String test_text = "Alter table users";
            bool test_result = test_injection.WordCheck(test_text);
            Assert.AreEqual(true, test_result);

        }
        [TestMethod]
        public void TestMethod4()
        {
            InjectionChecker test_injection = new InjectionChecker();
            String test_text = "Delete * from medicine";
            bool test_result = test_injection.WordCheck(test_text);
            Assert.AreEqual(true, test_result);

        }

    }
}
