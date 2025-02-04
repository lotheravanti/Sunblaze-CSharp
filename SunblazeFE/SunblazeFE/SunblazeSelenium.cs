using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SunblazeFE.PagesSE;

namespace SunblazeFE
{
    [TestFixture]
    //Need IDisposable for Setup and Teardown
    public class SeleniumTests: IDisposable
    {
        //[TestFixture]
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenHomepage()
        {
            Homepage homePage = new Homepage(driver);
        }

        [Test]
        public void InputNumber()
        {
            Inputs inputs = new Inputs(driver);
            //Inputs Class inherits FieldSendKeys method from Homepage Class
            inputs.FieldSendKeys(inputs.inputNumber, "23");
        }

        [Test]
        public void SelectFromDropdown()
        {
            Dropdown dropdown = new Dropdown(driver);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 2");
            //So we can observe it actually changed
            Thread.Sleep(1000);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 1");
        }
        //Add a wait at the end of every test for visibility when running manually
        //Ensure driver is closed
        [TearDown]
        public void Dispose()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}