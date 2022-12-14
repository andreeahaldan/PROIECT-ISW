namespace PharmacyStoreTests
{
    using System;
    using PharmacyStore;
    using PharmacyStore.AdministratorUC;


    [TestClass]
    public class PharmacyStoreTests 
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 5.5;
            double b = 6.5;
            double c = a + b;
            
            Assert.AreEqual(c,12,0.001, "Correctly calculated");
        }
    }
}