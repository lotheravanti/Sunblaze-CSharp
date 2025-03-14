using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SunblazeFE.PagesSE;
using static System.Net.Mime.MediaTypeNames;

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
            Assert.That(verifyHomePage, Is.EqualTo("Welcome to the-internet"), "Homepage text should appear");
        }

        [Test]
        public void AddRemove()
        {
            AddRemove addRemove = new(_driver);
            int timesClick = 3;
            addRemove.ClickMultiple(addRemove._btnAddElement, timesClick);
            Thread.Sleep(1000);
            int numDeleteButtons = addRemove.GetElements(addRemove._btnDeleteElement).Count;
            Assert.That(numDeleteButtons, Is.EqualTo(timesClick), $"The Add button was clicked {timesClick} times and that many Delete buttons appeared");
            addRemove.ClickMultiple(addRemove._btnDeleteElement, timesClick - 1);
            int remainingDeleteButtons = addRemove.GetElements(addRemove._btnDeleteElement).Count;
            Assert.That(remainingDeleteButtons, Is.EqualTo(1), "One Delete button remaining");
            Thread.Sleep(1000);
        }

        [Test]
        public void SelectFromDropdown()
        {
            Dropdown dropdown = new(_driver);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 2");
            //So we can observe it actually changed
            Thread.Sleep(1000);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 1");
        }

        [Test]
        public void InputNumber()
        {
            Inputs inputs = new(_driver);
            //Inputs Class inherits FieldSendKeys method from Homepage Class
            inputs.FieldSendKeys(inputs.inputNumber, "23");
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