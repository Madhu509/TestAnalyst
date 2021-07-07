using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.pages;
using TurnUpPortal.utilities;

namespace TurnUpPortal
{
    [TestFixture]

    class Program : CommonDriver
    {

        [SetUp]

        public void LoginSteps()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            //object for homepage

            Homepage homeObj = new Homepage();
            homeObj.GOTOTMpage(driver);

        }
        [Test]

        public void CreateTMTest()
        {
            TMpages tmObj = new TMpages();
            tmObj.CreateTM(driver);
        }
        [Test]

        public void EditTMTest()

        {
            TMpages tmObj = new TMpages();
            tmObj.EditTM(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            TMpages tmObj = new TMpages();
            tmObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }

    }
}



























