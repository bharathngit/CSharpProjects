using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;

namespace firstCsharpProject.lib
{
    public class FirstTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //driver = new ChromeDriver("/Users/admin/Projects/firstCsharpProject/firstCsharpProject/drivers");
            driver = new SafariDriver();
            driver.Manage().Window.Maximize();
        }
 
        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
