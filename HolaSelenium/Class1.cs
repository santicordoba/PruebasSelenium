using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HolaSelenium
{
    public class PruebaGoogle
    {
        protected IWebDriver Driver;
        
        
        public void Busqueda()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Hola Mundo");
            Driver.FindElement(By.Name("btnK")).Click();
            Driver.Close();
        }
        
    }
}