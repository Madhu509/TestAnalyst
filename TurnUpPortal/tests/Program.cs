using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.pages;

namespace TurnUpPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // open chrome browser
            IWebDriver driver = new ChromeDriver();

           //object for login page
            loginpage loginObj = new loginpage();
            loginObj.LoginActions(driver);

            //object for homepage

            Homepage homeObj = new Homepage();
            homeObj.GOTOTMpage(driver);


            // object for TMpages

            TMpages TMObj = new TMpages();
            TMObj.createTM(driver);

            //call the method for edit and delete TMpages

            TMObj.EditTM(driver);

            TMObj.DeleteTM(driver);

            TMObj.Mpages(driver);

            TMObj.editTM(driver);

            TMObj.deleteTM(driver);

        }
    }
}          
               
               
