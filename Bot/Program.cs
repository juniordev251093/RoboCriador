using System;
using System.Threading;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;


namespace Bot
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Firefox, @"C:\Selenium\FirefoxDriver\", true);
            int i = 0;
            while (true)
            {
                CarregarPagina(webDriver);
                Console.WriteLine(i++);
            }
        }

        public static void CarregarPagina(IWebDriver webDriver)
        {
            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(1), "www.google.com.br");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Thread.Sleep(1000);
        }
    }
}
