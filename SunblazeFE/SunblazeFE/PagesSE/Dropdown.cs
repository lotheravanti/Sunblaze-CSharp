using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class Dropdown : Homepage
    {
        private readonly IWebDriver _driver;
        public By dropdownField = By.Id("dropdown");
        //Inherit from Homepage Class will initiate its Constructor automatically
        public Dropdown(IWebDriver driver) : base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            _driver = driver;
            //Go to Test Page
            _driver.FindElement(_lnkDropdown).Click();
        }
    }
}
