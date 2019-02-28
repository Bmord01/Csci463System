using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csci463System.Models;
namespace Csci463SystemTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestCreator()
        {
            User newUser =new User();
            Assert.AreNotEqual(newUser, null);
        }
    }
}
