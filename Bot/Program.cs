using System;
using System.Threading;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using Bot.Model;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Firefox, @"C:\Selenium\FirefoxDriver\", true);

            #region Declarações
            //Declarações
            int i = 0;
            int QTD_RPT_INS_ACSS = 0;
            int CodigoRobInsPubl = 1;
            int CodigoRobGooCria = 2;
            int CodigoRobInsCria = 3;
            int CodigoRobBusEmpr = 4;
            int CodigoRobInsHast = 5;
            int CodigoRobLinkEnc = 6;
            int CodigoRobLixeiro = 7;
            int CodigoRobVerific = 8;
            bool StatusRob = false; ;
            bool New_Rob_PERM = false;
            #endregion

            while (true)
            {
                //RoboPublicitario
                //CodigoRob = "Resultado Consulta";
                //StatusRob = "Resultado Consulta";
                //QTD_RPT_INS_ACSS = "Resultado Consulta";
                //New_Rob_PERM = "Resultado Consulta";
                //New_Rob_Perm tera uma procedure que ira verificar se a quantidade de robos que informei em uma tabela esta acima caso esteja
                //o sistema nao ira permite a ativação de um novo robo.
                if (CodigoRobInsPubl == 1 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                        BotInstagram.CarregarPaginaInstagram(webDriver, "https://www.instagram.com/accounts/login/?source=auth_switcher", 1);
                        BotInstagram.LogarInstagram(webDriver, "flavio251093@gmail.com", "30111142");
                        i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobGooCria == 2 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                       i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobInsCria == 3 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                       i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobBusEmpr == 4 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                       i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobInsHast == 5 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                       i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobLinkEnc == 6 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                       i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobLixeiro == 7 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                        i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }

                if (CodigoRobVerific == 8 && StatusRob == true && New_Rob_PERM == true)
                {
                    //Consultar para tabela Controle QTD de Robo Ativo e Soma +1
                    while (i <= QTD_RPT_INS_ACSS)
                    {
                        i++;
                    }
                    //Consultar para tabela Controle QTD de Robo Ativo e Diminuir -1
                }
            }
        }
    }
}
