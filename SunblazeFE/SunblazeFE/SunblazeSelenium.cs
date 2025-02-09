using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SunblazeFE.PagesSE;

namespace SunblazeFE
{
    public class SeleniumTests
      {
        IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            //Need to match IWebDriver type between _driver and driver by getting .driver object from SeleniumDriver class
            IWebDriver driver = new SeleniumDriver().driver;
            _driver = driver;
            Console.WriteLine("Starting Tests");
        }

        [Test]
        public void OpenHomepage()
        {
            Homepage homePage = new(_driver);
            String verifyHomePage = homePage.GetText(homePage._txtHomePagetitle);
            Assert.That(verifyHomePage, Is.EqualTo("Welcome to the-internet"));
        }

        [Test]
        public void InputNumber()
        {
            Inputs inputs = new Inputs(_driver);
            //Inputs Class inherits FieldSendKeys method from Homepage Class
            inputs.FieldSendKeys(inputs.inputNumber, "23");
        }

        [Test]
        public void SelectFromDropdown()
        {
            Dropdown dropdown = new Dropdown(_driver);
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
            _driver.Quit();
            Console.WriteLine("Test(s) completed");
        }
      }
}