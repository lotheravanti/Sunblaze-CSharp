using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SunblazeFE.PagesSE
{
    public class Homepage
    {
        IWebDriver driver;
        public By _txtHomePagetitle => By.XPath("//h1[text()='Welcome to the-internet']");
        public By _lnkInputs => By.XPath("//a[text()='Inputs']");
        public By _lnkDropdown => By.XPath("//a[text()='Dropdown']");

        public void ClickOn(By by)
        {
            driver.FindElement(by).Click();
        }
        public void FieldSendKeys(By by, string inputValue)
        {
            driver.FindElement(by).SendKeys(inputValue);
        }
        //Function instead of Method for retrieving the String of a Text from a Web Element
        //Declare return type: String
        public string GetText(By by)
        {
            return driver.FindElement(by).Text;
        }
        public void SelectByTextDropdown(By by, string text)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(by));
            selectElement.SelectByText(text);
        }
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
        }
    }
}
