using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SunblazeFE
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}