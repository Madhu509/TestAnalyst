using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortal.utilities;

namespace TurnUpPortal.pages
{
    public class EmployeesPage
    {
        public void CreateEmployees(IWebDriver driver)

        {

            //click on create button and navigates to employees details page

            IWebElement createbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbutton.Click();
            Thread.Sleep(2000);

            wait.WaitForWebElementToExist(driver, "Name", "Id", 3);

            IWebElement actualName = driver.FindElement(By.Id("Name"));
            Thread.Sleep(2000);
            actualName.SendKeys("Madhurima Atla");
            Thread.Sleep(2000);

            //wait.WaitForWebElementToExist(driver, "UserName", "Id", 3);

            IWebElement actualUsername = driver.FindElement(By.Id("Username"));
            Thread.Sleep(2000);
            actualUsername.SendKeys("madhu509");
            Thread.Sleep(2000);

            //click on editcontactbutton and edit the contact

            wait.WaitForWebElementToExist(driver, "ContactDisplay", "Id", 5);
            IWebElement actualContactDisplay = driver.FindElement(By.Id("ContactDisplay"));
            Thread.Sleep(2000);
            actualContactDisplay.SendKeys("madhurima atla, madhu, 023444462, madhurima.atla@gmail.com, " +
                "122 orawa road, takapuna, 1044, Auckland, Newzealand");
            Thread.Sleep(2000);

            
            IWebElement actualPassword = driver.FindElement(By.Id("Password"));
            Thread.Sleep(2000);
            actualPassword.SendKeys("Hanuman123@");
            Thread.Sleep(2000);

            IWebElement actualRetypepassword = driver.FindElement(By.Id("RetypePassword"));
            Thread.Sleep(2000);
            actualRetypepassword.SendKeys("Hanuman123@");
            Thread.Sleep(2000);

            IWebElement actualIsadmin = driver.FindElement(By.Id("IsAdmin"));
            Thread.Sleep(2000);
            actualIsadmin.Click();
            Thread.Sleep(2000);

            IWebElement actualVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            Thread.Sleep(2000);
            actualVehicle.SendKeys("Mazda");
            Thread.Sleep(2000);

            IWebElement actualGroups = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]/input"));
            Thread.Sleep(2000);
            actualGroups.Click();
            Thread.Sleep(3000);
            IWebElement ActualGroups = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[4]"));
            ActualGroups.Click();

            IWebElement actualSave = driver.FindElement(By.Id("SaveButton"));
            Thread.Sleep(2000);
            actualSave.Click();
            Thread.Sleep(2000);

            IWebElement actualBacktolist = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            Thread.Sleep(2000);
            actualBacktolist.Click();
            Thread.Sleep(2000);

            IWebElement actualgotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Thread.Sleep(2000);
            actualgotolastpage.Click();
            Thread.Sleep(1000);
            

            //check if the created record is present in the table and has expected values
           
            Thread.Sleep(3000);
            IWebElement ActualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
            Assert.That(ActualName.Text == "Madhurima Atla", "Actual Name and Expected Name did not Match");
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement ActualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(2000);
            Assert.That(ActualUsername.Text == "madhu509", "Actual Username and Expected Username did not Match");

        }


          //click on edit button and edit employees details

        public void EditEmployees(IWebDriver driver)

        {

            IWebElement actualGotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Thread.Sleep(2000);
            actualGotolastpage.Click();
            Thread.Sleep(2000);

            IWebElement ActualEditButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            ActualEditButton.Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("Name")).Clear();
            Thread.Sleep(2000);
            IWebElement actualname = driver.FindElement(By.Id("Name"));
            Thread.Sleep(2000);
            actualname.SendKeys("Nainika");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("Username")).Clear();
            Thread.Sleep(2000);
            IWebElement actualUsername = driver.FindElement(By.Id("Username"));
            Thread.Sleep(2000);
            actualUsername.SendKeys("Naina509");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("Password")).Clear();
            IWebElement actualPassword = driver.FindElement(By.Id("Password"));
            Thread.Sleep(2000);
            actualPassword.SendKeys("Hanuman123@");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("RetypePassword")).Clear();
            IWebElement actualRetypepassword = driver.FindElement(By.Id("RetypePassword"));
            Thread.Sleep(2000);
            actualRetypepassword.SendKeys("Hanuman123@");
            Thread.Sleep(2000);


            IWebElement actualIsadmin = driver.FindElement(By.Id("IsAdmin"));
            Thread.Sleep(2000);
            actualIsadmin.Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input")).Clear();
            IWebElement actualVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            Thread.Sleep(2000);
            actualVehicle.SendKeys("Mazda");
            Thread.Sleep(2000);

            /* driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]/input")).Clear();
             IWebElement actualGroups = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]/input"));
             Thread.Sleep(2000);
             actualGroups.Clear();
             Thread.Sleep(3000);
             IWebElement ActualGroups = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[4]"));
             ActualGroups.Click();*/


            IWebElement actualSave = driver.FindElement(By.Id("SaveButton"));
            actualSave.Click();
            Thread.Sleep(1500);

            IWebElement actualBacktolist = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            actualBacktolist.Click();
            Thread.Sleep(1000);

            IWebElement actualgotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            actualgotolastpage.Click();
            Thread.Sleep(2000);

            wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[4]/a[4]/span", "XPath", 4);

            wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 2);
            Thread.Sleep(3000);

            IWebElement ActualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
            Assert.That(ActualName.Text == "Nainika", "Actual Name and Expected Name did not match");

            wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]", "XPath", 2);

            IWebElement ActualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(2000);
            Assert.That(ActualUsername.Text == "Naina509", "Actual Username and Expected Username did not match");

        }

        //click on delete button, employees details deleted as expected

        public void DeleteEmployees(IWebDriver driver)
        {

            IWebElement actualgotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            actualgotolastpage.Click();
            Thread.Sleep(2000);

            IWebElement actualDelete = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            actualDelete.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            wait.WaitForWebElementToExist(driver, "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 3);

            IWebElement ActualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(1000);

            IWebElement ActualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(3000);
            if (ActualName.Text == "Nainika" && ActualUsername.Text == "Naina123@")

            {
                Assert.Fail("Test Failed");
            }
            else
            {
                Assert.Pass("record deleted successfully, test passed");
            }



        }

    }

}


























