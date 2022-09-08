using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ObtenerCodigoFuente
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7121/Identity/Account/Register");

            IWebElement correo = driver.FindElement(By.Name("Input.Email"));
            IWebElement pass = driver.FindElement(By.Name("Input.Password"));
            IWebElement repass = driver.FindElement(By.Name("Input.ConfirmPassword"));

            correo.SendKeys("prueba7@test.com");
            pass.SendKeys("123456aA.");
            repass.SendKeys("123456aA.");
            IWebElement boton = driver.FindElement(By.Id("registerSubmit"));
            boton.Click();

            IWebElement confirmacion = driver.FindElement(By.Id("confirm-link"));
            confirmacion.Click();
            driver.Navigate().GoToUrl("https://localhost:7121/Identity/Account/Login");
            IWebElement correologin = driver.FindElement(By.Name("Input.Email"));
            IWebElement passlogin = driver.FindElement(By.Name("Input.Password"));
            correologin.SendKeys("prueba7@test.com");
            passlogin.SendKeys("123456aA.");
            IWebElement botonlogin = driver.FindElement(By.Id("login-submit"));
            botonlogin.Click();
            Thread.Sleep(5000);
            /*driver.Close();*/
        }
    }
}