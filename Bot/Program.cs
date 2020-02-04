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
                LogarInstagram(webDriver, "flavio251093@gmail.com", "30111142");
                Console.WriteLine(i++);
            }
        }

        public static void CarregarPagina(IWebDriver webDriver)
        {
            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(1), "https://www.instagram.com/accounts/login/?source=auth_switcher");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           // Thread.Sleep(1000);
        }


        public static void LogarInstagram(IWebDriver webDriver,string Usuario,string Senha) {
            try
            {
                webDriver.SetText(By.Name("username"),Usuario);
                webDriver.SetText(By.Name("password"), Senha);
                webDriver.Submit(By.TagName("button"));
               // Thread.Sleep(1000);
                Console.WriteLine("Logado");
                webDriver.Quit();
                //Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //Thread.Sleep(1000);

        }
    }
}
