using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackOffice;

namespace BackOffice.UnitTests
{
    [TestClass]
    public class BackOffice_UnitTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            var logic = new BackOfficeLogic();
            int result = logic.Add(3, 5);
            Assert.AreEqual(8, result, "Addition logic failed.");
        }

        [TestMethod]
        public void IsUserAdmin_ShouldReturnTrueForAdmin()
        {
            var logic = new BackOfficeLogic();
            bool isAdmin = logic.IsUserAdmin("admin");
            Assert.IsTrue(isAdmin, "Expected user to be admin.");
        }

        [TestMethod]
        public void IsUserAdmin_ShouldReturnFalseForNonAdmin()
        {
            var logic = new BackOfficeLogic();
            bool isAdmin = logic.IsUserAdmin("guest");
            Assert.IsFalse(isAdmin, "Expected user to NOT be admin.");
        }
    }
}
