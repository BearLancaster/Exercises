using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject_Selenium
{
    
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--enable-experimental-web-platform-features");
            //options.AddArgument(@"user-data-dir=C:\Users\18221\AppData\Local\Google\Chrome\User Data");
           // options.AddArgument(@"profile-directory=Profile 1");

            var experimentalFlags = new List<string>();
            experimentalFlags.Add("enable-web-bluetooth-new-permissions-backend@1");
            options.AddLocalStatePreference("browser.enabled_labs_experiments", experimentalFlags);


            driver = new ChromeDriver(@"D:\Users\18221\source\repos\TestProject_Selenium\TestProject_Selenium\driver\", options);
            driver.Url = "https://www.pdfdrive.com/";
        }

        [Test]
        public void test()
        {

            driver.Navigate().GoToUrl("https://www.pdfdrive.com/");
        

            //IWebElement link = driver.FindElement(By.Id("btnLoginVerocard"));
            //link.Click();

            
        }
    }
}