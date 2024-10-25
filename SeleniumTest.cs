
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests
{
    public class SeleniumTest
    {
        public bool HasFailed { get; private set; } = false;

        public void RunTest()
        {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.example.com");
                var element = driver.FindElement(By.Id("nonexistent-id"));
                Console.WriteLine("Test Passed");
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test Failed: " + ex.Message);
                HasFailed = true;
            }
        }
    }
}
