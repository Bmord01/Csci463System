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
        }
    }
}
