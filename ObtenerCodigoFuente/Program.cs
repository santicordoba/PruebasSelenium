using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace ObtenerCodigoFuente
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.dangotoons.com");
            var source = driver.PageSource;
            Console.Write(source);
            /*File.WriteAllLines("codigo_fuente.html", source);*/
            File.WriteAllText("..\\..\\..\\index.html", source);
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}