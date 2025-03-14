using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SunblazeFE.PagesSE
{
    public class Homepage
    {
        private readonly IWebDriver _driver;
        public By _txtHomePagetitle => By.XPath("//h1[text()='Welcome to the-internet']");
        public By _lnkAddRemove => By.XPath("//a[text()='Add/Remove Elements']");
        public By _lnkDropdown => By.XPath("//a[text()='Dropdown']");
        public By _lnkInputs => By.XPath("//a[text()='Inputs']");
        //Storing manipulator methods in Homepage class since all others Page classes are derived from it in current framework
        public void ClickOn(By by)
        {
            _driver.FindElement(by).Click();
        }
        public void ClickMultiple(By by, int num)
        {
            while (num > 0)
            {
                _driver.FindElement(by).Click();
                num -= 1;
            }
        }
        public void FieldSendKeys(By by, string inputValue)
        {
            _driver.FindElement(by).SendKeys(inputValue);
        }
        //Function instead of Method for retrieving the String of a Text from a Web Element
        //Declare return type: String
        public string GetText(By by)
        {
            return _driver.FindElement(by).Text;
        }
        //In C# type must be IReadOnlyList for List of Web Elements
        public IReadOnlyList<IWebElement> GetElements(By by)
        {
            return _driver.FindElements(by);
        }
        public void SelectByTextDropdown(By by, string text)
        {
            SelectElement selectElement = new SelectElement(_driver.FindElement(by));
            selectElement.SelectByText(text);
        }
        public Homepage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
        }
    }
}
