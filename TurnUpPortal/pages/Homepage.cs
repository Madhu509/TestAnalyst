using System;
using System.Threading;
using OpenQA.Selenium;

namespace TurnUpPortal.pages
{
    public class Homepage
    
    {
     //function to navigate to TMpage
      public void GOTOTMpage(IWebDriver driver)
        {

          
            //navigate to time and material page

            IWebElement administrationButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationButton.Click();
            Thread.Sleep(1500);

            IWebElement timeMaterialButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            timeMaterialButton.Click();
            Thread.Sleep(1500);

        }



    }
}
