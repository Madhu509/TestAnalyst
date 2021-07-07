using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnUpPortal.utilities
{
    public class wait
    {

        //reusable function for wait
        public static void WaitForWebElementToExist(IWebDriver driver, string attributevalue, string attribute, int secondsToWait)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
            if (attribute == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributevalue)));
            }
            if (attribute == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributevalue)));
            }
            if (attribute == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributevalue)));
            }

        }


    }
}

