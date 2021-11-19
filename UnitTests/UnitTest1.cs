using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var company = new Company();
            var testDomainClass = new TestDomainClass();
            company.Update(testDomainClass);
        }
    }
}