using Csci463System.Models;
using Csci463System.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests
{
    [TestClass]
    public class JsonServiceTest
    {
        [TestMethod]
        public void TestSerialization()
        {
            User newUser = new User("bdr", "1234");
            JsonService js = new JsonService();
            string JsonString = js.Serialize(newUser);
            User obj = new User();
            obj = js.Deserialize<User>(JsonString);
            Assert.AreEqual(newUser.Username, obj.Username);
            //Assert.AreEqual(newUser.Username, afterJsonDeserialize.Username);
        }
        [TestMethod]
        public void TestSerialization2()
        {
            Keypad keypad = new Keypad();
            JsonService js = new JsonService();
            string JsonString = js.Serialize(keypad);
            Keypad obj = js.Deserialize<Keypad>(JsonString);
            Assert.AreEqual(keypad.UID, obj.UID);
        }
    }
}
