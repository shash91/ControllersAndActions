﻿using System;
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

            Assert.AreEqual("Hello,World", result.ViewData.Model);



        }
    }
}
