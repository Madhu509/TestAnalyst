using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.pages;
using TurnUpPortal.utilities;

namespace TurnUpPortal.tests
{
    [TestFixture]
    [Parallelizable]
    public class Employees : CommonDriver

    { 

        [Test]
        public void CreateEmployeesTest()
        {
            Homepage homeObj = new Homepage();
            homeObj.GOTOEmployeespage(driver);

            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.CreateEmployees(driver);
        }
        [Test]
        public void EditEmployeesTest()
        {
            Homepage homeObj = new Homepage();
            homeObj.GOTOEmployeespage(driver);

            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.EditEmployees(driver);
        }
        [Test]
        public void DeleteEmployeesTest()
        {
            Homepage homeObj = new Homepage();
            homeObj.GOTOEmployeespage(driver);

            EmployeesPage employeeObj = new EmployeesPage();
            employeeObj.DeleteEmployees(driver);
        }


    }
}
