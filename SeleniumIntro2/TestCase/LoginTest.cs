using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumIntro2.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumIntro2.TestCase
{
    [TestFixture]
    public class LoginTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://localhost:7121/Identity/Account/Login");
        }

        [Test]
        public void SuccesfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("prueba7@test.com", "123456aA.");
            Assert.IsTrue(employeePage.WelcomeIsPresent());
        }

        [TearDown]
        public void AfterTest()
        {
            if(Driver != null)
            {
                Driver.Dispose();
            }   
        }

    }
}
