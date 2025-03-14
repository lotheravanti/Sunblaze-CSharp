using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class AddRemove : Homepage
    {
        private readonly IWebDriver _driver;
        public By _btnAddElement = By.XPath("//button[text()='Add Element']");
        public By _btnDeleteElement = By.XPath("//button[text()='Delete']");
        //Inherit from Homepage Class will initiate its Constructor automatically
        public AddRemove(IWebDriver driver) : base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            _driver = driver;
            //Go to Test Page
            _driver.FindElement(_lnkAddRemove).Click();
        }
    }
}
