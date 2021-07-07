using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.utilities;

namespace TurnUpPortal.pages
{
    public class LoginPage
    {
        //Function that allows users to login to TU portal
        public void LoginActions(IWebDriver driver)

        {
            driver.Manage().Window.Maximize();
            try
            {
                // launch turnup portal
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

                // identify username textbox and enter valid username

                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");
                // identify password textbox and enter valid password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");
                // indentify login action button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }

            catch (Exception ex)

            {
                Assert.Fail(ex.Message);
            }
        }

        }



    }

