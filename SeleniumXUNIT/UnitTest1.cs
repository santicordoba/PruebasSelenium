using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

namespace SeleniumXUNIT;

public class PruebaBase : IDisposable
{
    public IWebDriver Driver { get; set; }

    public PruebaBase()
    {
        //contructor web driver
        Driver = new ChromeDriver();
    }

    public void Dispose()
    {
        // cierre web driver
        Driver.Close();
    }
}

public class UnitTest1 : PruebaBase
{

    [Fact]
    public void Test1()
    {
        Driver.Navigate().GoToUrl("http://dangotoons.com");

        var elementos = Driver.FindElements(By.CssSelector("#body1 > div.pagina > div > div.lateral > div.top-series > table > tbody > tr > td > a"));

        var cantidad = elementos.Count;
        var puesto = 1;



        foreach (var element in elementos)
        {
            Console.WriteLine($"En el puesto nro {puesto} esta la serie {element.GetAttribute("title")}");
            puesto++;
        }
        Assert.Equal(10, cantidad);
    }
}