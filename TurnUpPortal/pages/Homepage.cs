using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortal.utilities;

namespace TurnUpPortal.pages
{
    public class Homepage
    
    {
     //function to navigate to TMpage
      public void GOTOTMpage(IWebDriver driver)
        {
            try
            {

                //navigate to time and material page

                IWebElement administrationButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
                administrationButton.Click();
                wait.WaitForWebElementToExist(driver, "/ html / body / div[3] / div / div / ul / li[5] / a", "XPath", 2);

                IWebElement timeMaterialButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
                timeMaterialButton.Click();
                wait.WaitForWebElementToExist(driver, ("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"), "XPath", 2);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }



    }
}
