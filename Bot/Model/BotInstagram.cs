using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;

namespace Bot.Model
{
    class BotInstagram
    {

        public static void CarregarPaginaInstagram(IWebDriver webDriver,string URL,int TempoCarregamento)
        {
            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(TempoCarregamento), URL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // Thread.Sleep(1000);
        }

        public static void LogarInstagram(IWebDriver webDriver, string Usuario, string Senha)
        {
            try
            {
                webDriver.SetText(By.Name("username"), Usuario);
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
