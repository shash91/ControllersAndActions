using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ViewSelectionTest()
        {
            ExampleController target = new ExampleController();

            ViewResult result = target.Index();

            Assert.AreEqual("Hello", result.ViewBag.Message);



        }
        [TestMethod]
        public void RedirectTest()
        {
            ExampleController target = new ExampleController();
            RedirectResult result = target.Redirect();

            Assert.AreEqual("/Example/Index", result.Url);
            Assert.IsTrue(result.Permanent);
        }
    }
}
