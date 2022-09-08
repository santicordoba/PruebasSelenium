using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

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
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            //tomar screenshot
            Driver.TakeScreenshot().SaveAsFile("C:\\Users\\sdc_s\\Pictures\\Saved Pictures\\Screenshot.png", ScreenshotImageFormat.Png);
            Driver.Close();
        }

    }

}