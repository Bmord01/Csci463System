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
        [TestMethod]
        public void TestPermissions()
        {
            User newUser = new User();
            Assert.IsNotNull(newUser.userPermissions);
            Assert.IsFalse(newUser.userPermissions.canAddSupervisor);
            Assert.IsFalse(newUser.userPermissions.canAddObserver);
            Assert.IsTrue(newUser.userPermissions.canLockdownZone);
            Assert.IsTrue(newUser.userPermissions.canUnlockZone);
        }
        [TestMethod]
        public void TestPermissionsChangeSupervisor()
        {
            User newUser = new User();
            Assert.IsNotNull(newUser.userPermissions);
            Assert.IsFalse(newUser.userPermissions.canAddSupervisor);
            Assert.IsFalse(newUser.userPermissions.canAddObserver);
            newUser.MakeSupervisor();
            Assert.IsTrue(newUser.userPermissions.canAddSupervisor);
            Assert.IsTrue(newUser.userPermissions.canAddObserver);
        }
        [TestMethod]
        public void TestPermissionsChangeObserver()
        {
            User newUser = new User();
            newUser.MakeSupervisor();
            Assert.IsNotNull(newUser.userPermissions);
            Assert.IsTrue(newUser.userPermissions.canAddSupervisor);
            Assert.IsTrue(newUser.userPermissions.canAddObserver);
            newUser.MakeObserver();
            Assert.IsFalse(newUser.userPermissions.canAddSupervisor);
            Assert.IsFalse(newUser.userPermissions.canAddObserver);
        }
        [TestMethod]
        public void TestValidateLogin()
        {
            User newUser = new User("bdr", "1234");
            Assert.IsNotNull(newUser);
            Assert.AreEqual(newUser.ValidateLogin("1234"), true);
            Assert.AreNotEqual(newUser.ValidateLogin("asdf"), true);
        }
    }
}
