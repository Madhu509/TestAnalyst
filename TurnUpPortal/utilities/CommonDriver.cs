using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.pages;

namespace TurnUpPortal.utilities
{
   
    public class CommonDriver
    {
        public IWebDriver driver;


        [OneTimeSetUp]

        public void LoginSteps()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

         }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}

