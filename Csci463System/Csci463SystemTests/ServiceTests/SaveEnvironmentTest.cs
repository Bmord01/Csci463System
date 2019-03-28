using Csci463System.Models;
using Csci463System.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests.ServiceTests
{
    [TestClass]
    class SaveEnvironmentTest
    {
        [TestMethod]
        public void TestWriteObject()
        {
            User user = new User("bdr", "123");
            SaveEnvironmentService ses = new SaveEnvironmentService();

            ses.SaveEnvironmentToFile(user,"user.txt");
        }
    }
}
