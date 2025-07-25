using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp;

namespace WebApp.UnitTests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void GetGreeting_ShouldReturnCorrectMessage()
        {
            var service = new UserService();
            string result = service.GetGreeting("Oscar");
            Assert.AreEqual("Hello, Oscar!", result);
        }
    }
}
