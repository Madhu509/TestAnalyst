using System;
using System.Threading;
using OpenQA.Selenium;
using TurnUpPortal.utilities;

namespace TurnUpPortal.pages
{
    public class TMpages
    {
        //create new TM
        public void createTM(IWebDriver driver)
        {
            // navigate to time and material page

            IWebElement administrationButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationButton.Click();
            wait.WaitForWebElementToExist(driver, "/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a", "XPath", 5);

            IWebElement timeMaterialButton = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            timeMaterialButton.Click();
            

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
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 2);

            //click go to last page

            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpagebutton.Click();
            

            //check if the created record is present in the table and has expected values

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "1234")
            {
                Console.WriteLine("Time record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (actualDescription.Text == "abcd")
            {
                Console.WriteLine("Time recorde created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (actualPrice.Text == "$23.00")
            {
                Console.WriteLine("Time recorde created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if (actualTypeCode.Text == "T")
            {
                Console.WriteLine("Time record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]", "XPath", 2);

            }
             //edit TM
             public void EditTM(IWebDriver driver)

             {
             // Identify Edit button and click

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            EditButton.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "XPath", 2);

            //update Time record

            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdown.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='TypeCode_listbox']/li[2]", "XPath", 3);

            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time.Click();

            wait.WaitForWebElementToExist(driver, "Code", "Id", 2);

            driver.FindElement(By.Id("Code")).Clear();
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("Naina123@");
            Thread.Sleep(2500);

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

            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            gotolastpage.Click();

           wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]","XPath", 3);

            //check if the created record is present in the table and has expected values

            IWebElement ActualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (ActualCode.Text == "Naina123@")
            {
                Console.WriteLine("Time record Updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

            IWebElement ActualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (ActualDescription.Text == "madhu")
            {
                Console.WriteLine("Time record Updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

            IWebElement ActualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            if (ActualPrice.Text == "$500.00")
            {
                Console.WriteLine("Time record Updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement ActualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            if (ActualTypeCode.Text == "T")
            {
                Console.WriteLine("Time record Updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }
             }

             //delete TM
             public void DeleteTM(IWebDriver driver)

             {
            //identify the delete button and click

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            DeleteButton.Click();
            driver.SwitchTo().Alert().Accept();
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 2);

            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotothelastpage.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 4);

            IWebElement AvailableCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement AvailableDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement AvailablePrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            
            if (AvailableCode.Text == "Naina123@" && AvailableDescription.Text == "madhu" && AvailablePrice.Text == "$500.00")
            {
                Console.WriteLine("Test Failed");
            }
            else
            {
                Console.WriteLine("Time record deleted successfully, Test Passed");

            }

            }

                public void Mpages(IWebDriver driver)
             {

             //click create new button

            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();
            Thread.Sleep(3500);

            //select Material from the dropdown list   

            IWebElement DropdownList = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            DropdownList.Click();
            Thread.Sleep(2500);
            IWebElement Material = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            Material.Click();
            Thread.Sleep(2000);

            //identify code and input code

            IWebElement CodetextBox = driver.FindElement(By.Id("Code"));
            CodetextBox.SendKeys("3339");


            //identify description and input description

            IWebElement DescriotionTextbox = driver.FindElement(By.Id("Description"));
            DescriotionTextbox.SendKeys("IT");
            

            //identify price per unit and input price  

            IWebElement Priceperunittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Priceperunittextbox.SendKeys("46");
            driver.FindElement(By.Id("Price"));
            

            //click on save button

            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 2);
           

            //click go to last page

            IWebElement Gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Gotolastpagebutton.Click();
            

            //check if the created record is present in the table and has expected values

            IWebElement actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualcode.Text == "3339")
            {
                Console.WriteLine("Material record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            IWebElement actualdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (actualdescription.Text == "IT")
            {
                Console.WriteLine("Material record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement actualprice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (actualprice.Text == "$46.00")
            {
                Console.WriteLine("Material record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement actualtypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if (actualtypeCode.Text == "M")
            {
                Console.WriteLine("Material record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

           

            }

            public void editTM(IWebDriver driver)

            {
            //Identify Edit button and click  

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            editButton.Click();

            wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "XPath", 2);
 
            //update Material record

            IWebElement dropdownlist = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdownlist.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='TypeCode_listbox']/li[1]", "XPath", 4);
            IWebElement material = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            material.Click();
            wait.WaitForWebElementToExist(driver, "Code", "Id", 4);


            driver.FindElement(By.Id("Code")).Clear();
            IWebElement codetextBox = driver.FindElement(By.Id("Code"));
            codetextBox.SendKeys("5000");
            wait.WaitForWebElementToExist(driver, "Description", "Id", 3);

            driver.FindElement(By.Id("Description")).Clear();
            IWebElement descriptiontextBox = driver.FindElement(By.Id("Description"));
            descriptiontextBox.SendKeys("test");
           
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            IWebElement pricetextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Price")).Clear();
            pricetextBox.SendKeys("850");
            



            //click on save button

            driver.FindElement(By.Id("SaveButton")).Click();

            

            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            Gotolastpage.Click();

            //Thread.Sleep(3000);
            IWebElement Actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (Actualcode.Text == "5000")
            {
                Console.WriteLine("Material record Updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

            IWebElement Actualdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (Actualdescription.Text == "test")
            {
                Console.WriteLine("Material record updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement Actualprice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (Actualprice.Text == "$850.00")
            {
                Console.WriteLine("Material record updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            IWebElement ActualtypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if (ActualtypeCode.Text == "M")
            {
                Console.WriteLine("Material record updated successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");

            }

            wait.WaitForWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]", "XPath", 3);

            }

              public void deleteTM(IWebDriver driver)

            {

            //identify the delete button and click

            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            deletebutton.Click();
           
            driver.SwitchTo().Alert().Accept();
          

            IWebElement gotoThelastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoThelastpage.Click();
            

            IWebElement Availablecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement Availabledescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            IWebElement Availableprice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (Availablecode.Text == "5000" && Availabledescription.Text == "test" && Availableprice.Text == "$850.00")
            {
                Console.WriteLine("Test Failed");
            }
            else
            {
                Console.WriteLine("Material record deleted successfully, Test Passed");

            }

           
        }
    }

}



