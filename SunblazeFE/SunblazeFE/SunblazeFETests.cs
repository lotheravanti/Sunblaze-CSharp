using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SunblazeFE
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OpenHomepage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
            Thread.Sleep(5000);
            driver.Quit();
        }

        [Test]
        public void InputNumber()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
            IWebElement webElement = driver.FindElement(By.XPath("//div/p[text()='Number']/following-sibling::input[1]"));
            webElement.SendKeys("23");
            // Simplified form, no need to create variable
            // driver.FindElement(By.XPath("//div/p[text()='Number']/following-sibling::input[1]")).SendKeys("23")
            driver.Quit();
        }

        [Test]
        public void SelectFromDropdown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("dropdown")));
            selectElement.SelectByText("Option 2");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}