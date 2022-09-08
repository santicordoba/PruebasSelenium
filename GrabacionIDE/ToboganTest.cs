// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void Tobogan() {
    driver.Navigate().GoToUrl("https://www.google.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1900, 1020);
    driver.FindElement(By.Name("q")).Click();
    driver.FindElement(By.Name("q")).SendKeys("Tobogan andaluz");
    driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
    {
      var element = driver.FindElement(By.LinkText("Vídeos"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.LinkText("Imágenes")).Click();
    driver.FindElement(By.CssSelector(".isv-r:nth-child(12) .rg_i")).Click();
    js.ExecuteScript("window.scrollTo(0,161)");
    {
      var element = driver.FindElement(By.CssSelector(".isv-r:nth-child(11) > .VFACy"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
  }
}