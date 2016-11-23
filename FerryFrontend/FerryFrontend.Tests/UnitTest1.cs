using System;
using FerryFrontend.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox3_Library_Hundige;

namespace FerryFrontend.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Controllers.FerryController controller = new FerryController();
            var res = controller.GetReservations(new Departure(new Ferry("medium ferry", 120, 40, 15000, true), DateTime.Now));

            Assert.IsTrue(res.Count == 4);
        }
    }
}
