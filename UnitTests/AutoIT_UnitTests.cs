using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoIT_Scripts;

namespace UnitTests
{
    [TestClass]
    public class AutoIT_UnitTests
    {
        [TestMethod]
        public void WindowsDoesNotExistUnitTest()
        {
            //Arrange
            string windowTitle = "Generic Window Title";
            bool expectedResponse = false;
            AutoIT a = new AutoIT();

            //Act
            bool response = a.CheckIfWindowExists(windowTitle);

            //Assert
            Assert.AreEqual(expectedResponse, response,String.Format("Test failed because a window exist with the title {0} is open somwewhere.",windowTitle));

        }

        [TestMethod]
        public void WindowExistsUnitTest()
        {
            //Arrange
            string windowTitle = "Generic Window Title";
            bool expectedResponse = true;
            AutoIT a = new AutoIT();

            //Act
            bool response = a.CheckIfWindowExists(windowTitle);

            //Assert
            Assert.AreNotEqual(expectedResponse, response, String.Format("Test failed because a window exist with the title {0} somewhere.", windowTitle));

        }
    }
}
