using OpenQA.Selenium;
using SeleniumIntro2.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumIntro2.PageObject
{
    public class EmployeePage
    {
        protected IWebDriver driver;

        // localizadores

        protected By Welcome = By.CssSelector("body > header > nav > div > div > ul:nth-child(2) > li:nth-child(1) > a");

        public EmployeePage(IWebDriver driver)
        {
            this.driver = driver;

            if (!driver.Title.Equals("Home Page - WebEjemplo"))
            {
                throw new Exception("this is not the login page");
            }
        }

        public bool WelcomeIsPresent()
        {
            return WaitHandler.ElementIsPresent(driver, Welcome);
        }

    }
}
