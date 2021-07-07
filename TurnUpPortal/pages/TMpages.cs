using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortal.utilities;

namespace TurnUpPortal.pages
{
    public class TMpages
    {
        //create new TM
        public void CreateTM(IWebDriver driver)
        {


            //click create new button

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "XPath", 2);


            //select time from the dropdown list   

            IWebElement dropdownList = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdownList.Click();

            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();

            //identify code and input code

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("1234");


            //identify description and input description

            IWebElement descriotionTextbox = driver.FindElement(By.Id("Description"));
            descriotionTextbox.SendKeys("abcd");


            //identify price per unit and input price  

            IWebElement priceperunittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunittextbox.SendKeys("23");
            driver.FindElement(By.Id("Price"));


            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 1);

            //click go to last page

            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpagebutton.Click();


            //check if the created record is present in the table and has expected values

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(actualCode.Text == "1234", "actual Code and expected Code did not meet");

            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            Assert.That(actualDescription.Text == "abcd", "actual Description and expected Description did not meet");

            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            Assert.That(actualPrice.Text == "$23.00", "actual Price and expected Price did not meet");

            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(actualTypeCode.Text == "T", "actual TypeCode and expected TypeCode did not meet");


        }
        //edit TM

        public void EditTM(IWebDriver driver)

        {
            // Identify Edit button and click

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]", "XPath", 1);

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            EditButton.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "XPath", 1);

            //update Time record

            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdown.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='TypeCode_listbox']/li[2]", "XPath", 2);

            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time.Click();

            wait.WaitForWebElementToExist(driver, "Code", "Id", 2);

            driver.FindElement(By.Id("Code")).Clear();
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("8000");
            Thread.Sleep(1500);

            driver.FindElement(By.Id("Description")).Clear();
            wait.WaitForWebElementToExist(driver, "Description", "Id", 3);
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("madhu");


            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

            driver.FindElement(By.Id("Price")).Clear();
            priceTextBox.SendKeys("500");

            wait.WaitForWebElementToExist(driver, "SaveButton", "Id", 2);


            //click on save button

            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));

            SaveButton.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 2);

            // IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            // gotolastpage.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 1);


            //check if the created record is present in the table and has expected values

            IWebElement ActualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(ActualCode.Text == "8000", "Actual Code and expected Code did not meet");



            IWebElement ActualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            Assert.That(ActualDescription.Text == "madhu", "Actual Description and expected Description did not meet");


            IWebElement ActualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(ActualPrice.Text == "$500.00", "Actual Price and expected Price did not meet");


            IWebElement ActualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(ActualTypeCode.Text == "T", "Actual TypeCode and expected TypeCode did not meet");


        }
        //delete TM
        public void DeleteTM(IWebDriver driver)

        {

            //identify the delete button and click

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]", "XPath", 2);

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            DeleteButton.Click();
            driver.SwitchTo().Alert().Accept();
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 2);

            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotothelastpage.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 1);

            IWebElement AvailableCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement AvailableDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement AvailablePrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (AvailableCode.Text == "8000" && AvailableDescription.Text == "madhu" && AvailablePrice.Text == "$500.00")
            {
                Assert.Fail("Test Failed");
            }
            else
            {
                Assert.Pass("Time record deleted successfully, Test Passed");

            }

        }

    }
}





