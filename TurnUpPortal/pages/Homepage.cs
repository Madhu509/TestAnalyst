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

            {

                //navigate to time and material page

                IWebElement administrationButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
                Thread.Sleep(2000);
                administrationButton.Click();
                wait.WaitForWebElementToExist(driver, "/ html / body / div[3] / div / div / ul / li[5] / a", "XPath", 2);

                IWebElement timeMaterialButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
                Thread.Sleep(2000);
                timeMaterialButton.Click();
                wait.WaitForWebElementToExist(driver, ("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"), "XPath", 2);

            }

        }
        public void GOTOEmployeespage(IWebDriver driver)

        {
            //navigate to employees page


            IWebElement administrationButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Thread.Sleep(2000);
            administrationButton.Click();
            wait.WaitForWebElementToExist(driver, "/ html / body / div[3] / div / div / ul / li[5] / a", "XPath", 2);

            IWebElement employeesbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Thread.Sleep(2000);
            employeesbutton.Click();
            wait.WaitForWebElementToExist(driver, "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", "XPath", 2);
        }


    }



}
