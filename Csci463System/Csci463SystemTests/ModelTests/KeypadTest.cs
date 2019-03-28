using Csci463System.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests
{
    [TestClass]
    public class KeypadTest
    {
        public Keypad keypad;
        [TestMethod]
        public void TestCreator()
        {
            keypad = new Keypad();
            Assert.AreNotEqual(keypad, null);
            Keypad k = new Keypad("123");
            Assert.AreNotEqual(k, null);
        }
        [TestMethod]
        public void TestUIDDifferent()
        {
            keypad = new Keypad();
            Keypad keypad2 = new Keypad();
            Assert.AreNotEqual(keypad.UID, keypad2.UID);
        }
        [TestMethod]
        public void UnlockTest()
        {
            keypad = new Keypad("123");
            bool unlock = keypad.Unlock("123");
            Assert.IsTrue(unlock);
            unlock = keypad.Unlock("AFDSAFS");
            Assert.IsFalse(unlock);
        }
    }
}
