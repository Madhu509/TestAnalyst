using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.pages;
using TurnUpPortal.utilities;

namespace TurnUpPortal
{
    [TestFixture]
    [Parallelizable]

    class Program : CommonDriver
    {
        [Test]

        public void CreateTMTest()
        {

            Homepage homeObj = new Homepage();
            homeObj.GOTOTMpage(driver);

            TMpages tmObj = new TMpages();
            tmObj.CreateTM(driver);
        }
        [Test]

        public void EditTMTest()

        {
            Homepage homeObj = new Homepage();
            homeObj.GOTOTMpage(driver);

            TMpages tmObj = new TMpages();
            tmObj.EditTM(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            Homepage homeObj = new Homepage();
            homeObj.GOTOTMpage(driver);

            TMpages tmObj = new TMpages();
            tmObj.DeleteTM(driver);
        }

        

    }
}



























