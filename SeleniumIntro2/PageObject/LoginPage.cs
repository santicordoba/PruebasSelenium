using OpenQA.Selenium;
using NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumIntro2.PageObject
{
    // Clase para representar la pagina del login
    public class LoginPage
    {
        protected IWebDriver driver;

        // localizadores

        protected By UserInput = By.Name("Input.Email");
        protected By PasswordInput = By.Name("Input.Password");
        protected By LoginButton = By.Id("login-submit");

        public LoginPage(IWebDriver aDriver)
        {
            this.driver = aDriver;

            if(!driver.Title.Equals("Log in - WebEjemplo"))
            {
                throw new Exception("this is not the login page");
            }
            
        }

        public void TypeUserName(string user)
        {
            driver.FindElement(UserInput).SendKeys(user);
        }

        public void TypePassword(string password)
        {
            driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ClickButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public EmployeePage LoginAs(string user, string password)
        {
            TypeUserName(user);
            TypePassword(password);
            ClickButton();
            return new EmployeePage(driver);
        }

    }
}
