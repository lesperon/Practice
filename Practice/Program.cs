using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program : BaseTest.BaseClass
    {
        static void Main(string[] args)
        {
            Setup();

            SendCredentials(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            SendCredentials(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));
        }
    }
}
