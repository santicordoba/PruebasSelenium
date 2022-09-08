using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ObtenerMuchosElementos
{
    class Program
    {
        static void Main(string[] args)
        {

            topRanking();

        }

        public static void topRanking()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://dangotoons.com");

            var elementos = driver.FindElements(By.CssSelector("#body1 > div.pagina > div > div.lateral > div.top-series > table > tbody > tr > td > a"));

            var cantidad = elementos.Count;
            var puesto = 1;



            foreach (var element in elementos)
            {
                Console.WriteLine($"En el puesto nro {puesto} esta la serie {element.GetAttribute("title")}");
                puesto++;

            }

            driver.Quit();
        }

    }
}