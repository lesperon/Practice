using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BaseTest
{
    class BaseClass
    {
        public static IWebDriver driver;

        private static string strUrlName = ConfigurationManager.AppSettings.Get("webaddress");

        public static void Setup()
        {

            driver = new ChromeDriver();

            driver.Url = strUrlName;
            
 
        }

        public static void SendCredentials(By by,String pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
            


        }

    }
}
