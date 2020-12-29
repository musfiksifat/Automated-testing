using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inegration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[1]/input"));
            element.SendKeys("170042088");
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[2]/input"));
            password.SendKeys("Abc.1234");
            driver.FindElement(By.Id("Log in")).Click();
            String at = driver.Title;

            String et = "Dashboard";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/section[2]/aside/section[1]/div/div/div[1]/div/div/div/table/tbody/tr/td[2]/div/a"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
